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
            var monthParser = new MonthParser();
            Assert.IsFalse(monthParser.ShouldParseVariable(""));
        }

        [Test, Category("MonthVariable")]
        public void ShouldParseSpace()
        {
            var monthParser = new MonthParser();
            Assert.IsFalse(monthParser.ShouldParseVariable(" "));
        }

        [Test, Category("MonthVariable")]
        public void ShouldParseFalseString()
        {
            var monthParser = new MonthParser();
            Assert.IsFalse(monthParser.ShouldParseVariable("MonthMonth"));
        }

        [Test, Category("MonthVariable")]
        public void CurrentMonthTest()
        {
            var monthParser = new MonthParser();
            var expectedDate = DateTime.Today;
            var actualDate = monthParser.ParseVariable("CurrentMonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void LastMonthTest()
        {
            var monthParser = new MonthParser();
            var expectedDate = DateTime.Today.AddMonths(-1);
            var actualDate = monthParser.ParseVariable("lastmonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void NextMonthTest()
        {
            var monthParser = new MonthParser();
            var expectedDate = DateTime.Today.AddMonths(1);
            var actualDate = monthParser.ParseVariable("nextmonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void MidMonthTest()
        {
            var monthParser = new MonthParser();
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, currentDate.Month, 15);
            var actualDate = monthParser.ParseVariable("midmonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void StartMonthTest()
        {
            var monthParser = new MonthParser();
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            var actualDate = monthParser.ParseVariable("startmonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void EndMonthTest()
        {
            var monthParser = new MonthParser();
            var currentDate = DateTime.Today;
            var lastDay = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            var expectedDate = new DateTime(currentDate.Year, currentDate.Month, lastDay);
            var actualDate = monthParser.ParseVariable("endmonth");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("MonthVariable")]
        public void MonthErrorTest()
        {
            var monthParser = new MonthParser();
            var actualDate = monthParser.ParseVariable("MonthMonth");
            Assert.AreEqual(actualDate.Error, "Incorrect Month Variable. Could not parse Month Variable = 'MonthMonth'");
        }
    }
}
