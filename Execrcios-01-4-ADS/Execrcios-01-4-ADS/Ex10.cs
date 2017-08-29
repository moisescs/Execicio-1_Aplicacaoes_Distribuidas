using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrcios_01_4_ADS
{
    class Ex10
    {
        public void ex10()
        {
            List<Double> salarios = new List<Double>();
            int i = 0;
            double entrada = 0;

            while (entrada != -1)
            {
                Console.Write("Digite o {0}º salário ou -1 para sair: ", (i + 1));
                Console.WriteLine("");
                entrada = Double.Parse(Console.ReadLine());
                if (entrada != -1)
                {               
                    salarios.Add(entrada);
                    i++;
                }                
            }

            Console.WriteLine("Digite a porcentagem do Reajuste: ");
            double reajuste = double.Parse(Console.ReadLine());
            Console.WriteLine("***********************************************");
            Console.WriteLine("Salarios Reajustados: ");

            foreach (var item in salarios)
            {
                double salarioreajustado = item+ (item * (reajuste / 100));
                Console.WriteLine(salarioreajustado);
            }
            Console.ReadKey();
        }
    }
}
