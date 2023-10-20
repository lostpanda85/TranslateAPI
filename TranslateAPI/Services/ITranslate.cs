namespace TranslateAPI.Services
{
    public interface ITranslate
    {
        Task<string> TranslateText(string text);
    }
}
