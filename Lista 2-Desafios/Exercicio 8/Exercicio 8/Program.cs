Console.WriteLine("8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.");
Console.WriteLine("Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.");
Console.WriteLine("Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.");
Console.WriteLine("E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do ");
Console.WriteLine("total de vendas. ");

string Nome;
double SalarioBase, SalarioFinal=0, totalVendas;

Console.Write("Digite o nome do funcionário ");
Nome = Console.ReadLine();
Console.Write("Digite o Salário Base: ");
SalarioBase = float.Parse(Console.ReadLine());
Console.Write("Digite o total de vendas: ");
totalVendas = float.Parse(Console.ReadLine());

if (totalVendas > 500.00 && totalVendas <= 1000.00)
{
    SalarioFinal = SalarioBase + (totalVendas * 0.05);
}
else if (totalVendas > 1000 && totalVendas <= 5000)
{
    SalarioFinal = SalarioBase + (totalVendas * 0.05);
}
else if(totalVendas > 5000)
{
    SalarioFinal = SalarioBase + (totalVendas * 0.10);
}
else
{
    SalarioFinal = SalarioBase;
}

Console.WriteLine("o funcionario " + Nome + " vendeu um total de " + totalVendas + " Ficando com o salário de: " + SalarioFinal + " De um salário base de: "+ SalarioBase);