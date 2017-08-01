
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
            var dayParser = new DayParser();
            Assert.IsFalse(dayParser.ShouldParseVariable(""));
        }

        [Test, Category("DayVariable")]
        public void ShouldParseSpace()
        {
            var dayParser = new DayParser();
            Assert.IsFalse(dayParser.ShouldParseVariable(" "));
        }

        [Test, Category("DayVariable")]
        public void ShouldParseFalseString()
        {
            var dayParser = new DayParser();
            Assert.IsFalse(dayParser.ShouldParseVariable("TodayToday"));
        }

        [Test, Category("DayVariable")]
        public void ShouldParseToday()
        {
            var dayParser = new DayParser();
            Assert.IsTrue(dayParser.ShouldParseVariable("today"));
        }

        [Test, Category("DayVariable")]
        public void ShouldParseYesterday()
        {
            var dayParser = new DayParser();
            Assert.IsTrue(dayParser.ShouldParseVariable("yesterday"));
        }

        [Test, Category("DayVariable")]
        public void ShouldParseTomorrow()
        {
            var dayParser = new DayParser();
            Assert.IsTrue(dayParser.ShouldParseVariable("toMorrow"));
        }

        [Test, Category("DayVariable")]
        public void TodayTest()
        {
            var dayParser = new DayParser();
            var expectedDate = DateTime.Today;
            var actualDate = dayParser.ParseVariable("Today");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DayVariable")]
        public void TomorrowTest()
        {
            var dayParser = new DayParser();
            var expectedDate = DateTime.Today.AddDays(1);
            var actualDate = dayParser.ParseVariable("tomorrow");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DayVariable")]
        public void YesterdayTest()
        {
            var dayParser = new DayParser();
            var expectedDate = DateTime.Today.AddDays(-1);
            var actualDate = dayParser.ParseVariable("Yesterday");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DayVariable")]
        public void ErrorTest()
        {
            var dayParser = new DayParser();
            var actualDate = dayParser.ParseVariable("Todayd");
            Assert.AreEqual(actualDate.Error, "Incorrect Day Variable. Could not parse Day Variable = 'Todayd'");
        }
    }
}
