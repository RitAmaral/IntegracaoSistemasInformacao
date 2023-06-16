namespace Agenda_Constantes
{
    //Nesta primeira versão criamos o enum Prioridade, posteriormente estes dados vão passar para a base de dados (uma lista) e o utilizador é 
    //que vai gerir as prioridades.
    [Serializable]
    public enum Prioridade : byte // em vez de int, até podemos por byte, porque gasta menos memória, é mais pequeno
    {
        Alta = 1,
        Media = 2,
        Baixa = 3
    }
    [Serializable]
    public enum TipoAgendamento : byte
    {
        Profissional = 1,
        Pessoal = 2
    }
}