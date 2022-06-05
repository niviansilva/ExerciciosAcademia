/*
*3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
si os valores de duas variáveis A e B.
*/


Console.WriteLine("3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio,\n" +
    " para trocar entre si os valores de duas variáveis A e B.!");



Console.Write("Digite uma frase qualquer: ");
string variavel1 = Console.ReadLine();

Console.Write("Digite a segunda frase qualquer: ");
string variavel2  = Console.ReadLine();

string auxiliar = variavel1;
variavel1 = variavel2;
variavel2 = auxiliar;

Console.WriteLine("O conteudo da variavel1 é: " + variavel1);

Console.WriteLine("O conteudo da variavel2 é: " + variavel2);




Console.Write("Digite uma nunero qualquer: ");
int variavelA = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo numero qualquer: ");
int variavelB = int.Parse(Console.ReadLine());

int aux = variavelA;
variavelA = variavelB;
variavelB= aux;

Console.WriteLine("O conteudo da variavel1 é: " + variavelA);

Console.WriteLine("O conteudo da variavel2 é: " + variavelB);