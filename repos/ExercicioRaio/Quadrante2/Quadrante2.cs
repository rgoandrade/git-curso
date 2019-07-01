using System;

namespace Quadrante2 {
    class Quadrante2 {
        static void Main(string[] args) {
            Console.Write("Entre com as coordenadas de X e X");
            string[] coordenadas = Console.ReadLine().Split(' ');
            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0) {

                if (x > 0.0 && y > 0.0) {
                    Console.WriteLine("Q1");
                }
                else if (x < 0.0 && y > 0.0) {
                    Console.WriteLine("Q2");
                }
                else if (x < 0.0 && y < 0.0) {
                    Console.WriteLine("Q3");
                }
                else {
                    Console.WriteLine("Q4");
                }

                Console.Write("Entre com as coordenadas de X e Y");
                string[] coordenadas1 = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas1[0]);
                y = int.Parse(coordenadas1[1]);
            }
        }
    }
}
