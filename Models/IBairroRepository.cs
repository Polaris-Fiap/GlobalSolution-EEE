namespace GlobalSolution_Polaris.Models
{
    public interface IBairroRepository
    {
        public Bairro? ObterPorId(long id);
        public List<Bairro> Listar();
        public void Cadastrar(Bairro bairro);
        public void Atualizar(Bairro bairro);
        public void Remover(Bairro bairro);
    }
}
