using CvPortfolio.Core.Models;

namespace CvPortfolio.Core.Services;

/// <summary>Textos fijos de la interfaz.</summary>
internal static class UiLabels
{
    private static readonly Dictionary<string, LocalizedText> Labels = new()
    {
        ["about"] = new("Sobre mí", "About me"),
        ["projects"] = new("Proyectos", "Projects"),
        ["experience"] = new("Experiencia", "Experience"),
        ["education"] = new("Educación", "Education"),
        ["skills"] = new("Habilidades", "Skills"),
        ["present"] = new("Actualidad", "Present"),
        ["repository"] = new("Repositorio", "Repository"),
        ["demo"] = new("Demo", "Demo"),
        ["contact"] = new("Contacto", "Contact"),
        ["noProjects"] = new("Todavía no hay proyectos cargados.", "No projects yet."),
    };

    public static string Get(string key, Language language) =>
        Labels.TryGetValue(key, out var text) ? text.Get(language) : key;
}
