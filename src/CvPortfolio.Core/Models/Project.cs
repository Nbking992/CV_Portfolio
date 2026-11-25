namespace CvPortfolio.Core.Models;

/// <param name="ImageUrl">Miniatura opcional. Si falta se muestra un placeholder tipo terminal.</param>
/// <param name="PreviewLines">Líneas del placeholder de terminal («usuario@host:~$ comando»). Si faltan se genera una por defecto.</param>
public sealed record Project(
    string Id,
    LocalizedText Name,
    LocalizedText Description,
    IReadOnlyList<string> Technologies,
    int Year,
    string? RepositoryUrl = null,
    string? DemoUrl = null,
    string? ImageUrl = null,
    IReadOnlyList<string>? PreviewLines = null);
