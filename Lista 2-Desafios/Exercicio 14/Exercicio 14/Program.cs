Console.WriteLine("14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um\n" +
"link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download \n" +
"do arquivo usando este link (em minutos)");

float tamanhoArquivo;
int Velocidade;
double VelocidadeMBs;
double segundo = 0.0166667;
//1 megabit vale 0,125 megabytes

Console.Write("informe o tamanho do arquivo em Megabytes: ");
tamanhoArquivo = float.Parse(Console.ReadLine());
Console.Write("Digite a velocidade da internet: ");
Velocidade = int.Parse(Console.ReadLine());

VelocidadeMBs = Velocidade * 0.125;

Console.WriteLine("");

Console.WriteLine("");

Console.WriteLine("O tempo estimado de downlaod será de : "+ (((tamanhoArquivo / VelocidadeMBs))*segundo).ToString("0.00")+ " minutos");