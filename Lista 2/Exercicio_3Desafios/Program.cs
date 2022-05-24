
Console.WriteLine("3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média,\n" +
    " e escrever na tela os que são superiores à média.");

/// <summary>
/// Armazena o valor do primeiro numero
/// </summary>
int val1;

/// <summary>
/// armazena o valor do segundo numero
/// </summary>
int val2;

/// <summary>
/// armazena o valor do terceiro numero
/// </summary>
int val3;

/// <summary>
/// armazena o valor do quarto numero
/// </summary>
int val4;

/// <summary>
/// armazena o valor da media entre os quatro numeros
/// </summary>
int media;


Console.Write(" Digite o primeiro valor:");
val1 = int.Parse(Console.ReadLine());

Console.Write(" Digite o segundo valor:");
val2 = int.Parse(Console.ReadLine());

Console.Write(" Digite o terceiro valor:");
val3 = int.Parse(Console.ReadLine());

Console.Write(" Digite o quarto valor:");
val4 = int.Parse(Console.ReadLine());


media = (val1 + val2 + val3 + val4) / 4;

if (val1 > media)
{
    Console.WriteLine("o valor 1 é maior que a média" + val1);
}
if (val2 > media) 
{
    Console.WriteLine("o valor 2 é maior que a média" + val2);
}  
if (val3 > media)
{
    Console.WriteLine("o valor 3 é maior que a média" + val3);
}
if(val4 > media)
{
    Console.WriteLine("o valor 4 é maior que a média" + val4);
}


Console.Write ("A média entre os valores é de: " +media);

