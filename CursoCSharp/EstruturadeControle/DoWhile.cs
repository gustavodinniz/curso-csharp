﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturadeControle {
    class DoWhile {
        public static void Executar() {
            string entrada;

            do {
                Console.WriteLine("Digite seu nome:");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem vindo {0}", entrada);
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
