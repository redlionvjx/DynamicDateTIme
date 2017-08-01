using System;
using DynamicDateTime.VariableParsers;
using NUnit.Framework;

namespace DynamicDateTime.Test.VariableTests
{
    [TestFixture]
    public class WeekVariableTest
    {
        [Test, Category("WeekVariable")]
        public void ShouldParseEmpty()
        {
            var weekParser = new WeekParser();
            Assert.IsFalse(weekParser.ShouldParseVariable(""));
        }

        [Test, Category("WeekVariable")]
        public void ShouldParseSpace()
        {
            var weekParser = new WeekParser();
            Assert.IsFalse(weekParser.ShouldParseVariable(" "));
        }

        [Test, Category("WeekVariable")]
        public void ShouldParseFalseString()
        {
            var weekParser = new WeekParser();
            Assert.IsFalse(weekParser.ShouldParseVariable("weekWeek"));
        }

        [Test, Category("WeekVariable")]
        public void NextQuarterTest()
        {
            var weekParser = new WeekParser();
            var expectedDate = DateTime.Today.AddDays(7);
            var actualDate = weekParser.ParseVariable("nextweek");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("WeekVariable")]
        public void LastQuarterTest()
        {
            var weekParser = new WeekParser();
            var expectedDate = DateTime.Today.AddDays(-7);
            var actualDate = weekParser.ParseVariable("lastweek");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }
    }
}
