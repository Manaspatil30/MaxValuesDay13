using System;
using System.Collections.Generic;

namespace Generics_Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC 1 to find max int
            Console.WriteLine("Maximum values for integer");
            TC1Integer.TC1int();
            TC1Integer.TC2int();
            TC1Integer.TC3int();
            Console.WriteLine("--------------------------------------------");

            //UC 2 
            Console.WriteLine("Maximum values for floats");
            TC2Float.TC1Flt();
            TC2Float.TC2Flt();
            TC2Float.TC3Flt();
            Console.WriteLine("--------------------------------------------");

            //UC3
            Console.WriteLine("Maximum values for strings");
            TC3String.TC1String();
            TC3String.TC2String();
            TC3String.testCase3String();
            Console.WriteLine("--------------------------------------------");


            //Refactor 1 : For multiple inputs
            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("\nMaximum Values : ");
            
            //For Int
            int[] arrInt = { 150, 250, 350, 450, 550 };
            int MaxInt = UC4ExtentMaxNum.MaxInt(arrInt);
            Console.WriteLine(MaxInt);

            //For Float
            double[] arrFlt = { 12.5, 55.5, 25.6, 84.7, 41.1 };
            double MaxFlt = UC4ExtentMaxNum.MaxFloat(arrFlt);
            Console.WriteLine(MaxFlt);

            //For String
            List<string> arrStr = new List<string> { "Apple", "Mango", "Banana", "Pineapple", "Orange" };
            string MaxStr = UC4ExtentMaxNum.MaxString(arrStr);
            Console.WriteLine(MaxStr);


            //Refactor 2 : To create Generic class to take 3 variables of generic type
            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("Maximum Values : ");

            //For int
            int[] arrayInt = { 150, 250, 450, 550, 620 };
            UC5MaxUsingGenerics<int> genericInt = new UC5MaxUsingGenerics<int>(arrayInt);
            genericInt.PrintMaxValue();

            //For float
            double[] arrayFlt = { 4.5, 5.2, 8.6, 1.2, 7.3 };
            UC5MaxUsingGenerics<double> genericFlt = new UC5MaxUsingGenerics<double>(arrayFlt);
            genericFlt.PrintMaxValue();

            //For string
            string[] arrayStr = { "Apple", "Mango", "Banana", "Pineapple", "Orange" };
            UC5MaxUsingGenerics<string> genericStr = new UC5MaxUsingGenerics<string>(arrayStr);
            genericStr.PrintMaxValue();
            

        }
    }
}
