using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrcios_01_4_ADS
{
    class Ex05
    {
        public void ex05()
        {
            Console.WriteLine("Tabuada com Loop For");
            for (int i = 0; i < 10; i++)
            {
                int aux = i + 1;
                Console.WriteLine("5 + {0} = {1}", i, aux);
            }

            Console.WriteLine();
            Console.WriteLine("Tabuada com Loop While");

            int j = 0;
            while (j < 10)
            {
                int aux = j + 1;
                Console.WriteLine("5 + {0} = {1}", j, aux);
                j++;
            }

            Console.ReadKey();
        }
    }
}
