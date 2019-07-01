using System;

namespace Curso15
{
    class Curso15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Então o número digito é PAR !");
            }
            else
            {
                Console.WriteLine("Então o número digito é ÍMPAR !");
            }

        }
    }
}
