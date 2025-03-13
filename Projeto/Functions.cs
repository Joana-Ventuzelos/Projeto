using System;

namespace Projeto
{
    public class Functions
    {
        // Torne os métodos públicos
        public static double Subtotal(double valorTotEst, double valorAcumulado)
        {
            return valorTotEst + valorAcumulado;
        }

        public static double TaxaServico(double subtotal, double taxa)
        {
            return subtotal * taxa;
        }

        public static int TryParse1()
        {
         bool check;
         int codigoProduto;
            do
            {
                Console.Write("Digite o código do artigo?\t");
                string input = Console.ReadLine();
                check = int.TryParse(input, out codigoProduto);
                if (check != true)
                {
                    Console.WriteLine("Código de artigo inválido! \n");
                }
            } while (!check);
            return codigoProduto;
        }

        public static double TryParse2()
        {
         bool check;
         double quantidade;
            do
            {
                Console.Write("Qual é a quantidade consumida?\t");
                string input = Console.ReadLine();
                check = double.TryParse(input, out quantidade);
                if (check != true)
                {
                    Console.WriteLine("Quantidade inválida! \n");
                }
            } while (!check);
            return quantidade;
        }

        public static double TryParseEstadia()
        {
            bool check;
            double diasEstadia;
            do
            {
                Console.WriteLine("\nDigite a duração da Estadia:\t");
                string input = Console.ReadLine();
                check = double.TryParse(input, out diasEstadia);
                if (check != true)
                {
                    Console.WriteLine("Duração Inválida! \n");
                }
            } while (!check);

            return diasEstadia;
        }
    }
}