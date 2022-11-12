namespace GlobalSolution_Polaris.Models
{
    public interface IEnderecoRepository
    {
        public Endereco? ObterPorId(long id);
        public List<Endereco> Listar();
        public void Cadastrar(Endereco endereco);
        public void Atualizar(Endereco endereco);
        public void Remover(Endereco endereco);
    }
}
