Console.WriteLine("6.Faça um programa que leia um número n e imprima se ele é primo ou não.");
//(um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!


int numero;

while (true)
{
    Console.Write("Digite um numero:");
    numero = int.Parse(Console.ReadLine());

       
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