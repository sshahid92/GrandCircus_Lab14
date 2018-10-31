using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab14_AlligatorsAndSheep
{
    class CountUtil
    {
        public static void Count(ICountable c, int maxCount)
        {
            for (int i = 0; i < maxCount; i++)
            {
                c.IncrementCount();
                Console.WriteLine($"{c.GetCountString()}");
            }
        }
    }
}
