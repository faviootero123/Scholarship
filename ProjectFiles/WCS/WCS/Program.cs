using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WCS
{
    public class Program
    {
        public static bool AllowStudentLogin { get; set; }

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
