using Microsoft.Extensions.Configuration;

namespace AspNetCoreApp
{
    public class Greeter : IGreeter
    {
        private readonly IConfiguration _config;

        public Greeter(IConfiguration config)
        {
            _config = config;
        }

        public string GetGreeting()
        {
            return $"{_config["Greeting"]}, {_config["username"]}!";
        }
    }
}