Console.WriteLine("9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição");
Console.WriteLine("diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:");
Console.WriteLine("Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia");
Console.WriteLine("Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.");

Console.WriteLine("Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for ");
Console.WriteLine("menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que");
Console.WriteLine("150, avisá-lo que será necessário adicionar 2 unidades de insulina.");


int vlrGlicemiaJ, vlrGlicemiaR, vlrGlicemiaM;
float Media;

Console.Write("informe o valor de glicemia em Jejum ");
vlrGlicemiaJ = int.Parse(Console.ReadLine());

if (vlrGlicemiaJ < 65)
{
    Console.WriteLine("Risco de Hipoglicemia");
}
else if (vlrGlicemiaJ > 250)
{
    Console.WriteLine("Risco de Hiperglicemia");
}

Console.Write("informe o valor de glicemia em Jejum ");
vlrGlicemiaR = int.Parse(Console.ReadLine());

if (vlrGlicemiaR < 65)
{
    Console.WriteLine("Risco de Hipoglicemia");
}
else if (vlrGlicemiaR > 250)
{
    Console.WriteLine("Risco de Hiperglicemia");
}
Console.Write("informe o valor de glicemia em Jejum ");
vlrGlicemiaM = int.Parse(Console.ReadLine());

if (vlrGlicemiaM < 65)
{
    Console.WriteLine("Risco de Hipoglicemia");
}
else if (vlrGlicemiaM > 250)
{
    Console.WriteLine("Risco de Hiperglicemia");
}

Media = (vlrGlicemiaJ + vlrGlicemiaR + vlrGlicemiaR) / 3;

Console.WriteLine("Média de insulina. "+ Media);

if (Media  < 80)
{
    Console.WriteLine("é preciso diminuir 2 unidades de insulina.");
}
else if (vlrGlicemiaM > 150)
{
    Console.WriteLine("é preciso aumentar 2 unidades de insulina.");
}
