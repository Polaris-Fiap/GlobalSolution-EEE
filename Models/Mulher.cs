namespace GlobalSolution_Polaris.Models
{
    public class Mulher
    {
        public int MulherID { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }

        //data
        public int Cpf { get; set; }

        public int Telefone { get; set; }

        //Relacionamento Endereco
        public int EnderecoID { get; set; }

        public Endereco Endereco { get; set; }

        //Relacionamento com local escolhido

        //public List<LocalEscolhido> Locais { get; set; }


        //public Mulher(int mulherID, string? nome, string? email, string? senha, int cpf, int telefone, int enderecoID, Endereco? endereco)
        //{
        //    MulherID = mulherID;
        //    Nome = nome;
        //    Email = email;
        //    Senha = senha;
        //    Cpf = cpf;
        //    Telefone = telefone;
        //    EnderecoID = enderecoID;
        //    Endereco = endereco;
        //}


    }


}
