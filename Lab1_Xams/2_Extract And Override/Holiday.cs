using System;

namespace Lab1_Xams._2_Extract_And_Override
{
    public class Holiday
    {
        public string IsTodayXmas()
        {
            if (Today().Month == 12 && Today().Day == 25)
            {
                return "Happy Xmas!";
            }

            return "Today is not Xmas";
        }

        protected virtual DateTime Today()
        {
            return DateTime.Now;
        }
    }
}