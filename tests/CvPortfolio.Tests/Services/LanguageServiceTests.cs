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
}
