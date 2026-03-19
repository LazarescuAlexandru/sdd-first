using src.Models;
using System.Net.Http.Json;

namespace src.Services;

public class SubscriptionService
{
    private readonly HttpClient _http;

    public SubscriptionService(HttpClient http)
    {
        _http = http;
    }

    public async Task AddSubscriptionAsync(string url)
    {
        var request = new { Url = url };
        await _http.PostAsJsonAsync("api/subscriptions", request);
    }

    public async Task<List<Subscription>> GetSubscriptionsAsync()
    {
        return await _http.GetFromJsonAsync<List<Subscription>>("api/subscriptions") ?? new List<Subscription>();
    }
}