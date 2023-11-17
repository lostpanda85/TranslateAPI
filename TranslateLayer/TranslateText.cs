using Microsoft.Extensions.Configuration;

namespace TranslateLayer
{
    public class TranslateText
    {
        private readonly IConfiguration _config;

        public TranslateText(IConfiguration config)
        {
            _config = config;
        }

        public string Execute(string translateText)
        {
            return "¡Buenos Dias! " + _config.GetSection("Environment").Value;
        }
    }
}