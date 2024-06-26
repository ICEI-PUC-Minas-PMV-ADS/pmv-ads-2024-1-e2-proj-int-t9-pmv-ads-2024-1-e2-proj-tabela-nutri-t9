// script.js

function adicionarLinha() {
    var tipo = document.querySelector('input[name="tipo"]:checked').value;
    var tabela = document.getElementById('tabela');
    var novaLinha = tabela.insertRow(-1);
    var colunas = 13; // Número de colunas

    // Adiciona checkbox como a primeira célula da nova linha
    var checkbox = document.createElement('input');
    checkbox.type = 'checkbox';
    var cellCheckbox = novaLinha.insertCell(0);
    cellCheckbox.appendChild(checkbox);

    for (var i = 1; i < colunas; i++) {
        var novaCelula = novaLinha.insertCell(i);
        if (i === 2) {
            novaCelula.textContent = tipo;
            novaCelula.contentEditable = false;
        } else if (i === 1) {
            novaCelula.contentEditable = true;
            novaCelula.dataset.inputType = "text";
        } else {
            novaCelula.contentEditable = true;
            novaCelula.dataset.inputType = "number";
        }
    }
}

function excluirLinhas() {
    var modal = document.getElementById('modal');
    var confirmarBtn = document.getElementById('confirmar-exclusao');
    var cancelarBtn = document.getElementById('cancelar-exclusao');

    // Exibe o modal
    modal.style.display = "block";

    // Ação ao clicar em "Excluir"
    confirmarBtn.onclick = function() {
        modal.style.display = "none";
        // Lógica para excluir as linhas aqui
        excluirLinhasConfirmadas();
    }

    // Ação ao clicar em "Cancelar"
    cancelarBtn.onclick = function() {
        modal.style.display = "none";
    }

    // Ação ao clicar no botão "Fechar" do modal
    window.onclick = function(event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
}

function excluirLinhasConfirmadas() {
    var tabela = document.getElementById('tabela');
    var linhas = tabela.rows;

    // Percorre as linhas da tabela (começa de 1 para pular o cabeçalho)
    for (var i = 1; i < linhas.length; i++) {
        var linha = linhas[i];
        var checkbox = linha.cells[0].querySelector('input[type="checkbox"]');

        // Se o checkbox estiver marcado, remove a linha
        if (checkbox.checked) {
            tabela.deleteRow(i);
            i--; // Decrementa o contador para ajustar a exclusão de linha
        }
    }
}

// Verificar entrada para garantir que apenas letras são inseridas na coluna "Nome"
document.getElementById('tabela').addEventListener('input', function(event) {
    var target = event.target;
    if (target.dataset.inputType === "text") {
        target.textContent = target.textContent.replace(/[^a-zA-Z]/g, '');
    }
});


// Verificar entrada para garantir que apenas números são inseridos nas demais células
document.getElementById('tabela').addEventListener('input', function(event) {
    var target = event.target;
    if (target.dataset.inputType === "number") {
        target.textContent = target.textContent.replace(/\D/g, '');
    }
});
