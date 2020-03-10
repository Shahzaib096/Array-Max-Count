using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Max_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int Size = 5;
            int[] myArray = new int[5] { 1, 2, 3, 4, 4 };
            Array.Sort(myArray);
            int Count = 0;
            for (int i = 0; i < Size; i++)
            {
                if (myArray[i] == myArray[Size - 1])
                {
                    Count++;
                }
            }
            Console.WriteLine("Array Max Values Count is :"+Count);
            Console.Read();
        }
    }
}
