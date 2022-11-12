namespace GlobalSolution_Polaris.Models
{
    public class EnderecoRepository : IEnderecoRepository
    {

        public EnderecoRepository(MulherApiDbContext context)
        {
            _context = context;
        }

        private readonly MulherApiDbContext _context;
        public void Atualizar(Endereco endereco)
        {
            Endereco enderecoN = ObterPorId(endereco.EnderecoID);

            if (enderecoN == null) throw new Exception("Usuario não encontrado");
            
            enderecoN.Cep = endereco.Cep;
            enderecoN.NomeRua = endereco.NomeRua;   
            enderecoN.NumeroRua = endereco.NumeroRua;
            enderecoN.DescricaoComplemento = endereco.DescricaoComplemento;

            _context.SaveChanges();
        }

        public void Cadastrar(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
        }

        public List<Endereco> Listar()
        {
            return _context.Enderecos.ToList();
        }

        public Endereco? ObterPorId(long id)
        {
            return _context.Enderecos.FirstOrDefault(e => e.EnderecoID == id); 
        }

        public void Remover(Endereco endereco)
        {
            _context.Enderecos.Remove(endereco);    

            _context.SaveChanges();
        }
    }
}
