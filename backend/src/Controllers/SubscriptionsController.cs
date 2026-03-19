using Microsoft.AspNetCore.Mvc;
using RssReaderApi.Models;
using RssReaderApi.Services;

namespace RssReaderApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly ISubscriptionService _service;

    public SubscriptionsController(ISubscriptionService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Post([FromBody] SubscriptionRequest request)
    {
        _service.AddSubscription(request.Url);
        return Created();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.GetSubscriptions());
    }
}