using System;
using System.Globalization;

namespace AreaCiruclo
{
    class AreaCiruclo
    {
        static void Main(string[] args)
        {
            double area, pi = 3.14159;
            Console.WriteLine("Entre com o valor do RAIO: ");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //area = pi * r * r;

            area = pi * Math.Pow(r, 2.0);
            Console.WriteLine("O resultado da área do cículo será:" + area.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
