using Agenda_Models2Api; //importar aqui o using, e criar a dependencia de Agenda_Models2Api
using Agenda_Services2Api; //importar aqui agenda services e criar dependencia
using Microsoft.AspNetCore.Mvc;

namespace Agenda_WebAPI.Controllers
{ //controllers têm de ter sempre nomes diferentes
    
    /// <summary>
    /// agendamento de compromissos
    /// </summary>
    
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase //mudar para ControllerBase
    { 
        /// <summary>
        /// devolve a lista de compromissos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json")] //este endpoint produz um objeto json
        [ProducesResponseType(typeof(List<AgendaRegistoResponse>), StatusCodes.Status200OK)] //vou dizer o tipo de dados que vai sair deste endopoint
        //o api tem que devolver sempre um código de estado, o 200 é OK
        public IActionResult Index()
        {
            AgendaServices _servicos = new AgendaServices();
            _servicos.Compromissos.ImportarDados();
            return new ObjectResult(_servicos.Compromissos.GetCompromissoListResponse()); //fazer ligaçao entre o api e a nossa libraria principal
        }
    }
}
