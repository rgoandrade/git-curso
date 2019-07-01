using System;
using System.Globalization;

namespace ExemploArray {
    class Arranjo {

        public int NumeroElemento { get; set; }
        public double avg { get; set; }


        public Arranjo (int n) {
            NumeroElemento = n;
        }

        public double Vetor (int n) {

            double[] vect = new double[n];
            double soma = 0.0;

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }            

            for (int i = 0; i < n; i++) {
                soma += vect[i];

            }

            avg = (soma / n);

            return avg;
        }

        public override string ToString() {
            return  "AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
