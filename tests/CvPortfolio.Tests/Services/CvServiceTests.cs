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
}
