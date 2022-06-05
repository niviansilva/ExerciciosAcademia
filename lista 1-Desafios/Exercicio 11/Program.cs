// See https://aka.ms/new-console-template for more information

Console.WriteLine("11) Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos,\n" +
 "nulos e válidos. Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.");


int TotalDeEleitores;
int VotosBrancos;
int VotosNulos;
int VotosValidos;
int TotalDeVotos;
float UmporcentoDosVotos;


Console.Write(" Informe a quantidade de eleitores ");
TotalDeEleitores = int.Parse(Console.ReadLine());

Console.Write(" O valor total dos votos brancos é: ");
VotosBrancos = int.Parse(Console.ReadLine());

Console.Write(" O valor total dos votos nulos é: ");
VotosNulos = int.Parse(Console.ReadLine());

Console.Write(" O valor total dos votos Validos é: ");
VotosValidos = int.Parse(Console.ReadLine());


TotalDeVotos = VotosBrancos + VotosNulos + VotosValidos;
UmporcentoDosVotos = 100/ TotalDeEleitores ;

Console.WriteLine("O total de Eleitores é: " + TotalDeVotos + " O percentual de votos em branco é de: " + VotosBrancos * UmporcentoDosVotos + "\n" +
    " O Percentual de votos nulos é de: " + VotosNulos * UmporcentoDosVotos + " O Percentual de votos Válidos é de: " + VotosValidos * UmporcentoDosVotos);

