namespace GlobalSolution_Polaris.Models
{
    public class Bairro
    {
        public int BairroID { get; set; }   

        public string? NomeBairro { get; set; }

        //Relacionamento Cidade
        public int CidadeID { get; set; }

        public virtual Cidade? Cidade { get; set; }

        //Relacionamento Endereco
        public List<Endereco>? Enderecos { get; set; }

        //public Bairro () { }

        //public Bairro(int bairroID, string? nomeBairro, int cidadeID, Cidade? cidade, List<Endereco>? enderecos)
        //{
        //    BairroID = bairroID;
        //    NomeBairro = nomeBairro;
        //    CidadeID = cidadeID;
        //    Cidade = cidade;
        //    Enderecos = enderecos;
        //}
    }
}
