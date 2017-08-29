using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrcios_01_4_ADS
{
    class Ex06
    {
        public void ex06()
        {

            Console.Write("Digite um número para a tabuada: ");
            int num = int.Parse(Console.ReadLine());
            int x = 0;
            while (x != -1)
            {
                Console.WriteLine("\nTabuada Usando o While");
                int i = 0;
                while (i < 10)
                {
                    int aux = i + 1;
                    Console.WriteLine("{0} + {1} = {2}", num, i, aux);
                    i++;
                }


                Console.WriteLine("\nTabuada Usando o for");
                for (int j = 0; j < 10; j++)
                {
                    int aux = j + 1;
                    Console.WriteLine("{0} + {1} = {2}", num, j, aux);
                }
                

                Console.Write("Deseja continuar?\nDigite -1 para Sair ou qual outro valor para continuar? ");
                x = int.Parse(Console.ReadLine());
                Console.Write(x);
            }
        }
    }
}
