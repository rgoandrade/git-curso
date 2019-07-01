using System;

namespace LerQuantidadeN {
    class LerQuantidadeN {
        static void Main(string[] args) {

            Console.Write("Informe um valor inteiro N....: ");
            int N = int.Parse(Console.ReadLine());

            int inDentroIntervalo = 0, outForaIntervalo = 0;

            for (int i = 1; i <= N; i++) {

                Console.Write("Forneça um valor ...: ");
                int X = int.Parse(Console.ReadLine());

                if (10 <= X && X <= 20) {
                    inDentroIntervalo++;
                }
                else {
                    outForaIntervalo++;
                }
            }
            Console.WriteLine(inDentroIntervalo +" in");
            Console.WriteLine(outForaIntervalo + " out");
        }
    }
}
