using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度n:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("请输入" + n + "个数组元素：");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int max = array[0];
            int min = array[0];
            int num = 0;
            foreach (int a in array)
            {
                num = num + a;
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }

            }
            double average = (double)num / (array.Length);
            Console.WriteLine("数组的最大值为：" + max);
            Console.WriteLine("数组的最小值为：" + min);
            Console.WriteLine("所有数组元素的和为：" + num);
            Console.WriteLine("数组的平均值为：" + average);
        }
    }
}
