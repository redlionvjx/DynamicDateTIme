
using System;
using DynamicDateTime.VariableParsers;
using NUnit.Framework;

namespace DynamicDateTime.Test.VariableTests
{
    [TestFixture]
    public class DayVariableTest
    {
        [Test, Category("DayVariable")]
        public void ShouldParseEmpty()
        {
            Assert.IsFalse(DayParser.ShouldParseVariable(""));
        }

        [Test, Category("DayVariable")]
        public void ShouldParseSpace()
        {
            Assert.IsFalse(DayParser.ShouldParseVariable(" "));
        }

        [Test, Category("DayVariable")]
        public void ShouldParseFalseString()
        {
            Assert.IsFalse(DayParser.ShouldParseVariable("TodayToday"));
        }

        [Test, Category("DayVariable")]
        public void ShouldParseToday()
        {
            Assert.IsTrue(DayParser.ShouldParseVariable("today"));
        }

        [Test, Category("DayVariable")]
        public void ShouldParseYesterday()
        {
            Assert.IsTrue(DayParser.ShouldParseVariable("yesterday"));
        }

        [Test, Category("DayVariable")]
        public void ShouldParseTomorrow()
        {
            Assert.IsTrue(DayParser.ShouldParseVariable("toMorrow"));
        }

        [Test, Category("DayVariable")]
        public void TodayTest()
        {
            var expectedDate = DateTime.Today;
            var actualDate = DayParser.ParseVariable("Today");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DayVariable")]
        public void TomorrowTest()
        {
            var expectedDate = DateTime.Today.AddDays(1);
            var actualDate = DayParser.ParseVariable("tomorrow");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DayVariable")]
        public void YesterdayTest()
        {
            var expectedDate = DateTime.Today.AddDays(-1);
            var actualDate = DayParser.ParseVariable("Yesterday");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DayVariable")]
        public void ErrorTest()
        {
            var actualDate = DayParser.ParseVariable("Todayd");
            Assert.AreEqual(actualDate.Error, "Incorrect Day Variable. Could not parse Day Variable = 'Todayd'");
        }
    }
}
