namespace CvPortfolio.Core.Models;

/// <param name="Summary">Resumen completo.</param>
/// <param name="ShortSummary">Versión corta, para la tarjeta de perfil.</param>
/// <param name="Tags">Etiquetas tipo hashtag (se muestran con «#» delante).</param>
/// <param name="PhotoUrl">Foto opcional; si falta se muestra un monograma con las iniciales.</param>
public sealed record Profile(
    string FullName,
    LocalizedText Headline,
    LocalizedText Summary,
    LocalizedText ShortSummary,
    string Email,
    string Location,
    string? GitHubUrl = null,
    string? LinkedInUrl = null,
    IReadOnlyList<LocalizedText>? Tags = null,
    string? PhotoUrl = null);
