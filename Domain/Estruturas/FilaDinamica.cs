namespace Domain.Estruturas
{
    public class FilaDinamica
    {
        private NoInteiro inicio;

        public FilaDinamica()
        {
            inicio = new NoInteiro(null);
        }

        public void Enfileirar(int numero)
        {
            if (EstaVazio())
            {
                Console.WriteLine($"Número {numero} adicionado à fila.");
                inicio.Conteudo = numero;
            }
            else
            {
                NoInteiro novoNo = new NoInteiro(numero);
                NoInteiro aux = inicio;

                while (aux != null)
                {
                    if (aux.Prox == null)
                    {
                        Console.WriteLine($"Número {numero} adicionado à fila.");
                        aux.Prox = novoNo;
                        return;
                    }
                    aux = aux.Prox;
                }
            }
        }

        public void Exibir()
        {
            if (!EstaVazio())
            {
                NoInteiro aux = inicio;
                while (aux != null)
                {
                    Console.WriteLine(aux.Conteudo);
                    aux = aux.Prox;
                }
            }
        }

        private bool EstaVazio()
        {
            if (inicio.Conteudo == null)
            {
                Console.WriteLine("A fila está vazia.");
                return true;
            }
            return false;
        }

        public void Desenfileirar()
        {
            if (!EstaVazio())
            {
                if (inicio.Prox == null)
                {
                    inicio.Conteudo = null;
                }
                else
                {
                    inicio = inicio.Prox;
                }
            }
        }
    }
}
