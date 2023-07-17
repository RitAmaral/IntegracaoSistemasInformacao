using Anotacoes_Models2Api;
using Anotacoes_Services2Apipg;
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
        /// devolve a lista de anotações
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json")] 
        [ProducesResponseType(typeof(List<AnotRegistoResponse>), StatusCodes.Status200OK)] 
        //status code 200 é OK
        public IActionResult Index()
        {
            AnotacoesServicos _servicos = new AnotacoesServicos();
            return new ObjectResult(_servicos.Anotacoes.GetAnotacoesListResponse()); //fazer ligaçao entre o api e a nossa libraria principal
        }

        //Acrescentar para CRUD:
        /// <summary>
        /// obter anotação por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")] //fornecer id, colocar minusculas
        [Produces("application/json")] //este endpoint produz um objeto json
        [ProducesResponseType(typeof(AnotRegistoResponse), StatusCodes.Status200OK)]
        public IActionResult GetId(int id)
        {
            AnotacoesServicos _servicos = new AnotacoesServicos();
            AnotRegistoResponse? anotRegistoResponse = _servicos.Anotacoes.ObterAnotacaoResponse(id); //vamos criar este método em AnotacoesAula BR
            if (anotRegistoResponse != null)
            {
                return new ObjectResult(anotRegistoResponse);
            }
            return new NotFoundResult(); //se o ID não existir vai mandar o erro 404
        }
        //Acrescentar:
        /// <summary>
        /// inserir anotação
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] AnotRegistoRequest value)
        {
            AnotacoesServicos _servicos = new AnotacoesServicos();
            if (_servicos.Anotacoes.AdicionarAnotacaoRequest(value)) //Criar também este método
            {
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir adicionar, devolve erro bad request
        }
        //Acrescentar:
        /// <summary>
        /// modificar anotação
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPut("{id}")] //fornecer o id o queremos alterar, e damos o valor que queremos alterar
        public IActionResult Put(int id, [FromBody] AnotRegistoRequest value) //-------------------Put aqui em vez de Post
        {
            AnotacoesServicos _servicos = new AnotacoesServicos();
            if (_servicos.Anotacoes.ModificarAnotacaoRequest(id, value)) //Criar também este método
            {
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir modificar, devolve erro bad request
        }
        //Acrescentar:
        /// <summary>
        /// apagar anotação
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AnotacoesServicos _servicos = new AnotacoesServicos();
            if (_servicos.Anotacoes.ApagarAnotacao(id)) //Criar também este método
            {
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir modificar, devolve erro bad request
        }
    }
}
