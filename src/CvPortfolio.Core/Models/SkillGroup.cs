namespace CvPortfolio.Core.Models;

public sealed record SkillGroup(LocalizedText Name, IReadOnlyList<string> Skills);
