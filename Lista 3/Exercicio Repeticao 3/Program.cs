Console.WriteLine("3.Fazer um laço(repetição) que fique solicitando números ao usuário.\n" +
"Se o usuário digitar 0 o programa em VS deve parar. \n" +
"Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.");


int numero;

while (true)
{
    Console.Write("Digite um numero:");
    numero=int.Parse(Console.ReadLine());

    if(numero == 0)
    {
        break;
    }

    if(numero % 2 == 0)
    {
        Console.WriteLine("É um numero par");

    }
    else
    {
        Console.WriteLine("É um numero impar");
    }
    int cont = 1;
    for (int i = 1; i < numero; i++)
    {
        if (numero % i == 0)
        {
            cont = cont + 1;
        }
    }
    if (cont == 2)
    {
        Console.WriteLine("O numero é primo");
    }
    else
    {
        Console.WriteLine("O numero não é primo");
    }
}
