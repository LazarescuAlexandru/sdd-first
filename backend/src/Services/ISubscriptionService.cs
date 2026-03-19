using RssReaderApi.Models;

namespace RssReaderApi.Services;

public interface ISubscriptionService
{
    void AddSubscription(string url);
    IEnumerable<Subscription> GetSubscriptions();
}