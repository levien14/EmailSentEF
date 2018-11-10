using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using T1708ENewsWeb.Models;

[assembly: HostingStartup(typeof(T1708ENewsWeb.Areas.Identity.IdentityHostingStartup))]
namespace T1708ENewsWeb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<T1708ENewsWebIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("T1708ENewsWebIdentityContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<T1708ENewsWebIdentityContext>();
            });
        }
    }
}