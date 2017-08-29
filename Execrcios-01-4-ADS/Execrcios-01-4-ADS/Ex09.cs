using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrcios_01_4_ADS
{
    class Ex09
    {
        public void ex09()
        {
            Console.WriteLine("Digite a Qtd de Alunos");
            int qtd = int.Parse(Console.ReadLine());
            String[] alunos = new string[qtd];
            double[] notas = new double[qtd];
            int i = 0;
            
            while (i < qtd)
            {
                Console.Write("Digite nome do {0}º aluno: ", (i + 1));
                alunos[i] = Console.ReadLine();
                Console.Write("Digite a nota do {0}º aluno: ", (i + 1));
                notas[i] = Double.Parse(Console.ReadLine());
                i++;
            }

            double media = 0;
            double soma = 0;

            foreach (var nota in notas)
            {
                soma += nota; 
            }

            media = soma / qtd;
            Console.WriteLine("Media da Turma: " + media);
            Console.WriteLine("Alunos com Nota Maior que a Média da sala:");

            for (int j = 0; j < qtd; j++)
            {
                if (notas[j] > media)
                {
                    Console.WriteLine(alunos[j] + "- " + notas[j]);
                }
            }
            Console.ReadKey();
        }
    }
}
