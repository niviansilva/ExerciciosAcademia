Console.WriteLine("20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. ");
Console.WriteLine("plus: você pode gerar o número de forma randomica (função random c#).");

Random r = new Random();
int numerosecreto, numeroDigitado;
Boolean acertou=false;
numerosecreto =r.Next(0,11);

for (int i = 1; i<= 3; i++)
{


Console.Write("Adivinhe o número: ");
numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado > numerosecreto)
        Console.WriteLine("O número digitado é maior");
    if (numeroDigitado < numerosecreto)
        Console.WriteLine("O número digitado é menor");
    if (numerosecreto == numeroDigitado) {
        Console.WriteLine("PARABÉNS!!!! VOCÊ ACERTOU!!!!");
        acertou = true;
        break;
    }
}
if (acertou == false)
{
    Console.WriteLine("O número era: " + numerosecreto.ToString());
}