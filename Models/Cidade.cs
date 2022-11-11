namespace GlobalSolution_Polaris.Models
{
    public class Cidade
    {
        public int CidadeID { get; set; }
        public string? NomeCidade { get; set; }

        public string? SiglaCidade { get; set; }

        //Relacionamento estado
        public int EstadoID { get; set; }

        public virtual Estado? Estado { get; set; }

        //Relacionamento bairro

        public List<Bairro>? Bairros { get; set; }

        public Cidade () { }

        public Cidade(int cidadeID, string? nomeCidade, string? siglaCidade, int estadoID, Estado? estado, List<Bairro>? bairros)
        {
            CidadeID = cidadeID;
            NomeCidade = nomeCidade;
            SiglaCidade = siglaCidade;
            EstadoID = estadoID;
            Estado = estado;
            Bairros = bairros;
        }
    }
}
