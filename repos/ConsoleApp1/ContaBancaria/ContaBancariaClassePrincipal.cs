using System;
using System.Globalization;


namespace ContaBancaria {
    class ContaBancariaClassePrincipal {
        static void Main(string[] args) {

            double quantia;
            char temDepositoInicial;

            ContaBancaria c;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            temDepositoInicial = char.Parse(Console.ReadLine());

            if (temDepositoInicial == 's' || temDepositoInicial == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(numero, titular, quantia);
            }
            else {
                c = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da Conta: " + c);

            Console.Write("Entre um valor para depósito: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: " + c);

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: " + c);
        }
    }
}