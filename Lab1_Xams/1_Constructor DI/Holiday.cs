using System;

namespace Lab1_Xams._1_Constructor_DI
{
    public class Holiday
    {
        private readonly DateTime _dateTime;

        public Holiday(DateTime dateTime)
        {
            this._dateTime = dateTime;
        }

        public string IsTodayXmas()
        {
            if (Today().Month == 12 && Today().Day == 25)
            {
                return "Happy Xmas!";
            }

            return "Today is not Xmas";
        }

        private DateTime Today()
        {
            return _dateTime;
        }
    }
}