using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Day13
{
    class TC2Float
    {
        //test cases for float
        // TC 2.1

        public static void TC1Flt()
        {
            double max = UC2MaxFloat.MaxFloat(5.1, 2.2, 3.1);
            Console.WriteLine("Maximum float is : " + max);
        }

        // TC 2.2

        public static void TC2Flt()
        {
            double max = UC2MaxFloat.MaxFloat(2.5, 8.4, 6.2);
            Console.WriteLine("Maximum float is : " + max);
        }

        // TC 2.3

        public static void TC3Flt()
        {
            double max = UC2MaxFloat.MaxFloat(5.1, 4.2, 10.8);
            Console.WriteLine("Maximum float is : " + max);
        }
    }
}
