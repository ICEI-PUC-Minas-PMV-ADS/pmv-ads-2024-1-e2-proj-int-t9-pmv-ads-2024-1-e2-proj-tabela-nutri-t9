function addMaterial() {
    const materialList = document.getElementById('material-list');
    const newItem = document.createElement('div');
    newItem.classList.add('material-item');
    newItem.innerHTML = `
      <input type="text" name="materialName[]" placeholder="Nome da Matéria-Prima" required>
      <input type="number" name="materialQuantity[]" placeholder="Quantidade" required>
      <button type="button" class="remove-btn" onclick="removeMaterial(this)">Remover</button>
    `;
    materialList.appendChild(newItem);
  }
  
  function removeMaterial(button) {
    const itemToRemove = button.parentNode;
    itemToRemove.parentNode.removeChild(itemToRemove);
  }
  