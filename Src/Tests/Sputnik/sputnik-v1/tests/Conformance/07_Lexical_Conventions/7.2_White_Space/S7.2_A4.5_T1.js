// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S7.2_A4.5_T1;
 * @section: 7.2, 7.4;
 * @assertion: Multi line comment can contain NO-BREAK SPACE (U+00A0);
 * @description: Use NO-BREAK SPACE(\u00A0);
 */

// CHECK#1
eval("/*\u00A0 multi line \u00A0 comment \u00A0*/");

//CHECK#2
var x = 0;
eval("/*\u00A0 multi line \u00A0 comment \u00A0 x = 1;*/");
if (x !== 0) {
  $ERROR('#1: var x = 0; eval("/*\\u00A0 multi line \\u00A0 comment \\u00A0 x = 1;*/"); x === 0. Actual: ' + (x));
}
