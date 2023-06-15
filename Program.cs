using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor;
            int opcao;

            Console.WriteLine("Deposite o Valor:");
            valor = float.Parse(Console.ReadLine());

            if (valor < 1)
            {
                Console.WriteLine("Valor Insuficiente...");
                Main(null);
                return;

            }

            Console.WriteLine("Selecione um produto: \n\n");
            Console.WriteLine("1 Café-Expresso - R$ 3,00");
            Console.WriteLine("2 Capuccino - R$ 4,50");
            Console.WriteLine("3 Mocaccino - R$ 6,00");
            Console.WriteLine("4 Água quente - R$ 1,00");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1 || opcao == 3 || opcao == 4.50f || opcao == 6.00f)
            {
                Console.WriteLine("Parece que o valor inserido não corresponde com o produto...");
                Main(null);
                return;
            }

            Console.WriteLine("o Seu Pedido Está Pronto...");
            Console.WriteLine("Obrigado, Volte Sempre :) ");
            Main(null);
            return;

            Console.ReadKey();

        
        }

    }
}
