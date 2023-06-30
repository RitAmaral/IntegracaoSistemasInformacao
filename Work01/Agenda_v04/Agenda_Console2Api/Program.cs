using Newtonsoft.Json;
using Agenda_Models2Api; //criar dependencia e using aqui
using System.Security.Principal;

internal class Program
{
    static readonly HttpClient client = new HttpClient(); //Acrescentar isto
    //forma disfarçada de usar o singleton dentro do program; apenas uma instancia 
    private static async Task Main(string[] args)
    { // foi criado um novo projeto aplicativo de console: Agenda_Console2Api
        //quando corremos esta consola, vai aparecer o mesmo que aparece no swagger, a lista de compromissos em json
        Console.WriteLine("Hello, World!");
        try
        {
            string a = "https://localhost:7045"; //copiar o link do swagger para aqui
            string b = $"{a}/api/Agenda"; //isto tem ser separado do "a" em cima porque posso ir buscar outras coisas à frente do Agenda/1 -> vai buscar o compromisso 1?
            using HttpResponseMessage response = await client.GetAsync(b); //tornar método assincrono: async em cima no private static async
            response.EnsureSuccessStatusCode(); //importante, obrigar a receber tudo e tem um status code 200 ok, se não gera um erro
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

            List<AgendaRegistoResponse> lista = JsonConvert.DeserializeObject<List<AgendaRegistoResponse>>(responseBody);
            if (lista != null && lista.Count > 0)
            {
                foreach (var item in lista)
                {
                    Console.WriteLine($"{item.Id}\t{item.Data}\t{item.Nome}\t{item.Assunto}\t{item.Prioridade}");
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }



    }
}