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

        public virtual Endereco? Endereco { get; set; }


        public Mulher () { }
        public Mulher(int mulherID, string? nome, string? email, string? senha, int cpf, int telefone, int enderecoID, Endereco? endereco)
        {
            MulherID = mulherID;
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            Telefone = telefone;
            EnderecoID = enderecoID;
            Endereco = endereco;
        }
    }
}
