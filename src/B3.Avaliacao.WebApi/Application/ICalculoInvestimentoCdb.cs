using B3.Avaliacao.Dominio.Entidades;

namespace B3.Avaliacao.WebApi.Application
{
    public interface ICalculoInvestimentoCdb
    {
        decimal CalculaValorBrutoCdb();
        decimal CalculaValorLiquidoCdb();
    }
}
