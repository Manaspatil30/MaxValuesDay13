using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Day13
{
    class TC3String
    {
        //test cases for string
        //TC 3.1

        public static void TC1String()
        {
            string max = UC3MaxString.MaxString("banana", "peach", " apple");
            Console.WriteLine("Maximum string is : " + max);
        }

        //TC 3.2

        public static void TC2String()
        {
            string max = UC3MaxString.MaxString("car", "train", "bus");
            Console.WriteLine("Maximum string is : " + max);
        }

        //TC 3.3

        public static void testCase3String()
        {
            string max = UC3MaxString.MaxString("dog", "cat", "horse");
            Console.WriteLine("Maximum string is : " + max);
        }
    }
}
