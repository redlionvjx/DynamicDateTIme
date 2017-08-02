using System;
using DynamicDateTime.VariableModels;
using DynamicDateTime.VariableParsers;
using NUnit.Framework;

namespace DynamicDateTime.Test.VariableTests
{
    [TestFixture()]
    public class MonthVariableTest
    {
        [Test, Category("MonthVariable")]
        public void ShouldParseEmpty()
        {
            Assert.IsFalse(MonthParser.ShouldParseVariable(""));
        }

        [Test, Category("MonthVariable")]
        public void ShouldParseSpace()
        {
            Assert.IsFalse(MonthParser.ShouldParseVariable(" "));
        }

        [Test, Category("MonthVariable")]
        public void ShouldParseFalseString()
        {
            Assert.IsFalse(MonthParser.ShouldParseVariable("MonthMonth"));
        }

        [Test, Category("MonthVariable")]
        public void CurrentMonthTest()
        {
            var expectedDate = DateTime.Today;
            var actualDate = MonthParser.ParseVariable("CurrentMonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void LastMonthTest()
        {
            var expectedDate = DateTime.Today.AddMonths(-1);
            var actualDate = MonthParser.ParseVariable("lastmonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void NextMonthTest()
        {
            var expectedDate = DateTime.Today.AddMonths(1);
            var actualDate = MonthParser.ParseVariable("nextmonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void MidMonthTest()
        {
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, currentDate.Month, 15);
            var actualDate = MonthParser.ParseVariable("midmonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void StartMonthTest()
        {
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            var actualDate = MonthParser.ParseVariable("startmonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void EndMonthTest()
        {
            var currentDate = DateTime.Today;
            var lastDay = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            var expectedDate = new DateTime(currentDate.Year, currentDate.Month, lastDay);
            var actualDate = MonthParser.ParseVariable("endmonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void MonthErrorTest()
        {
            var actualDate = MonthParser.ParseVariable("MonthMonth");
            Assert.AreEqual(actualDate.Error, "Incorrect Month Variable. Could not parse Month Variable = 'MonthMonth'");
        }
    }
}
