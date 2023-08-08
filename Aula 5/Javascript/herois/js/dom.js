// pegando um elemento pela id

const getId1 = document.getElementById('heroi-um');
console.log(getId1);

const getId2 = document.querySelector('#heroi-um')

//Pegando pela classe CSS

const getClass = document.getElementsByClassName('nome')
console.log(getClass1)
console.log(getClass1[3])
console.log(getClass1[3].textContent);

const getClass2 = document.querySelectorAll('.nome')

// Pegando pela tag

const getTag1 = document.getElementsByTagName('td');
console.log(getTag1);