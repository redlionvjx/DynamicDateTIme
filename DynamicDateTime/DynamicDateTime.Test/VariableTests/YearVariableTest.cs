using System;
using DynamicDateTime.VariableParsers;
using NUnit.Framework;

namespace DynamicDateTime.Test.VariableTests
{
    [TestFixture]
    public class YearVariableTest
    {
        [Test, Category("YearVariable")]
        public void ShouldParseEmpty()
        {
            var yearParser = new YearParser();
            Assert.IsFalse(yearParser.ShouldParseVariable(""));
        }

        [Test, Category("YearVariable")]
        public void ShouldParseSpace()
        {
            var yearParser = new YearParser();
            Assert.IsFalse(yearParser.ShouldParseVariable(" "));
        }

        [Test, Category("YearVariable")]
        public void ShouldParseFalseString()
        {
            var yearParser = new YearParser();
            Assert.IsFalse(yearParser.ShouldParseVariable("yearyear"));
        }

        [Test, Category("YearVariable")]
        public void CurrentYearTest()
        {
            var yearParser = new YearParser();
            var expectedDate = DateTime.Today;
            var actualDate = yearParser.ParseVariable("CurrentYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }
        
        [Test, Category("YearVariable")]
        public void LastYearTest()
        {
            var yearParser = new YearParser();
            var expectedDate = DateTime.Today.AddYears(-1);
            var actualDate = yearParser.ParseVariable("lastYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void NextYearTest()
        {
            var yearParser = new YearParser();
            var expectedDate = DateTime.Today.AddYears(1);
            var actualDate = yearParser.ParseVariable("nextyear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void EndYearTest()
        {
            var yearParser = new YearParser();
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, 12, 31);
            var actualDate = yearParser.ParseVariable("EndYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void EndNextYearTest()
        {
            var yearParser = new YearParser();
            var currentDate = DateTime.Today.AddYears(1);
            var expectedDate = new DateTime(currentDate.Year, 12, 31);
            var actualDate = yearParser.ParseVariable("EndNextYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void EndLastYearTest()
        {
            var yearParser = new YearParser();
            var currentDate = DateTime.Today.AddYears(-1);
            var expectedDate = new DateTime(currentDate.Year, 12, 31);
            var actualDate = yearParser.ParseVariable("EndLastYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void StartYearTest()
        {
            var yearParser = new YearParser();
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, 1, 1);
            var actualDate = yearParser.ParseVariable("startYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void StartNextYearTest()
        {
            var yearParser = new YearParser();
            var currentDate = DateTime.Today.AddYears(1);
            var expectedDate = new DateTime(currentDate.Year, 1, 1);
            var actualDate = yearParser.ParseVariable("startNextYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void StartLastYearTest()
        {
            var yearParser = new YearParser();
            var currentDate = DateTime.Today.AddYears(-1);
            var expectedDate = new DateTime(currentDate.Year, 1, 1);
            var actualDate = yearParser.ParseVariable("startLastYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }
    }
}
