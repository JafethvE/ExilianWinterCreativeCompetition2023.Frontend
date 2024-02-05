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
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
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

        public async Task<HttpResponseMessage> SaveNewAnimal(Animal animal)
        {
            string json = JsonSerializer.Serialize(animal, options);
            return await client.PostAsync(@"http://" + url + ":" + port + "/animal/add", new StringContent(json, System.Text.Encoding.UTF8, "application/json")).ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> UpdateAnimal(Animal animal)
        {
            string json = JsonSerializer.Serialize(animal, options);
            return await client.PostAsync(@"http://" + url + ":" + port + "/animal/update", new StringContent(json, System.Text.Encoding.UTF8, "application/json")).ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> DeleteAnimal(Animal animal)
        {
            string json = JsonSerializer.Serialize(animal, options);
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json"),
                RequestUri = new System.Uri("http://" + url + ":" + port + "/animal/delete")
            };
            return await client.SendAsync(requestMessage).ConfigureAwait(false);
        }
    }
}
