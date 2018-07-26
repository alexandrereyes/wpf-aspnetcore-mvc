using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WpfTest
{
    public static class HostBuilder
    {
        private static IWebHost host;

        public static async Task Start()
        {
            if (host == null)
            {
                var ip = System.Net.IPAddress.Parse("127.0.0.1");
                var port = 9388;

                host = new WebHostBuilder()
                   .UseKestrel(options =>
                   {
                       options.Listen(ip, port);
                   })
                   .UseStartup<HostStartup>()
                   .Build();

                await host.RunAsync();
            }
        }

    }

}
