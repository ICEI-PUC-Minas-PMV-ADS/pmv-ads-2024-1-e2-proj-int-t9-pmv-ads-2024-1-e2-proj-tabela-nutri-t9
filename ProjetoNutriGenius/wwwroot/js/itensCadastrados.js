$(document).ready(function () {
  $('.select2').select2();
});

carregarProdutos();

function printItensCadastrados(e) {
  console.log(e.parentElement);
  let paiElement = e.parentElement;
  let nomeReceita = paiElement.querySelector('#nomesMpFiltro').value;

  let listProdutosSalvos = JSON.parse(localStorage.getItem('listaProdutosSalvos'));
  let produtoSelecionado = {};
  listProdutosSalvos.forEach(element => {
    if(element.nomeReceita == nomeReceita)
      produtoSelecionado = element;
  });

  localStorage.setItem('produtoParaImpressao', JSON.stringify(produtoSelecionado));
  print((window.location.href = "/Relatorio"));
};


function carregarProdutos() {
  let produtosSalvos = JSON.parse(localStorage.getItem('listaProdutosSalvos'));

  let tabelaFake = document.querySelector('#material-list');

  for (let i = 0; i < produtosSalvos.length; i++) {
    const produtoSalvo = produtosSalvos[i];
    let novoItem = `
    <div class="material-item">
        <button type="button" id="add-btn" onclick="addMateria()">Editar</button>
        <button type="button" id="add-btn" onclick="printItensCadastrados(this)">Imprimir</button>

        <input value="${produtoSalvo.nomeReceita}" type="text" name="nomesMpFiltro" id="nomesMpFiltro" class="nomeMP"
            placeholder="Receita Cadastrada" disabled>

        <input value="${produtoSalvo.quantidadeMP}" class="infoNutri" type="text" name="quantidadeMP" placeholder="Quant. (g)" disabled>

        <input value="${produtoSalvo.valorEnergetico}" class="infoNutri" type="number" name="valorEnergetico" placeholder="Kcal" disabled id="">
        <input value="${produtoSalvo.carboidratos}" class="infoNutri" type="number" name="carboidratos" placeholder="CHO" disabled id="">
        <input value="${produtoSalvo.acucaresTotais}" class="infoNutri" type="number" name="acucaresTotais" placeholder="Açúc. Total" disabled
            id="">
        <input value="${produtoSalvo.acucaresAdicionados}" class="infoNutri" type="number" name="acucaresAdicionados" placeholder="Açúc. Add."
            disabled id="">
        <input value="${produtoSalvo.proteinas}" class="infoNutri" type="number" name="proteinas" placeholder="PTN" disabled id="">
        <input value="${produtoSalvo.gordurasTotais}" class="infoNutri" type="number" name="gordurasTotais" placeholder="G. Totais" disabled
            id="">
        <input value="${produtoSalvo.gordurasSaturadas}" class="infoNutri" type="number" name="gordurasSaturadas" placeholder="G. Sat." disabled
            id="">
        <input value="${produtoSalvo.gordurasTrans}" class="infoNutri" type="number" name="gordurasTrans" placeholder="G.Trans" disabled
            id="">
        <input value="${produtoSalvo.fibraAlimentar}" class="infoNutri" type="number" name="fibraAlimentar" placeholder="Fibra" disabled id="">
        <input value="${produtoSalvo.sodio}" class="infoNutri" type="number" name="sodio" placeholder="Sódio" disabled id="">
    </div>
    `
    tabelaFake.innerHTML += novoItem;
  }
}