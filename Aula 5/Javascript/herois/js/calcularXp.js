const botao = document.querySelector('#calcular');

console.log(botao)

// Atribuir função quando for pressionado

botao.addEventListener('click', () => {
    // Corpo da função
    const herois = document.querySelectorAll('.heroi');

    herois.forEach(heroi => {

        const forca = Number(heroi.querySelector('.forca').textContent);
        const velocidade = Number(heroi.querySelector('.velocidade').textContent);
        const agilidade = Number(heroi.querySelector('.agilidade').textContent);

        const xpFinal = (forca + velocidade + agilidade)/3

        heroi.querySelector('.xp').textContent = parseInt(xpFinal);

        // colocar linha vermelha no herói com xp menor que 80

        if(xpFinal < 80){
            heroi.classList.add('bg-danger', 'text-light')
        }
    })
})