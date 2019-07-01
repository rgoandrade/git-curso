using System;
using System.Globalization;

namespace DivisaoNumeros {
    class DivisaoNumeros {
        static void Main(string[] args) {
            Console.Write("Informe um valor inteiro N....: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {

                Console.Write("Forneça um valor ...: ");
                string[] X = Console.ReadLine().Split(' ');
                double v1 = double.Parse(X[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(X[1], CultureInfo.InvariantCulture);
                
                if (v2 == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double divisao = v1 / v2;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }                
            }
        }
    }
}
