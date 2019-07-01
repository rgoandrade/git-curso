using System;

namespace MostrarNumerosImparUsandoFor {
    class MostrarNumerosImparUsandoFor {
        static void Main(string[] args) {

            Console.Write("Qual o número que você vai digitar ?....: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X && X <= 1000; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
