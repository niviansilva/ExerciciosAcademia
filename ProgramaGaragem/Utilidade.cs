namespace ProgramaGaragem
{
    class Utilidade
    {
        public static void carregarListaVeiculos(List<Veiculo> ListaCarro)
        {
            StreamReader leitorArquivo;
            string localArquivo = "garagem.dat";
            string[] vetorDados;
            try
            {
                leitorArquivo = new StreamReader(localArquivo);
                do
                {
                    vetorDados = leitorArquivo.ReadLine().Split(";");
                    ListaCarro.Add(new Veiculo(vetorDados[0], DateTime.Parse(vetorDados[1])));
                } while (!leitorArquivo.EndOfStream);
                leitorArquivo.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Arquivo de usuários com problemas ou inexistente");
            }
        }

        public static void cadastrarVeiculo(string frase, List<Veiculo> listaCarro)
        {
            Console.WriteLine(frase);
            string placa;
            DateTime dhEntrada;

            Console.Write("Digite a placa do veiculo: ");
            placa =Console.ReadLine();
            dhEntrada = System.DateTime.Now;

            Veiculo veiculosCadastrar = new Veiculo(placa, dhEntrada);
            Utilidade.gravarArquivo(veiculosCadastrar);

        }
        public static void gravarArquivo(Veiculo Garagem)
        {
            try
            {
                StreamWriter GravadorArquivo = new StreamWriter("garagem.dat", true);

                GravadorArquivo.WriteLine(Garagem.placaCarro+";"+ Garagem.dtHEntrada.ToString());
                GravadorArquivo.Flush();
                GravadorArquivo.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Arquivo de veiculos com problemas "+ex.Message);
            }
        }

        public static void exibirLista(string frase, List<Veiculo> listaCarro)
        {
            Console.WriteLine(frase);
            Utilidade.carregarListaVeiculos(listaCarro);
            foreach (Veiculo carrosgaragem in listaCarro)
            {
                Console.WriteLine(carrosgaragem.placaCarro + " " + carrosgaragem.dtHEntrada);
            }
          
        }
    }
}
