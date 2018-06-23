using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Xams.SourceCode
{
    public class Holiday
    {
        public string IsTodayXmas()
        {
            if (DateTime.Now.Year == 12 && DateTime.Now.Month == 25)
            {
                return "Happy Xmas!";
            }

            return "Today is not Xmas";
        }
    }
}
