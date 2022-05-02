// See https://aka.ms/new-console-template for more information
Console.WriteLine("2 Escreva um programa em C# e no Visual Studio para calcular a média aritmética \n entre quatro números quaisquer.");


float numero1;
float numero2;
float numero3;
float numero4;

float media_aritmetica;





Console.Write("informe o 1º numero : ");
numero1 = float.Parse(Console.ReadLine());


Console.Write("informe o 2º numero : ");
numero2 = float.Parse(Console.ReadLine());

Console.Write("informe o 3º numero : ");
numero3 = float.Parse(Console.ReadLine());

Console.Write("informe o 4º numero : ");
numero4 = float.Parse(Console.ReadLine());


media_aritmetica = (numero1 + numero2 + numero3 + numero4 ) / 4;


Console.WriteLine("A média dos 4 valores é: "+ media_aritmetica);

