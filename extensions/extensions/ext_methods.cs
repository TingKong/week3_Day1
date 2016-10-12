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

        public static int Mutiplication(this int originalInt)
        {
            int multNum = originalInt * 10;
            return multNum;
        }

        public static int Snow(this string originalString)
        {

            int count = 0;
            for (int i = 0; i < originalString.Length; i++)
            {
                if (i < originalString.Length - 3)
                {
                    if (originalString.Substring(i, 4) == "snow")
                    {

                        count++;

                    }
                }
            }


            return count;

        }

        public static double Tax(this double dollarAmount)
        {
            double newAmt = dollarAmount * .06;
            double totalAmt = newAmt + dollarAmount;
            return totalAmt;
        }

        public static bool GreaterThan(this int ranNum)
        {

            if (ranNum > 20)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public static char AmountChar(this string howChar)
        {
            int charcount = 0;
            for (int i = 0; i < howChar.Length; i++) {
                if (howChar.Contains("/"))
                {
                    charcount++;
                }
            }

            int a = charcount;
            char b = Convert.ToChar(a);
            return b;
        }
    }
}

