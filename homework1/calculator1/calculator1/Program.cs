using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入要计算的类型：");
            string type = Console.ReadLine();

            Calculate calculate = new Calculate();
            int sum = calculate.GetResult(type, num1, num2);
            Console.WriteLine("计算结果为：{0}",sum);
            Console.ReadKey();
        }
    }
}
