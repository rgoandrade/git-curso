﻿using System;
using System.Globalization;

namespace Cruso55 {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto ( "TV", 500.00, 20 );

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);           
        }
    }
}
