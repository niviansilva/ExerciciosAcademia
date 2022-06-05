//•Escreva uma classe Pessoa contendo todos os atributos de uma pessoa. Faça métodos para apresentar os dados.

Pessoa P = new Pessoa();

Console.WriteLine("Digite o nome: ");
P.nome=Console.ReadLine();
//P.nome = "Daniel";

Console.WriteLine("Digite a data de nascimento: ");
P.dtnascimento= Console.ReadLine();
//P.dtnascimento = "02/04/1995";

Console.WriteLine("Digite o sexo: ");
P.sexo = Console.ReadLine();
//P.sexo = "masculino";

Console.WriteLine("Digite a altura: ");
P.altura =float.Parse( Console.ReadLine());
//P.altura = 1.85F;

Console.WriteLine("O nome da pessoa é:" +P.nome);
Console.WriteLine("A data de nascimento da pessoa é: " + P.dtnascimento);
Console.WriteLine("O sexo da pessoa é: " + P.sexo);
Console.WriteLine("A altura da pessoa é: "+ P.altura);

public class Pessoa
{
    public string nome;
    public string dtnascimento;
    public string sexo;
    public float altura;

    public string retornanome()
    {
        return nome;
    }

    public string retornadtnascimento()
    {
        return dtnascimento;
    }

    public string retornasexo()
    {
        return sexo;
    }

    public float retornaaltura()
    {
        return altura;
    }

}