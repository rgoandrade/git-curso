using System;


namespace Triplicar {
    class Program {
        static void Main(string[] args) { 
            
            int a = 20;
            int triple;
            Calculator.Triplicar(a, out triple);
            Console.WriteLine(triple);           

        }
    }
}
