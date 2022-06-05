Console.WriteLine("4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles.");
Console.WriteLine("Mostrar na tela qual dos professores tem o maior salário total.");

int horasProfessor1;
int horasProfessor2;

float ValorHoraProfessor1;
float ValorHoraProfessor2;

float SalarioTotalProfessor1;
float SalarioTotalProfessor2;


Console.Write("Digite a quantidade de horas do Primeiro Professor: ");
horasProfessor1 = int.Parse(Console.ReadLine());

Console.Write("Digite o valor da hora do Primeiro Professor: ");
ValorHoraProfessor1 = int.Parse(Console.ReadLine());


Console.Write("Digite a quantidade de horas do Segundo Professor: ");
horasProfessor2 = int.Parse(Console.ReadLine());

Console.Write("Digite o valor da hora do Segundo Professor: ");
ValorHoraProfessor2 = int.Parse(Console.ReadLine());

SalarioTotalProfessor1 = (ValorHoraProfessor1 * horasProfessor1);
SalarioTotalProfessor2 = (ValorHoraProfessor2 * horasProfessor2);

Console.WriteLine("");

if (SalarioTotalProfessor2 > SalarioTotalProfessor1)
{
    Console.WriteLine("o maior salario é do segundo professor que é de : " + SalarioTotalProfessor2);
}
else
{
    Console.WriteLine("o maior salario é do primeiro professor que é de : " + SalarioTotalProfessor1);
}