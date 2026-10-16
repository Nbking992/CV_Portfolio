using CvPortfolio.Core.Models;

namespace CvPortfolio.Core.Services;

public sealed class LanguageService : ILanguageService
{
    public Language Current { get; private set; } = Language.Es;

    public event Action? Changed;

    public void Set(Language language)
    {
        if (language == Current) return;
        Current = language;
        Changed?.Invoke();
    }

    public string T(LocalizedText text) => text.Get(Current);

    public string Label(string key) => UiLabels.Get(key, Current);
}
