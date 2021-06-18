using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProvaDev
{
    class TesteMock
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;


            Console.Write("Digiete o valor de A:");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digiete o valor de B:");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digiete o valor de C:");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Ovalor de Delta é: " + delta);

            x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            x2 = (-b + Math.Sqrt(delta)) / 2 * a;

            if (delta > 0)
            {
                Console.WriteLine("Retorna maior valor das raízes. x1:" + x1 + "X2:" + x2);
            }
            else if (delta == 0)
            {
                Console.WriteLine("Raizes iguais, retorne o valor zero. x1:" + x1 + "X2:" + x2);
            }
            else
            {
                Console.WriteLine("Retorna menor que zero!");
            }

            Console.ReadKey();
        }
    }

}


