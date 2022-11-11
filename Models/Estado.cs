namespace GlobalSolution_Polaris.Models
{
    public class Estado
    {
        public int EstadoID { get; set; }
        public string? NomeEstado { get; set; }
        public string? SiglaEstado { get; set; }

        //Relacionamento
        public virtual List<Cidade>? Cidades { get; set; }

        public Estado () { }

        public Estado(int estadoID, string? nomeEstado, string? siglaEstado, List<Cidade>? cidades)
        {
            EstadoID = estadoID;
            NomeEstado = nomeEstado;
            SiglaEstado = siglaEstado;
            Cidades = cidades;
        }
    }
}
