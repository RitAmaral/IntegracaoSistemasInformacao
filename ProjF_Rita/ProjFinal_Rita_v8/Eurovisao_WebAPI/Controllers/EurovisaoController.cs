﻿using Eurovisao_Models2Api;
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

        /// <summary>
        /// obter concorrente por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")] //temos id como parâmetro
        [Produces("application/json")] //este endpoint produz um objeto json
        [ProducesResponseType(typeof(EuroRegistoResponse), StatusCodes.Status200OK)]
        public IActionResult GetId(int id)
        {
            EurovisaoServices _servicos = new EurovisaoServices();
            _servicos.Concorrentes.ImportarDados();
            EuroRegistoResponse? euroRegistoResponse = _servicos.Concorrentes.ObterConcorrenteResponse(id); //vamos criar este método em Eurovisao BR
            //^ se a função devolver um nulo, é porque não existe
            if (euroRegistoResponse != null)
            {
                return new ObjectResult(euroRegistoResponse);
            }
            return new NotFoundResult(); //se o ID não existir vai mandar o erro 404
        }
        
        /// <summary>
        /// inserir concorrente
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] EuroRegistoRequest value)
        {
            EurovisaoServices _servicos = new EurovisaoServices();
            _servicos.Concorrentes.ImportarDados();
            if (_servicos.Concorrentes.AdicionarConcorrenteRequest(value)) //Criar também este método
            {
                _servicos.Concorrentes.ExportarDados();
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir adicionar concorrente, devolve erro bad request
        }
        
        /// <summary>
        /// modificar concorrente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPut("{id}")] //fornecer o id do concorrente que queremos alterar, e inserimos os valores que queremos alterar (os que não queremos alterar, deixamos igual)
        public IActionResult Post(int id, [FromBody] EuroRegistoRequest value)
        {
            EurovisaoServices _servicos = new EurovisaoServices();
            _servicos.Concorrentes.ImportarDados();
            if (_servicos.Concorrentes.ModificarConcorrenteRequest(id, value)) //Criar também este método
            {
                _servicos.Concorrentes.ExportarDados();
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir modificar o concorrente, devolve erro bad request
        }
        
        /// <summary>
        /// apagar concorrente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            EurovisaoServices _servicos = new EurovisaoServices();
            _servicos.Concorrentes.ImportarDados();
            if (_servicos.Concorrentes.ApagarConcorrente(id)) //Criar também este método
            {
                _servicos.Concorrentes.ExportarDados();
                return new OkResult();
            }
            return new BadRequestResult(); //se nao conseguir eliminar concorrente, devolve erro bad request
        }
    }
}

