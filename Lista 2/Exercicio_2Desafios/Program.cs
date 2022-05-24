Console.WriteLine("2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.");

/// <summary>
/// Recebe o valor de um numero
/// </summary>
int num;




Console.Write(" Digite um numero: ");
num= int.Parse(Console.ReadLine());

if (num %2 == 0)
{
  Console.WriteLine("O numero é par");
}
else
{
    Console.WriteLine("O numero é impar");
}
        