using System;
using DynamicDateTime.VariableModels;
using DynamicDateTime.VariableParsers;
using NUnit.Framework;

namespace DynamicDateTime.Test.VariableTests
{
    public class DynamicParserTest
    {
        [Test, Category("DynamicParser")]
        public void DynamicTodayTest()
        {
            var expectedDate = DateTime.Today;
            var actualDate = DynamicParser.GetDate(DayVariable.Today);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicTomorrowTest()
        {
            var expectedDate = DateTime.Today.AddDays(1);
            var actualDate = DynamicParser.GetDate(DayVariable.Tomorrow);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicYesterdayTest()
        {
            var expectedDate = DateTime.Today.AddDays(-1);
            var actualDate = DynamicParser.GetDate(DayVariable.Yesterday);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicErrorTest()
        {
            var actualDate = DynamicParser.GetDate("dfd");
            Assert.AreEqual(actualDate.Error, "Incorrect Date Variable. Could not parse Date Variable = 'dfd'");
        }

        [Test, Category("DynamicParser")]
        public void DynamicCurrentMonthTest()
        {
            var expectedDate = DateTime.Today;
            var actualDate = DynamicParser.GetDate(MonthVariable.CurrentMonth);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicLastMonthTest()
        {
            var expectedDate = DateTime.Today.AddMonths(-1);
            var actualDate = DynamicParser.GetDate(MonthVariable.LastMonth);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicNextMonthTest()
        {
            var expectedDate = DateTime.Today.AddMonths(1);
            var actualDate = DynamicParser.GetDate(MonthVariable.NextMonth);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicMidMonthTest()
        {
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, currentDate.Month, 15);
            var actualDate = DynamicParser.GetDate(MonthVariable.MidMonth);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicStartMonthTest()
        {
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            var actualDate = DynamicParser.GetDate(MonthVariable.StartMonth);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicEndMonthTest()
        {
            var currentDate = DateTime.Today;
            var lastDay = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            var expectedDate = new DateTime(currentDate.Year, currentDate.Month, lastDay);
            var actualDate = DynamicParser.GetDate(MonthVariable.EndMonth);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicNextQuarterTest()
        {
            var expectedDate = DateTime.Today.AddDays(90);
            var actualDate = DynamicParser.GetDate(QuarterVariable.NextQuarter);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicLastQuarterTest()
        {
            var expectedDate = DateTime.Today.AddDays(-90);
            var actualDate = DynamicParser.GetDate(QuarterVariable.LastQuarter);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicNextWeekTest()
        {
            var expectedDate = DateTime.Today.AddDays(7);
            var actualDate = DynamicParser.GetDate(WeekVariable.NextWeek);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicLastWeekTest()
        {
            var expectedDate = DateTime.Today.AddDays(-7);
            var actualDate = DynamicParser.GetDate(WeekVariable.LastWeek);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicCurrentYearTest()
        {
            var expectedDate = DateTime.Today;
            var actualDate = DynamicParser.GetDate(YearVariable.CurrentYear);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicLastYearTest()
        {
            var expectedDate = DateTime.Today.AddYears(-1);
            var actualDate = DynamicParser.GetDate(YearVariable.LastYear);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicNextYearTest()
        {
            var expectedDate = DateTime.Today.AddYears(1);
            var actualDate = DynamicParser.GetDate(YearVariable.NextYear);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicEndYearTest()
        {
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, 12, 31);
            var actualDate = DynamicParser.GetDate(YearVariable.EndYear);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicEndNextYearTest()
        {
            var currentDate = DateTime.Today.AddYears(1);
            var expectedDate = new DateTime(currentDate.Year, 12, 31);
            var actualDate = DynamicParser.GetDate(YearVariable.EndNextYear);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicEndLastYearTest()
        {
            var currentDate = DateTime.Today.AddYears(-1);
            var expectedDate = new DateTime(currentDate.Year, 12, 31);
            var actualDate = DynamicParser.GetDate(YearVariable.EndLastYear);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicStartYearTest()
        {
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, 1, 1);
            var actualDate = DynamicParser.GetDate(YearVariable.StartYear);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicStartNextYearTest()
        {
            var currentDate = DateTime.Today.AddYears(1);
            var expectedDate = new DateTime(currentDate.Year, 1, 1);
            var actualDate = DynamicParser.GetDate(YearVariable.StartNextYear);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("DynamicParser")]
        public void DynamicStartLastYearTest()
        {
            var currentDate = DateTime.Today.AddYears(-1);
            var expectedDate = new DateTime(currentDate.Year, 1, 1);
            var actualDate = DynamicParser.GetDate(YearVariable.StartLastYear);
            Assert.AreEqual(expectedDate, actualDate.Date);
        }
    }
}
