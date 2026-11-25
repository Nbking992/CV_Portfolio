// Marca la sección que se está viendo en la barra superior (escritorio) y en la inferior (móvil).
(function () {
    var ALL = ['about', 'projects', 'experience', 'education', 'skills'];
    // En dos columnas, perfil y habilidades viven en la barra lateral, al lado del contenido.
    // Allí solo se siguen las secciones del contenido; «about» es lo que queda arriba del todo.
    var CONTENT = ['projects', 'experience', 'education'];
    var wide = window.matchMedia('(min-width: 960px)');
    var lockUntil = 0;
    var ticking = false;

    function navLinks() {
        return document.querySelectorAll('.top-nav a, .bottom-nav a');
    }

    function lineY() {
        var bar = document.querySelector('.topbar');
        // Un poco más que la altura de la barra: al llegar a un ancla (scroll-margin-top 76px) la sección ya cuenta como actual.
        return (bar ? bar.offsetHeight : 56) + 30;
    }

    function currentId() {
        var ids = wide.matches ? CONTENT : ALL;
        var y = lineY();
        var current = null;

        ids.forEach(function (id) {
            var el = document.getElementById(id);
            if (el && el.getBoundingClientRect().top <= y) current = id;
        });

        var atBottom = window.innerHeight + window.scrollY >= document.documentElement.scrollHeight - 2;
        if (atBottom && window.scrollY > 0) return ids[ids.length - 1];

        return current || 'about';
    }

    function mark(id) {
        navLinks().forEach(function (link) {
            var active = link.getAttribute('href') === '#' + id;
            link.classList.toggle('active', active);
            if (active) link.setAttribute('aria-current', 'location');
            else link.removeAttribute('aria-current');
        });
    }

    function update() {
        ticking = false;
        // Justo después de un clic el scroll suave todavía está en camino: respetamos lo que tocó la persona.
        if (Date.now() < lockUntil) return;
        mark(currentId());
    }

    function schedule() {
        if (ticking) return;
        ticking = true;
        window.requestAnimationFrame(update);
    }

    function init() {
        // Blazor renderiza el layout de forma asíncrona: reintentar hasta que exista.
        if (!document.querySelector('.top-nav a')) { setTimeout(init, 200); return; }

        window.addEventListener('scroll', schedule, { passive: true });
        window.addEventListener('resize', schedule);
        if (wide.addEventListener) wide.addEventListener('change', schedule);

        document.addEventListener('click', function (e) {
            var link = e.target.closest ? e.target.closest('.top-nav a, .bottom-nav a, .brand') : null;
            if (!link) return;
            var href = link.getAttribute('href') || '';
            if (href.charAt(0) !== '#') return;
            lockUntil = Date.now() + 900;
            mark(href.slice(1));
            setTimeout(schedule, 950);
        });

        update();
    }

    init();
})();
