Console.WriteLine("6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.");
Console.WriteLine("O programa deve calcular o Indice de Massa Corpórea (IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.");
Console.WriteLine("O cálculo do imc = peso / (altura * altura");


/*IMC
menor que 18->baixo peso
maior que 18 e menor que 25->peso normal
maior que 25 e menor que 30->sobrepeso
maior que 30 e menor que 35->obesidade
maior que 35->obesidade grau sério*/


/// <summary>
/// armazena o nome completo informado pelo usuario
/// </summary>
String nome;

/// <summary>
/// armazena o valor da altura
/// </summary>
float altura;

/// <summary>
/// armazena o valor do peso
/// </summary>
float peso;

/// <summary>
/// armazena o calculo do imc
/// </summary>
float imc;

/// <summary>
/// armazena a classificaçao do imc
/// </summary>
string tipoIMC = "";


Console.Write("Digite um nome completo:");
nome = Console.ReadLine();
nome = nome.ToUpper();

Console.Write("Digite a altura:");
altura = float.Parse (Console.ReadLine());

Console.Write("Digite o peso:");
peso = float.Parse (Console.ReadLine());




imc = peso / (altura * altura);

if (imc < 18)
{
    tipoIMC = "baixo peso";
}
else if (imc > 18 && imc < 25)
{
    tipoIMC = "peso normal";
}
else if (imc > 25 && imc < 30)
{
    tipoIMC = "sobrepeso";
}
else if (imc > 30 && imc < 35 )
{
    tipoIMC = "obesidade";

}
else if (imc > 35)
{
    tipoIMC = "obesidade grau serio";
}



Console.WriteLine("A pessoa de nome: " + nome + "\nAtura: "+ altura + "m peso: "+ peso+ "Kg Possui Imc: " + imc + " "+tipoIMC);



