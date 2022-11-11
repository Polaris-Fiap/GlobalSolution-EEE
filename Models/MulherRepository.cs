namespace GlobalSolution_Polaris.Models
{
    public class MulherRepository : IMulherRepository
    {

        private readonly MulherApiDbContext _context;

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
            _context.Mulheres.Add(mulher);
            _context.SaveChanges();
        }

        public IEnumerable<Mulher> Listar()
        {
            return _context.Mulheres.OrderBy(m => m.MulherID);
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
