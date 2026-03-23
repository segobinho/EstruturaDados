namespace Domain.Estruturas
{
    public class PilhaDinamica
    {
        private NoInteiro topo;

        public PilhaDinamica()
        {
            topo = new NoInteiro(null);
        }

        public void Empilhar(int numero)
        {
            if (EstaVazio())
            {
                Console.WriteLine($"{numero} adicionado ao topo.");
                topo.Conteudo = numero;
            }
            else
            {
                NoInteiro novoNo = new NoInteiro(numero);
                novoNo.Prox = topo;
                topo = novoNo;

                Console.WriteLine($"{numero} adicionado ao topo.");
            }
        }


        public int? Desempilhar()
        {
            if (!EstaVazio())
            {
                int? valor = topo.Conteudo;

                if (topo.Prox == null)
                    topo.Conteudo = null;
                else
                    topo = topo.Prox;

                return valor;
            }

            return null;
        }

        public int? Topo()
        {
            if (!EstaVazio())
                return topo.Conteudo;

            return null;
        }

        public void Exibir()
        {
            if (!EstaVazio())
            {
                NoInteiro aux = topo;

                while (aux != null)
                {
                    Console.WriteLine(aux.Conteudo);
                    aux = aux.Prox;
                }
            }
        }

        private bool EstaVazio()
        {
            if (topo.Conteudo == null)
            {
                Console.WriteLine("a pilha está vazia.");
                return true;
            }
            return false;
        }
    }
}