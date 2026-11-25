using CvPortfolio.Core.Models;
using CvPortfolio.Core.Services;

namespace CvPortfolio.Tests.Services;

public class LanguageServiceTests
{
    [Fact]
    public void DefaultLanguage_IsSpanish()
    {
        Assert.Equal(Language.Es, new LanguageService().Current);
    }

    [Fact]
    public void Set_RaisesChanged_OnlyWhenLanguageDiffers()
    {
        var service = new LanguageService();
        var calls = 0;
        service.Changed += () => calls++;

        service.Set(Language.Es);
        service.Set(Language.En);

        Assert.Equal(1, calls);
    }

    [Fact]
    public void T_ReturnsTextForCurrentLanguage()
    {
        var service = new LanguageService();
        var text = new LocalizedText("hola", "hello");

        Assert.Equal("hola", service.T(text));
        service.Set(Language.En);
        Assert.Equal("hello", service.T(text));
    }

    [Fact]
    public void Label_UnknownKey_ReturnsKey()
    {
        Assert.Equal("zzz", new LanguageService().Label("zzz"));
    }

    [Theory]
    [InlineData("viewCv", "Ver CV", "View CV")]
    [InlineData("contactMe", "Contactame", "Contact me")]
    [InlineData("year", "año", "year")]
    [InlineData("years", "años", "years")]
    [InlineData("themeLight", "Cambiar a tema claro", "Switch to light theme")]
    [InlineData("themeDark", "Cambiar a tema oscuro", "Switch to dark theme")]
    [InlineData("nav.about", "sobre-mí", "about")]
    [InlineData("prompt.projects", "$ ls ./proyectos", "$ ls ./projects")]
    public void Label_NewKeys_AreTranslated(string key, string es, string en)
    {
        var service = new LanguageService();

        Assert.Equal(es, service.Label(key));
        service.Set(Language.En);
        Assert.Equal(en, service.Label(key));
    }

    [Theory]
    [InlineData("about")]
    [InlineData("projects")]
    [InlineData("experience")]
    [InlineData("education")]
    [InlineData("skills")]
    public void NavLabels_ExistForEverySection(string section)
    {
        var service = new LanguageService();

        Assert.NotEqual($"nav.{section}", service.Label($"nav.{section}"));
        Assert.NotEqual(section, service.Label(section));
    }
}
