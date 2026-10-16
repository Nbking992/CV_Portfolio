using CvPortfolio.Core.Models;

namespace CvPortfolio.Core.Services;

public interface ILanguageService
{
    Language Current { get; }
    event Action? Changed;
    void Set(Language language);

    /// <summary>Devuelve el texto del idioma actual.</summary>
    string T(LocalizedText text);

    /// <summary>Devuelve una etiqueta de interfaz (títulos, botones) en el idioma actual.</summary>
    string Label(string key);
}
