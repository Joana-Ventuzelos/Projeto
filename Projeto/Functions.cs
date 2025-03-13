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
                Console.Write("Qual o código de item? ");
                string input = Console.ReadLine();
                check = int.TryParse(input, out codigoProduto);
                if (check != true)
                {
                    Console.WriteLine("Código de item inválido!");
                    Console.WriteLine("Digite outro código: ");
                }
            } while (!check);
            return codigoProduto;
        }







    }
}