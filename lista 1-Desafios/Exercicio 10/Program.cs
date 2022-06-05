// See https://aka.ms/new-console-template for more information
Console.WriteLine("10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo");
Console.WriteLine ("para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que");
Console.WriteLine("realizou o saque.Um possível critério seria o da “distribuição ótima” no sentido de que as");
Console.WriteLine("notas de menor valor fossem distribuídas em número mínimo possível.");
Console.WriteLine("Por exemplo, se a quantia solicitada fosse R$ 87, 00 o programa deveria indicar uma nota de R$ 50, 00");
Console.WriteLine("três notas de R$ 10, 00, uma nota de R$ 5, 00 e duas notas de R$ 1, 00.");
Console.WriteLine("Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas");
Console.WriteLine("de acordo com o critério da “distribuição ótima”.");


/// <summary>
/// armazena a quantidade de notas de 200
/// </summary>
int quantidadeNotas200;

/// <summary>
/// armazena a quantidade de notas de 100
/// </summary>
int quantidadeNotas100;

/// <summary>
/// armazena a quantidade de notas de 50
/// </summary>
int quantidadeNotas50;

/// <summary>
/// armazena a quantidade de notas de 20
/// </summary>
int quantidadeNotas20;

/// <summary>
/// armazena a quantidade de notas de 10
/// </summary>
int quantidadeNotas10;

/// <summary>
///  amazena a quantidade de notas de 5
/// </summary>
int quantidadeNotas5;



/// <summary>
/// variavel recebida para o valor do saque
/// </summary>
int valorSaque;

/// <summary>
/// armazena a sobra da divisao
/// </summary>
int sobra;



Console.Write("Quanto deseja sacar?  [ Notas: 5 , 10 , 20 , 50, 100 e 200]");
valorSaque = int.Parse(Console.ReadLine());


quantidadeNotas200 = (int)valorSaque / 200;
sobra = (int)valorSaque % 200;

quantidadeNotas100 = (int)sobra / 100;
sobra = (int)sobra % 100;

quantidadeNotas50 = (int)sobra / 50;
sobra = (int)sobra % 50;

quantidadeNotas20 = (int)sobra / 20;
sobra = (int)sobra % 20;

quantidadeNotas10 = (int)sobra / 10;
sobra = (int)sobra % 10;

quantidadeNotas5 = (int)sobra / 5;
sobra = (int)sobra % 5;


if (sobra != 0)
{
    Console.WriteLine("Saque Impossibilitado [ Notas: 5 , 10 , 20 , 50, 100 e 200]");
}

else
{



    Console.WriteLine("Quantidade de notas de 200: " + quantidadeNotas200);

    Console.WriteLine("Quantidade de notas de 100: " + quantidadeNotas100);

    Console.WriteLine("Quantidade de notas de 50: " + quantidadeNotas50);

    Console.WriteLine("Quantidade de notas de 20: " + quantidadeNotas20);

    Console.WriteLine("Quantidade de notas de 10: " + quantidadeNotas10);

    Console.WriteLine("Quantidade de notas de 5: " + quantidadeNotas5);

}




