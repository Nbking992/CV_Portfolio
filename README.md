# CvPortfolio

CV web bilingüe (ES/EN) hecho con **C# y Blazor WebAssembly**, publicable gratis en **GitHub Pages**.

## Estructura

```
CvPortfolio.sln
├── src/
│   ├── CvPortfolio.Core/      Lógica sin UI (reutilizable y testeable)
│   │   ├── Models/            Records: Project, Profile, Experience, LocalizedText...
│   │   └── Services/          ICvService, ILanguageService y sus implementaciones
│   └── CvPortfolio.Web/       Interfaz Blazor WebAssembly
│       ├── Layout/            MainLayout
│       ├── Pages/             Home
│       ├── Components/        ProjectCard, ProjectList, SkillList, LanguageSwitcher...
│       └── wwwroot/           index.html, css, 404.html, .nojekyll
├── tests/CvPortfolio.Tests/   Pruebas xUnit sobre Core
└── .github/workflows/         Deploy automático a GitHub Pages
```


