Console.WriteLine("2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja\n" +
"informar um outro número.Caso positivo, o programa em VS deve ser repetido.");

/*Exemplo:
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.


Deseja informar outro número(s / n) ? S


Digite um número inteiro positivo: 12
Numero digitado: 20
Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


Deseja informar outro número(s / n) ? N*/


int numero = 0;
string continua = "S";

while (continua == "S")
{
    do
{
    if (numero < 0)
    {
        Console.WriteLine("O numero precisa ser positivo: ");
    }
    Console.Write("Digite um numero inteiro positivo: ");
    numero = int.Parse(Console.ReadLine());
}
while (0 >= numero );
{
    


        Console.Write("O numero é positivo: ");

        for (int i = 0; i <= numero; i++)
        {
            int resultado = i % 2;

            if (resultado == 0)
            {
                Console.WriteLine(i);
            }

        }
        Console.Write("Deseja digitar outro numero? S/N: ");
        continua = Console.ReadLine().ToUpper();
        Console.Clear();

    }
}

