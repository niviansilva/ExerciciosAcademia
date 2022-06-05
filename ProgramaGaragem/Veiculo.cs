namespace ProgramaGaragem
{
    class Veiculo
    {
         string placa;
        DateTime dataHoraEntrada;

        public Veiculo(string placa, DateTime dataHoraEntrada)
        {
            this.placa = placa;
            this.dataHoraEntrada = dataHoraEntrada;
        }



        public string placaCarro { get => placa; set => placa = value; }
        public DateTime dtHEntrada { get => dataHoraEntrada; set => dataHoraEntrada = value; }


    }
}
