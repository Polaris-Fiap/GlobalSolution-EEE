namespace GlobalSolution_Polaris.Models
{
    public class LocalEscolhidoRepository : ILocalEscolhidoRepository
    {

        private readonly MulherApiDbContext _context;

        public LocalEscolhidoRepository(MulherApiDbContext context)
        {
            _context = context;
        }

        public void Atualizar(LocalEscolhido localEscolhido)
        {
            LocalEscolhido localN = ObterPorId(localEscolhido.LocalEscolhidoID);

            if (localN == null) throw new Exception("Usuario não encontrado");

            localN.Incidente = localEscolhido.Incidente;
            localN.AvaliacaoPerigo = localEscolhido.AvaliacaoPerigo;

            _context.SaveChanges();
        }   

        public void Cadastrar(LocalEscolhido localEscolhido)
        {
            _context.LocaisEscolhidos.Add(localEscolhido);

            _context.SaveChanges();
        }

        public List<LocalEscolhido> Listar()
        {
            return _context.LocaisEscolhidos.ToList();
        }

        public LocalEscolhido? ObterPorId(long id)
        {
            return _context.LocaisEscolhidos.FirstOrDefault(l => l.LocalEscolhidoID == id);
        }

        public void Remover(LocalEscolhido localEscolhido)
        {
            _context.LocaisEscolhidos.Remove(localEscolhido);

            _context.SaveChanges();
        }
    }
}
