namespace GlobalSolution_Polaris.Models
{
    public class LocalEscolhido
    {
        public int LocalEscolhidoID { get; set; }

        public string Incidente { get; set; }

        public int AvaliacaoPerigo { get; set; }

        //Relacionamento com mulher

        public int MulherID { get; set; }

        public Mulher mulher { get; set; }


    }
}
