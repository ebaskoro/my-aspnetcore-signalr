using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalR.Models;


namespace SignalR.Hubs
{

    public class HeroHub : Hub
    {
        
        public Task Add(HeroModel model)
        {
            var connectionId = Context.ConnectionId;
            return Clients
                .AllExcept(new[] { connectionId })
                .InvokeAsync("Add", model);
        }


        public Task Update(HeroModel model)
        {
            var connectionId = Context.ConnectionId;
            return Clients
                .AllExcept(new[] { connectionId })
                .InvokeAsync("Update", model);
        }


        public Task Remove(long id)
        {
            var connectionId = Context.ConnectionId;
            return Clients
                .AllExcept(new[] { connectionId })
                .InvokeAsync("Remove", id);
        }
        
    }
    
}