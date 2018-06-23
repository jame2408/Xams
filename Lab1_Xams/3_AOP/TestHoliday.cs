using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab1_Xams._3_AOP
{
    [TestClass]
    public class TestHoliday
    {
        [TestInitialize]
        public void BeforeEachTestMethods()
        {
            SystemTime.ReSet();
        }

        [TestMethod]
        public void Today_Is_Xmas()
        {
            SystemTime.Set(new DateTime(2018, 12, 25));
            TodayShouldBe("Happy Xmas!");
        }

        [TestMethod]
        public void Today_Is_Not_Xmas()
        {
            SystemTime.Set(new DateTime(2018, 12, 24));
            TodayShouldBe("Today is not Xmas");
        }

        private static void TodayShouldBe(string expected)
        {
            var target = new Holiday();
            var actual = target.IsTodayXmas();
            Assert.AreEqual(expected, actual);
        }

        [TestCleanup]
        public void AfterEachTestMethods()
        {
            SystemTime.ReSet();
        }
    }
}