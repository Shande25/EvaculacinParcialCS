using EjemploMVC_MAT.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EjemploMVC_MAT.Services
{
    public class CardService
    {
        private readonly HttpClient _httpClient;
        private const string apiUrl = "https://f1api.dev/api/drivers";

        public CardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Card>> GetCardsAsync(int page = 1)
        {
            try
            {
                // Realizamos la solicitud a la API con la paginación
                var response = await _httpClient.GetStringAsync($"{apiUrl}&page={page}");

                if (string.IsNullOrWhiteSpace(response))
                {
                    return new List<Card>();
                }

                // Deserializamos la respuesta JSON
                var cardResponse = JsonConvert.DeserializeObject<dynamic>(response);

                if (cardResponse?.data == null)
                {
                    return new List<Card>();
                }

                // Convertir los datos a lista de objetos Card
                var cards = cardResponse.data.ToObject<List<Card>>();

                return cards ?? new List<Card>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener cartas: {ex.Message}");
                return new List<Card>();
            }
        }

        public async Task<Card> GetCardDetailsAsync(int cardId)
        {
            try
            {
                var response = await _httpClient.GetStringAsync($"https://db.ygoprodeck.com/api/v7/cardinfo.php?id={cardId}");
                if (string.IsNullOrWhiteSpace(response))
                {
                    return null;
                }

                var cardResponse = JsonConvert.DeserializeObject<dynamic>(response);
                var card = cardResponse?.data?.ToObject<List<Card>>()?.FirstOrDefault();

                return card;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener detalles de la carta: {ex.Message}");
                return null;
            }
        }
    }
}
