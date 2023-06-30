using Agenda_BL; //criar dependencia e colocar using Agenda_BL
namespace Agenda_Services2Api
{
    public class AgendaServices
    {
        //aloca memória quando esse objeto for invocado, ate lá só existe a nível de conceito
        private readonly Lazy<Compromisso_BR> _compromissos = new Lazy<Compromisso_BR>(() => new Compromisso_BR());

        //criar atributo
        public Compromisso_BR Compromissos => _compromissos.Value;
    }
}