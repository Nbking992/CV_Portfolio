// Tema claro/oscuro. Se carga en <head>, antes del primer pintado, para evitar el parpadeo de color.
(function () {
    var root = document.documentElement;
    var META_COLORS = { dark: '#0b0f14', light: '#f7f9fb' };

    function stored() {
        try {
            var value = localStorage.getItem('theme');
            return value === 'light' || value === 'dark' ? value : null;
        } catch (e) {
            return null;
        }
    }

    function systemTheme() {
        return window.matchMedia && window.matchMedia('(prefers-color-scheme: light)').matches ? 'light' : 'dark';
    }

    function paintMeta(theme) {
        var meta = document.querySelector('meta[name="theme-color"]');
        if (meta) meta.setAttribute('content', META_COLORS[theme]);
    }

    // Si el usuario ya eligió un tema lo aplicamos ya mismo. Si no, el CSS decide con prefers-color-scheme.
    var saved = stored();
    if (saved) root.dataset.theme = saved;

    // API que usan los componentes Blazor (JS.InvokeAsync("cvTheme.getTheme"), etc.).
    window.cvTheme = {
        getTheme: function () {
            return stored() || systemTheme();
        },
        setTheme: function (theme) {
            root.dataset.theme = theme;
            try { localStorage.setItem('theme', theme); } catch (e) { /* sin almacenamiento: no persiste */ }
            paintMeta(theme);
        },
        setLang: function (lang) {
            root.lang = lang;
        }
    };

    paintMeta(window.cvTheme.getTheme());
})();
