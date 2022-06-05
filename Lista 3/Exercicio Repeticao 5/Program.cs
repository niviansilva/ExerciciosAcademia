Console.WriteLine("5. Modifique o programa em VS anterior para aceitar votos nulos"); 
Console.WriteLine("(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO)");
Console.WriteLine("Ao final, informe o nome do candidato vencedor, o número de votos nulos");
Console.WriteLine("e o número de pessoas que votaram.");

string voto; //ZECA ,JOAO, BRANCO
int totalvotosZeca = 0;
int totalvotosJoao = 0;
int totalvotosBranco = 0;
int totalvotosNulos = 0;
string vencedor;
do
{
    Console.Write("Digite o nome do seu candidato, ou Branco, ou FIM para encerrrar: ");
    voto = Console.ReadLine().ToUpper();

    switch (voto)
    {
        case "JOAO":
            totalvotosJoao++;
            break;
        case "ZECA":
            totalvotosZeca++;
            break;
        case "BRANCO":
            totalvotosBranco++;
            break;
        
        case "FIM":
            Console.WriteLine("Programa encerrado");
            break;
        default:
            totalvotosNulos++;


            break;
    }

} while (voto != "FIM");

if (totalvotosZeca > totalvotosJoao)
{
    vencedor = "ZECA";

}

else
{
    vencedor = "JOAO";
}
Console.WriteLine("Total de votos para Zeca:" + totalvotosZeca);
Console.WriteLine("Total de votos para o Joao:" + totalvotosJoao);
Console.WriteLine("Total de votos em Branco: " + totalvotosBranco);
Console.WriteLine("Total de votos Nulos: "+ totalvotosNulos);
Console.WriteLine("o total de pessoas que votaram é: " +( totalvotosZeca + totalvotosJoao + totalvotosBranco + totalvotosNulos)+" e o vencedor e: "+vencedor);