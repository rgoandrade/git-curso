using System;
using System.Globalization;

namespace ImpostoRenda {
    class Program {
        static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000.00) {

                imposto = 0.0;

            }




            Console.WriteLine("Hello World!");
        }
    }
}
