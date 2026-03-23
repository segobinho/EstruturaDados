namespace Domain.Estruturas
{
    public class PilhaSimples
    {
        private int?[] Pilha;

        public PilhaSimples(int tamanho)
        {
            Pilha = new int?[tamanho];
        }

        public void Empilhar(int numero)
        {
            if (!EstaCheia())
            {
                for (int i = 0; i < Pilha.Length; i++)
                {
                    if (Pilha[i] == null)
                    {
                        Pilha[i] = numero;
                        Console.WriteLine($"{numero} inserido no topo.");
                        return;
                    }
                }
            }
        }

        public int? Desempilhar()
        {
            if (!EstaVazia())
            {
                for (int i = Pilha.Length - 1; i >= 0; i--)
                {
                    if (Pilha[i] != null)
                    {
                        int? valor = Pilha[i];
                        Pilha[i] = null;
                        return valor;
                    }
                }
            }

            return null;
        }


        public int? Topo()
        {
            if (!EstaVazia())
            {
                for (int i = Pilha.Length - 1; i >= 0; i--)
                {
                    if (Pilha[i] != null)
                    {
                        return Pilha[i];
                    }
                }
            }

            return null;
        }

        public void Exibir()
        {
            if (!EstaVazia())
            {
                for (int i = Pilha.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(Pilha[i]);
                }
            }
        }

        private bool EstaCheia()
        {
            if (Pilha[Pilha.Length - 1] != null)
            {
                Console.WriteLine("Pilha cheia");
                return true;
            }
            return false;
        }

        private bool EstaVazia()
        {
            if (Pilha[0] == null)
            {
                Console.WriteLine("Pilha vazia");
                return true;
            }
            return false;
        }
    }
}