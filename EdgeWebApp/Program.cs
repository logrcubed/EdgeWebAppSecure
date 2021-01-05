using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;

namespace EdgeWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // string[] info = Directory.GetFiles("/app/https/");
                    // Console.WriteLine("https folder content");
                    // foreach (var file in info)
                    // {
                    //     Console.WriteLine(file);
                    //     //var certificate = new X509Certificate2(file, "P@ssw0rd1!") ;
                    // }
                    webBuilder
                        .UseStartup<Startup>();
                        // webBuilder.UseKestrel(options => options.ListenAnyIP(5001, listenOptions => listenOptions.UseHttps(
                        // adapterOptions =>
                        // {
                        //     adapterOptions.ServerCertificate = new X509Certificate2("/https/EdgeWebApp.pfx", "P@ssw0rd1!");
                        // })));
                });
    }
}
