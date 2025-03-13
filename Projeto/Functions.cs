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
    }
}