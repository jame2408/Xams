using System;

namespace Lab1_Xams._0_SourceCode
{
    public class Holiday
    {
        public string IsTodayXmas()
        {
            if (DateTime.Now.Month == 12 && DateTime.Now.Day == 25)
            {
                return "Happy Xmas!";
            }

            return "Today is not Xmas";
        }
    }
}