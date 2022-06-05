
Console.WriteLine("5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel"); 
Console.WriteLine("(medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume de combustível");
Console.WriteLine("consumido para percorrê - la(medido em l).");


float consumo;
float distancia;
float volume;


Console.Write("Digite a distancia percorrida: ");
distancia = float.Parse(Console.ReadLine());

Console.Write("Digite o volume de combustivel: ");
volume = float.Parse(Console.ReadLine());

consumo = distancia / volume;
Console.Write("O consumo do combustível é: "+consumo+" km/L"); 
