namespace TranslateAPI.Services
{
    public class TranslateService : ITranslate
    {
        private readonly IConfiguration _config;

        public TranslateService(IConfiguration config)
        {
            _config = config;
        }

        public Task<string> TranslateText(string text)
        {
            var service = new TranslateLayer.TranslateText(_config);

            if(!string.IsNullOrEmpty(text))
            {
                return Task.FromResult(service.Execute(text));
            }

            throw new Exception("Translation string is empty");
        }
    }
}
