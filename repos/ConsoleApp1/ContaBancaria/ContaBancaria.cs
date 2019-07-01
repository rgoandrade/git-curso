using System;
using System.Globalization;



namespace ContaBancaria {
    class ContaBancaria {

        /* Ordem sugerida
         Atributos privados
         Propriedades autoimplementadas
         Construtores
         Propriedades customizadas
         Outros métodos da classe
        */
        
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria ( int numero, string titular, double quantia) : this(numero, titular) {        
            Saldo = quantia;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.00;
        }

        public override string ToString() {
            return
            "Conta: "
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
