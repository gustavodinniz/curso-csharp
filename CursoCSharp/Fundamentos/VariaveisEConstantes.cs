using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("Área da Circunferência = " + area);

            // Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade = " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols = " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Slário = " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor int = " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira = " + populacaoBrasileira);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preco do Computador = " + precoComputador);
        }
    }
}
