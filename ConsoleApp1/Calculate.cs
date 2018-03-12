using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculate
    {
        public static int GetSum(int ivalue)
        {
            int sum = 0;
            for (int i = 1; i <= ivalue; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
