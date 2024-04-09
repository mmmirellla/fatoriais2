using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class CalculoAposentadoria
    {
        public static void Aposentadoria(int idade)
        {
            int o;
            Console.WriteLine("\nInforme seu gênero:\n0) Homem\n1) Mulher");
            while (!int.TryParse(Console.ReadLine(), out o))
            {
                Console.WriteLine("Precisa ser um número! ");
            }
            int idadeAposentadoriaM = 62;
            int idadeAposentadoriaH = 65;

            if (o == 1)
            {
                if (idade < idadeAposentadoriaM) 
                {
                    Console.WriteLine($"Você não está apta para aposentar, faltam {idadeAposentadoriaM - idade} anos!");
                }
                else
                {
                    Console.WriteLine("Você já está apta para aposentar!");
                }

            }
            if (o == 0)
            {
                if (idade < idadeAposentadoriaH)
                {
                    Console.WriteLine($"Você não está apto para aposentar, faltam {idadeAposentadoriaH - idade} anos!");
                }
                else
                {
                    Console.WriteLine("Você já está apto para aposentar!");
                }

            }
        }
    }
}