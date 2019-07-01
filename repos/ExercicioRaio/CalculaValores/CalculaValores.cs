using System;

namespace CalculaValores {
    class CalculaValores {
        static void Main(string[] args) {
            Console.WriteLine("Entre com o valor de A = ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B = ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de C = ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de D = ");
            int D = int.Parse(Console.ReadLine());

            int diferenca = (A * B) - (C * D);

            Console.WriteLine(diferenca);
            
        }
    }
}
