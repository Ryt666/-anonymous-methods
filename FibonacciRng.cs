using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_2
{
    class FibonacciRng : IEnumerable<double>
    {
        private uint lagA { get; set; }
        private uint lagB { get; set; }

        public FibonacciRng(uint param1, uint param2)
        {
            lagA = param1;
            lagB = param2;
        }

        public IEnumerator<double> GetEnumerator()
        {
            uint _max = Math.Max(lagA, lagB);
            int indA = (int)(_max - lagA) + 1;
            int indB = (int)(_max - lagB) + 1;

            Random r = new Random(); 
            List<double> list = new List<double>();
            for (int i = 0; i <= _max; i++)
                list.Add(r.NextDouble()); 

            double ka = 0;
            double kb = 0;
            double res = 0;
            while (true)
            {
                ka = list[indA];
                kb = list[indB];

                if (ka < kb)
                    res = ka - kb + 1;
                else
                    res = ka - kb;

                list.RemoveAt(0);
                list.Add(res);

                
                yield return res;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
