namespace CvPortfolio.Core.Models;

public sealed record Project(
    string Id,
    LocalizedText Name,
    LocalizedText Description,
    IReadOnlyList<string> Technologies,
    int Year,
    string? RepositoryUrl = null,
    string? DemoUrl = null);
