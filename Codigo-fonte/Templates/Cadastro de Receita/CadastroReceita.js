function addMateria() {
    const materialList = document.getElementById('material-list');
    const newItem = document.createElement('div');
    newItem.classList.add('material-item');
    newItem.innerHTML = `
  <input class="nomeMP" type="text" name="nomeMP" placeholder="Nome da Matéria-Prima" required>
  <input class="quantidadeMP" type="number" name="quantidadeMP" placeholder="Quant. (Kg)" required>
  <button type="button" class="remove-btn" onclick="removeMateria(this)">Remover</button>
  <input type="number" name="" placeholder="Kcal" disabled id="">
  <input type="number" name="" placeholder="CHO" disabled id="">
  <input type="number" name="" placeholder="Açúc. Total" disabled id="">
  <input type="number" name="" placeholder="Açúc. Add." disabled id="">
  <input type="number" name="" placeholder="PTN" disabled id="">
  <input type="number" name="" placeholder="G. Totais" disabled id="">
  <input type="number" name="" placeholder="G. Sat." disabled id="">
  <input type="number" name="" placeholder="G.Trans" disabled id="">
  <input type="number" name="" placeholder="Fibra" disabled id="">
  <input type="number" name="" placeholder="Sódio" disabled id="">
    `;
    materialList.appendChild(newItem);
}

function removeMateria(button) {
    const itemToRemove = button.parentNode;
    itemToRemove.parentNode.removeChild(itemToRemove);
}

criarTabela();

function criarTabela() {
    let tabelaDiv = document.querySelector('.tabela')

    let tabela = retornarTabela();

    let tabelaTratada = trocarValor(tabela, '{!porcao}', 0)

    tabelaDiv.innerHTML = tabelaTratada;
}

function retornarTabela() {

    return `
    <section class="informacao">
    <h2>INFORMAÇÃO NUTRICIONAL</h2>
    <hr>
    <ul>
        <li>
            <span>Porções por embalagem: <span>000</span></span>
        </li>
        <li>
            <span>Porção: <span>{!porcao} g (medida caseira)</span></span>
        </li>
    </ul>
    <hr class="hr">
    <table>
        <thead>
            <tr>
                <th></th>
                <th>100 g</th>
                <th>Porção</th>
                <th>%VD*</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class="td">Valor energético (kcal)</td>
                <td>--</td>
                <td>--</td>
                <td>--</td>
            </tr>
            <tr>
                <td class="td">Carboidratos (g)</td>
                <td>--</td>
                <td>--</td>
                <td>--</td>
            </tr>
            <tr>
                <td class="prima">Açúcares totais (g)</td>
                <td>--</td>
                <td>--</td>
                <td>--</td>
            </tr>
            <tr>
                <td class="secon">Açúcares adicionados (g)</td>
                <td>--</td>
                <td>--</td>
                <td></td>
            </tr>
            <tr>
                <td class="td">Proteinas (g)</td>
                <td>--</td>
                <td>--</td>
                <td>--</td>
            </tr>
            <tr>
                <td class="td">Gorduras totais (g)</td>
                <td>--</td>
                <td>--</td>
                <td>--</td>
            </tr>
            <tr>
                <td class="prima">Gorduras saturadas (g)</td>
                <td>--</td>
                <td>--</td>
                <td>--</td>
            </tr>
            <tr>
                <td class="prima">Gorduras trans (g)</td>
                <td>--</td>
                <td>--</td>
                <td>--</td>
            </tr>
            <tr>
                <td class="td">Fibra alimentar (g)</td>
                <td>--</td>
                <td>--</td>
                <td>--</td>
            </tr>
            <tr>
                <td class="td">Sódio (mg)</td>
                <td>--</td>
                <td>--</td>
                <td>--</td>
            </tr>
        </tbody>
    </table>
<hr class="hr2">
    <p>* Percentual de valores diários fornecidos pela porção.</p>
</section>
    `
}

function trocarValor(tabela, campo, valor) {

    let tabelaSub = tabela.replace(campo, valor)
    return tabelaSub;
}