using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execrcios_01_4_ADS
{
    class Ex07
    {
        public void ex07()
        {
            Compras[] compras = new Compras[25];
            Double Total = 0;
            Double TotalVista = 0;
            Double TotalPrazo = 0;


            int i = 0;
            while (i < compras.Length)
            {

                Compras c = new Compras();

                c.valor = i * 2.5 + i + 3.5;//Gera Número Qualquer para montar a lista

                if (i % 2 == 0)
                {
                    c.tipo = "P";
                }
                else
                {
                    c.tipo = "V";
                }

                compras[i] = c;
                /*
                Console.Write(c.tipo + i);
                Console.Write(c.tipo + " - ");
                Console.WriteLine(c.valor);
                */

                i++;
            }

            i = 0;
            while (i < compras.Length)
            {

                Total += compras[i].valor;

                if (compras[i].tipo == "p")
                {
                    TotalPrazo = compras[i].valor / 3;
                }
                else
                {
                    TotalVista = compras[i].valor;
                }

            }

            Console.WriteLine(Total);
            Console.WriteLine(TotalPrazo);
            Console.WriteLine(TotalVista);
        }  
    }

    public class Compras
    {
        public String tipo;
        public Double valor;
    }
}
