using System;
using DynamicDateTime.VariableParsers;
using NUnit.Framework;

namespace DynamicDateTime.Test.VariableTests
{
    public class QuarterVariableTest
    {
        [Test, Category("QuarterVariable")]
        public void ShouldParseEmpty()
        {
            Assert.IsFalse(QuarterParser.ShouldParseVariable(""));
        }

        [Test, Category("QuarterVariable")]
        public void ShouldParseSpace()
        {
            Assert.IsFalse(QuarterParser.ShouldParseVariable(" "));
        }

        [Test, Category("QuarterVariable")]
        public void ShouldParseFalseString()
        {
            Assert.IsFalse(QuarterParser.ShouldParseVariable("QuarterQuarter"));
        }

        [Test, Category("QuarterVariable")]
        public void NextQuarterTest()
        {
            var expectedDate = DateTime.Today.AddDays(90);
            var actualDate = QuarterParser.ParseVariable("nextquarter");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("QuarterVariable")]
        public void LastQuarterTest()
        {
            var expectedDate = DateTime.Today.AddDays(-90);
            var actualDate = QuarterParser.ParseVariable("lastquarter");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }
    }
}
