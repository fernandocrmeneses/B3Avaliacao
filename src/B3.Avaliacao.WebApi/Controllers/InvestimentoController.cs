using B3.Avaliacao.WebApi.Application;
using B3.Avaliacao.WebApi.Models;
using System.Web.Http;
using System.Web.Http.Cors;

namespace B3.Avaliacao.WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InvestimentoController : ApiController
    {
        // GET: Investimento
        private readonly ICalculoInvestimentoCdb _calculo;
        
        public InvestimentoController()
        {
            _calculo = App_Start.DependencyResolver.Resolve<ICalculoInvestimentoCdb>();
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/calcular")]
        [HttpPost]
        public IHttpActionResult CalculoInvestimento([FromBody] DadosModel model)
        {
            _calculo.ConfiguraValores(model.Meses, model.ValorInicial);
            var resposta = new RespostaModel()
            {
                valorBruto = _calculo.CalculaValorBrutoCdb(),
                valorLiquido = _calculo.CalculaValorLiquidoCdb()
            };

            return Json(resposta);
        }
    }
}