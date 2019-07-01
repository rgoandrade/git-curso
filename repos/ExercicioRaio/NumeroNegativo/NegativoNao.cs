using System;

namespace NumeroNegativo {
    class NumeroNegativo {
        static void Main(string[] args) {

            Console.WriteLine("ENTRE COM UM NÚMERO");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }

    }
}