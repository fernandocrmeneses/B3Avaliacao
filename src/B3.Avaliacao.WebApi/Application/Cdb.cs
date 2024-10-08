using B3.Avaliacao.Dominio.Entidades;

namespace B3.Avaliacao.WebApi.Application
{
    public class Cdb : ICalculoInvestimentoCdb
    {
        public const decimal TB = 1.08m;
        public const decimal CDI = 0.009m;
        private decimal ValorBruto { get; set; }
        private decimal ValorInicial { get; set; }
        private int Meses { get; set; }
        private Investimento investimento { get; set; }

        public Cdb(decimal valorInicial, int meses)
        {
            investimento = new Investimento(valorInicial, meses);
        }

        public decimal CalculaValorBrutoCdb()
        {
            ValorInicial = investimento.ObtemValorMonetario();
            Meses = investimento.ObtemMeses();

            for (int i = 0; i < Meses; i++)
            {
                ValorBruto += ValorInicial * (1 + (CDI * TB) / 100);
            }

            return ValorBruto;
        }

        public decimal CalculaValorLiquidoCdb()
        {
            ValorBruto = CalculaValorBrutoCdb();
            Meses = investimento.ObtemMeses();
            ValorInicial = investimento.ObtemValorMonetario();

            var alicotaIR = ObtemTabelaImposto(Meses);
            var valorLiquido = ValorBruto - ((ValorBruto - ValorInicial) * alicotaIR);

            return valorLiquido;
        }

        private static decimal ObtemTabelaImposto(int meses)
        {
            if (meses <= 6) return 0.225m;
            if (meses <= 12) return 0.20m;
            if (meses <= 24) return 0.175m;
            return 0.15m;
        }
    }
}