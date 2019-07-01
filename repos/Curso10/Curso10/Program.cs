using System;

namespace Curso10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O PRIMEIRO NÚMERO");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE O SEGUNDO NÚMERO");
            int n2 = int.Parse(Console.ReadLine());

            int somaNumeros = n1 + n2;

            Console.WriteLine("SOMA = " + somaNumeros);
        }
    }
}
