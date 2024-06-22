let produtoImpressao = JSON.parse(localStorage.getItem('produtoParaImpressao'));
criarTabela();
atualizarInfoGerais();

function criarTabela() {

    let tabelaDiv = document.querySelector('.tabela');

    let tabela = retornarTabela();

    let valorPorcaoEmb = produtoImpressao.porcaoEmb;

    let valorPorcao = produtoImpressao.porcao;

    let tabelaTratada = trocarValor(tabela, '{!porcaoEmb}', valorPorcaoEmb);
    tabelaTratada = trocarValor(tabelaTratada, '{!porcao}', valorPorcao);

    tabelaTratada = trocarValor(tabelaTratada, '{!kcal_c}', parseInt(100 * produtoImpressao.valorEnergetico / produtoImpressao.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!kcal_p}', parseInt(valorPorcao * produtoImpressao.valorEnergetico / produtoImpressao.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!kcal_vd}', parseInt(valorPorcao * produtoImpressao.valorEnergetico / produtoImpressao.quantidadeMP * 100 / 2000))

    tabelaTratada = trocarValor(tabelaTratada, '{!cho_c}', parseInt(100 * produtoImpressao.carboidratos / produtoImpressao.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!cho_p}', parseInt(valorPorcao * produtoImpressao.carboidratos / produtoImpressao.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!cho_vd}', parseInt(valorPorcao * produtoImpressao.carboidratos / produtoImpressao.quantidadeMP * 100 / 300))

    tabelaTratada = trocarValor(tabelaTratada, '{!act_c}', parseInt(100 * produtoImpressao.acucaresTotais / produtoImpressao.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!act_p}', parseInt(valorPorcao * produtoImpressao.acucaresTotais / produtoImpressao.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!act_vd}', "")

    tabelaTratada = trocarValor(tabelaTratada, '{!acd_c}', parseInt(100 * produtoImpressao.acucaresAdicionados / produtoImpressao.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!acd_p}', parseInt(valorPorcao * produtoImpressao.acucaresAdicionados / produtoImpressao.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!acd_vd}', parseInt(valorPorcao * produtoImpressao.acucaresAdicionados / produtoImpressao.quantidadeMP * 100 / 50))

    tabelaTratada = trocarValor(tabelaTratada, '{!ptn_c}', parseInt(100 * produtoImpressao.proteinas / produtoImpressao.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!ptn_p}', parseInt(valorPorcao * produtoImpressao.proteinas / produtoImpressao.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!ptn_vd}', parseInt(valorPorcao * produtoImpressao.proteinas / produtoImpressao.quantidadeMP * 100 / 50))

    tabelaTratada = trocarValor(tabelaTratada, '{!lip_c}', parseInt(100 * produtoImpressao.gordurasTotais / produtoImpressao.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!lip_p}', parseInt(valorPorcao * produtoImpressao.gordurasTotais / produtoImpressao.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!lip_vd}', parseInt(valorPorcao * produtoImpressao.gordurasTotais / produtoImpressao.quantidadeMP * 100 / 65))

    tabelaTratada = trocarValor(tabelaTratada, '{!sat_c}', parseFloat(100 * produtoImpressao.gordurasSaturadas / produtoImpressao.quantidadeMP).toFixed(1))
    tabelaTratada = trocarValor(tabelaTratada, '{!sat_p}', parseFloat(valorPorcao * produtoImpressao.gordurasSaturadas / produtoImpressao.quantidadeMP).toFixed(1));
    tabelaTratada = trocarValor(tabelaTratada, '{!sat_vd}', parseInt(valorPorcao * produtoImpressao.gordurasSaturadas / produtoImpressao.quantidadeMP * 100 / 20))

    tabelaTratada = trocarValor(tabelaTratada, '{!trans_c}', parseFloat(100 * produtoImpressao.gordurasTrans / produtoImpressao.quantidadeMP).toFixed(1));
    tabelaTratada = trocarValor(tabelaTratada, '{!trans_p}', parseFloat(valorPorcao * produtoImpressao.gordurasTrans / produtoImpressao.quantidadeMP).toFixed(1));
    tabelaTratada = trocarValor(tabelaTratada, '{!trans_vd}', parseInt(valorPorcao * produtoImpressao.gordurasTrans / produtoImpressao.quantidadeMP * 100 / 2))

    tabelaTratada = trocarValor(tabelaTratada, '{!fib_c}', parseInt(100 * produtoImpressao.fibraAlimentar / produtoImpressao.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!fib_p}', parseInt(valorPorcao * produtoImpressao.fibraAlimentar / produtoImpressao.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!fib_vd}', parseInt(valorPorcao * produtoImpressao.fibraAlimentar / produtoImpressao.quantidadeMP * 100 / 25))

    tabelaTratada = trocarValor(tabelaTratada, '{!sod_c}', parseInt(100 * produtoImpressao.sodio / produtoImpressao.quantidadeMP))
    tabelaTratada = trocarValor(tabelaTratada, '{!sod_p}', parseInt(valorPorcao * produtoImpressao.sodio / produtoImpressao.quantidadeMP));
    tabelaTratada = trocarValor(tabelaTratada, '{!sod_vd}', parseInt(valorPorcao * produtoImpressao.sodio / produtoImpressao.quantidadeMP * 100 / 2000))

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
                <td id='valorEnergeticoTabelaP'>{!kcal_p}</td>
                <td>{!kcal_vd}</td>
            </tr>
            <tr>
                <td class="td">Carboidratos (g)</td>
                <td>{!cho_c}</td>
                <td id='carboidratosTabelaP'>{!cho_p}</td>
                <td>{!cho_vd}</td>
            </tr>
            <tr>
                <td class="prima">Açúcares totais (g)</td>
                <td>{!act_c}</td>
                <td id='acucaresTotaisTabelaP'>{!act_p}</td>
                <td>{!act_vd}</td>
            </tr>
            <tr>
                <td class="secon">Açúcares adicionados (g)</td>
                <td>{!acd_c}</td>
                <td id='acucaresAdicionadosTabelaP'>{!acd_p}</td>
                <td>{!acd_vd}</td>
            </tr>
            <tr>
                <td class="td">Proteinas (g)</td>
                <td>{!ptn_c}</td>
                <td id='proteinasTabelaP'>{!ptn_p}</td>
                <td>{!ptn_vd}</td>
            </tr>
            <tr>
                <td class="td">Gorduras totais (g)</td>
                <td>{!lip_c}</td>
                <td id='gordurasTotaisTabelaP'>{!lip_p}</td>
                <td>{!lip_vd}</td>
            </tr>
            <tr>
                <td class="prima">Gorduras saturadas (g)</td>
                <td>{!sat_c}</td>
                <td id='gordurasSaturadasTabelaP'>{!sat_p}</td>
                <td>{!sat_vd}</td>
            </tr>
            <tr>
                <td class="prima">Gorduras trans (g)</td>
                <td>{!trans_c}</td>
                <td id='gordurasTransTabelaP'>{!trans_p}</td>
                <td>{!trans_vd}</td>
            </tr>
            <tr>
                <td class="td">Fibra alimentar (g)</td>
                <td>{!fib_c}</td>
                <td id='fibraAlimentarTabelaP'>{!fib_p}</td>
                <td>{!fib_vd}</td>
            </tr>
            <tr>
                <td class="td">Sódio (mg)</td>
                <td>{!sod_c}</td>
                <td id='sodioTabelaP'>{!sod_p}</td>
                <td>{!sod_vd}</td>
            </tr>
        </tbody>
    </table>
<hr class="hr2">
    <p>* Percentual de valores diários fornecidos pela porção.</p>
</section>
    `
}

function atualizarInfoGerais() {
    console.log(produtoImpressao)
    let nomeReceitaElement = document.querySelector('#nomeReceita');
    nomeReceitaElement.textContent = produtoImpressao.nomeReceita;
    let tipoElement = document.querySelector('#tipoMP');
    tipoElement.textContent = produtoImpressao.tipoMP == 'acabado' ? 'Produto Acabado' : 'Produto Semi-acabado';
    let porcaoElement = document.querySelector('#porcao');
    porcaoElement.textContent = produtoImpressao.porcao + ' g';
    let alergicosElement = document.querySelector('#alergicosRelatorio');
    alergicosElement.textContent = produtoImpressao.alergicos;
    let preparoElement = document.querySelector('#preparoRelatorio');
    preparoElement.textContent = produtoImpressao.modoPreparo;
    
}

function trocarValor(tabela, campo, valor) {

    let tabelaSub = tabela.replace(campo, isNaN(valor) ? '-' : valor)
    return tabelaSub;
}

