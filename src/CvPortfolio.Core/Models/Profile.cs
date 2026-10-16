namespace CvPortfolio.Core.Models;

public sealed record Profile(
    string FullName,
    LocalizedText Headline,
    LocalizedText Summary,
    string Email,
    string Location,
    string? GitHubUrl = null,
    string? LinkedInUrl = null);
