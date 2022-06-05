//1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
/*Este é 
    um comentário
    de muitas linhas*/

Console.WriteLine("exercicio 1:Escreva um programa em C# e no Visual \n"+
    "Studio para calcular a média aritmética entre dois números quaisquer.");



float numero1;
float numero2;
float media_aritmetica;



Console.Write("digite o primeiro valor:");
numero1 = float.Parse (Console.ReadLine());

Console.Write("digite o segundo valor:");
numero2 = float.Parse (Console.ReadLine());         

media_aritmetica = (numero1 + numero2)/2;

Console.Write("A média aritimetica dos valores é: " + media_aritmetica);    