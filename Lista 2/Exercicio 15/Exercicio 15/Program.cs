Console.WriteLine("15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados\n "+
"da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados \n "+
"e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. \n "+
"Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.");

int LitroTinta = 3;
int LataTinta = 10 * 3, LatasPorMetro, MetroPorTinta, MetroQuadrado;
double ValorLata = 88;
double valorTotal;

Console.Write("Digite o valor em Metros Quadrados: ");
MetroQuadrado = int.Parse(Console.ReadLine());

MetroPorTinta = MetroQuadrado / LitroTinta;

LatasPorMetro = MetroPorTinta / LataTinta;

valorTotal = LatasPorMetro * ValorLata;

Console.WriteLine("Serão necessários " + LatasPorMetro + " Latas, que dão o valor de : " + valorTotal);

