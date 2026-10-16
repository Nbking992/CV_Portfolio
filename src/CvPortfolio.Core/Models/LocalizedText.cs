namespace CvPortfolio.Core.Models;

/// <summary>Texto disponible en español e inglés.</summary>
public sealed record LocalizedText(string Es, string En)
{
    public string Get(Language language) => language switch
    {
        Language.En => En,
        _ => Es
    };

    /// <summary>Atajo para textos iguales en ambos idiomas (nombres propios, tecnologías).</summary>
    public static LocalizedText Same(string value) => new(value, value);
}
