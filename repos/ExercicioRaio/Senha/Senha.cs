using System;

namespace Senha {
    class Senha {
        static void Main(string[] args) {
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

        }
    }
}
