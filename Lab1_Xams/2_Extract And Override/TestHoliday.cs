using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab1_Xams._2_Extract_And_Override
{
    [TestClass]
    public class TestHoliday
    {
        [TestMethod]
        public void Today_Is_Xams()
        {
            var target = new HolidayStub { SetDateTime = new DateTime(2018, 12, 25) };
            var actual = target.IsTodayXmas();
            Assert.AreEqual("Happy Xmas!", actual);
        }

        [TestMethod]
        public void Today_Is_Not_Xams()
        {
            var target = new HolidayStub { SetDateTime = new DateTime(2018, 12, 24) };
            var actual = target.IsTodayXmas();
            Assert.AreEqual("Today is not Xmas", actual);
        }
    }

    public class HolidayStub : Holiday
    {
        private DateTime _dateTime;

        public DateTime SetDateTime
        {
            set => _dateTime = value;
        }

        protected override DateTime Today()
        {
            return _dateTime;
        }
    }
}