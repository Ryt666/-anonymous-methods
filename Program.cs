using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciRng a = new FibonacciRng(97,33);

            int cnt = 0;
            foreach (double var in a)
            {
                Console.WriteLine("{0:F1}",var);
                cnt++;
                if (cnt == 10)
                    break;
            }

            Console.Read();
        }
    }
}
