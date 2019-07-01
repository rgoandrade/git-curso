using System;
using System.Globalization;

namespace LerTresValores {
    class Program {
        static void Main(string[] args) {

            double areaTrianguloRetangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo, pi = 3.14159;

            Console.WriteLine("Entre com os valores de A B C");
            string[] valores = Console.ReadLine().Split(' ');
            
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);           
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);           
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            areaTrianguloRetangulo = b * a / 2;
            areaCirculo = pi * Math.Pow(c, 2.0);
            areaTrapezio = (a + b) / 2.0 * c;
            areaQuadrado = Math.Pow(b, 2.0);
            areaRetangulo = a * b;

            Console.WriteLine("ÁREA DO TRIANGULO RETANGULO =" + areaTrianguloRetangulo.ToString("F2", CultureInfo.InvariantCulture ));
            Console.WriteLine("ÁREA DO DO CÍRCULO =" + areaCirculo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("ÁREA DO TRAPÉZIO =" + areaTrapezio.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("ÁREA DO QUADRADO =" + areaQuadrado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("ÁREA DO RETANGULO =" + areaRetangulo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
