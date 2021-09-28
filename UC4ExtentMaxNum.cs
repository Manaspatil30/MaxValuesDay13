using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Day13
{
    class UC4ExtentMaxNum
    {
        public static int MaxInt(int[] arr)
        {
            int maxI = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > maxI)
                    maxI = arr[i];
            return maxI;
        }

        public static double MaxFloat(double[] arr)
        {
            double maxF = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > maxF)
                    maxF = arr[i];
            return maxF;
        }

        public static string MaxString(List<string> arr)
        {
            arr.Sort();
            string maxS = arr[arr.Count - 1];
            return maxS;
        }
    }
}
