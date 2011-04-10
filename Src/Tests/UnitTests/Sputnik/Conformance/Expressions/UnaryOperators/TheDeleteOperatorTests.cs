// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.UnaryOperators
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TheDeleteOperatorTests : SputnikTestFixture
    {
        public TheDeleteOperatorTests()
            : base(@"Conformance\11_Expressions\11.4_Unary_Operators\11.4.1_The_delete_Operator")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [TestCase("S11.4.1_A1.js", Description = "White Space and Line Terminator between \"delete\" and UnaryExpression are allowed")]
        public void WhiteSpaceAndLineTerminatorBetweenDeleteAndUnaryExpressionAreAllowed(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [TestCase("S11.4.1_A2.1.js", Description = "If Type(x) is not Reference, return true")]
        public void IfTypeXIsNotReferenceReturnTrue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [TestCase("S11.4.1_A2.2_T1.js", Description = "If GetBase(x) doesn\'t have a property GetPropertyName(x), return true")]
        [TestCase("S11.4.1_A2.2_T2.js", Description = "If GetBase(x) doesn\'t have a property GetPropertyName(x), return true")]
        public void IfGetBaseXDoesnTHaveAPropertyGetPropertyNameXReturnTrue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [TestCase("S11.4.1_A3.1.js", Description = "If the property has the DontDelete attribute, return false")]
        public void IfThePropertyHasTheDontDeleteAttributeReturnFalse(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [TestCase("S11.4.1_A3.2.js", Description = "If the property doesn\'t have the DontDelete attribute, return true")]
        public void IfThePropertyDoesnTHaveTheDontDeleteAttributeReturnTrue(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [TestCase("S11.4.1_A3.3.js", Description = "If the property doesn\'t have the DontDelete attribute, remove the property")]
        public void IfThePropertyDoesnTHaveTheDontDeleteAttributeRemoveTheProperty(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 11.4.1")]
        [TestCase("S11.4.1_A4.js", Description = "\"Delete\" operator removes property, which is reference to the object, not the object")]
        public void DeleteOperatorRemovesPropertyWhichIsReferenceToTheObjectNotTheObject(string file)
        {
            RunFile(file);
        }
    }
}