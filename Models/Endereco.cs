namespace GlobalSolution_Polaris.Models
{
    public class Endereco
    {
        public int EnderecoID { get; set; }

        public int Cep { get; set; }

        public string? NomeRua { get; set; }

        public int NumeroRua { get; set; }

        public string? DescricaoComplemento { get; set; }

        //Relacionamento bairro
        //public int BairroID { get; set; }

        //public virtual Bairro? Bairros { get; set; }

        //Relacionamento mulher
        public List<Mulher> MulheresRel { get; set; }

        //public Endereco () { }

        //public Endereco(int enderecoID, int cep, string? nomeRua, int numeroRua, string? descricaoComplemento, int bairroID, Bairro? bairros, List<Mulher>? mulheres)
        //{
        //    EnderecoID = enderecoID;
        //    Cep = cep;
        //    NomeRua = nomeRua;
        //    NumeroRua = numeroRua;
        //    DescricaoComplemento = descricaoComplemento;
        //    BairroID = bairroID;
        //    Bairros = bairros;
        //    Mulheres = mulheres;
        //}
    }
}
