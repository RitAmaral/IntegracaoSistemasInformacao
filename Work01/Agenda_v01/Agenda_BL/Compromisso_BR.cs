using Agenda_BO; //não esquecer de colocar os using se não forem importados automaticamente
using Agenda_Constantes;
using Agenda_DAL;

namespace Agenda_BL //adicionar referencia de projeto (em cima de dependencias_BL), a Agenda_BO e a Agenda_console
{
    public class Compromisso_BR
    { //colocar aqui as regras de inserção de dados (que estão/estavam no construtor em Agenda_BO -> Compromisso)

        private Compromisso_DAO _CompromissoDao;
        public Compromisso_BR() 
        {
            _CompromissoDao = new Compromisso_DAO();
        }

        public Compromisso NovoCompromisso(DateTime data, int hora, int bloco, Prioridade prioridade, string nome, 
            string assunto, TipoAgendamento tipoAgendamento)
        {
            int tBloco = bloco < 1 ? 1 : (bloco > 4 ? 4 : bloco); //queremos condicionar, logo se for menor que 1 passa a ser 1, e se for maior que 4 passa a ser 4.
            DateTime tData = new DateTime(data.Year, data.Month, data.Day, hora, (bloco - 1) * 15, 0);
            Prioridade tPrioridade = prioridade;
            string tNome = nome ?? throw new ArgumentNullException(nameof(nome)); // ?? = verifica se o nome é nulo
            string tAssunto = assunto ?? throw new ArgumentNullException(nameof(assunto));
            TipoAgendamento tTipoAgendamento = tipoAgendamento;

            return new Compromisso(tData, tBloco, tPrioridade, tNome, tAssunto, tTipoAgendamento); //o resultado disto (vai criar um compromisso) é que vai para a base de dados
        }
        public Compromisso NovoCompromisso(int hora, int bloco, string nome, string assunto,
            Prioridade prioridade = Prioridade.Media, TipoAgendamento tipoAgendamento = TipoAgendamento.Profissional)
        {
            return NovoCompromisso(DateTime.Now, hora, bloco, prioridade, nome, assunto, tipoAgendamento);
        }

        public bool AdicionarCompromisso(Compromisso compromisso)
        {
            if (ReferenceEquals(compromisso, null)) return false; //se adicionar nulo, não vai ser adicionado
            return _CompromissoDao.AdicionarCompromisso(compromisso);
        }

        public List<string> GetCompromissoList()
        {
            return _CompromissoDao.GetCompromissoList(); 
        }
        public bool ApagarCompromisso(string nome)
        {
            return _CompromissoDao.ApagarCompromisso(nome);
        }
        public bool ExisteCliente(string nome)
        {
            return _CompromissoDao.ExisteCliente(nome);
        }
    }
}