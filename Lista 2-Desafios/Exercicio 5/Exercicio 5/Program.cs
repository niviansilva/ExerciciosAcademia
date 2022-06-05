Console.WriteLine("5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” ");
Console.WriteLine("se a média das duas notas for maior ou igual a 7, 0.");

Console.WriteLine("Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,");
Console.WriteLine("é a média entre a nota do exame e a média das 2 notas. ");
Console.WriteLine("Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve ");
Console.WriteLine("escrever “Reprovado”.");



float Nota1;
float Nota2;
float Media;
float NotaExame;
float NotaFinal;

Console.Write("Digite a primeira nota: ");
Nota1 = float.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
Nota2 = float.Parse(Console.ReadLine());

Media = (Nota1 + Nota2) / 2;

if (Media > 7)
{
    Console.WriteLine("Aprovado a média foi de: " + Media);
}
else
{
    Console.WriteLine("A média foi de: " + Media);
    Console.WriteLine("Qual foi a Nota do Exame: ");
    NotaExame= float.Parse(Console.ReadLine());

    NotaFinal = (NotaExame + Media) / 2;

    if (NotaFinal >= 5)
    {
        Console.Write("Aprovado a nota final foi de: " + NotaFinal);
    }
    else
    {
        Console.WriteLine("Reprovado, a nota final foi: " + NotaFinal);
    }

}