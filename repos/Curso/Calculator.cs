using System;


namespace Curso {
    class Calculator {

        public static int Sum(int[] numeros) {

            int sum = 0;
            for (int i = 0; i < numeros.Length; i++) {
                sum += numeros[i];
            }
            return sum;
        }
    }
}
