namespace ToolBox
{
    public class GetNewId //Implementa o padrão de design singleton
    {
        private static GetNewId instancia;
        private static int contador = 0;

        private GetNewId() { } //construtor privado que evita que outras classes criem instâncias dele

        public int Proximo => ++contador; // => é o mesmo que get

        public static GetNewId Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new GetNewId();
                }
                return instancia;
            }
        }
        public void ResetProximo(int novoInicioContador) // necessário executar quando carregamos a base de dados XML, para evitar duplicação de Id's
        {
            contador = novoInicioContador;
        }
    }
}