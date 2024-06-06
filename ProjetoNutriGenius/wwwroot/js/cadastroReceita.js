$(document).ready(function () {
    $('.select2').select2();
});

let todasMps = [];
filtrarMP()
criarTabela();

function addMateria() {
    const materialList = document.getElementById('material-list');
    const newItem = document.createElement('div');
    newItem.classList.add('material-item');
    newItem.innerHTML = `
  <input class="nomeMP" type="text" name="nomeMP" disabled id="">
  <input class="quantidadeMP" type="number" name="quantidadeMP" disabled id="">
  <button type="button" class="remove-btn" onclick="removeMateria(this)">Remover</button>
  <input class="infoNutri" type="number" name="valorEnergetico" placeholder="Kcal" disabled id="">
  <input class="infoNutri" type="number" name="carboidratos" placeholder="CHO" disabled id="">
  <input class="infoNutri" type="number" name="acucaresTotais" placeholder="Açúc. Total" disabled id="">
  <input class="infoNutri" type="number" name="acucaresAdicionados" placeholder="Açúc. Add." disabled id="">
  <input class="infoNutri" type="number" name="proteinas" placeholder="PTN" disabled id="">
  <input class="infoNutri" type="number" name="gordurasTotais" placeholder="G. Totais" disabled id="">
  <input class="infoNutri" type="number" name="gordurasSaturadas" placeholder="G. Sat." disabled id="">
  <input class="infoNutri" type="number" name="gordurasTrans" placeholder="G.Trans" disabled id="">
  <input class="infoNutri" type="number" name="fibraAlimentar" placeholder="Fibra" disabled id="">
  <input class="infoNutri" type="number" name="sodio" placeholder="Sódio" disabled id="">
    `;
    materialList.appendChild(newItem);

    let mpFiltrada = {};
    let mpSelecionado = document.getElementById('nomesMpFiltro').value;
    let quantidadeMP = document.querySelector("input[name='quantidadeMP']").value;
    todasMps.forEach((mp) => {
        if (mpSelecionado == mp.nomeMateriaPrima) {
            mpFiltrada = mp;
        }
    });

    console.log(mpFiltrada);

    let inputs = newItem.querySelectorAll("input");

    for (let i = 0; i < inputs.length; i++) {
        const element = inputs[i];
        console.log(element.name);
        if (element.name == 'nomeMP') {
            element.value = mpFiltrada.nomeMateriaPrima;
        }
        if (element.name == 'quantidadeMP') {
            element.value = quantidadeMP;
        }
        if (element.name == 'valorEnergetico') {
            element.value = mpFiltrada.valorEnergetico;
        }
        if (element.name == 'carboidratos') {
            element.value = mpFiltrada.carboidratos;
        }
        if (element.name == 'acucaresTotais') {
            element.value = mpFiltrada.acucaresTotais;
        }
        if (element.name == 'acucaresAdicionados') {
            element.value = mpFiltrada.acucaresAdicionados;
        }
        if (element.name == 'proteinas') {
            element.value = mpFiltrada.proteinas;
        }
        if (element.name == 'gordurasTotais') {
            element.value = mpFiltrada.gordurasTotais;
        }
        if (element.name == 'gordurasSaturadas') {
            element.value = mpFiltrada.gordurasSaturadas;
        }
        if (element.name == 'gordurasTrans') {
            element.value = mpFiltrada.gordurasTrans;
        }
        if (element.name == 'fibraAlimentar') {
            element.value = mpFiltrada.fibraAlimentar;
        }
        if (element.name == 'sodio') {
            element.value = mpFiltrada.sodio;
        }

        if (!isNaN(element.value) && element.name != 'quantidadeMP')
            element.value *= quantidadeMP / 100;
    }
}

function removeMateria(button) {
    const itemToRemove = button.parentNode;
    itemToRemove.parentNode.removeChild(itemToRemove);
}

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

function filtrarMP() {
    const selectElement = document.getElementById('nomesMpFiltro');
    selectElement.innerHTML = '';
    //let nomeFiltrado = document.getElementById('nomeMP').value;

    //console.log("nomeMP",nomeFiltrado);


    let options = [];
    fetch('http://localhost:5292/api/materia_prima', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then((resp) => resp.json())
        .then((mps) => {

            todasMps = mps;

            mps.forEach((mp) => {
                options.push(mp.nomeMateriaPrima);
            });

            options.forEach(optionText => {
                const optionElement = document.createElement('option');
                optionElement.value = optionText;
                optionElement.textContent = optionText;
                selectElement.appendChild(optionElement);
            });


        });

    console.log(options);




}