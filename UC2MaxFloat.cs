using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Day13
{
    class UC2MaxFloat
    {
        public static double MaxFloat(double first, double second, double third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}
