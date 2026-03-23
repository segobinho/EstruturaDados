namespace Domain.Estruturas
{
    public class NoInteiro
    {
        public int? Conteudo { get; set; }
        public NoInteiro Prox { get; set; }

        public NoInteiro(int? conteudo)
        {
            Conteudo = conteudo;
            Prox = null;
        }
    }
}
