using System;
using System.Globalization;

namespace TabelaPreco {
    class TabelaPreco {
        static void Main(string[] args) {

            Console.WriteLine("Entre com o código e a quantidade");
            string[] vetorValoresEntrada = Console.ReadLine().Split(' ');

            int codigo = int.Parse(vetorValoresEntrada[0]);
            int quantidade = int.Parse(vetorValoresEntrada[1]);

            double resultado;

            if (codigo == 1) {
                resultado = quantidade * 4.00;
            }
            else if (codigo == 2) {
                resultado = quantidade * 4.50;
            }
            else if (codigo == 3) {
                resultado = quantidade * 5.00;
            }
            else if (codigo == 4) {
                resultado = quantidade * 2.00;
            }
            else  {
                resultado = quantidade * 1.50;
            }

            Console.WriteLine("O valor a pagar é " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
