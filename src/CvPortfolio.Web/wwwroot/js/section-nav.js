// Resalta en la barra inferior (móvil) la sección que se está viendo.
(function () {
    var ids = ['about', 'projects', 'experience', 'education', 'skills'];

    function init() {
        var links = document.querySelectorAll('.bottom-nav a');
        // Blazor renderiza el layout de forma asíncrona: reintentar hasta que exista.
        if (!links.length) { setTimeout(init, 300); return; }

        var io = new IntersectionObserver(function (entries) {
            entries.forEach(function (e) {
                if (!e.isIntersecting) return;
                links.forEach(function (l) {
                    l.classList.toggle('active', l.getAttribute('href') === '#' + e.target.id);
                });
            });
        }, { rootMargin: '-45% 0px -50% 0px' });

        ids.forEach(function (id) {
            var el = document.getElementById(id);
            if (el) io.observe(el);
        });
    }

    init();
})();
