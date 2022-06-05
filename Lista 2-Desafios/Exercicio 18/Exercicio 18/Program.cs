Console.WriteLine("18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles");

int valorA,valorB,valorC;

Console.Write("Digite o primeiro valor: ");
valorA = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
valorB = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor: ");
valorC = int.Parse(Console.ReadLine());

if ((valorA > valorB) && (valorA > valorC))
{
    Console.WriteLine("Valor A é o maior");
}
else if ((valorB > valorA) && (valorB > valorC))
{
    Console.WriteLine("Valor B é o maior");
}
else
{
    Console.WriteLine("Valor C é o maior");
}