using B3.Avaliacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3.Avaliacao.Dominio.Servicos
{
    public class CalculaCdb
    {
        public const int TB = 108;
        public const float CDI = 0.9f;
        private decimal ValorFinal { get; set; }
        private decimal ValorInicial { get; set; }

        public CalculaCdb(decimal valorInicial, decimal valorFinal)
        {
            ValorFinal = valorFinal;
            ValorInicial = valorInicial;
        }

        public void CalculaRendimento()
        {
        }

        public decimal CalculateGrossValue(Investment investment)
        {
            decimal grossValue = investment.InitialValue;

            for (int i = 0; i < investment.Months; i++)
            {
                grossValue *= 1 + (CDI * TB);
            }
            return grossValue;
        }

        public decimal CalculateNetValue(Investment investment)
        {
            var grossValue = CalculateGrossValue(investment);
            var taxRate = GetTaxRate(investment.Months);
            var netValue = grossValue - ((grossValue - investment.InitialValue) * taxRate);

            return netValue;
        }

        private decimal GetTaxRate(int months)
        {
            if (months <= 6) return 0.225m;
            if (months <= 12) return 0.20m;
            if (months <= 24) return 0.175m;
            return 0.15m;
        }

        //TODO: Fazer os todos os calculos na camada de dominio e depois apenas chamar esses calculos na camada de application.
    }
}
