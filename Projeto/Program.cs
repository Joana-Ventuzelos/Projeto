using System;
using Projeto;

namespace EmpreendimentoTuristico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExercicioAvaliacao());
            Console.WriteLine("Pressione qualquer tecla para sair...");

        }

        static string ExercicioAvaliacao()
        {
            string nome, apartamento;
            double custoApartamento = 0, diasEstadia, valorDesconto = 0, valorTotEst = 0;
            int codigoProduto;
            double aPagar, valorAcumulado = 0, quantidade;
            double taxaServico, subtotal, total;

            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("| Empreendimento Turístico - Check-Out |");
            Console.WriteLine("|--------------------------------------|");
            Console.Write("Nome do Cliente: ");
            nome = Console.ReadLine();

            Console.WriteLine("|---------------------|----------------|");
            Console.WriteLine("| Tipo de Apartamento | Preço          |");
            Console.WriteLine("|---------------------|----------------|");
            Console.WriteLine("|          A          | 150.00€        |");
            Console.WriteLine("|          B          | 75.00€         |");
            Console.WriteLine("|          C          | 100.00€        |");
            Console.WriteLine("|          D          | 150.00€        |");
            Console.WriteLine("|---------------------|----------------|");

            Console.Write("Qual o tipo de apartamento escolhido pelo cliente: ");
            apartamento = Console.ReadLine().ToUpper();

            while (apartamento != "A" && apartamento != "B" && apartamento != "C" && apartamento != "D")
            {
                Console.WriteLine("Opção inválida!");
                Console.Write("Digite outra opção: ");
                apartamento = Console.ReadLine().ToUpper();
            }

            switch (apartamento)
            {
                case "A":
                    custoApartamento = 150;
                    break;
                case "B":
                    custoApartamento = 75;
                    break;
                case "C":
                    custoApartamento = 100;
                    break;
                case "D":
                    custoApartamento = 150;
                    break;
            }

            Console.Write("Duração da estadia: ");
            diasEstadia = Convert.ToDouble(Console.ReadLine());

            while (diasEstadia < 0)
            {
                Console.WriteLine("Duração inválida!");
                Console.Write("Duração da estadia: ");
                diasEstadia = Convert.ToDouble(Console.ReadLine());
            }

            if (diasEstadia > 7 && diasEstadia <= 15)
            {
                Console.WriteLine($"Estadia completa de {diasEstadia} dias!");
                Console.WriteLine("Como recompensa terá um desconto de 5%");
                valorTotEst = custoApartamento * diasEstadia * 0.95;
                valorDesconto = custoApartamento * diasEstadia * 0.05;
            }
            else if (diasEstadia > 15)
            {
                Console.WriteLine($"Estadia completa de {diasEstadia} dias!");
                Console.WriteLine("Como recompensa terá um desconto de 10%");
                valorTotEst = custoApartamento * diasEstadia * 0.90;
                valorDesconto = custoApartamento * diasEstadia * 0.10;
            }
            else
            {
                Console.WriteLine($"Estadia completa de {diasEstadia} dias!");
                valorTotEst = custoApartamento * diasEstadia;
                valorDesconto = 0;
            }

            Console.WriteLine("|-----------------------------------|");

            Console.WriteLine("Artigos Consumidos");
            Console.WriteLine("(Pressione qualquer tecla após o código 106 para sair)");
            valorAcumulado = 0;

            do
            {
                Console.WriteLine("|-----------------|--------|--------|");
                Console.WriteLine("| Artigo          | Código | Preço  |");
                Console.WriteLine("|-----------------|--------|--------|");
                Console.WriteLine("| Café            | 100    | 1,00€  |");
                Console.WriteLine("| Chá             | 101    | 1,00€  |");
                Console.WriteLine("| Água            | 102    | 1,00€  |");
                Console.WriteLine("| Leite           | 103    | 1,20€  |");
                Console.WriteLine("| Iogurte         | 104    | 0,70€  |");
                Console.WriteLine("| Sumo            | 105    | 1,50€  |");
                Console.WriteLine("| SAIR            | 106    | ----   |");
                Console.WriteLine("|-----------------|--------|--------|");

                Console.Write("Qual o código de item? ");
                codigoProduto = Convert.ToInt32(Console.ReadLine());
                if (codigoProduto == 106) break;

                Console.Write("Qual a quantidade consumida? ");
                quantidade = Convert.ToDouble(Console.ReadLine());

                switch (codigoProduto)
                {
                    case 100:
                        Console.WriteLine("-> Adicionou Café <-");
                        aPagar = 1.00 * quantidade;
                        valorAcumulado += aPagar;
                        break;
                    case 101:
                        Console.WriteLine("-> Adicionou Chá <-");
                        aPagar = 1.00 * quantidade;
                        valorAcumulado += aPagar;
                        break;
                    case 102:
                        Console.WriteLine("-> Adicionou Água <-");
                        aPagar = 1.00 * quantidade;
                        valorAcumulado += aPagar;
                        break;
                    case 103:
                        Console.WriteLine("-> Adicionou Leite <-");
                        aPagar = 1.20 * quantidade;
                        valorAcumulado += aPagar;
                        break;
                    case 104:
                        Console.WriteLine("-> Adicionou Iogurte <-");
                        aPagar = 0.70 * quantidade;
                        valorAcumulado += aPagar;
                        break;
                    case 105:
                        Console.WriteLine("-> Adicionou Sumo <-");
                        aPagar = 1.50 * quantidade;
                        valorAcumulado += aPagar;
                        break;
                }
            } while (codigoProduto != 106);

            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("|-----------------------------------|");

            //subtotal =  valorTotEst + valorAcumulado;
            subtotal= Functions.Subtotal(valorTotEst,valorAcumulado);
            taxaServico = Functions.TaxaServico(subtotal,0.1);
            total = subtotal + taxaServico;

            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("|      Recibo      |                |");
            Console.WriteLine("|-----------------------------------|");

            Console.WriteLine($"| Nome Cliente: {nome} ");
            Console.WriteLine($"| Tipo do Apartamento: {apartamento} ");
            Console.WriteLine($"| Numero de dias da estadia: {diasEstadia} ");
            Console.WriteLine($"| Valor unitário da diaria: {custoApartamento}€");
            Console.WriteLine($"| Desconto Aplicado: {valorDesconto}€");
            Console.WriteLine($"| Valor total da diária: {valorTotEst}€");
            Console.WriteLine($"| Valor do Consumo Interno: {valorAcumulado}€");
            Console.WriteLine($"| Taxa de Serviço (10% do subtotal): {taxaServico}€");
            Console.WriteLine($"| Sub-total: {subtotal}€");
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine($"| Total Geral: {total}€");
            Console.WriteLine("|-----------------------------------|");

            return "Check-out completo: Obrigado pela sua estadia!";
        }
    }
}

