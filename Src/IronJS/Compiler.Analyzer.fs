﻿module IronJS.Compiler.Analyzer

open IronJS
open IronJS.Utils
open IronJS.Types
open IronJS.Ast.Types

type private Locals = Map<string,Local>

(*Checks if a local always will result in a Dynamic type*)
let private isDynamic (loc:Local) =
  match loc.UsedAs with
  | JsTypes.Double 
  | JsTypes.String
  | JsTypes.Object -> true && loc.InitUndefined
  | _ -> true

let private isNotAssignedTo (var:Local) =
  var.UsedWith.Count = 0

(**)
let private setType (name:string) (var:Local) (typ:JsTypes) =
  let expr = EtTools.param name (match var.ClosureAccess with
                                 | Read | Write -> StrongBoxType.MakeGenericType(ToClr typ)
                                 | None -> ToClr typ)
  { var with UsedAs = typ; Expr = expr }

(*Gets the type of a variable, resovling it if necessary*)
let private getType name (vars:Locals) =

  let rec getType name (vars:Locals) (exclude:string Set) =
    let var = vars.[name]
    if exclude.Contains name then JsTypes.None
    elif not(var.Expr = null) then var.UsedAs 
    else var.UsedWith
          |> Set.map  (fun var -> getType var vars (exclude.Add name))
          |> Set.fold (fun typ state -> typ ||| state) var.UsedAs

  getType name vars Set.empty

let private resolveType name (vars:Locals) =
  Map.add name (setType name vars.[name] (getType name vars)) vars

let analyze (scope:Scope) (types:ClrType list) = 
    scope.Locals 
      |> Map.map (fun name var -> 
        if var.IsParameter then
          if var.ParamIndex < types.Length 
            then { var with UsedAs = var.UsedAs ||| ToJs types.[var.ParamIndex] } // We got an argument for this parameter
            else { setType name var JsTypes.Dynamic with ParamIndex = -1; InitUndefined = true; } // We didn't, means make it dynamic and demote to a normal local
        else 
          if isDynamic var then setType name var JsTypes.Dynamic    // No need to resolve type, force it here
          elif isNotAssignedTo var then setType name var var.UsedAs // If it's not assigned from any variables
          else var // Needs to be resolved
        )
      |> fix (fun next locals -> 
          match Map.tryFindKey (fun _ v -> v.Expr = null) locals with
          | Option.None -> 
            locals // If we didn't find any, return the map
          | Option.Some(name) -> 
            next (resolveType name locals)
        )
