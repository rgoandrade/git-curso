using System;
using System.Globalization;

namespace Funcionario {
    class Funcionario {
        static void Main(string[] args) {

            Console.WriteLine("Número do Funcionário:");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de horas trabalhadas:");
            int horaTrabalhada = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor Hora:");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horaTrabalhada * valorHora;

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
