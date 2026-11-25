namespace CvPortfolio.Core.Models;

/// <summary>Cómo se presenta un grupo de habilidades en la interfaz.</summary>
public enum SkillGroupKind
{
    /// <summary>Barras de progreso según los años de experiencia.</summary>
    Bars,

    /// <summary>Chips con borde.</summary>
    Chips,

    /// <summary>Lista vertical con tilde.</summary>
    Checklist,

    /// <summary>Una sola línea: «nombre: valores».</summary>
    Inline
}
