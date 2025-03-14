using System;
using System.IO;

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


        public static void Imprime_Recibo(
        string nome, 
        string apartamento, 
        double custoApartamento, 
        double diasEstadia, 
        double valorDesconto, 
        double valorTotEst, 
        double valorAcumulado, 
        double taxaServico, 
        double subtotal, 
        double total)
    {
        // Defina o caminho para o arquivo onde o recibo será salvo
        string caminhoArquivo = "recibo.txt";

        // Usando o StreamWriter para criar ou sobrescrever o arquivo
        using (StreamWriter writer = new StreamWriter(caminhoArquivo))
        {
            // Escrevendo as linhas no arquivo
            writer.WriteLine("|-----------------------------------|");
            writer.WriteLine("|              *RECIBO*             |");
            writer.WriteLine("|-----------------------------------|");

            writer.WriteLine($"| Nome Cliente: {nome} ");
            writer.WriteLine($"| Tipo do Apartamento: {apartamento} ");
            writer.WriteLine($"| Numero de dias da estadia: {diasEstadia} ");
            writer.WriteLine($"| Valor unitário da diária: {custoApartamento:F2}€");
            writer.WriteLine($"| Desconto Aplicado: {valorDesconto:F2}€");
            writer.WriteLine($"| Valor total da diária: {valorTotEst:F2}€");
            writer.WriteLine($"| Valor do Consumo Interno: {valorAcumulado:F2}€");
            writer.WriteLine($"| Taxa de Serviço (10% do subtotal): {taxaServico:F2}€");
            writer.WriteLine($"| Sub-total: {subtotal:F2}€");
            writer.WriteLine("|-----------------------------------|");
            writer.WriteLine($"| Total Geral: {total:F2}€             ");
            writer.WriteLine("|-----------------------------------|");
        }

        // Opcional: Exibe uma mensagem informando que o recibo foi salvo
        Console.WriteLine("Recibo salvo com sucesso em 'recibo.txt'.");
    }


    }
}