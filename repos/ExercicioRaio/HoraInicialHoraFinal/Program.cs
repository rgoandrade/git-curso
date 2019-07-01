using System;

namespace HoraInicialHoraFinal {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com valores");
            string[] horaInicialFinal = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(horaInicialFinal[0]);
            int horaFinal = int.Parse(horaInicialFinal[1]);

            int duracao;

            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O valor da duração é " + duracao);
        }
    }
}
