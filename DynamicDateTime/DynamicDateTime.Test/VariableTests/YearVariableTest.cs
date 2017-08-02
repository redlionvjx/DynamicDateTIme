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
            Assert.IsFalse(YearParser.ShouldParseVariable(""));
        }

        [Test, Category("YearVariable")]
        public void ShouldParseSpace()
        {
            Assert.IsFalse(YearParser.ShouldParseVariable(" "));
        }

        [Test, Category("YearVariable")]
        public void ShouldParseFalseString()
        {
            Assert.IsFalse(YearParser.ShouldParseVariable("yearyear"));
        }

        [Test, Category("YearVariable")]
        public void CurrentYearTest()
        {
            var expectedDate = DateTime.Today;
            var actualDate = YearParser.ParseVariable("CurrentYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }
        
        [Test, Category("YearVariable")]
        public void LastYearTest()
        {
            var expectedDate = DateTime.Today.AddYears(-1);
            var actualDate = YearParser.ParseVariable("lastYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void NextYearTest()
        {
            var expectedDate = DateTime.Today.AddYears(1);
            var actualDate = YearParser.ParseVariable("nextyear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void EndYearTest()
        {
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, 12, 31);
            var actualDate = YearParser.ParseVariable("EndYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void EndNextYearTest()
        {
            var currentDate = DateTime.Today.AddYears(1);
            var expectedDate = new DateTime(currentDate.Year, 12, 31);
            var actualDate = YearParser.ParseVariable("EndNextYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void EndLastYearTest()
        {
            var currentDate = DateTime.Today.AddYears(-1);
            var expectedDate = new DateTime(currentDate.Year, 12, 31);
            var actualDate = YearParser.ParseVariable("EndLastYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void StartYearTest()
        {
            var currentDate = DateTime.Today;
            var expectedDate = new DateTime(currentDate.Year, 1, 1);
            var actualDate = YearParser.ParseVariable("startYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void StartNextYearTest()
        {
            var currentDate = DateTime.Today.AddYears(1);
            var expectedDate = new DateTime(currentDate.Year, 1, 1);
            var actualDate = YearParser.ParseVariable("startNextYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }

        [Test, Category("YearVariable")]
        public void StartLastYearTest()
        {
            var currentDate = DateTime.Today.AddYears(-1);
            var expectedDate = new DateTime(currentDate.Year, 1, 1);
            var actualDate = YearParser.ParseVariable("startLastYear");
            Assert.AreEqual(expectedDate, actualDate.Date);
        }
    }
}
