
// See https://aka.ms/new-console-template for more information


Console.WriteLine("12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça.\n" +
" Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a marcação do odômetro(marcador de quilometragem)\n" +
" no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebidodos passageiros.\n" +
"Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia "); 

float Odometro_InicioDoDia;
float Odometro_FinalDoDia;
float CombustivelGasto;
float ValorTotalRecebido;
float QuilometragemTotal;
float LucroDiario;
float MediaDoConsumo;
float ValorDoLitro;


  
Console.Write(" Digite o valor do odometro no inicio do dia: ");
Odometro_InicioDoDia = float.Parse(Console.ReadLine());

Console.Write(" Digite o valor do odometro final do dia: ");
Odometro_FinalDoDia = float.Parse(Console.ReadLine());

Console.Write(" Digite o total do combustivel gasto em Litros: ");
CombustivelGasto = float.Parse(Console.ReadLine());

Console.Write(" Digite o valor total recebido em R$: ");
ValorTotalRecebido= float.Parse(Console.ReadLine());
Console.WriteLine("");

QuilometragemTotal = Odometro_FinalDoDia - Odometro_InicioDoDia;
Console.WriteLine(" A quilometragem total percorrida é: " + QuilometragemTotal + " KM");

MediaDoConsumo = QuilometragemTotal / CombustivelGasto;
Console.WriteLine(" A media do consumo é: " + MediaDoConsumo + "Km/L");

ValorDoLitro = MediaDoConsumo /float.Parse ("6,90");

LucroDiario = ValorTotalRecebido - (QuilometragemTotal * ValorDoLitro);
Console.WriteLine(" O valor do lucro diario é R$: " + LucroDiario);
