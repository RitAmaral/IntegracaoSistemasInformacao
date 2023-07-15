using Agenda_BL;

namespace Agenda_Services2Api
{
    public class AgendaServicespg
    {
        private readonly Lazy<Compromisso_BR> _compromissos =
            new Lazy<Compromisso_BR>(() => new Compromisso_BR());

        public Compromisso_BR Compromissos => _compromissos.Value;

    }
}