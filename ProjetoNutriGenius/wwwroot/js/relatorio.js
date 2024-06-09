criarTabela();

function criarTabela() {
    let tabelaDiv = document.querySelector('.tabela')

    let tabela = retornarTabela();

    let tabelaTratada = trocarValor(tabela, '{!porcao}', 150)

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

