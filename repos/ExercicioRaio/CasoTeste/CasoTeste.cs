using System;
using System.Globalization;

namespace CasoTeste {
    class CasoTeste {
        static void Main(string[] args) {

            Console.Write("Informe um valor inteiro N....: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {

                Console.Write("Forneça um valor ...: ");
                string[] X = Console.ReadLine().Split(' ');
                double v1 = double.Parse(X[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(X[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(X[2], CultureInfo.InvariantCulture);

                double mediaPonderada = (v1 * 2 + v2 * 3 + v3 * 5) / 10;

                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
