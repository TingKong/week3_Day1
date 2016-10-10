using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensions
{
    public static class WholeNumbers
    {
        public static List<int> OrderInt(this List<int> originalInt)
        {
            originalInt.Sort();
            return originalInt;
        }

        public static int Mutiplication (this int originalInt)
        {
            int multNum = originalInt * 10;
            return multNum;
        }
    }
}
