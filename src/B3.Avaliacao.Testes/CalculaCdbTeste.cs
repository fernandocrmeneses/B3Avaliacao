using B3.Avaliacao.WebApi.Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace B3.Avaliacao.Testes
{
    [TestClass]
    public class CalculaCdbTeste
    {
        CalculoInvestimentoCdb _calcula;
        [TestInitialize]
        public void Setup()
        {
            _calcula = new CalculoInvestimentoCdb();
           
        }

        [TestMethod]
        public void CalculaValorLiquidoCdb()
        {
            var meses = 12;
            var valor = 2345;
            _calcula.ConfiguraValores(meses, valor);
            var resultado = _calcula.CalculaValorLiquidoCdb();
            Assert.AreNotEqual(0, resultado); 
        }

        [TestMethod]
        public void CalculaValorBrutoCdb()
        {
            var meses = 12;
            var valor = 1000;
            _calcula.ConfiguraValores(meses, valor);
            var resultado = _calcula.CalculaValorBrutoCdb();
            Assert.AreNotEqual(0, resultado);
        }
    }
}
