namespace CvPortfolio.Core.Models;

public sealed record Experience(
    LocalizedText Role,
    string Company,
    int StartYear,
    int? EndYear,
    LocalizedText Description)
{
    public bool IsCurrent => EndYear is null;
}
