using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrcios_01_4_ADS
{
    class Ex03
    {
        public void ex03()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("{0} é divisivel por 4!", i);
                }
            }
            Console.ReadKey();
        }
    }
}
