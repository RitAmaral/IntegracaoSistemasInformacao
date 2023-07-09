using Anotacoes_Models2Api;
using Newtonsoft.Json;

internal class Program
{
    static readonly HttpClient client = new HttpClient();
    private static async Task Main(string[] args)
    { //quando corremos esta consola, vai aparecer o mesmo que aparece no swagger, a lista de anotações em json
        //nota: precisamos de ter outra solução aberta, onde está a correr na consola anotacoes_webapi
        try
        {
            string a = "https://localhost:7110"; //copiar o link do swagger para aqui
            string b = $"{a}/api/Anotacoes"; 
            using HttpResponseMessage response = await client.GetAsync(b); //tornar método assincrono: async em cima no private static async
            response.EnsureSuccessStatusCode(); //importante, obrigar a receber tudo e tem um status code 200 ok, se não gera um erro
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

            List<AnotRegistoResponse> lista = JsonConvert.DeserializeObject<List<AnotRegistoResponse>>(responseBody);
            if (lista != null && lista.Count > 0)
            {
                foreach (var item in lista)
                {
                    Console.WriteLine($"{item.Id}\t{item.Nome}\t{item.Aula}\t{item.Tipo}\t{item.Revisado}"); //assim aparece a lista de forma mais organizada
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