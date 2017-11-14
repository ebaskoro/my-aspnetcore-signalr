using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SignalR.Hubs;


namespace SignalR
{

    public class Startup
    {
        
        private readonly IConfiguration _configuration;


        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
                options.AddPolicy("AllowAll", policy =>
                    policy
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod()));

            services.AddSignalR();
        }

        
        public void Configure(IApplicationBuilder app)
        {
            app.UseCors("AllowAll");

            app.UseSignalR(routes =>
            {
                routes.MapHub<HeroHub>("hero");
            });
        }

    }

}
