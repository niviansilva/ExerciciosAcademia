Console.WriteLine("12 - Elabore um programa em VS que leia as variáveis codigo e numeroHoras, respectivamente código e"); 
Console.WriteLine("número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha"); 
Console.WriteLine("R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento ");
Console.WriteLine("armazenando-o na variável extra, caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. ");
Console.WriteLine("No final do processamento, exibir o salário total e o salário excedente do operário.");

int codigo, numeroHoras, extra;
float SalarioTotal, SalarioExcedente;

Console.Write("Digite o código do Operário: ");
codigo= int.Parse(Console.ReadLine());
Console.Write("Digite as horas trabalhadas: ");
numeroHoras= int.Parse( Console.ReadLine());

extra = numeroHoras - 50;

SalarioExcedente = 20 * extra;
SalarioTotal = 10 * 50;

Console.WriteLine("O salario Total do funcionario :" + codigo +" é de :" + SalarioTotal + " e o Excedente é de: " + SalarioExcedente +" De um total de horas exras: "+ extra+"h");