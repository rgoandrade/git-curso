using System;

namespace PreferenciaCombustivel {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o Tipo de COMBUSTÍVEL......: ");
            int codigo = int.Parse(Console.ReadLine());

            int alcool = 0, gasolina = 0, diesel = 0;

            while (codigo != 4) {

                if (codigo == 1) {
                    alcool++;
                }
                else if (codigo == 2) {
                    gasolina++;
                }
                else if (codigo == 3) {
                    diesel++;
                }
                else {
                    Console.WriteLine("NÚMERO DIGITADO FORA DA FAIXA ! ... DIGITE NOVAMENTE !!!");
                }

                Console.Write("Entre com o Tipo de COMBUSTÍVEL......: ");
                codigo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO......: ");
            Console.WriteLine("ÁLCOOL..............: " + alcool);
            Console.WriteLine("GASOLINA............: " + gasolina);
            Console.WriteLine("DIESEL..............: " + diesel);
        }
    }
}