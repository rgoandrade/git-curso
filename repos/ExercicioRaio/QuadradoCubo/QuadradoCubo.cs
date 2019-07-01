using System;

namespace QuadradoCubo {
    class QuadradoCubo {
        static void Main(string[] args) {
            Console.Write("Informe um valor inteiro N....: ");
            int N = int.Parse(Console.ReadLine());

            int quadrado = 0, cubo = 0;


            for (int i = 1; i <= N; i++) {

                quadrado = i * i;
                cubo = i * i * i;

                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
    }
}
