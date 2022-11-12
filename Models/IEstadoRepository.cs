namespace GlobalSolution_Polaris.Models
{
    public interface IEstadoRepository
    {
        public Estado? ObterPorId(long id);
        public List<Estado> Listar();
        public void Cadastrar(Estado estado);
        public void Atualizar(Estado estado);
        public void Remover(Estado estado);
    }
}
