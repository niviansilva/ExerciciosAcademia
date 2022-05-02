// See https://aka.ms/new-console-template for more information
//Console.WriteLine(exercicio2):) Escreva um programa em C# e no Visual Studio\n"
  //  para calcular a média aritmética entre quatro números quaisquer.");

float numero1;
float numero2;
float numero3;  
float numero4;
float media_aritmetica;


Console.Write("informe o 1o numero:");
    numero1 = float.Parse(Console.ReadLine());

Console.Write("informe o 2o numero: ");
    numero2 = float.Parse(Console.ReadLine());

Console.Write("informe o 3o numero: ");
    numero3 = float.Parse(Console.ReadLine());

Console.Write("informe o 4o numero: ");
    numero4 = float.Parse(Console.ReadLine());


media_aritmetica = (numero1 + numero2 + numero3 + numero4) / 4;

Console.WriteLine("a media dos quatro valores é: " + media_aritmetica);
