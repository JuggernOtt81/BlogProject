using BlogMVC.Helpers;
using BlogMVC;
using BlogMVC.Data;
using BlogMVC.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using Microsoft.Extensions.DependencyInjection;

namespace BlogMVC
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
               
        }
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(async webBuilder =>
                {

                    var app = builder.Build();
                    var scope = app.Services.CreateScope();
                    await DataHelper.ManageDataAsync(scope.ServiceProvider);
                    webBuilder.UseStartup<Startup>();
                });

    }
}
