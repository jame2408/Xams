using System;

namespace Lab1_Xams._3_AOP
{
    public class Holiday
    {
        public string IsTodayXmas()
        {
            if (SystemTime.Now.Month == 12 && SystemTime.Now.Day == 25)
            {
                return "Happy Xmas!";
            }

            return "Today is not Xmas";
        }
    }

    public class SystemTime
    {
        private static DateTime _date;

        public static void Set(DateTime custom) => _date = custom;

        public static void ReSet() => _date = DateTime.MinValue;

        public static DateTime Now
        {
            get
            {
                if (_date != DateTime.MinValue)
                {
                    return _date;
                }
                return DateTime.Now;
            }
        }
    }
}