using System;

namespace ExemploArray {
    class Program {
        static void Main(string[] args) {

            Arranjo a;

            Console.Write("Entre com a quantidade de elementos do meu vetor: ");
            int n = int.Parse(Console.ReadLine());

            a = new Arranjo(n);            

            a.Vetor();
            
            Console.WriteLine(a);
        }
    }
}
