using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrcios_01_4_ADS
{
    class Ex04
    {
        public void ex04()
        {
            Double s = 0;
            Double x = 4;
            String operador = "+";
            int i = 1;

            while (i <= 20)
            {

                if (operador == "-")
                {
                    s -= x / i;
                    operador = "+";
                }
                else
                {
                    s += x / i;
                    operador = "-";
                }

                Console.WriteLine(s);

                i++;
            }
        }
    }
}
