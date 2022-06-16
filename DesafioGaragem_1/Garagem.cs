using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioGaragem_1
{
    class Garagem
    {
        string Placa;
        string DataEntrada;
        string HoraEntrada;
        string DataSaida;
        string HoraSaida;
        double VlrCobrado;
        double VlrHora;
        double TempoPermanencia;

        public Garagem()
        {

        }
       public Garagem( string Placa)
        {
            this.Placa = Placa;
        }
        public Garagem(string Placa, string DataEntrada , string HoraEntrada)
        {
            this.Placa=Placa;
            this.DataEntrada=DataEntrada;
            this.HoraEntrada=HoraEntrada;
        }

        public Garagem(string Placa, string DataSaida, string HoraSaida, double ValorCobrado)
        {
            this.Placa = Placa;
            this.DataSaida = DataSaida;
            this.HoraSaida = HoraSaida;
            this.ValorCobrado = ValorCobrado;
        }

        public void realizarCobranca(double ValorHora)
        {

        if (HoraEntrada == "Erro")
            {
                MessageBox.Show("A hora de entrada não retornou corretamente");
                return;
            }

            string[] arrayplaca = HoraEntrada.Split(':');   //Descobrindo o tempo em minutos da entrada
            int hora = int.Parse(arrayplaca[0]);
            int minutos = int.Parse(arrayplaca[1]);
            int entrada = hora * 60 + minutos;

            arrayplaca = HoraSaida.Split(':'); //Descobrindo o tempo em minutos da saida
            hora = int.Parse(arrayplaca[0]);
            minutos = int.Parse(arrayplaca[1]);
            int saida = hora * 60 + minutos;

            this.TempoPermanencia = saida - entrada;
            double resultado = (double)this.TempoPermanencia / 60;
            double qtdHorasNaGaragem = Math.Ceiling(resultado);

            this.ValorCobrado = (int)qtdHorasNaGaragem * ValorHora;
        }

        public string PlacaCarro{ get=>Placa; set =>Placa = value; } 
        public string DtEntrada { get=>DataEntrada; set =>DataEntrada = value; }
        public string HrEntrada { get=>HoraEntrada;set =>HoraEntrada = value; }
        public string DtSaida { get => DataSaida; set => DataSaida = value; }
        public string HrSaida { get => HoraSaida; set => HoraSaida = value; }
        public double ValorCobrado { get => VlrCobrado; set => VlrCobrado = value; }
        public double ValorHora { get => VlrHora; set => VlrHora = value; }
    }
}
