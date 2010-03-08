﻿using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime.Tree;
using IronJS.Runtime2.Js;
using IronJS.Tools;
using Microsoft.Scripting.Utils;

#if CLR2
using Microsoft.Scripting.Ast;
#else
using System.Linq.Expressions;
#endif

namespace IronJS.Compiler.Ast {
	using AstUtils = Microsoft.Scripting.Ast.Utils;
	using Et = Expression;

	public enum NodeType {
		Assign, Identifier, Double, Null,
		MemberAccess, Call, If, Eq, Block,
		String, Func, While, BinaryOp,
		Object, New, AutoProperty, Return,
		UnaryOp, Logical, PostfixOperator,
		TypeOf, Boolean, Void, StrictCompare,
		UnsignedRShift, ForStep, ForIn,
		Break, Continue, With, Try, Catch,
		Throw, IndexAccess, Delete, In,
		Switch, InstanceOf, Regex, Array,
		Integer, Var, Parameter, Local,
		Global, Closed
	}

	abstract public class Node : INode {
		public NodeType NodeType { get; protected set; }
		public INode[] Children { get; protected set; }
		public virtual Type Type { get { return IjsTypes.Dynamic; } }

		public Node(NodeType type, ITree node) {
			NodeType = type;
		}

		public virtual INode Analyze(Stack<Function> stack) {
			if (Children != null) {
				for (int i = 0; i < Children.Length; ++i) {
					if (Children[i] != null) {
						Children[i] = Children[i].Analyze(stack);
					}
				}
			}

			return this;
		}

		public virtual Et Compile(Function func) {
			return AstUtils.Empty();
		}

		public override string ToString() {
			return NodeType.ToString();
		}
	}
}
