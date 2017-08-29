using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrcios_01_4_ADS
{
    class Ex08
    {
        public void ex08()
        {
            Console.Write("Informe a qtd de notas: ");
            int qtd = int.Parse(Console.ReadLine());

            double[] notas = new double[qtd];
            double media = 0;
            double soma = 0;
            String maior = "";
            String menor = "";
            
            int i = 0;
            while (i < notas.Length)
            {
                Console.Write("Digite uma nota: ");
                notas[i] = double.Parse(Console.ReadLine());   
                soma += notas[i];
                i++;
             }

            Console.WriteLine("Soma: " + soma);
            media = soma / qtd;
            Console.WriteLine("Media: " + media);

            foreach (int nota in notas)
            {
                if (nota > media)
                {
                    maior += nota +", ";
                }
                else if(nota < media)
                {
                    menor += nota + ", "; 
                }
            }

            Console.WriteLine("Notas Maiores que Média: " + maior);
            Console.WriteLine("Notas Menores que Média: " + menor);
            Console.ReadKey();
        }
    }
}
