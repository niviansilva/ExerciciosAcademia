
Console.WriteLine("4) Faça um programa em C# e no Visual Studio que receba a data na forma DD/MM/AAAA \n" +
    " e imprima na forma AAAA/MM/DD e AA/MM/DD.\nNote que o dia, o mês e o ano devem ser lidos em variáveis diferentes.");


int dia;
int mes;
int ano;

Console.Write("Digite o dia: ");
dia = int.Parse(Console.ReadLine());

Console.Write("Digite o mes: ");
mes = int.Parse(Console.ReadLine());

Console.Write("Digite o ano: ");
ano = int.Parse(Console.ReadLine());

Console.WriteLine("AAAA/MM/DD "+ano+"/"+mes+"/"+dia);

Console.WriteLine("AA/MM/DD " + ano.ToString().Substring(2,2)+ "/" + mes + "/" + dia);




