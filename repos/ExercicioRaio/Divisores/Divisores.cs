using System;

namespace Divisores {
    class Divisores {
        static void Main(string[] args) {

            Console.Write("Informe um valor inteiro N....: ");
            int N = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= N; i++) {

                if (N % i == 0) {

                    Console.WriteLine(i);
                }
            }
        }
    }
}
