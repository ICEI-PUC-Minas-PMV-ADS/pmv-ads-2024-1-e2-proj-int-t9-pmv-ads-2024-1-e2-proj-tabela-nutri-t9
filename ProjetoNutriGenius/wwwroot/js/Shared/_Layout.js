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
        <li><a href="/Home">Página Inicial</a></li>
        <li><a href="/Menu">Menu Principal</a></li>
        <li><a href="#">Como usar?</a></li>
        <li><a href="/Legislacao">Qual legislação vigente?</a></li>
        <li><a href="/SobreNos">Sobre Nós</a></li>
        <li><a href="/Login">Login</a></li>
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
