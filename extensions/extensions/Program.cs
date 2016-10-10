using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            //int
            //string
            //double
            //bool
            //char
            //float

            //LIST

            List<int> myList = new List<int>();
            myList.Add(10);
            myList.Add(1);
            myList.Add(5);
            List<int> empList = myList.OrderInt();

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(empList[i]);

             
            }

            //INT
            int myNumb = 10;
            int newNumb = myNumb.Mutiplication();

            Console.WriteLine(newNumb);

            //STRING
            string myString = "snow snow";
            int wcount = myString.Snow();
            Console.WriteLine(wcount);

            //DOUBLE
            double tshirt = 8;
            double totalAmt = tshirt.Tax();

            Console.WriteLine(totalAmt);

            //BOOL
            int newNum = 9;
            bool whatIsIT = newNum.GreaterThan();
            if (whatIsIT)
            {
                Console.WriteLine("Your number is greater than 20!");
            }
            else
            {
                Console.WriteLine("Your number is less than 20!");

            }

            //CHAR




            Console.ReadLine();





        }
    }
}
