using RssReaderApi.Models;

namespace RssReaderApi.Services;

public class SubscriptionService : ISubscriptionService
{
    private readonly List<Subscription> _subscriptions = new();

    public void AddSubscription(string url)
    {
        if (!string.IsNullOrWhiteSpace(url))
        {
            _subscriptions.Add(new Subscription { Url = url });
        }
    }

    public IEnumerable<Subscription> GetSubscriptions()
    {
        return _subscriptions;
    }
}