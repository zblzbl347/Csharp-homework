using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = i;
            }
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    int j, temp;
                    temp = array[i];
                    for (j = 2 * temp; j < array.Length; j = j + temp)
                    {
                        array[j] = 0;
                    }
                }
            }
            foreach(int i in array)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
