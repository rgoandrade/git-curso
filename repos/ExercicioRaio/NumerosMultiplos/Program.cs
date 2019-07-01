using System;

namespace NumerosMultiplos {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com valores");
            string[] n1 = Console.ReadLine().Split(' ');

            int A = int.Parse(n1[0]);
            int B = int.Parse(n1[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("SÃO MÚLTIPLUS");
            }
            else {
                Console.WriteLine("NÃO SÃO MÚLTIPLUS");
            }
        }
    }
}
