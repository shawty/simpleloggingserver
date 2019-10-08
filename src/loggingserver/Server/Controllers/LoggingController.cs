using loggingserver.Server.Hubs;
using loggingserver.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Text.Json;

namespace loggingserver.Server.Controllers
{
  public class LoggingController : ControllerBase
  {
    private readonly IHubContext<LogMessageHub> _hubContext;

    public LoggingController(IHubContext<LogMessageHub> hubContext)
    {
      _hubContext = hubContext;
    }

    [HttpPost]
    [Route("/logger/postlogmessage")]
    public async void PostLogMessage([FromBody] LogMessage logMessage)
    {
      await _hubContext.Clients.All.SendAsync("RxdMessage", JsonSerializer.Serialize(logMessage));
    }

  }
}
