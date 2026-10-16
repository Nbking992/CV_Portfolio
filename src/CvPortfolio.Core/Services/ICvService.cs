using CvPortfolio.Core.Models;

namespace CvPortfolio.Core.Services;

public interface ICvService
{
    Profile GetProfile();
    IReadOnlyList<Project> GetProjects();
    IReadOnlyList<Experience> GetExperiences();
    IReadOnlyList<Education> GetEducation();
    IReadOnlyList<SkillGroup> GetSkills();
}
