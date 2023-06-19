namespace ToolBox
{
    public class GetNewId
    {
        private static GetNewId instancia;
        private static int contador = 0;

        private GetNewId() { }

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
    }
}