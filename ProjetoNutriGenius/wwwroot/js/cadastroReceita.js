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


    let inputs = newItem.querySelectorAll("input");

    for (let i = 0; i < inputs.length; i++) {
        const element = inputs[i];

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

        if (!isNaN(element.value) && element.name != 'quantidadeMP') {
            element.value *= quantidadeMP / 100;
            element.value = parseFloat(element.value).toFixed(2)
        }
    }
}

function pegarMateriasAdd() {
    const materialList = document.querySelector('#material-list');

    let info = {
        quantidadeMP: 0,
        valorEnergetico: 0,
        carboidratos: 0,
        acucaresTotais: 0,
        acucaresAdicionados: 0,
        proteinas: 0,
        gordurasTotais: 0,
        gordurasSaturadas: 0,
        gordurasTrans: 0,
        fibraAlimentar: 0,
        sodio: 0,
    }

    for (let i = 3; i < materialList.childNodes.length; i++) {
        const element1 = materialList.childNodes[i];

        console.log(element1);

        let inputs = element1.querySelectorAll("input");

        for (let i = 0; i < inputs.length; i++) {
            let element = inputs[i];

            if (element.name == 'quantidadeMP') {
                info.quantidadeMP += parseFloat(element.value);
            }
            if (element.name == 'valorEnergetico') {
                info.valorEnergetico += parseFloat(element.value);
            }
            if (element.name == 'carboidratos') {
                info.carboidratos += parseFloat(element.value);
            }
            if (element.name == 'acucaresTotais') {
                info.acucaresTotais += parseFloat(element.value);
            }
            if (element.name == 'acucaresAdicionados') {
                info.acucaresAdicionados += parseFloat(element.value);
            }
            if (element.name == 'proteinas') {
                info.proteinas += parseFloat(element.value);
            }
            if (element.name == 'gordurasTotais') {
                info.gordurasTotais += parseFloat(element.value);
            }
            if (element.name == 'gordurasSaturadas') {
                info.gordurasSaturadas += parseFloat(element.value);
            }
            if (element.name == 'gordurasTrans') {
                info.gordurasTrans += parseFloat(element.value);
            }
            if (element.name == 'fibraAlimentar') {
                info.fibraAlimentar += parseFloat(element.value);
            }
            if (element.name == 'sodio') {
                info.sodio += parseFloat(element.value);
            }
        }

    }
    console.log(info);

    return info

}

function removeMateria(button) {
    const itemToRemove = button.parentNode;
    itemToRemove.parentNode.removeChild(itemToRemove);
}

function criarTabela() {

    let tabelaDiv = document.querySelector('.tabela').children[0];

    let valorPorcaoEmb = document.querySelector('#porcaoEmb').value;

    let valorPorcao = document.querySelector('#porcao').value;

    let tabela = retornarTabela();

    let infoSoma = pegarMateriasAdd();

    let tabelaTratada = trocarValor(tabela, '{!porcaoEmb}', valorPorcaoEmb);
    tabelaTratada = trocarValor(tabelaTratada, '{!porcao}', valorPorcao);

    tabelaTratada = trocarValor(tabelaTratada, '{!kcal_c}', parseInt(100 * infoSoma.valorEnergetico / infoSoma.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!kcal_p}', parseInt(valorPorcao * infoSoma.valorEnergetico / infoSoma.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!kcal_vd}', parseInt(valorPorcao * infoSoma.valorEnergetico / infoSoma.quantidadeMP * 100 / 2000))

    tabelaTratada = trocarValor(tabelaTratada, '{!cho_c}', parseInt(100 * infoSoma.carboidratos / infoSoma.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!cho_p}', parseInt(valorPorcao * infoSoma.carboidratos / infoSoma.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!cho_vd}', parseInt(valorPorcao * infoSoma.carboidratos / infoSoma.quantidadeMP * 100 / 300))

    tabelaTratada = trocarValor(tabelaTratada, '{!act_c}', parseInt(100 * infoSoma.acucaresTotais / infoSoma.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!act_p}', parseInt(valorPorcao * infoSoma.acucaresTotais / infoSoma.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!act_vd}', "")

    tabelaTratada = trocarValor(tabelaTratada, '{!acd_c}', parseInt(100 * infoSoma.acucaresAdicionados / infoSoma.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!acd_p}', parseInt(valorPorcao * infoSoma.acucaresAdicionados / infoSoma.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!acd_vd}', parseInt(valorPorcao * infoSoma.acucaresAdicionados / infoSoma.quantidadeMP * 100 / 50))

    tabelaTratada = trocarValor(tabelaTratada, '{!ptn_c}', parseInt(100 * infoSoma.proteinas / infoSoma.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!ptn_p}', parseInt(valorPorcao * infoSoma.proteinas / infoSoma.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!ptn_vd}', parseInt(valorPorcao * infoSoma.proteinas / infoSoma.quantidadeMP * 100 / 50))

    tabelaTratada = trocarValor(tabelaTratada, '{!lip_c}', parseInt(100 * infoSoma.gordurasTotais / infoSoma.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!lip_p}', parseInt(valorPorcao * infoSoma.gordurasTotais / infoSoma.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!lip_vd}', parseInt(valorPorcao * infoSoma.gordurasTotais / infoSoma.quantidadeMP * 100 / 65))

    tabelaTratada = trocarValor(tabelaTratada, '{!sat_c}', parseFloat(100 * infoSoma.gordurasSaturadas / infoSoma.quantidadeMP).toFixed(1))
    tabelaTratada = trocarValor(tabelaTratada, '{!sat_p}', parseFloat(valorPorcao * infoSoma.gordurasSaturadas / infoSoma.quantidadeMP).toFixed(1));
    tabelaTratada = trocarValor(tabelaTratada, '{!sat_vd}', parseInt(valorPorcao * infoSoma.gordurasSaturadas / infoSoma.quantidadeMP * 100 / 20))

    tabelaTratada = trocarValor(tabelaTratada, '{!trans_c}', parseFloat(100 * infoSoma.gordurasTrans / infoSoma.quantidadeMP).toFixed(1));
    tabelaTratada = trocarValor(tabelaTratada, '{!trans_p}', parseFloat(valorPorcao * infoSoma.gordurasTrans / infoSoma.quantidadeMP).toFixed(1));
    tabelaTratada = trocarValor(tabelaTratada, '{!trans_vd}', parseInt(valorPorcao * infoSoma.gordurasTrans / infoSoma.quantidadeMP * 100 / 2))

    tabelaTratada = trocarValor(tabelaTratada, '{!fib_c}', parseInt(100 * infoSoma.fibraAlimentar / infoSoma.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!fib_p}', parseInt(valorPorcao * infoSoma.fibraAlimentar / infoSoma.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!fib_vd}', parseInt(valorPorcao * infoSoma.fibraAlimentar / infoSoma.quantidadeMP * 100 / 25))

    tabelaTratada = trocarValor(tabelaTratada, '{!sod_c}', parseInt(100 * infoSoma.sodio / infoSoma.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!sod_p}', parseInt(valorPorcao * infoSoma.sodio / infoSoma.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!sod_vd}', parseInt(valorPorcao * infoSoma.sodio / infoSoma.quantidadeMP * 100 / 2000))

    tabelaDiv.innerHTML = tabelaTratada;
}

