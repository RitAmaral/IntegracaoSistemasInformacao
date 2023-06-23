namespace Anotacoes_Constantes
{
    [Serializable] //se o enum não for serializado vai dar erro.
    public enum Tipo : byte
    {
        Aula = 1,
        Seminario = 2,
        Sessao = 3,
        Leitura = 4,
        GrupoDeEstudo = 5
    };
}