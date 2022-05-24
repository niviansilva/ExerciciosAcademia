Console.Write("17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados");
Console.Write("formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos");
Console.Write("os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).");

float ladoA, ladoB, ladoC;
Boolean formaTriangulo;

formaTriangulo = true;

Console.WriteLine("Digite a largura do lado A: ");
ladoA = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a largura do lado B: ");
ladoB = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a largura do lado C: ");
ladoC = float.Parse(Console.ReadLine());



if (ladoA > (ladoB + ladoC))
{
    Console.WriteLine("Lado A não pode formar um triangulo");
    formaTriangulo = false;
}
else if (ladoB > (ladoA + ladoC))
{
    formaTriangulo = false;
    Console.WriteLine("Lado B não pode formar um triangulo");
}
if (ladoC > (ladoB + ladoA))
{
    formaTriangulo = false;
    Console.WriteLine("Lado C não pode formar um triangulo");
}
else if(formaTriangulo)
{
    if ((ladoA == ladoB) && (ladoA == ladoC))
    {
        Console.WriteLine("Triangulo equilátero");
    }
    if ((ladoA==ladoB) && (ladoA != ladoC) || ((ladoB!=ladoA) && (ladoC==ladoA)))
    {
        Console.WriteLine("Triangulo isocele");
    }
    if ((ladoA != ladoB) && (ladoA != ladoC) && (ladoB!=ladoC))
    {
        Console.WriteLine("Triangulo escaleno");
    }
}