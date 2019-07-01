using System;
using System.Globalization;

namespace Curso4
{
    class Curso4
    {
        static void Main(string[] args)
        {
            //float x = 4.5f;
            //double y = x;

            int a = 5;
            int b = 2;

            double resultado = (double) a / b;

            //Console.WriteLine(resultado);


            Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
