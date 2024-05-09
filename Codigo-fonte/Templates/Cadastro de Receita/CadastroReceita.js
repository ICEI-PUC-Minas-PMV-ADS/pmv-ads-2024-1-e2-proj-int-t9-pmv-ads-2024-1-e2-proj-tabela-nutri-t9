const formIngrediente = document.getElementById('formIngrediente');
const listaIngredientes = document.getElementById('listaIngredientes').querySelector('ul');

formIngrediente.addEventListener('submit', function(event) {
    event.preventDefault();

    const nomeIngrediente = document.getElementById('nomeIngrediente').value;
    const quantidadeIngrediente = document.getElementById('quantidadeIngrediente').value;

    adicionarIngrediente(nomeIngrediente, quantidadeIngrediente);

    formIngrediente.reset();
});

function adicionarIngrediente(nomeIngrediente, quantidadeIngrediente) {
    const li = document.createElement('li');
    li.textContent = `${nomeIngrediente}: ${quantidadeIngrediente}`;

    const botaoRemover = document.createElement('button');
    botaoRemover.textContent = 'Remover';
    botaoRemover.addEventListener('click', function() {
        removerIngrediente(li);
    });

    li.appendChild(botaoRemover);
    listaIngredientes.appendChild(li);
}

function removerIngrediente(li) {
    listaIngredientes.removeChild(li);
}
