using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrcios_01_4_ADS
{
    class Ex02
    {
        public void ex02()
        {
            for (int i = 1; i < 200; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("{0} é Multiplo de 7", i);                    
                }
            }
            Console.ReadKey();
        }
    }
}
