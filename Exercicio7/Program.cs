// See https://aka.ms/new-console-template for more information
Console.WriteLine("7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo"); 
Console.WriteLine("o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas.");
Console.WriteLine("Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.");




int numero_vendedor;
float salario_fixo;
int totaldeVendas;
float PercentualsobreVendas;
float salarioTotal;



Console.Write("Digite o numero do vendedor: ");
numero_vendedor = int.Parse(Console.ReadLine());

Console.Write("Digite o valor do salario fixo: ");
salario_fixo = float.Parse(Console.ReadLine());

Console.Write("Atribuir a quantidade de vendas realizadas: ");
totaldeVendas = int.Parse(Console.ReadLine());

Console.Write("Digitar valor percentual sobre as vendas: ");
PercentualsobreVendas = float.Parse(Console.ReadLine());

//Console.Write("Digitar o valor do salario total : ");
//salarioTotal = float.Parse(Console.ReadLine());




salarioTotal =  salario_fixo+ (totaldeVendas * (salario_fixo * (PercentualsobreVendas / 100)));


Console.Write("O numero do vendedor é: " + numero_vendedor + " que possui o salario total de " + salarioTotal); 




