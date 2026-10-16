using CvPortfolio.Core.Data;
using CvPortfolio.Core.Models;

namespace CvPortfolio.Core.Services;

public sealed class CvService : ICvService
{
    public Profile GetProfile() => CvData.Profile;

    /// <summary>Proyectos del más reciente al más antiguo.</summary>
    public IReadOnlyList<Project> GetProjects() =>
        CvData.Projects.OrderByDescending(p => p.Year).ThenBy(p => p.Id, StringComparer.Ordinal).ToList();

    /// <summary>Experiencia actual primero, luego por año de inicio descendente.</summary>
    public IReadOnlyList<Experience> GetExperiences() =>
        CvData.Experiences.OrderByDescending(e => e.IsCurrent).ThenByDescending(e => e.StartYear).ToList();

    public IReadOnlyList<Education> GetEducation() =>
        CvData.Education.OrderByDescending(e => e.StartYear).ToList();

    public IReadOnlyList<SkillGroup> GetSkills() => CvData.Skills;
}
