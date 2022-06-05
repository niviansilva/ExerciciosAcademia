Console.WriteLine("10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).");
Console.WriteLine("O programa deve mostrar os dados do atleta mais novo e mais alto.");

string nome1, nome2;
int idade1, idade2;
float altura1, altura2;

Console.Write("Digite o nome do primeiro Atleta: ");
nome1 = Console.ReadLine();
Console.Write("Digita a idade: ");
idade1 = int.Parse(Console.ReadLine());
Console.Write("Digita a Altura do primeiro Atleta: ");
altura1 = float.Parse(Console.ReadLine());

Console.Write("Digite o nome do segundo Atleta: ");
nome2 = Console.ReadLine();
Console.Write("Digita a idade: ");
idade2 = int.Parse(Console.ReadLine());
Console.Write("Digita a Altura do segundo Atleta: ");
altura2 = float.Parse(Console.ReadLine());

if (idade1 < idade2)
{
    Console.WriteLine("O atleta mais novo é: " + nome1 + " com " + idade1 + " de idade");
}
else
{
    Console.WriteLine("O atleta mais novo é: " + nome2 + " com " + idade2 + " de idade");
}
if (altura2 > altura1)
{
    Console.WriteLine("O atleta mais alto é: " + nome2 + " com " + altura2 + " de altura");
}
else
{
    Console.WriteLine("O atleta mais alto é: " + nome1 + " com " + altura1 + " de altura");
}
