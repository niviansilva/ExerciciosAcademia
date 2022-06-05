Console.WriteLine("7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.");
Console.WriteLine("O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por");
Console.WriteLine("exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.");

String Frase;
String Busca;

Console.Write("Digite uma frase qualquer: ");
Frase = Console.ReadLine();

Console.Write("Digite a palavra a ser buscada: ");
Busca = Console.ReadLine();

if ((int)Frase.IndexOf(Busca) < 0)
{
    Console.WriteLine("A palavra não se encontra na frase");
}
else
{
    Console.WriteLine("A palavra encontra-se na frase");
}