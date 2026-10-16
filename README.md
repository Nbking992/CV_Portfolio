# CvPortfolio

CV web bilingüe (ES/EN) hecho con **C# y Blazor WebAssembly**, publicable gratis en **GitHub Pages**.

## Estructura

```
CvPortfolio.sln
├── src/
│   ├── CvPortfolio.Core/      Lógica sin UI (reutilizable y testeable)
│   │   ├── Models/            Records: Project, Profile, Experience, LocalizedText...
│   │   ├── Data/CvData.cs     <- AQUÍ se edita el contenido del CV
│   │   └── Services/          ICvService, ILanguageService y sus implementaciones
│   └── CvPortfolio.Web/       Interfaz Blazor WebAssembly
│       ├── Layout/            MainLayout
│       ├── Pages/             Home
│       ├── Components/        ProjectCard, ProjectList, SkillList, LanguageSwitcher...
│       └── wwwroot/           index.html, css, 404.html, .nojekyll
├── tests/CvPortfolio.Tests/   Pruebas xUnit sobre Core
└── .github/workflows/         Deploy automático a GitHub Pages
```

## Cargar tus proyectos

Edita `src/CvPortfolio.Core/Data/CvData.cs` y agrega un `Project` a la lista `Projects`:

```csharp
new(
    Id: "mi-proyecto",
    Name: new("Mi proyecto", "My project"),
    Description: new("Qué hace (ES)", "What it does (EN)"),
    Technologies: new[] { "C#", "Blazor" },
    Year: 2026,
    RepositoryUrl: "https://github.com/usuario/mi-proyecto",
    DemoUrl: null),
```

También se editan ahí tu perfil, experiencia, educación y habilidades. Los datos de ejemplo
(nombre del GitHub, textos, etc.) son placeholders: reemplázalos.

## Ejecutar en local

Requiere [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

```bash
dotnet test
dotnet run --project src/CvPortfolio.Web
```

## Publicar en GitHub Pages

1. Crea un repo en GitHub y sube el código a la rama `main`.
2. En el repo: **Settings → Pages → Build and deployment → Source: GitHub Actions**.
3. Cada `git push` a `main` ejecuta los tests, publica el sitio y lo despliega.
4. Queda en `https://<usuario>.github.io/<repo>/` (o en la raíz si el repo se llama `<usuario>.github.io`).
   El workflow ajusta `<base href>` automáticamente.
