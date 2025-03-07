using Newtonsoft.Json;
using EjemploMVC_MAT.Models;

namespace EjemploMVC_MAT.Services
{
    public class CardService
    {
        private readonly HttpClient _httpClient;
        private readonly string apiUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php?archetype=Blue-Eyes";

        public CardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Card>> GetCardsAsync()
        {
            var response = await _httpClient.GetStringAsync(apiUrl);
            var jsonResponse = JsonConvert.DeserializeObject<Dictionary<string, List<Card>>>(response);
            return jsonResponse?["data"] ?? new List<Card>();
        }

        public async Task<Card> GetCardAsync(int id)
        {
            var response = await _httpClient.GetStringAsync($"{apiUrl}&id={id}");
            var jsonResponse = JsonConvert.DeserializeObject<Dictionary<string, List<Card>>>(response);
            return jsonResponse?["data"]?.FirstOrDefault() ?? new Card();
        }
    }
}
