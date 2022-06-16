namespace DesafioGaragem_1
{
    public partial class Form1 : Form
    {
        List<Garagem> ListaGaragem = new List<Garagem>();  //Criando lista (vazia) com os atributos da Classe Garagem
        List<Garagem> ListaGaragemSaida = new List<Garagem>();  //Criando lista (vazia) com os atributos da Classe Garagem
        public Form1()
        {


            InitializeComponent();

            Generica.lerArquivoEntrada(ListaGaragem); // Classe de Persistencia lendo o arquivo de entrada
            Generica.lerArquivoSaida(ListaGaragemSaida);


            if (ListaGaragem.Count > 0)
            {

                foreach (Garagem placa in ListaGaragem)   // Laço de repetição lendo cada placa da lista de Garagem
                {
                    tbEntrVeiculos.AppendText(placa.PlacaCarro + ";" + placa.DtEntrada + ";" + placa.HrEntrada + "\n");   //Escrevendo os itens da lista no textbox
                }
            }

            if (ListaGaragemSaida.Count > 0)
            {

                foreach (Garagem placaSaida in ListaGaragemSaida)   // Laço de repetição lendo cada placa da lista de Garagem
                {
                    tbSaidaVeiculo.AppendText(placaSaida.PlacaCarro + ";" + placaSaida.DtSaida + ";" + placaSaida.HrSaida+";"+placaSaida.ValorCobrado + "\n");   //Escrevendo os itens da lista no textbox
                }
            }



            lblContVagas.Text = Generica.calculaVagas(ListaGaragem); //Calcula a quantidade de vagas disponiveis

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();


        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (mskTbDtEnt.Text.Replace(":","").Trim() == "")
            {
                MessageBox.Show("Hora não digitada", "Alerta!");
                return;
            }

            if(Generica.VerificaVeiculoEntrada(ListaGaragem, tbPlaca.Text.ToUpper()) == -27)
            {
                MessageBox.Show("Veículo Já deu entrada", "Alerta!");
                return;
            }


            if (!Generica.ValidaCalendario(dtPicker, lblData))
            {
                MessageBox.Show("A data não pode ser diferente da atual", "Alerta!");
                return;
            }


            if (!Generica.ValidaHoraMinuto(mskTbDtEnt.Text))
            {
                MessageBox.Show("A hora está em formato incorreto", "Alerta!");
                return;
            }

            if (tbDtEnt.Text == "")
                tbDtEnt.Text = dtPicker.Value.ToShortDateString();

            tbHrEnt.Text = mskTbDtEnt.Text;

            Garagem G = new Garagem();  //Inicializando construtor da Classe Garagem
            G.PlacaCarro = tbPlaca.Text.ToUpper();
            G.DtEntrada = tbDtEnt.Text;
            G.HrEntrada = tbHrEnt.Text;

            try
            {


                Generica.gravaArquivoEntrada(G);
                MessageBox.Show("Cadastro de Entrada realizado com sucesso!", "Sucesso");
                ListaGaragem.Clear();
                Generica.lerArquivoEntrada(ListaGaragem); // Classe de Persistencia lendo o arquivo de entrada


                if (ListaGaragem.Count > 0)
                {

                    foreach (Garagem placa in ListaGaragem)   // Laço de repeticao lendo cada placa da lista de Garagem
                    {
                        tbEntrVeiculos.AppendText(placa.PlacaCarro + ";" + placa.DtEntrada + ";" + placa.HrEntrada + "\n");   //Escrevendo os itens da lista no textbox
                    }
                }

                lblContVagas.Text = Generica.calculaVagas(ListaGaragem);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o cadastro!\n" + ex.Message, "Erro");
            }
            LimpaTela();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();

        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            tbDtEnt.Text = dtPicker.Value.Day.ToString().PadLeft(2, '0') + "/" + dtPicker.Value.Month.ToString().PadLeft(2, '0') + "/" + dtPicker.Value.Year.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult RespostaMessaBox = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo);

            if (RespostaMessaBox == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btLiberar_Click(object sender, EventArgs e)
        {

            if (mskTbHrSaida.Text.Replace(":", "").Trim() == "")
            {
                MessageBox.Show("Hora não digitada", "Alerta!");
                return;
            }

            if (Generica.VerificaVeiculoSaida(ListaGaragemSaida, tbPlacaSaida.Text.ToUpper()) == -27)
            {
                MessageBox.Show("Veículo Já deu Saída", "Alerta!");
                return;
            }

            tbDtSaida.Text = dtPicker.Value.ToShortDateString(); //Coloca a Data no Campo de saída

            if (!Generica.ValidaHoraMinuto(mskTbHrSaida.Text))
            {
                MessageBox.Show("A hora está em formato incorreto", "Alerta!");
                return;
            }


           tbHrSaida.Text = mskTbHrSaida.Text;

            Garagem G = new Garagem();  //Inicializando construtor da Classe Garagem
            G.PlacaCarro = tbPlacaSaida.Text.ToUpper();
            G.DtSaida = tbDtSaida.Text;
            G.HrSaida = tbHrSaida.Text;
            G.HrEntrada = Generica.BuscaHoraEntrada(G.PlacaCarro, ListaGaragem);

            G.realizarCobranca(5.00);

            try
            {
                Generica.RemoveListaEntrada(ListaGaragem, tbPlacaSaida.Text.ToUpper());

                Generica.LimpaArquivoEntrada();

                tbEntrVeiculos.Text = "";

                foreach (Garagem placa in ListaGaragem)   // Laço de repeticao lendo cada placa da lista de Garagem
                {
                    tbEntrVeiculos.AppendText(placa.PlacaCarro + ";" + placa.DtEntrada + ";" + placa.HrEntrada + "\n");   //Escrevendo os itens da lista no textbox

                    Generica.gravaArquivoEntrada(new Garagem(placa.PlacaCarro, placa.DtEntrada, placa.HrEntrada));
                }

                Generica.gravaArquivoSaida(G);
            }
            catch (Exception ex)
            {

            }




            MessageBox.Show("Saída do veículo liberada!", "Sucesso");
            ListaGaragem.Clear();
            ListaGaragemSaida.Clear();
            Generica.lerArquivoEntrada(ListaGaragem); // Classe de Persistencia lendo o arquivo de entrada
            Generica.lerArquivoSaida(ListaGaragemSaida); // Classe de Persistencia lendo o arquivo de entrada

            if (ListaGaragemSaida.Count > 0)
            {

                foreach (Garagem placaSaida in ListaGaragemSaida)   // Laço de repetição lendo cada placa da lista de Garagem
                {
                    tbSaidaVeiculo.AppendText(placaSaida.PlacaCarro + ";" + placaSaida.DtSaida + ";" + placaSaida.HrSaida + ";" + placaSaida.ValorCobrado + "\n");   //Escrevendo os itens da lista no textbox
                }
            }

            LimpaTela();

            lblContVagas.Text = Generica.calculaVagas(ListaGaragem); //Calcula a quantidade de vagas disponiveis


        }

        public void LimpaTela()
        {
            tbPlaca.Text = "";
            tbHrEnt.Text = "";
            tbDtEnt.Text = "";
            tbPlacaSaida.Text = "";
            mskTbHrSaida.Text = "";
            mskTbDtEnt.Text = "";
        }

        private void btLimparSaida_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
    }
}