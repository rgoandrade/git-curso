using System;
using System.Globalization;

namespace Curso11
{
    class Curso11
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("ENTRE COM O VALOR DO RAIO");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * r * r;

            Console.WriteLine("A= " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
