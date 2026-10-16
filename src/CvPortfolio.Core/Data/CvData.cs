using CvPortfolio.Core.Models;

namespace CvPortfolio.Core.Data;

/// <summary>
/// Único lugar donde se edita el contenido del CV.
/// Para agregar un proyecto: sumar un <see cref="Project"/> a <see cref="Projects"/>.
/// Los valores actuales son de ejemplo (placeholders).
/// </summary>
public static class CvData
{
    public static Profile Profile { get; } = new(
        FullName: "Federico Bonaldo",
        Headline: new("Desarrollador de software", "Software Developer"),
        Summary: new(
            "Desarrollador con foco en C# y .NET. Me interesa construir software claro, mantenible y útil. (Texto de ejemplo: reemplazar por tu resumen.)",
            "Developer focused on C# and .NET. I enjoy building clear, maintainable and useful software. (Sample text: replace with your own summary.)"),
        Email: "fbonaldo@amr.org.ar",
        Location: "Buenos Aires, Argentina",
        GitHubUrl: "https://github.com/tu-usuario",
        LinkedInUrl: null);

    public static IReadOnlyList<Project> Projects { get; } = new List<Project>
    {
        new(
            Id: "cv-portfolio",
            Name: LocalizedText.Same("CV Portfolio"),
            Description: new(
                "Este sitio: un CV web hecho con Blazor WebAssembly y publicado en GitHub Pages.",
                "This site: a web CV built with Blazor WebAssembly and published on GitHub Pages."),
            Technologies: new[] { "C#", ".NET 8", "Blazor WebAssembly", "GitHub Actions" },
            Year: 2026,
            RepositoryUrl: "https://github.com/tu-usuario/CvPortfolio"),
        new(
            Id: "proyecto-ejemplo",
            Name: new("Proyecto de ejemplo", "Sample project"),
            Description: new(
                "Descripción breve de un proyecto. Reemplazar por uno real.",
                "Short description of a project. Replace with a real one."),
            Technologies: new[] { "C#", "ASP.NET Core", "SQL Server" },
            Year: 2025)
    };

    public static IReadOnlyList<Experience> Experiences { get; } = new List<Experience>
    {
        new(
            Role: new("Cargo de ejemplo", "Sample role"),
            Company: "Hospital Español",
            StartYear: 2024,
            EndYear: null,
            Description: new("Descripción de tareas y logros.", "Description of duties and achievements."))
    };

    public static IReadOnlyList<Education> Education { get; } = new List<Education>
    {
        new(
            Title: new("Título de ejemplo", "Sample degree"),
            Institution: "Institución",
            StartYear: 2018,
            EndYear: 2023)
    };

    public static IReadOnlyList<SkillGroup> Skills { get; } = new List<SkillGroup>
    {
        new(new("Lenguajes", "Languages"), new[] { "C#", "SQL", "JavaScript" }),
        new(new("Frameworks", "Frameworks"), new[] { ".NET 8", "ASP.NET Core", "Blazor", "Entity Framework Core" }),
        new(new("Herramientas", "Tools"), new[] { "Git", "GitHub Actions", "Visual Studio" })
    };
}