function retornarTabela() {

    return `
    <section class="informacao">
    <h2>INFORMAÇÃO NUTRICIONAL</h2>
    <hr>
    <ul>
        <li>
            <span>Porções por embalagem: <span>{!porcaoEmb}</span></span>
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
                <td>{!kcal_c}</td>
                <td>{!kcal_p}</td>
                <td>{!kcal_vd}</td>
            </tr>
            <tr>
                <td class="td">Carboidratos (g)</td>
                <td>{!cho_c}</td>
                <td>{!cho_p}</td>
                <td>{!cho_vd}</td>
            </tr>
            <tr>
                <td class="prima">Açúcares totais (g)</td>
                <td>{!act_c}</td>
                <td>{!act_p}</td>
                <td>{!act_vd}</td>
            </tr>
            <tr>
                <td class="secon">Açúcares adicionados (g)</td>
                <td>{!acd_c}</td>
                <td>{!acd_p}</td>
                <td>{!acd_vd}</td>
            </tr>
            <tr>
                <td class="td">Proteinas (g)</td>
                <td>{!ptn_c}</td>
                <td>{!ptn_p}</td>
                <td>{!ptn_vd}</td>
            </tr>
            <tr>
                <td class="td">Gorduras totais (g)</td>
                <td>{!lip_c}</td>
                <td>{!lip_p}</td>
                <td>{!lip_vd}</td>
            </tr>
            <tr>
                <td class="prima">Gorduras saturadas (g)</td>
                <td>{!sat_c}</td>
                <td>{!sat_p}</td>
                <td>{!sat_vd}</td>
            </tr>
            <tr>
                <td class="prima">Gorduras trans (g)</td>
                <td>{!trans_c}</td>
                <td>{!trans_p}</td>
                <td>{!trans_vd}</td>
            </tr>
            <tr>
                <td class="td">Fibra alimentar (g)</td>
                <td>{!fib_c}</td>
                <td>{!fib_p}</td>
                <td>{!fib_vd}</td>
            </tr>
            <tr>
                <td class="td">Sódio (mg)</td>
                <td>{!sod_c}</td>
                <td>{!sod_p}</td>
                <td>{!sod_vd}</td>
            </tr>
        </tbody>
    </table>
<hr class="hr2">
    <p>* Percentual de valores diários fornecidos pela porção.</p>
</section>
    `
}

function atualizarTab() {

    let tabelaDiv = document.querySelector('.tabela');
    let tabela = tabelaDiv.children[0]
    tabela.remove()
    tabelaDiv.append(document.createElement('div'))

    criarTabela()

}

function trocarValor(tabela, campo, valor) {

    let tabelaSub = tabela.replace(campo, isNaN(valor) ? '-' : valor)
    return tabelaSub;
}

function filtrarMP() {
    const selectElement = document.getElementById('nomesMpFiltro');
    selectElement.innerHTML = '';

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


}