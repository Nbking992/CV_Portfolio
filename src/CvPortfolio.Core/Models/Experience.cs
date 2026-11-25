namespace CvPortfolio.Core.Models;

public sealed record Experience(
    LocalizedText Role,
    string Company,
    int StartYear,
    int? EndYear,
    IReadOnlyList<LocalizedText> Bullets)
{
    public bool IsCurrent => EndYear is null;
}
