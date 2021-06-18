using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaDev
{
    public class Pessoa
    {
        static int Main(string[] args)
        {
            var vetor = new int[10];
            int i, posicao;

            for (i = 0; i < vetor.GetLength(0); i++)
            {
                Console.Write($"Digite o {i}° número: ");
                vetor[i] = int.Parse(Console.ReadLine());
                do
                {
                    if (vetor[i] <= 0)
                    {
                        Console.Write($"Digite o {i}° número: ");
                        vetor[i] = int.Parse(Console.ReadLine());
                    }
                } while (vetor[i] <= 0);

            }

            for (i = 0; i < vetor.GetLength(0); i++)
            {
                if (vetor[i] % 2 == 1)
                {
                    posicao = i;
                    Console.WriteLine($"Número {vetor[i]} é primo e está na posição {posicao}");
                }
            }
            Console.ReadKey();
            return 0;
        }
    }
}
