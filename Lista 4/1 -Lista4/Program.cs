Console.WriteLine("1.Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte");
//("soma: S = 1 + 1 / 2 + 1 / 3 + 1 / 4+1...");
    
    
    
int numero = 0;



do
{
    if (numero < 0)
    {
        Console.WriteLine("O numero precisa ser positivo: ");
    }
    Console.Write("Digite um numero inteiro positivo: ");
    numero = int.Parse(Console.ReadLine());
}
while (0 >= numero);
{
    Console.WriteLine("O numero é positivo: ");
}

for (int i = 1; i <=10 ; i++)
{
    int soma = numero + i ;

        Console.WriteLine("a soma é :"+numero + "+"+i +"="+soma);
    

}
