using System;

namespace NullAble01 {
    class Program {
        static void Main(string[] args) {

            double? x = null;
            double? y = 10.0;

            double a = x ?? 5;      //operador de coalecência nula.
            double b = y ?? 1000;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
