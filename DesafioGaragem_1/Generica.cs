namespace DesafioGaragem_1
{
    class Generica
    {
        public static void gravaArquivoEntrada(Garagem Veiculo)
        {
            string localArquivo = "veiculosEntrada.dat";
            StreamWriter gravadorArquivo = new StreamWriter(localArquivo, true);
            gravadorArquivo.WriteLine(Veiculo.PlacaCarro + ";" + Veiculo.DtEntrada + ";" + Veiculo.HrEntrada);
            gravadorArquivo.Flush();
            gravadorArquivo.Close();
        }

        public static void gravaArquivoSaida(Garagem Veiculo)
        {
            string localArquivo = "veiculosSaida.dat";
            StreamWriter gravadorArquivo = new StreamWriter(localArquivo, true);
            gravadorArquivo.WriteLine(Veiculo.PlacaCarro + ";" + Veiculo.DtSaida + ";" + Veiculo.HrSaida+";"+Veiculo.ValorCobrado.ToString());
            gravadorArquivo.Flush();
            gravadorArquivo.Close();
        }

        public static void lerArquivoEntrada(List<Garagem> ListaGaragem)
        {
            try
            {
                string localArquivo = "veiculosEntrada.dat"; //Nome do arquivo que será carregado
                StreamReader leitorArquivo = new StreamReader(localArquivo);  // Criando variavel para leitura do arquivo
                string[] arrayPlaca; // array de placas



                do
                {

                    arrayPlaca = leitorArquivo.ReadLine().Split(";");   //carregando o array com os dados do arquivo separados por ;

                    ListaGaragem.Add(new Garagem(arrayPlaca[0], arrayPlaca[1], arrayPlaca[2])); // Carregando a lista com o construtor
                } while (!leitorArquivo.EndOfStream);   //Laco de repetição ate o final do arquivo
                leitorArquivo.Close();   //Fechando o arquivo apos a leitura

            }
            catch (Exception ex)
            {

            }
        }

        internal static void lerArquivoSaida(List<Garagem> listaGaragemSaida)
        {
            try
            {
                string localArquivo = "veiculosSaida.dat"; //Nome do arquivo que será carregado
                StreamReader leitorArquivo = new StreamReader(localArquivo);  // Criando variavel para leitura do arquivo
                string[] arrayPlaca; // array de placas



                do
                {

                    arrayPlaca = leitorArquivo.ReadLine().Split(";");   //carregando o array com os dados do arquivo separados por ;

                    listaGaragemSaida.Add(new Garagem(arrayPlaca[0], arrayPlaca[1], arrayPlaca[2], Double.Parse(arrayPlaca[3]))); // Carregando a lista com o construtor
                } while (!leitorArquivo.EndOfStream);   //Laco de repetição ate o final do arquivo
                leitorArquivo.Close();   //Fechando o arquivo apos a leitura

            }
            catch (Exception ex)
            {

            }
        }

        internal static int VerificaVeiculoEntrada(List<Garagem> listaGaragem, string Placa)
        {
            int Retorna_Teste = 0;
            foreach (Garagem placa in listaGaragem)   // Laço de repetição lendo cada placa da lista de Garagem
            {
                if (placa.PlacaCarro.Equals(Placa))
                {
                    Retorna_Teste = -27;
                    break;
                }
                else
                {
                    Retorna_Teste = 0;
                }
            }
            return Retorna_Teste;
        }

        internal static int VerificaVeiculoSaida(List<Garagem> listaGaragemSaida, string Placa)
        {
            int Retorna_Teste = 0;
            foreach (Garagem placa in listaGaragemSaida)   // Laço de repetição lendo cada placa da lista de Garagem
            {
                if (placa.PlacaCarro.Equals(Placa))
                {
                    Retorna_Teste = -27;
                    break;
                }
                else
                {
                    Retorna_Teste = 0;
                }
            }
            return Retorna_Teste;
        }


        internal static bool ValidaCalendario(DateTimePicker dtPicker, Label lblData)
        {
            if (dtPicker.Value.ToShortDateString() == lblData.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaHoraMinuto(string HoraMinuto)
        {
            if (Convert.ToInt32(HoraMinuto.Substring(0, 2)) < 0 || Convert.ToInt32(HoraMinuto.Substring(0, 2)) >= 24) //Valida se a hora está entre 00 e 24
            {
                return false;
            }
            else if (Convert.ToInt32(HoraMinuto.Substring(3, 2)) < 0 || Convert.ToInt32(HoraMinuto.Substring(3, 2)) > 59) //Valida se o minuto está entre 00 e 59
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public static string calculaVagas(List<Garagem> ListaGaragem)
        {
            int vagasDisponiveis;
            vagasDisponiveis = 50 - ListaGaragem.Count;

            if (vagasDisponiveis > 0)
            {
                return vagasDisponiveis.ToString() + "/50";
            }
            else
            {
                return "LOTADO";
            }

        }

        public static void RemoveListaEntrada(List<Garagem> listaGaragem, string Placa)
        {
            int i = 0;
            foreach (Garagem placa in listaGaragem)   // Laço de repetição lendo cada placa da lista de Garagem
            {
                if (placa.PlacaCarro.Equals(Placa))
                {
                    listaGaragem.RemoveAt(i);
                    break;
                }
                i++;
            }
        }
        public static void LimpaArquivoEntrada()
        {
            FileInfo fi = new FileInfo("veiculosEntrada.dat");

            if (fi.Exists)
            {
                fi.Delete();
            }
        }

        internal static string BuscaHoraEntrada(string placaCarro, List<Garagem> listaGaragem)
        {
            string Retorno ="";
            foreach (Garagem placa in listaGaragem)   // Laço de repetição lendo cada placa da lista de Garagem
            {
                if (placa.PlacaCarro.Equals(placaCarro))
                {
                    Retorno = placa.HrEntrada.ToString();
                }
                else
                {
                    Retorno =  "erro";
                }
            }
            return Retorno;
        }
    }
}
