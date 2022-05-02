Console.WriteLine("6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B,");
Console.WriteLine("isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem");
Console.WriteLine(" de IPI(única) a ser acrescentada. ");


String parafusoA;
int cod_parafusoA;
int qtd_parafusoA;
float valor_parafusoA;
float IPI_parafusoA;
float valorFinalParafusoA;


String parafusoB;
int cod_parafusoB;
int qtd_parafusoB;
float valor_parafusoB;
float IPI_parafusoB;
float valorFinalParafusoB;





Console.Write("O tipo do parafusoA: ");
parafusoA = Console.ReadLine();

Console.Write("o codigo do parafusoA: ");
cod_parafusoA = int.Parse(Console.ReadLine());

Console.Write("A quantidade do parafusoA: ");
qtd_parafusoA = int.Parse(Console.ReadLine()); 

Console.Write("O valor unitario do parafusoA: ");
valor_parafusoA = float.Parse(Console.ReadLine());

Console.Write("O valor do IPI do parafusoA: ");
IPI_parafusoA = float.Parse(Console.ReadLine());





Console.Write("O tipo do parafusoB: ");
parafusoB = Console.ReadLine();

Console.Write("o codigo do parafusoB: ");
cod_parafusoB = int.Parse(Console.ReadLine());

Console.Write("A quantidade do parafusoB: ");
qtd_parafusoB = int.Parse(Console.ReadLine());

Console.Write("O valor unitario do parafusoB: ");
valor_parafusoB = float.Parse(Console.ReadLine());

Console.Write("O valor do IPI do parafusoB: ");
IPI_parafusoB = float.Parse(Console.ReadLine());

valorFinalParafusoA= (valor_parafusoA + (valor_parafusoA * (IPI_parafusoA / 100))) * qtd_parafusoA;

Console.Write("O tipo do parafusoA é: " + parafusoA + " que possui o codigo: "+cod_parafusoA + "\n que tem a quantidade em estoque de: "+qtd_parafusoA+" com o valor unitário de: "+valor_parafusoA + "\n com o IPI de: " +IPI_parafusoA+" totalizando: " + valorFinalParafusoA);


valorFinalParafusoB = (valor_parafusoB + (valor_parafusoB * (IPI_parafusoB / 100))) * qtd_parafusoB;

Console.Write("O tipo do parafusoB é: " + parafusoB + " que possui o codigo: " + cod_parafusoB + "\n que tem a quantidade em estoque de: " + qtd_parafusoA + " com o valor unitário de: " + valor_parafusoB + "\n com o IPI de: " + IPI_parafusoB + " totalizando: " + valorFinalParafusoB);

