using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;

namespace ExilianWinterCreativeCompetition2023.Frontend
{
    class RestController
    {
        private readonly string url;
        private readonly string port;
        private readonly HttpClient client = new HttpClient();
        private readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public RestController()
        {
            IniData data = new FileIniDataParser().ReadFile("Settings.ini");
            url = data["remote"]["url"];
            port = data["remote"]["port"];
        }

        public async Task<List<Animal>> GetAllAnimals()
        {
            List<Animal> animals;
            string json = await client.GetStringAsync(@"http://"+ url + ":" + port + "/animals").ConfigureAwait(false);
            animals = JsonSerializer.Deserialize<List<Animal>>(json, options);
            return animals;
        }
    }
}
