using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Day13
{
    class UC5MaxUsingGenerics<T> where T : IComparable
    {
        public T[] value;
        public UC5MaxUsingGenerics(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sortedValue = Sort(values);
            return sortedValue[sortedValue.Length - 1];
        }

        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
