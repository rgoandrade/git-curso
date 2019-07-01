using System;

namespace TipoReferenciaTipoValor {
    class Program {
        static void Main(string[] args) {

            Point p;

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();
            p.X = 400;
            p.Y = 500;

            Console.WriteLine(p);
        }
    }
}
