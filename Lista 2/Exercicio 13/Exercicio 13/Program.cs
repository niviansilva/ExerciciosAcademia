Console.WriteLine("13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule ");
Console.WriteLine("seu peso ideal, utilizando as seguintes fórmulas:");
Console.WriteLine("Para homens: (72.7 * h) - 58");
Console.WriteLine("Para mulheres: (62.1 * h) - 44.7");

double h, pesoIdeal;
string Sexo, mensagem;

Console.Write("Digite a altura: ");
h = double.Parse(Console.ReadLine());
Console.Write("Digite o sexo da pessoa (homem ou mulher): ");
Sexo = Console.ReadLine();

if (Sexo.ToLower() == "homem")
{
    pesoIdeal = (72.7 * h) - 58;
    mensagem = "O peso ideal deste homem é: " + pesoIdeal.ToString("00.00");
}
else if (Sexo.ToLower() == "mulher")
{
    pesoIdeal = (62.1 * h) - 44.7;
    mensagem = "O peso ideal desta mulher é: " + pesoIdeal.ToString("00.00");
}
else
{
    pesoIdeal = 0;
    mensagem = "Sexo não informado corretamente";
}

if (pesoIdeal > 0)
{
    Console.WriteLine(mensagem);
}

