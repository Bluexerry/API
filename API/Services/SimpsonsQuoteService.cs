using API.Models;
using System.Net.Http.Json;

namespace API.Services
{
    public class SimpsonsQuoteService : ISimpsonsQuoteService
    {
        private readonly HttpClient _httpClient;

        public SimpsonsQuoteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<SimpsonsQuote>> GetRandomQuotesAsync(int? count = null, string? character = null)
        {
            var url = "quotes";

            var queryParameters = new List<string>();
            if (count.HasValue)
            {
                queryParameters.Add($"count={count.Value}");
            }
            if (!string.IsNullOrEmpty(character))
            {
                queryParameters.Add($"character={character}");
            }
            if (queryParameters.Any())
            {
                url += "?" + string.Join("&", queryParameters);
            }

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<IEnumerable<SimpsonsQuote>>() ?? Enumerable.Empty<SimpsonsQuote>();
        }
    }
}