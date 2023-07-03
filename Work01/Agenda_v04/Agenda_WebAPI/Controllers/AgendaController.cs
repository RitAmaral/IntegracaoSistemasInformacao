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

        //Acrescentar para CRUD:
        [HttpGet("{id}")] //fornecer id, colocar minusculas
        [Produces("application/json")] //este endpoint produz um objeto json
        [ProducesResponseType(typeof(AgendaRegistoResponse), StatusCodes.Status200OK)]
        public IActionResult GetId(int id)
        {
            AgendaServices _servicos = new AgendaServices();
            _servicos.Compromissos.ImportarDados();
            AgendaRegistoResponse? agendaRegistoResponse = _servicos.Compromissos.ObterCompromissoResponse(id); //vamos criar este método em Compromisso BR
            //^ se a função devolver um nulo, é porque não existe
            if (agendaRegistoResponse != null)
            {
                return new ObjectResult(agendaRegistoResponse);
            }
            return new NotFoundResult(); //se o ID não existir vai mandar o erro 404
        }
        //Acrescentar:
        [HttpPost]
        public IActionResult Post([FromBody] AgendaRegistoRequest value)
        {
            AgendaServices _servicos = new AgendaServices();
            _servicos.Compromissos.ImportarDados();
            if (_servicos.Compromissos.AdicionarCompromissoRequest(value)) //Criar também este método
            {
                _servicos.Compromissos.ExportarDados();
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir adicionar, devolve erro bad request
        }
        //Acrescentar:
        [HttpPut("{id}")] //fornecer o id o queremos alterar, e damos o valor que queremos alterar
        public IActionResult Post(int id, [FromBody] AgendaRegistoRequest value)
        {
            AgendaServices _servicos = new AgendaServices();
            _servicos.Compromissos.ImportarDados();
            if (_servicos.Compromissos.ModificarCompromissoRequest(id, value)) //Criar também este método
            {
                _servicos.Compromissos.ExportarDados();
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir modificar, devolve erro bad request
        }
        //Acrescentar:
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AgendaServices _servicos = new AgendaServices();
            _servicos.Compromissos.ImportarDados();
            if (_servicos.Compromissos.ApagarCompromisso(id)) //Criar também este método
            {
                _servicos.Compromissos.ExportarDados();
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir modificar, devolve erro bad request
        }
    }
}
