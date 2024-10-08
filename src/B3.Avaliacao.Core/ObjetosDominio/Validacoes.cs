using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3.Avaliacao.Core.ObjetosDominio
{
    public static class Validacoes
    {
        public static void ValidarSeValorForMenor(decimal valor, decimal valorMinimo, string mensagem)
        {
            if (valor < valorMinimo)
            {
                throw new DominioException(mensagem);
            }
        }
    }
}
