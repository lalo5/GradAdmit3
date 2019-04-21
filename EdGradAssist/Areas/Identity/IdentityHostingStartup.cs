using System;
using EdGradAssist.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EdGradAssist.Areas.Identity.IdentityHostingStartup))]
namespace EdGradAssist.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EdGradAssistContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EdGradAssistContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<EdGradAssistContext>();
            });
        }
    }
}