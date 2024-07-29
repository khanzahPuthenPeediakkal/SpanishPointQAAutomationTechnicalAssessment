using Microsoft.Extensions.Configuration;

namespace SpanishPointTestAutomation.TestConfig
{
    public  class ConfigurationManager
    {
        public static IConfiguration ConfigReader()
        {
            var configurationBuilder = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = configurationBuilder.Build();
            return configuration;
        }
        public static string GetUrl()
        {
            IConfiguration configuration =  ConfigReader();
            string url = configuration["url"];
            return url;
        }
        public static string GetBrowser()
        {
            IConfiguration configuration = ConfigReader();
            string browser = configuration["browser"];
            return browser;
        }
    }
}
