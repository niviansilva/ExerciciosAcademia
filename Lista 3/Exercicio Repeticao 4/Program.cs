Console.WriteLine("4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA).\n" +
"Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.\n" +
"Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA."+
"Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuárioescrever FIM.\n" +
"Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número de votos em branco.");

string voto; //ZECA ,JOAO, BRANCO
int totalvotosZeca = 0;
int totalvotosJoao = 0;
int totalvotosBranco = 0;


do {
    Console.Write("Digite o nome do seu candidato, ou Branco, ou FIM para encerrrar: ");
    voto=Console.ReadLine().ToUpper();

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
            Console.WriteLine("Candidato Inesxistente");
            break;
    }

}while (voto != "FIM");

    Console.WriteLine("Total de votos para Zeca:" + totalvotosZeca);
    Console.WriteLine("Total de votos para o Joao:" + totalvotosJoao);
    Console.WriteLine("Total de votos em Branco: " + totalvotosBranco);
