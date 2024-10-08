using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B3.Avaliacao.WebApi.Application
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
    }
}