using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using vid19.Models;

namespace vid19.Services
{
    public class Covid19Services
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<Stats> GetWorldStats()
        {
            var worldStatTask = client.GetStreamAsync("https://api.covid19api.com/world/total");

            var worldStats = await JsonSerializer.DeserializeAsync<Stats>(await worldStatTask);
            return worldStats;
        }
    }
}