using Eurovisao_Models2Api;
using Eurovisao_Services2Api;
using Microsoft.AspNetCore.Mvc;

namespace Eurovisao_WebAPI.Controllers
{
    /// <summary>
    /// registo de concorrentes
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]
    public class EurovisaoController : ControllerBase //mudar para ControllerBase
    {
        /// <summary>
        /// devolve a lista de concorrentes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json")] //este endpoint produz um objeto json
        [ProducesResponseType(typeof(List<EuroRegistoResponse>), StatusCodes.Status200OK)] //vou dizer o tipo de dados que vai sair deste endopoint
        //o api tem que devolver sempre um código de estado, o 200 é OK
        public IActionResult Index()
        {
            EurovisaoServices _servicos = new EurovisaoServices();
            _servicos.Concorrentes.ImportarDados();
            return new ObjectResult(_servicos.Concorrentes.GetConcorrenteListResponse()); //faz ligaçao entre o api e a nossa libraria principal
        }
    }
}
