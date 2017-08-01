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
            var quarterParser = new QuarterParser();
            Assert.IsFalse(quarterParser.ShouldParseVariable(""));
        }

        [Test, Category("QuarterVariable")]
        public void ShouldParseSpace()
        {
            var quarterParser = new QuarterParser();
            Assert.IsFalse(quarterParser.ShouldParseVariable(" "));
        }

        [Test, Category("QuarterVariable")]
        public void ShouldParseFalseString()
        {
            var quarterParser = new QuarterParser();
            Assert.IsFalse(quarterParser.ShouldParseVariable("QuarterQuarter"));
        }

        [Test, Category("QuarterVariable")]
        public void NextQuarterTest()
        {
            var quarterParser = new QuarterParser();
            var expectedDate = DateTime.Today.AddDays(90);
            var actualDate = quarterParser.ParseVariable("nextquarter");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("QuarterVariable")]
        public void LastQuarterTest()
        {
            var quarterParser = new QuarterParser();
            var expectedDate = DateTime.Today.AddDays(-90);
            var actualDate = quarterParser.ParseVariable("lastquarter");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }
    }
}
