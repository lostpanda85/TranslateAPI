namespace TranslateAPI.Services
{
    public class TranslateService : ITranslate
    {
        public Task<string> TranslateText(string text)
        {
            if(!string.IsNullOrEmpty(text))
            {
                return Task.FromResult(TranslateLayer.TranslateText.Execute(text));
            }

            throw new Exception("Translation string is empty");
        }
    }
}
