
Console.WriteLine("6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados");
Console.WriteLine("ou seja, repita a leitura até que ela esteja correta(maior do que zero).");
Console.WriteLine("Ao final, mostre a idade digitada.");


int idade;
Boolean continuawhile =true;


while (continuawhile)
{
    Console.Write("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());

    if(idade <= 0)
    {
        Console.WriteLine("Idade inválida");
        continuawhile =true;
    }
    else
    {
        Console.WriteLine("A idade é: " + idade + " anos.");
        continuawhile =false;
        break;
    }

}

