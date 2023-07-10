using Newtonsoft.Json;
using Eurovisao_Models2Api;


internal class Program
{
    static readonly HttpClient client = new HttpClient(); 
    //forma disfarçada de usar o singleton dentro do program; apenas uma instancia 
    private static async Task Main(string[] args)
    { // foi criado um novo projeto aplicativo de console: EuroConsole2Api
        //quando corremos esta consola, vai aparecer o mesmo que aparece no swagger, a lista de concorrentes em json (nota: a webAPI deve tar aberta ao mesmo tempo)
        try
        {
            string a = "https://localhost:7042"; //copiar o link do swagger para aqui
            string b = $"{a}/api/Eurovisao"; 
            using HttpResponseMessage response = await client.GetAsync(b); //tornar método assincrono: async em cima no private static async
            response.EnsureSuccessStatusCode(); //importante, obrigar a receber tudo e tem um status code 200 ok, se não gera um erro
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);

            List<EuroRegistoResponse> lista = JsonConvert.DeserializeObject<List<EuroRegistoResponse>>(responseBody);
            if (lista != null && lista.Count > 0)
            {
                Console.WriteLine("\nID\t|País\t|Representante\t|Música\t|Ronda\t|Júri\t|Televoto\t|Total Pontos");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                foreach (var item in lista)
                {
                    Console.WriteLine($"{item.ID}\t|{item.Pais}\t|{item.NomeRepresentante}\t|{item.NomeMusica}\t|{item.Ronda}\t|{item.PontosJuri}\t|{item.PontosTelevoto}\t|{item.TotalPontos}");
                } //aqui aparece a lista de forma mais organizada/separada
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