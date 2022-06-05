/*13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
vendidas pelo vendedor, calcule e mostre: o salário do empregado*/


double salMin, custo, qtdBicicleta, salEmp, pVenda;

/// <summary>
/// Indica o valor do salário mínimo
/// </summary>
Console.Write("Digite o valor do salario minimo:");
salMin = double.Parse(Console.ReadLine());

/// <summary>
/// Recebe o valor de custo unitário da bicicleta
/// </summary>
Console.Write("Digite o preço de custo da bicicleta:");
custo = double.Parse(Console.ReadLine());

/// <summary>
/// Indica a quantidade de bicicletas vendidas pelo vendedor
/// </summary>
Console.Write("Digite o numero de bicicletas vendidas pelo vendedor:");
qtdBicicleta = double.Parse(Console.ReadLine());

/// <summary>
/// recebe o preco de venda final
/// </summary>
pVenda = custo * 1.5;


//comissao = custo* 0.15 * qtdBicicleta;

/// <summary>
/// recebe o valor final do salario do vendedor
/// </summary>
salEmp = (salMin * 2) + (custo * 0.15 * qtdBicicleta);

Console.Write("O salário final do vendedor é :" + salEmp);