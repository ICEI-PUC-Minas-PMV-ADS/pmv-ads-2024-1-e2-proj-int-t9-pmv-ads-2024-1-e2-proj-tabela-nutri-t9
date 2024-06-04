criarNav();

function criarNav() {
    let headerNav = document.querySelector('.cabecalho')

    let nav = retornarNav();

    let cabecalhoPronto = nav;

    headerNav.innerHTML = cabecalhoPronto;
};

function retornarNav() {

    return `<nav class="navbar">
    <a> <img class="logo" src="/docs/img/Logo.png"></a>
    <ul class="menu">
        <li><a href="#">Página Inicial</a></li>
        <li><a href="#">Como usar?</a></li>
        <li><a href="#">Qual legislação vigente?</a></li>
        <li><a href="#">Sobre Nós</a></li>
        <li><a href="../Usuario/CadastroUsuario.cshtml">Login</a></li>
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
