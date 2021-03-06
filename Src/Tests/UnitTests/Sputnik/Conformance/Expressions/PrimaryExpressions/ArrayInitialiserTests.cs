// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.PrimaryExpressions
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ArrayInitialiserTests : SputnikTestFixture
    {
        public ArrayInitialiserTests()
            : base(@"Conformance\11_Expressions\11.1_Primary_Expressions\11.1.4_Array_Initialiser")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.4")]
        [TestCase("S11.1.4_A1.1.js", Description = "Evaluate the production ArrayLiteral: [ ]")]
        public void EvaluateTheProductionArrayLiteral(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.4")]
        [TestCase("S11.1.4_A1.2.js", Description = "Evaluate the production ArrayLiteral: [ Elision ]")]
        public void EvaluateTheProductionArrayLiteralElision(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.4")]
        [TestCase("S11.1.4_A1.3.js", Description = "Evaluate the production ArrayLiteral: [ AssignmentExpression ]")]
        public void EvaluateTheProductionArrayLiteralAssignmentExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.4")]
        [TestCase("S11.1.4_A1.4.js", Description = "Evaluate the production ArrayLiteral: [ Elision, AssignmentExpression ]")]
        public void EvaluateTheProductionArrayLiteralElisionAssignmentExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.4")]
        [TestCase("S11.1.4_A1.5.js", Description = "Evaluate the production ArrayLiteral: [ AssignmentExpression, Elision ]")]
        public void EvaluateTheProductionArrayLiteralAssignmentExpressionElision(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.4")]
        [TestCase("S11.1.4_A1.6.js", Description = "Evaluate the production ArrayLiteral: [ Elision, AssignmentExpression, Elision ]")]
        public void EvaluateTheProductionArrayLiteralElisionAssignmentExpressionElision(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.4")]
        [TestCase("S11.1.4_A1.7.js", Description = "Evaluate the production ArrayLiteral: [ AssignmentExpression, Elision, AssignmentExpression ]")]
        public void EvaluateTheProductionArrayLiteralAssignmentExpressionElisionAssignmentExpression(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.1.4")]
        [TestCase("S11.1.4_A2.js", Description = "Create multi dimensional array")]
        public void CreateMultiDimensionalArray(string file)
        {
            RunFile(file);
        }
    }
}