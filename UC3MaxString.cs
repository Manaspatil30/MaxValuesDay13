using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Day13
{
    class UC3MaxString
    {
        public static string MaxString(string firstS, string secondS, string thirdS)
        {
            if (firstS.CompareTo(secondS) > 0 && firstS.CompareTo(thirdS) > 0 ||
                firstS.CompareTo(secondS) >= 0 && firstS.CompareTo(thirdS) > 0 ||
                firstS.CompareTo(secondS) > 0 && firstS.CompareTo(thirdS) >= 0)
            {
                return firstS;
            }

            if (secondS.CompareTo(firstS) > 0 && secondS.CompareTo(thirdS) > 0 ||
                secondS.CompareTo(firstS) >= 0 && secondS.CompareTo(thirdS) > 0 ||
                secondS.CompareTo(firstS) > 0 && secondS.CompareTo(thirdS) >= 0)
            {
                return secondS;
            }

            if (thirdS.CompareTo(firstS) > 0 && thirdS.CompareTo(secondS) > 0 ||
                thirdS.CompareTo(firstS) >= 0 && thirdS.CompareTo(secondS) > 0 ||
                thirdS.CompareTo(firstS) > 0 && thirdS.CompareTo(secondS) >= 0)
            {
                return thirdS;
            }

            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}
