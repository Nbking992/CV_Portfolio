namespace CvPortfolio.Core.Models;

/// <summary>Una habilidad; si tiene <paramref name="Years"/> se puede mostrar como barra de experiencia.</summary>
public sealed record Skill(LocalizedText Name, int? Years = null)
{
    /// <summary>Atajo para habilidades cuyo nombre es igual en ambos idiomas (tecnologías, nombres propios).</summary>
    public static Skill Same(string name, int? years = null) => new(LocalizedText.Same(name), years);
}
