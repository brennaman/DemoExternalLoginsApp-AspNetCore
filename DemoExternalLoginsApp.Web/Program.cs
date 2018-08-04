using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DemoExternalLoginsApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    var builtConfig = config.Build();

                    var environment = builtConfig["ASPNETCORE_ENVIRONMENT"];
                    var isDevelopment = environment == EnvironmentName.Development;
                    
                    if(!isDevelopment)
                    {
                        config.AddAzureKeyVault(
                        $"https://{builtConfig["AZURE_KEY_VAULT_NAME"]}.vault.azure.net/",
                        builtConfig["AZURE_KEY_VAULT_CLIENT_ID"],
                        builtConfig["AZURE_KEY_VAULT_CLIENT_SECRET"]);
                    }

                })
                .UseStartup<Startup>();
    }
}
