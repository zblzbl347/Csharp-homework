using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    public class Calculate
    {
        /// <summary>
        /// 获取用户输入的值
        /// </summary>
        /// <param name="type">计算类型</param>
        /// <param name="num1">第一个数字</param>
        /// <param name="num2">第二个数字</param>
        /// <returns></returns>
        public int GetResult(string type, int num1,int num2)
        {
            int sum = 0;
            if (type == "+")
            {
                sum = num1 + num2;
            }
            else if (type == "-")
            {
                sum = num1 - num2;
            }
            else if (type == "*")
            {
                sum = num1 * num2;
            }
            else if (type == "/")
            {
                sum = num1 / num2;
            }
            return sum;
        }
    }
}
