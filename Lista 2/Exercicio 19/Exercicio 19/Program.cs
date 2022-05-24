Console.WriteLine("19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.");

int valorA,valorB, valorC;

List<int> lista = new List<int>();

Console.Write("digite o primeiro valor: ");
valorA = int.Parse(Console.ReadLine());

lista.Add(valorA);

Console.Write("digite o segundo valor: ");
valorB = int.Parse(Console.ReadLine());

lista.Add(valorB);

Console.Write("digite o terceiro valor: ");
valorC = int.Parse(Console.ReadLine());

lista.Add(valorC);

lista.Sort();

Console.WriteLine("Os numeros digitados e ordem crescente são: ");

foreach (int i in lista)
{
    Console.WriteLine(i);
}
