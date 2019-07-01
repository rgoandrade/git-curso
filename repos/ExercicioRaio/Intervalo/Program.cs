using System;
using System.Globalization;

namespace Intervalo {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com num numero qualquer");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0 && valor <= 25) {
                Console.WriteLine("O valor informado pertence ao intervalo [0,25]");
            }
            else if (valor >= 25.01 && valor <= 50) {
                Console.WriteLine("O valor informado pertence ao intervalo [25,50]");
            }
            else if (valor >= 50.01 && valor <= 75) {
                Console.WriteLine("O valor informado pertence ao intervalo [50,75]");
            }
            else if (valor >= 75.01 && valor <= 100) {
                Console.WriteLine("O valor informado pertence ao intervalo [75,100]");
            }
            else
                Console.WriteLine("Fora de intervalo ");
        }
    }
}