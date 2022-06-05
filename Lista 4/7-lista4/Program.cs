/*7.Os dois primeiros números da sequência de Fibonacci são 0 e 1. Os próximos números dessa 
sequência podem ser calculados como sendo a soma dos dois números anteriores. Os primeiros
números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … Escreva um algoritmo 
que leia um número pelo teclado N, e então mostre os N primeiros números da sequência de Fibonacci.*/



int N;

Console.WriteLine("Digite o valor para a sequencia: ");
N = int.Parse(Console.ReadLine());

int num1 = 0, num2 = 1, aux;

for (int i = 0; i​​​​​​​ < N; i++)
{
	aux = num1;
	num1 = num2;
	num2 = num1 + aux;
	Console.WriteLine("{0}", num2);

}
