using loggingserver.Shared;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using System.Text.Json;

namespace loggingserver.Server.Hubs
{
  public class LogMessageHub : Hub
  {
    public Task SendMessage(string category, string message)
    {
      Clients.All.SendAsync("RxdMessage", JsonSerializer.Serialize(new LogMessage() { Category = category, Message = message }));
      return Task.CompletedTask;
    }
  }
}
