using System;
using DynamicDateTime.KeyWordParsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynamicDateTime.Test
{
    [TestClass]
    public class SDCUnitTest
    {
        [TestCategory("UnitTest_Date_Factory")]
        [TestMethod]
        public void Current()
        {
            var now = DateTime.Now;

            var actualDate1 = DateParser.Parse("current");
            Assert.IsTrue(actualDate1.Date.Equals(now.Date), string.Format("expected value = {0}, actual = {1}", now, actualDate1));
        }

        [TestCategory("UnitTest_Date_Factory")]
        [TestMethod]
        public void Future()
        {
            var now = DateTime.Today;
            var expectDate = now.AddMonths(1);
            var actualDate = DateParser.Parse("future");
            Assert.IsTrue(actualDate.Date.Equals(expectDate.Date), string.Format("expected value = {0}, actual = {1}", expectDate, actualDate));
        }

        [TestCategory("UnitTest_Date_Factory")]
        [TestMethod]
        public void FutureDependent()
        {
            var dependentDate = new DateTime(2016, 10, 28);
            var expectDate = new DateTime(2016, 11, 28);
            var actualDate = DateParser.Parse("future", dependentDate);
            Assert.IsTrue(actualDate.Date.Equals(expectDate.Date), string.Format("expected value = {0}, actual = {1}", expectDate, actualDate));
        }

        [TestCategory("UnitTest_Date_Factory")]
        [TestMethod]
        public void Past()
        {
            var now = DateTime.Now;
            var expectDate = now.AddMonths(-1);
            var actualDate1 = DateParser.Parse("past");
            Assert.IsTrue(actualDate1.Date.Equals(expectDate.Date), string.Format("expected value = {0}, actual = {1}", expectDate, actualDate1));
        }

        [TestCategory("UnitTest_Date_Factory")]
        [TestMethod]
        public void PastDependent()
        {
            var dependentDate = new DateTime(2016, 10, 28);
            var expectDate = new DateTime(2016, 9, 28);
            var actualDate = DateParser.Parse("past", dependentDate);
            Assert.IsTrue(actualDate.Date.Equals(expectDate.Date), string.Format("expected value = {0}, actual = {1}", expectDate, actualDate));
        }
    }
}
