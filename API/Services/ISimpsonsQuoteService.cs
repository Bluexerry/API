using API.Models;

namespace API.Services
{
    public interface ISimpsonsQuoteService
    {
        Task<IEnumerable<SimpsonsQuote>> GetRandomQuotesAsync(int? count = null, string? character = null);
    }
}