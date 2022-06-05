Console.WriteLine("11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).");
Console.WriteLine("O programa deve exibir se a hora digitada está ou não válida."); 
Console.WriteLine("Lembre que usaremos o padrão de hora com 24h, de 0 a 23.");

int hora, minuto;

Console.Write("Digita a hora: ");
hora = int.Parse(Console.ReadLine());
Console.Write("Digite o minuto: ");
minuto = int.Parse(Console.ReadLine());

if( (hora < 0  || hora > 24) || (minuto < 0 || minuto > 59))
{
    Console.WriteLine("Hora inválida...");
} 
else
{
    Console.WriteLine("Hora Válida: " + hora + ":" + minuto);
}
