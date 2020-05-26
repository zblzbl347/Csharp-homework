using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            int n = int.Parse(Console.ReadLine());
            Console.Write(n + "的素数因子是： " + n + "=");
            int i = n;
            for (int j = 2; j < i + 1; j++)
            {
                while (i % j == 0 && i != j)
                {
                    i = i / j;
                    Console.Write(j + "*");
                }
                if (i == j)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
