namespace GlobalSolution_Polaris.Models
{
    public class MulherRepository : IMulherRepository
    {

        public IEnumerable<Mulher> MulheresMock =>
            new List<Mulher>()
            {
                new Mulher
                {
                    MulherID = 1,
                    Nome = "Claudia",
                    Email = "clau@gmail.com",
                    Senha = "123",
                    Cpf = 132,
                    Telefone = 123
                },
                new Mulher
                {
                    MulherID = 2,
                    Nome = "Silvia",
                    Email = "silvie@gmail.com",
                    Senha = "123",
                    Cpf = 132,
                    Telefone = 123
                }
            };

        private readonly MulherApiDbContext _context;

        public MulherRepository(MulherApiDbContext context)
        {
            _context = context;
        }

        public void Atualizar(Mulher mulher)
        {
            Mulher mulherN = ObterPorId(mulher.MulherID);

            if (mulherN == null) throw new Exception("Usuario não encontrado");

            mulherN.Nome = mulher.Nome;
            mulherN.Email = mulher.Email;
            mulherN.Senha = mulher.Senha;
            mulherN.Cpf = mulher.Cpf;
            mulherN.Telefone = mulher.Telefone;

            _context.SaveChanges();
        }

        public void Cadastrar(Mulher mulher)
        {

            Endereco endereco = new Endereco();

            endereco.Cep = mulher.Endereco.Cep;
            endereco.NomeRua = mulher.Endereco.NomeRua;
            endereco.NumeroRua = mulher.Endereco.NumeroRua;
            endereco.DescricaoComplemento = mulher.Endereco.DescricaoComplemento;

            _context.Enderecos.Add(endereco);
            _context.Mulheres.Add(mulher);
            _context.SaveChanges();
        }

        public List<Mulher> Listar()
        {
            return _context.Mulheres.ToList();
        }

        public Mulher? ObterPorId(long id)
        {
            return _context.Mulheres.FirstOrDefault(m => m.MulherID == id); 
        }

        public void Remover(Mulher mulher)
        {
            _context.Mulheres.Remove(mulher);

            _context.SaveChanges();
        }
    }
}
