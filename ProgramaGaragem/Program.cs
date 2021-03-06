/*Trabalho para entender e aplicar a teoria de Orientação a Objetos (terceirização), uso adequado de Listas e Arquivos. 
 Além disso, aplicar a ideia de menu de opções. 
  
 Construir um programa em VS que gerencie veículos em garagem. O programa deve ter um menu de operação. Os dados dos 
 veículos devem ser persistidos em arquivo e manipulados em uma lista dinâmica em memória. 
 Os dados dos veículos são : string placa; DateTime dataHoraEntrada.

 MENU
 1 - Cadastrar veículo entrando na garagem
 2 - Exibir veículos cadastrados
 3 - Sair
 Opção:  


 Observações: Criar a classe Veiculo (placa, dataHoraEntrada); usar as classes List, StreamReader, StreamWriter, DateTime
 Use como base de dados o arquivo 'garagem.dat'.*/


using ProgramaGaragem;

List<Veiculo> listaVeiculo = new List<Veiculo>();
string opcao;

Utilidade.carregarListaVeiculos(listaVeiculo);

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar um veiculo");
    Console.WriteLine("2 - Listar veiculos");
    Console.WriteLine("3 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //cadastrar um veiculo;
           Utilidade.cadastrarVeiculo("Cadastrando veiculo", listaVeiculo);
            break;
        case "2":
            //listar veiculo;
            Utilidade.exibirLista("Exibindo a lista de veiculos cadastrados", listaVeiculo);
            break;
        case "3":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "3");