using System;
using System.Globalization;

namespace ExemploArray {
    class Arranjo {

        public int NumeroElemento { get; set; }
        public double avg { get; set; }


        public Arranjo (int n) {
            NumeroElemento = n;
        }

        public double Vetor () {

            double[] vect = new double[NumeroElemento];
            double soma = 0.0;

            for (int i = 0; i < NumeroElemento; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }            

            for (int i = 0; i < NumeroElemento; i++) {
                soma += vect[i];

            }

            avg = (soma / NumeroElemento);

            return avg;
        }

        public override string ToString() {
            return  "AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
