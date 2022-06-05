// See https://aka.ms/new-console-template for more information

using ClasseLivro;

Console.WriteLine("Estamos no nosso projeto que trabalharemos com livros!");

/*atributos
public string titulo;
public string autor;
public int paginas;
public int ano;
public int edicao;*/


String t, a;
int pag, ano, ed;

Console.WriteLine("Digte o titulo do livro:");
t = Console.ReadLine();
Console.WriteLine("Digite o autor do livro:");
a = Console.ReadLine();
Console.WriteLine("Digte a quantidade de páginas do livro:");
pag = int.Parse (Console.ReadLine());
Console.WriteLine("Digite o ano de lançamento do livro:");
ano = int.Parse (Console.ReadLine());
Console.WriteLine("Digite a edição do livro:");
ed = int.Parse (Console.ReadLine());


Livro l1 = new Livro(t, a, pag, ano, ed);
l1.apresentaInfoLivro();
