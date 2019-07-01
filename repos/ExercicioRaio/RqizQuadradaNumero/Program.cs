using System;

namespace RqizQuadradaNumero {
    class RqizQuadradaNumero {
        static void Main(string[] args) {

            Console.Write("Digite uma senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {

                Console.WriteLine("Senha Inválida !");

                Console.Write("Digite uma senha: ");
                senha = int.Parse(Console.ReadLine());                
            }
            Console.WriteLine("Acesso Permitido !");
        }
    }
}
