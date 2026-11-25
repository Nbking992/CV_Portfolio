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
        Headline: new(
            "Desarrollador de software y estudiante de ciberseguridad",
            "Software Developer and Cybersecurity Student"),
        Summary: new(
            "Desarrollador de software en el área de Sistemas del Hospital Español de Rosario, con experiencia en Visual FoxPro y PostgreSQL, y soporte técnico de infraestructura. Me formo en ciberseguridad, hacking ético y pentesting, practicando con retos CTF.",
            "Software developer in the Systems department of Hospital Español in Rosario, with experience in Visual FoxPro and PostgreSQL, plus IT infrastructure support. I am training in cybersecurity, ethical hacking and pentesting, practicing with CTF challenges."),
        ShortSummary: new(
            "Desarrollador en el área de Sistemas del Hospital Español de Rosario. Me formo en ciberseguridad y hacking ético.",
            "Developer in the Systems department of Hospital Español in Rosario. Training in cybersecurity and ethical hacking."),
        Email: "bonaldo.federico.97@gmail.com",
        Location: "Rosario, AR",
        GitHubUrl: "https://github.com/Nbking992",
        LinkedInUrl: "https://www.linkedin.com/in/federico-bonaldo",
        Tags: new LocalizedText[]
        {
            new("ciberseguridad", "cybersecurity"),
            new("hacking-ético", "ethical-hacking"),
            LocalizedText.Same("ctf"),
            new("siempre-aprendiendo", "always-learning")
        });

    public static IReadOnlyList<Project> Projects { get; } = new List<Project>
    {
        new(
            Id: "bandit-overthewire",
            Name: LocalizedText.Same("OverTheWire (Bandit)"),
            Description: new(
                "Resolución de los retos de Bandit, de OverTheWire, con writeups documentados paso a paso. Práctica de Linux, terminal y fundamentos de seguridad.",
                "Solutions to the OverTheWire Bandit challenges with step-by-step writeups. Hands-on practice with Linux, the terminal and security fundamentals."),
            Technologies: new[] { "Bash", "Linux", "SSH", "CTF" },
            Year: 2026,
            RepositoryUrl: "https://github.com/Nbking992/practice-over-the-wire",
            PreviewLines: new[] { "bandit0@bandit:~$ cat readme", "bandit0@bandit:~$ ls -la" }),
        new(
            Id: "cv-portfolio",
            Name: LocalizedText.Same("CV Portfolio"),
            Description: new(
                "Este sitio: un CV web bilingüe hecho con Blazor WebAssembly y publicado en GitHub Pages.",
                "This site: a bilingual web CV built with Blazor WebAssembly and published on GitHub Pages."),
            Technologies: new[] { "C#", ".NET 8", "Blazor WebAssembly", "GitHub Actions" },
            Year: 2026,
            RepositoryUrl: "https://github.com/Nbking992/CV_Portfolio",
            PreviewLines: new[] { "dev@cv:~$ dotnet run", "dev@cv:~$ git push origin main" })
    };

    public static IReadOnlyList<Experience> Experiences { get; } = new List<Experience>
    {
        new(
            Role: new("Desarrollador de software Visual FoxPro", "Visual FoxPro Software Developer"),
            Company: "Hospital Español (Rosario, Argentina)",
            StartYear: 2021,
            EndYear: null,
            Bullets: new LocalizedText[]
            {
                new(
                    "Desarrollo y mantenimiento de aplicaciones en Visual FoxPro para automatizar procesos, archivos, correos y circuitos de trabajo.",
                    "Development and maintenance of Visual FoxPro applications to automate processes, files, emails and work flows."),
                new(
                    "Consultas, subconsultas y operaciones CRUD sobre PostgreSQL.",
                    "Queries, subqueries and CRUD operations on PostgreSQL."),
                new(
                    "Metodologías ágiles y principios SOLID.",
                    "Agile methodologies and SOLID principles."),
                new(
                    "Help desk: gestión de software, reparación de equipos e instalación de puestos de trabajo.",
                    "Help desk: software management, PC repair and workstation setup.")
            })
    };

    public static IReadOnlyList<Education> Education { get; } = new List<Education>
    {
        new(
            Title: new(
                "Técnico Superior en Soporte de Infraestructura de TI",
                "Higher Technician in IT Infrastructure Support"),
            Institution: "Instituto de Educación Técnica N°55",
            StartYear: 2019,
            EndYear: 2021),
        new(
            Title: new("Técnico en Electrónica", "Electronics Technician"),
            Institution: "E.E.T.N 8013 San José",
            StartYear: 2010,
            EndYear: 2016)
    };

    public static IReadOnlyList<SkillGroup> Skills { get; } = new List<SkillGroup>
    {
        new(new("Lenguajes y SO · años", "Languages and OS · years"),
            new Skill[]
            {
                Skill.Same("Visual FoxPro 6/9", 4),
                Skill.Same("PostgreSQL", 4),
                Skill.Same("Windows", 4),
                Skill.Same("HTML/CSS", 2),
                Skill.Same("Linux / Kali Linux", 1)
            },
            SkillGroupKind.Bars),
        new(new("Ciberseguridad", "Cybersecurity"),
            new Skill[]
            {
                new(new("Linux y scripting", "Linux and scripting")),
                new(new("Redes", "Networking")),
                new(new("Resolución de retos (CTFs)", "Challenge solving (CTFs)")),
                new(new("Fundamentos de seguridad informática", "Information security fundamentals")),
                Skill.Same("Bash"),
                new(new("Git y GitHub", "Git and GitHub"))
            },
            SkillGroupKind.Chips),
        new(new("Cursos", "Courses"),
            new Skill[]
            {
                new(new("JavaScript desde Cero", "JavaScript from Scratch")),
                new(new("Introducción a la Ciberseguridad", "Introduction to Cybersecurity")),
                new(new("Introducción al Pentesting", "Introduction to Pentesting")),
                new(new("Administrador de Redes Linux y Ciberseguridad", "Linux Network Administrator and Cybersecurity")),
                Skill.Same("Full Ethical Hacking")
            },
            SkillGroupKind.Checklist),
        new(new("Idiomas", "Spoken languages"),
            new Skill[] { new(new("Inglés técnico", "Technical English")) },
            SkillGroupKind.Inline)
    };
}
