using System;


namespace Triplicar {
    class Program {
        static void Main(string[] args) { 
            
            int a = 2000;
            Calculator.Triplicar(ref a);
            Console.WriteLine(a);           

        }
    }
}
