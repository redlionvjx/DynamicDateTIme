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
            Assert.IsFalse(WeekParser.ShouldParseVariable(""));
        }

        [Test, Category("WeekVariable")]
        public void ShouldParseSpace()
        {
            Assert.IsFalse(WeekParser.ShouldParseVariable(" "));
        }

        [Test, Category("WeekVariable")]
        public void ShouldParseFalseString()
        {
            Assert.IsFalse(WeekParser.ShouldParseVariable("weekWeek"));
        }

        [Test, Category("WeekVariable")]
        public void NextWeekTest()
        {
            var expectedDate = DateTime.Today.AddDays(7);
            var actualDate = WeekParser.ParseVariable("nextweek");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("WeekVariable")]
        public void LastWeekTest()
        {
            var expectedDate = DateTime.Today.AddDays(-7);
            var actualDate = WeekParser.ParseVariable("lastweek");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }
    }
}
