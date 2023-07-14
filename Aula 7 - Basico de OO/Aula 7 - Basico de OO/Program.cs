using System.ComponentModel;
using Aula_7___Basico_de_OO;

List<Editora> lista = new Editora();
lista.Add(new Editora("Editora A", "site da Editora A", "site da editora A"));

Editora editora = new Editora();
editora.nome = "Editora B";
editora.site = "Site da Editora B";
editora.telefone = "Telefone da Editora B";
lista.Add(editora);

Editora editora1 = new Editora("Editora C", "site da Editora C", "telefone da Editora C");
lista.Remove(editora1);

// NÃO SEI ONDE BOTAR ISSO!
//public int id { get; set; }
//public string Nome { get; set; }

//List<Autor> autor = new List<Autor>();

//autor.Add(new autor("Autor A, função do Autor A, telefone do Autor A"));
//Lista.Add



//Livro livro = new Livro();

//Console.WriteLine("Insira o nome do usuário: ");
//livro.Nome = Console.ReadLine();
//Console.ReadLine(Livro.Nome);

//Console.WriteLine("Insira o resumo do usuário: ");
//livro.
