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
        ["viewRepository"] = new("Ver repositorio", "View repository"),
        ["demo"] = new("Demo", "Demo"),
        ["contact"] = new("Contacto", "Contact"),
        ["noProjects"] = new("Todavía no hay proyectos cargados.", "No projects yet."),

        // Botones de la tarjeta de perfil
        ["viewCv"] = new("Ver CV", "View CV"),
        ["contactMe"] = new("Contactame", "Contact me"),

        // Años de experiencia en las barras de habilidades
        ["year"] = new("año", "year"),
        ["years"] = new("años", "years"),

        // Tema claro / oscuro (la etiqueta indica el tema al que se va a cambiar)
        ["themeLight"] = new("Cambiar a tema claro", "Switch to light theme"),
        ["themeDark"] = new("Cambiar a tema oscuro", "Switch to dark theme"),

        // Navegación superior, en formato «slug»
        ["nav.about"] = new("sobre-mí", "about"),
        ["nav.projects"] = new("proyectos", "projects"),
        ["nav.experience"] = new("experiencia", "experience"),
        ["nav.education"] = new("educación", "education"),
        ["nav.skills"] = new("habilidades", "skills"),
        ["navSections"] = new("Secciones", "Sections"),

        // Prompts de terminal de cada sección
        ["prompt.projects"] = new("$ ls ./proyectos", "$ ls ./projects"),
        ["prompt.experience"] = new("$ cat experiencia.log", "$ cat experience.log"),
        ["prompt.education"] = new("$ cat educacion.log", "$ cat education.log"),

        ["footer"] = new("hecho con Blazor WebAssembly", "built with Blazor WebAssembly"),
    };

    public static string Get(string key, Language language) =>
        Labels.TryGetValue(key, out var text) ? text.Get(language) : key;
}
