using Microsoft.AspNetCore.SignalR;
using SignalR.Hubs;
using FakeItEasy;
using Xunit;


namespace SignalR.Tests.Hub
{

    public class HeroHubTest
    {
        
        public HeroHubTest()
        {
            Target = new HeroHub();
            Target.Context = A.Fake<HubCallerContext>();
            Target.Clients = A.Fake<IHubClients>();
        }


        HeroHub Target
        {
            get;
        }

        
        [Fact]
        public async void Add_Throws_NoException()
        {
            await Target.Add(null);
        }


        [Fact]
        public async void Update_Throws_NoException()
        {
            await Target.Update(null);
        }


        [Fact]
        public async void Remove_Throws_NoException()
        {
            await Target.Remove(0);
        }

    }

}