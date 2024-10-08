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

        /// <summary>
        /// Se por ventura exista um acesso a camada de domain, e os valores informados não sejam correspontes a regra, será utilizado
        /// a tecnica de fast fail.
        /// </summary>
        /// <param name="valorMonetario">Valor monetario inserido pelo usuario.</param>
        /// <param name="meses">Meses inseridos pelo usuario.</param>
        private static void Validadores(decimal valorMonetario, int meses)
        {
            Validacoes.ValidarSeValorForMenor(valorMonetario, 0, "Valor não pode ser negativo.");
            Validacoes.ValidarSeValorForMenor(meses, 1, "Os meses devem ser maiores que 1.");

        }

        /// <summary>
        /// Obtem o valor monetario inserido pelo usuario, após a tratativa e validação no construtor Investimento().
        /// </summary>
        /// <returns>Retorna o valor monetario.</returns>
        public decimal ObtemValorMonetario()
        {
            return ValorMonetario;
        }

        /// <summary>
        /// Obtem os meses inserido pelo usuario, após a tratativa e validação no construtor Investimento().
        /// </summary>
        /// <returns>Retorna a quantidade de meses.</returns>
        public int ObtemMeses()
        {
            return Meses;
        }
    }
}
