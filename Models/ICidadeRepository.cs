namespace GlobalSolution_Polaris.Models
{
    public interface ICidadeRepository
    {
        public Cidade? ObterPorId(long id);
        public List<Cidade> Listar();
        public void Cadastrar(Cidade cidade);
        public void Atualizar(Cidade cidade);
        public void Remover(Cidade cidade);
    }
}
