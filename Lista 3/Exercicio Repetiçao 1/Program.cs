Console.WriteLine("1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados\n " +
"(informando se ele estiver errado e repetindo a solicitação até que esteja correto)"+ 
"Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.");

/*Exemplo:
Digite um número inteiro positivo: -8
Valor incorreto!
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6. */

int numero=0;



do
{
    if (numero < 0)
    {
        Console.WriteLine("O numero precisa ser positivo: ");
    }
    Console.Write("Digite um numero inteiro positivo: ");
    numero = int.Parse(Console.ReadLine());
}
while ( 0 >= numero);
{
        Console.Write("O numero é positivo: ");
}

for (int i = 0; i <= numero; i++)
{
    int resultado = i % 2;

    if(resultado == 0)
    {
        Console.WriteLine(i);
    }
    
}
