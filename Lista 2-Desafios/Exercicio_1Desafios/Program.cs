Console.WriteLine("1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores");
Console.WriteLine(" da base e da altura lidos pelo teclado: Área do triangulo = (base * altura) / 2");
Console.WriteLine("Teste se a base ou a altura digitada não foi igual a zero.");

/// <summary>
/// armazena o valor da base
/// </summary>
double Base;

/// <summary>
/// armazena o valor da altura
/// </summary>
double altura;

/// <summary>
/// armazena o valor do calculo da area do triangulo
/// </summary>
double areaTriangulo;

Console.Write(" Digite o valor da Base: ");
Base = Double.Parse(Console.ReadLine());

if(Base == 0)
{
    Base = 1;
}

Console.Write("Digite o valor da altura:");
altura = Double.Parse(Console.ReadLine());

if(altura == 0)
{
    altura = 1;
}

areaTriangulo = (Base * altura) / 2;


Console.WriteLine(" o valor da area do triangulo é: " +areaTriangulo);