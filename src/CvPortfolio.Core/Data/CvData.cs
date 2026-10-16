using CvPortfolio.Core.Models;

namespace CvPortfolio.Core.Data;

/// <summary>
/// Único lugar donde se edita el contenido del CV.
/// Para agregar un proyecto: sumar un <see cref="Project"/> a <see cref="Projects"/>.
/// </summary>
public static class CvData
{
    public static Profile Profile { get; } = new(
        FullName: "Federico Bonaldo",
        Headline: new("Desarrollador de software", "Software Developer"),
        Summary: new(
            "Desarrollador de software en el área de Sistemas del Hospital Español de Rosario, con experiencia en Visual FoxPro y PostgreSQL, y soporte técnico de infraestructura. Me estoy formando en ciberseguridad y pentesting.",
            "Software developer in the Systems department of Hospital Español in Rosario, with experience in Visual FoxPro and PostgreSQL, plus IT infrastructure support. I am currently training in cybersecurity and pentesting."),
        Email: "bonaldo.federico.97@gmail.com",
        Location: "Rosario, Argentina",
        GitHubUrl: "https://github.com/Nbking992",
        LinkedInUrl: "https://www.linkedin.com/in/federico-bonaldo");

    public static IReadOnlyList<Project> Projects { get; } = new List<Project>
    {
        new(
            Id: "cv-portfolio",
            Name: LocalizedText.Same("CV Portfolio"),
            Description: new(
                "Este sitio: un CV web bilingüe hecho con Blazor WebAssembly y publicado en GitHub Pages.",
                "This site: a bilingual web CV built with Blazor WebAssembly and published on GitHub Pages."),
            Technologies: new[] { "C#", ".NET 8", "Blazor WebAssembly", "GitHub Actions" },
            Year: 2026,
            RepositoryUrl: "https://github.com/Nbking992/CV_Portfolio")
    };

    public static IReadOnlyList<Experience> Experiences { get; } = new List<Experience>
    {
        new(
            Role: new("Desarrollador de software Visual FoxPro", "Visual FoxPro Software Developer"),
            Company: "Hospital Español (Rosario, Argentina)",
            StartYear: 2021,
            EndYear: null,
            Description: new(
                "Desarrollo y mantenimiento de aplicaciones en Visual FoxPro, orientadas a la automatización de procesos, el manejo de archivos, el envío de correos y los circuitos de trabajo, aplicando metodologías ágiles y principios SOLID. Desarrollo de consultas, subconsultas y operaciones CRUD sobre PostgreSQL. Soporte técnico (help desk): gestión de software, reparación de equipos e instalación de puestos de trabajo.",
                "Development and maintenance of Visual FoxPro applications focused on process automation, file handling, email delivery and work flows, applying agile methodologies and SOLID principles. Development of queries, subqueries and CRUD operations on PostgreSQL. Technical support (help desk): software management, PC repair and workstation setup."))
    };

    public static IReadOnlyList<Education> Education { get; } = new List<Education>
    {
        new(
            Title: new(
                "Técnico Superior en Soporte de Infraestructura de Tecnología de la Información",
                "Higher Technician in Information Technology Infrastructure Support"),
            Institution: "Instituto de Educación Técnica N°55, Rosario, Argentina",
            StartYear: 2019,
            EndYear: 2021),
        new(
            Title: new("Técnico en Electrónica", "Electronics Technician"),
            Institution: "E.E.T.N 8013 San José, Rosario, Argentina",
            StartYear: 2010,
            EndYear: 2016)
    };

    public static IReadOnlyList<SkillGroup> Skills { get; } = new List<SkillGroup>
    {
        new(new("Lenguajes y bases de datos", "Languages and databases"),
            new LocalizedText[]
            {
                new("Visual FoxPro 6/9 (4 años)", "Visual FoxPro 6/9 (4 years)"),
                new("PostgreSQL (4 años)", "PostgreSQL (4 years)"),
                new("HTML/CSS (2 años)", "HTML/CSS (2 years)")
            }),
        new(new("Sistemas operativos", "Operating systems"),
            new LocalizedText[]
            {
                new("Windows (4 años)", "Windows (4 years)"),
                new("Linux / Kali Linux (1 año)", "Linux / Kali Linux (1 year)")
            }),
        new(new("Cursos", "Courses"),
            new LocalizedText[]
            {
                new("JavaScript desde Cero", "JavaScript from Scratch"),
                new("Introducción a la Ciberseguridad", "Introduction to Cybersecurity"),
                new("Introducción al Pentesting", "Introduction to Pentesting"),
                new("Administrador de Redes Linux y Ciberseguridad", "Linux Network Administrator and Cybersecurity"),
                LocalizedText.Same("Full Ethical Hacking")
            }),
        new(new("Idiomas", "Spoken languages"),
            new LocalizedText[] { new("Inglés técnico", "Technical English") })
    };
}
