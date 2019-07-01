using System;

namespace MaiorDeles {
    class MaiorDeles {
        static void Main(string[] args) {

            Console.WriteLine("Entre com três valores");
            string[] valores = Console.ReadLine().Split(' ');
            int n1 = int.Parse(valores[0]);
            int n2 = int.Parse(valores[1]);
            int n3 = int.Parse(valores[2]);


            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior deles é = " + resultado);
        }
        static int Maior(int a, int b, int c) {
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
        }
    }
}
