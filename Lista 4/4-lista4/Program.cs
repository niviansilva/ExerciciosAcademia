//4.Faça um algoritmo que leia uma lista de números inteiros positivos terminada pelo número 0 (zero). 
//Ao final, o algoritmo deve mostrar a média aritmética de todos os números lidos (excluindo o zero).


int N1;
int N2;

do
{
    Console.WriteLine("Digite um valor para N1: ");
    N1 = int.Parse(Console.ReadLine());
}
while ((N1 <= 0) && (N1 % 10 != 0));
{
    Console.WriteLine("O numero precisa ser positivo e terminar em 0");
}