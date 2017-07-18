using System;
using DynamicDateTime.KeyWordParsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynamicDateTime.Test
{
    [TestClass]
    public class SDCUnitTest
    {
        [TestCategory("SDC_Unit_Test")]
        [TestMethod]
        public void Current()
        {
            var now = DateTime.Now;
            var actualDate = DateParser.Parse("current");
            Assert.AreEqual(now.Date, actualDate.Date);
        }

        [TestCategory("SDC_Unit_Test")]
        [TestMethod]
        public void Future()
        {
            var now = DateTime.Today;
            var expectedDate = now.AddMonths(1);
            var actualDate = DateParser.Parse("future");
            Assert.AreEqual(expectedDate.Date, actualDate.Date);
        }

        [TestCategory("SDC_Unit_Test")]
        [TestMethod]
        public void FutureDependent()
        {
            var dependentDate = DateTime.Today;
            var expectedDate = dependentDate.AddMonths(1);
            var actualDate = DateParser.Parse("future", dependentDate);
            Assert.AreEqual(expectedDate.Date, actualDate.Date);
        }

        [TestCategory("SDC_Unit_Test")]
        [TestMethod]
        public void Past()
        {
            var now = DateTime.Now;
            var expectedDate = now.AddMonths(-1);
            var actualDate = DateParser.Parse("past");
            Assert.AreEqual(expectedDate.Date, actualDate.Date);
        }

        [TestCategory("SDC_Unit_Test")]
        [TestMethod]
        public void PastDependent()
        {
            var dependentDate = DateTime.Today;
            var expectedDate = dependentDate.AddMonths(-1);
            var actualDate = DateParser.Parse("past", dependentDate);
            Assert.AreEqual(expectedDate.Date, actualDate.Date);
        }
    }
}
