Console.WriteLine("16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre");
Console.WriteLine("na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se");
Console.WriteLine("enfrentar novamente em um novo jogo.");
Console.WriteLine("ex: time da casa 4 x 3 time de fora, mostra Os dois times se enfrentarão em um novo jogo");
Console.WriteLine("ex2: time da casa 1 x 3 time de fora, mostra O time de fora já se classificou");
Console.WriteLine("plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.");

int timeCasa, timeFora, DifPlacar;

Console.Write("Digite o placar do time da casa: ");
timeCasa = int.Parse(Console.ReadLine());

Console.Write("Digite o placar do time de Fora: ");
timeFora = int.Parse(Console.ReadLine());

DifPlacar = timeFora - timeCasa;

if (DifPlacar >= 2)
{
   Console.WriteLine("time da casa "+ timeCasa +" x "+ timeFora +" time de fora. Time de fora se classificou");
}
else if (DifPlacar < 2 )
{
    Console.WriteLine("time da casa " + timeCasa + " x " + timeFora + " time de fora. Haverá um novo jogo");
}

if (DifPlacar < 2)
{

    Console.WriteLine("");
    Console.WriteLine("");

    Console.Write("Digite o novo placar do time da casa: ");
    timeCasa = int.Parse(Console.ReadLine());

    Console.Write("Digite o novo placar do time de Fora: ");
    timeFora = int.Parse(Console.ReadLine());

    DifPlacar = timeFora - timeCasa;

    if (DifPlacar > 0)
    {
        Console.WriteLine("time da casa " + timeCasa + " x " + timeFora + " time de fora. Time de fora classificado");
    }
    else if (DifPlacar < 2)
    {
        Console.WriteLine("time da casa " + timeCasa + " x " + timeFora + " time de fora. Time da casa Classificado");
    }




}