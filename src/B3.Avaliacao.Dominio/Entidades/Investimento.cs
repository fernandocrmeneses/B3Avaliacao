using B3.Avaliacao.Core.ObjetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3.Avaliacao.Dominio.Entidades
{
    public class Investimento
    {
        private decimal ValorMonetario { get; set; }
        private int Meses { get; set; }
        public Investimento(decimal valorMonetario, int meses)
        {
            Validadores(valorMonetario, meses);
            ValorMonetario = valorMonetario;
            Meses = meses;
        }

        private static void Validadores(decimal valorMonetario, int meses)
        {
            Validacoes.ValidarSeValorForMenor(valorMonetario, 0, "Valor não pode ser negativo");
            Validacoes.ValidarSeValorForMenor(meses, 1, "Os meses devem ser maiores que 1");

        }
    }
}
