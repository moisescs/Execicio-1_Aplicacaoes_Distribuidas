using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrcios_01_4_ADS
{
    class Ex01
    {
        public void ex01()
        {
            for (int i = 1; i < 100; i++)
            {
                int a = i + 1;
                int b = i + a;

                Console.WriteLine("A Soma de: {0} + {1} + {2}", i, a, b);

            }
            Console.ReadKey();
        }
    }
}
