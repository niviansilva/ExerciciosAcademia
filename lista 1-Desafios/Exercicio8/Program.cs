// See https://aka.ms/new-console-template for more information
Console.WriteLine("8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit."); 
Console.WriteLine(" fórmula da conversão é F = (9 * C + 160) / 5.");

float C;
float F;

Console.Write("Digite a temperatura em Celsius: ");
C = float.Parse(Console.ReadLine());

F = (9 * C + 160) / 5;

Console.Write("A temperatura digitada em Celsius foi :"+C +" que em Fahrenheit é : " + F);

