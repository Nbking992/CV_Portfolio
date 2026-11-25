namespace CvPortfolio.Core.Models;

public sealed record SkillGroup(
    LocalizedText Name,
    IReadOnlyList<Skill> Skills,
    SkillGroupKind Kind = SkillGroupKind.Chips);
