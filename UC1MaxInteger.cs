using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Day13
{
    class UC1MaxInteger
    {
        public static int MaxInt(int first, int second, int third)
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
            throw new Exception("first,second and third Numbers are same");
        }
    }
}
