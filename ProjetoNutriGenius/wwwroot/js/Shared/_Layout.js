criarNav();

function criarNav() {
    let headerNav = document.querySelector('.cabecalho')

    let nav = retornarNav();

    let cabecalhoPronto = nav;

    headerNav.innerHTML = cabecalhoPronto;
};

function retornarNav() {

    return `<nav class="navbar">
    <a><img class="logo" src="/img/Logo.png" style="width: 150px; height: 30px;"></a>
    <ul class="menu">
        <li><a href="/Menu">Página Inicial</a></li>
        <li><a href="/Relatorio">Como usar?</a></li>
        <li><a href="#">Qual legislação vigente?</a></li>
        <li><a href="#">Sobre Nós</a></li>
        <li><a href="">Login</a></li>
    </ul>
    </nav>`
};


criarCopy();

function criarCopy() {
    let footerCopy = document.querySelector('.rodape')

    let copy = retornarCopy();

    let rodapePronto = copy;

    footerCopy.innerHTML = rodapePronto;
}

function retornarCopy() {

    return `<p>&copy; 2024 - NutriGenius</p>`
};
