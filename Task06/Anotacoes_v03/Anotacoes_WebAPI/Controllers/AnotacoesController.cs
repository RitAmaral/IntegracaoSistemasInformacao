using Anotacoes_Models2Api;
using Anotacoes_Services2Api;
using Microsoft.AspNetCore.Mvc;

namespace Anotacoes_WebAPI.Controllers
{
    /// <summary>
    /// registo de anotacoes
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class AnotacoesController : ControllerBase
    {
        /// <summary>
        /// devolve a lista de anotacoes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json")] 
        [ProducesResponseType(typeof(List<AnotRegistoResponse>), StatusCodes.Status200OK)] 
        //status code 200 é OK
        public IActionResult Index()
        {
            AnotacoesServicos _servicos = new AnotacoesServicos();
            _servicos.Anotacoes.ImportarDados();
            return new ObjectResult(_servicos.Anotacoes.GetAnotacoesListResponse()); //fazer ligaçao entre o api e a nossa libraria principal
        }

        //Acrescentar para CRUD:
        [HttpGet("{id}")] //fornecer id, colocar minusculas
        [Produces("application/json")] //este endpoint produz um objeto json
        [ProducesResponseType(typeof(AnotRegistoResponse), StatusCodes.Status200OK)]
        public IActionResult GetId(int id)
        {
            AnotacoesServicos _servicos = new AnotacoesServicos();
            _servicos.Anotacoes.ImportarDados();
            AnotRegistoResponse? agendaRegistoResponse = _servicos.Anotacoes.ObterAnotacaoResponse(id); //vamos criar este método em Compromisso BR
            if (agendaRegistoResponse != null)
            {
                return new ObjectResult(agendaRegistoResponse);
            }
            return new NotFoundResult(); //se o ID não existir vai mandar o erro 404
        }
        //Acrescentar:
        [HttpPost]
        public IActionResult Post([FromBody] AnotRegistoRequest value)
        {
            AnotacoesServicos _servicos = new AnotacoesServicos();
            _servicos.Anotacoes.ImportarDados();
            if (_servicos.Anotacoes.AdicionarAnotacaoRequest(value)) //Criar também este método
            {
                _servicos.Anotacoes.ExportarDados();
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir adicionar, devolve erro bad request
        }
        //Acrescentar:
        [HttpPut("{id}")] //fornecer o id o queremos alterar, e damos o valor que queremos alterar
        public IActionResult Post(int id, [FromBody] AnotRegistoRequest value)
        {
            AnotacoesServicos _servicos = new AnotacoesServicos();
            _servicos.Anotacoes.ImportarDados();
            if (_servicos.Anotacoes.ModificarAnotacaoRequest(id, value)) //Criar também este método
            {
                _servicos.Anotacoes.ExportarDados();
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir modificar, devolve erro bad request
        }
        //Acrescentar:
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AnotacoesServicos _servicos = new AnotacoesServicos();
            _servicos.Anotacoes.ImportarDados();
            if (_servicos.Anotacoes.ApagarAnotacao(id)) //Criar também este método
            {
                _servicos.Anotacoes.ExportarDados();
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir modificar, devolve erro bad request
        }
    }
}
