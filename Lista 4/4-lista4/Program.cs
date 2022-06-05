//4.Faça um algoritmo que leia uma lista de números inteiros positivos terminada pelo número 0 (zero). 
//Ao final, o algoritmo deve mostrar a média aritmética de todos os números lidos (excluindo o zero).


int N1;
List<int> Lista = new List<int>(); //criando lista de numeros inteiros chamada Lista//
int total, totalMedia =0; // criando variaveis inteiras, sendo a total média ja inicializada como 0.//

for(int i = 1; i <= 100; i++) //criando um laço de 1 a 100//
{
    if(i % 10 == 0)   //verificando se a divisao por 10 tem resto 0.//
    Lista.Add(i);    //Add o valor de i na lista//
}

foreach (int itemLista in Lista) //laco de repeticao recuperando os valores da lista : 1 por vez. Carregando a informacao para variavel item lista)
{
   totalMedia = totalMedia + itemLista; //a cada giro a variavel item lista vem com um valor diferente e soma com o valor anterior da variavel total media//6
}

total = Lista.Count; // correga a variavel total com a informacao de quantos itens estao na lista//

Console.WriteLine("A média aritmética de todos os números lidos é : "+(totalMedia/total));

