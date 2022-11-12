namespace GlobalSolution_Polaris.Models
{
    public interface ILocalEscolhidoRepository
    {
        public LocalEscolhido? ObterPorId(long id);
        public List<LocalEscolhido> Listar();
        public void Cadastrar(LocalEscolhido localEscolhido);
        public void Atualizar(LocalEscolhido localEscolhido);
        public void Remover(LocalEscolhido localEscolhido);
    }
}
