using System;

namespace Fatorial {
    class Fatorial {
        static void Main(string[] args) {
            Console.Write("Informe um valor inteiro N....: ");
            int N = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= N; i++) {

                fatorial = fatorial * i;
                Console.WriteLine(fatorial);
            }

            Console.WriteLine(fatorial);
        }
    }
}
