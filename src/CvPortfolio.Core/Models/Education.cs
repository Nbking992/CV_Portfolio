namespace CvPortfolio.Core.Models;

public sealed record Education(
    LocalizedText Title,
    string Institution,
    int StartYear,
    int? EndYear);
