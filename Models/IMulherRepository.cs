namespace GlobalSolution_Polaris.Models
{
    public interface IMulherRepository
    {
        public Mulher? ObterPorId(long id);
        public List<Mulher> Listar();
        public void Cadastrar(Mulher mulher);
        public void Atualizar(Mulher mulher);
        public void Remover(Mulher mulher);
    }
}
