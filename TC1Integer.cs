using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Day13
{
    class TC1Integer
    {
        // test cases for integers
        // TC 1.1
        public static void TC1int()
        {
            int max = UC1MaxInteger.MaxInt(20, 10, 5);
            Console.WriteLine("Maximum integer is : " + max);
        }

        // TC 1.2

        public static void TC2int()
        {
            int max = UC1MaxInteger.MaxInt(22, 55, 12);
            Console.WriteLine("Maximum integer is : " + max);
        }

        //TC 1.3

        public static void TC3int()
        {
            int max = UC1MaxInteger.MaxInt(5, 8, 10);
            Console.WriteLine("Maximum integer is : " + max);
        }
    }
}
