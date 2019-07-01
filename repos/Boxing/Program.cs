using System;

namespace Boxing {
    class Program {
        static void Main(string[] args) {

            //BOXING
            int x = 20;

            Object obj = x;
            Console.WriteLine(obj);

            //UNBOXING
            int y = (int) obj;
            Console.WriteLine(y);
        }
    }
}
