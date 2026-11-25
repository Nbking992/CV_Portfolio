using CvPortfolio.Core.Models;
using CvPortfolio.Core.Services;

namespace CvPortfolio.Tests.Services;

public class CvServiceTests
{
    private readonly CvService _service = new();

    [Fact]
    public void GetProjects_ReturnsMostRecentFirst()
    {
        var years = _service.GetProjects().Select(p => p.Year).ToList();
        Assert.Equal(years.OrderByDescending(y => y), years);
    }

    [Fact]
    public void GetProjects_HaveUniqueIds()
    {
        var ids = _service.GetProjects().Select(p => p.Id).ToList();
        Assert.Equal(ids.Count, ids.Distinct().Count());
    }

    [Fact]
    public void GetProjects_AllHaveTextInBothLanguages()
    {
        foreach (var p in _service.GetProjects())
        {
            Assert.False(string.IsNullOrWhiteSpace(p.Name.Es));
            Assert.False(string.IsNullOrWhiteSpace(p.Name.En));
            Assert.False(string.IsNullOrWhiteSpace(p.Description.Es));
            Assert.False(string.IsNullOrWhiteSpace(p.Description.En));
        }
    }

    [Fact]
    public void GetExperiences_PutsCurrentJobFirst()
    {
        var first = _service.GetExperiences().First();
        Assert.True(first.IsCurrent);
    }

    [Fact]
    public void GetExperiences_AllHaveBulletsInBothLanguages()
    {
        foreach (var e in _service.GetExperiences())
        {
            Assert.NotEmpty(e.Bullets);
            foreach (var b in e.Bullets)
            {
                Assert.False(string.IsNullOrWhiteSpace(b.Es));
                Assert.False(string.IsNullOrWhiteSpace(b.En));
            }
        }
    }

    [Fact]
    public void GetProfile_HasShortSummaryAndTagsInBothLanguages()
    {
        var profile = _service.GetProfile();

        Assert.False(string.IsNullOrWhiteSpace(profile.ShortSummary.Es));
        Assert.False(string.IsNullOrWhiteSpace(profile.ShortSummary.En));
        Assert.NotNull(profile.Tags);
        Assert.NotEmpty(profile.Tags!);
        foreach (var t in profile.Tags!)
        {
            Assert.False(string.IsNullOrWhiteSpace(t.Es));
            Assert.False(string.IsNullOrWhiteSpace(t.En));
        }
    }

    [Fact]
    public void GetSkills_AllSkillsHaveNameInBothLanguages()
    {
        foreach (var skill in _service.GetSkills().SelectMany(g => g.Skills))
        {
            Assert.False(string.IsNullOrWhiteSpace(skill.Name.Es));
            Assert.False(string.IsNullOrWhiteSpace(skill.Name.En));
        }
    }

    [Fact]
    public void GetSkills_BarGroupsOnlyContainSkillsWithPositiveYears()
    {
        var barGroups = _service.GetSkills().Where(g => g.Kind == SkillGroupKind.Bars).ToList();

        Assert.NotEmpty(barGroups);
        foreach (var skill in barGroups.SelectMany(g => g.Skills))
        {
            Assert.NotNull(skill.Years);
            Assert.True(skill.Years > 0);
        }
    }
}
