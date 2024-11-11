namespace Frontend.App;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) =>
            {
                config.Sources.Clear();
                config.SetBasePath(Directory.GetCurrentDirectory());
                config.AddJsonFile("App/Config/appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                Console.WriteLine("Loading HTTPS certificate...");
                string? certificatePath = Environment.GetEnvironmentVariable("ASPNETCORE_Kestrel__Certificates__Default__Path");
                string? certificatePassword = Environment.GetEnvironmentVariable("ASPNETCORE_Kestrel__Certificates__Default__Password");
                if (!string.IsNullOrEmpty(certificatePath) && !string.IsNullOrEmpty(certificatePassword))
                {
                    Console.WriteLine("HTTPS certifcicate load successfully");
                    webBuilder.ConfigureKestrel(serverOptions =>
                    {
                        serverOptions.ListenAnyIP(8081, listenOptions =>
                        {
                            listenOptions.UseHttps(certificatePath, certificatePassword);
                        });
                        serverOptions.ListenAnyIP(8080);
                    });
                }
                else Console.WriteLine("HTTPS certifcicate was not loaded");

                webBuilder.UseStartup<Startup>();
            });
}
