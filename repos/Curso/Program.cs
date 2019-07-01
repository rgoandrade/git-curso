using System;

namespace Curso {
    class Program {
        static void Main(string[] args) {

            int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });

            //int result = Calculator.Sum(10, 20, 30, 40, 50, 60);
            Console.WriteLine(result);
        }
    }
}
