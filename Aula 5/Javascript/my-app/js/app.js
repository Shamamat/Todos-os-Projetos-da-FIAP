const tbody = document.querySelector('tbody');

// pegar o formulário e atribuir um listened para o evento submit
// Executar a função que está sendo criada e depois o evento submit vai ser cancelado

document.querySelector('form').addEventListener('submit', function(event){

    // cancelar o evento
    event.preventDefault();

    // recuperar os campos do formulário
    const campos = [
        document.querySelector('#usuario'),
        document.querySelector('#email'),
        document.querySelector('#dataCadastro'),
        document.querySelector('#tipoConta')
    ];

    // console.log(campos)

    // Criando a tr que reberá as colunas digitadas com os dados digitados

    const tr = document.createElement('tr')

    // Percorrer cada campo  e criar uma td

    campos.forEach(campo => {
        
        const td = document.createElement('td');

        // colocar na td o conteúdo do campo
        td.textContent = campo.value;

        // vincular tr na td
        tr.appendChild(td);
    });

    // Vincular tr dentro do tbody

    tbody.appendChild(tr);

    // Limpar o formulário
    this.reset();

})

