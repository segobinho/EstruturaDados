namespace Domain.Estruturas
{
    public class FilaSimples
    {
        private int?[] fila;

        public FilaSimples(int tamanho)
        {
            fila = new int?[tamanho];
        }

        public void Enfileirar(int numero)
        {
            if (!EstaCheia())
            {
                for (int i = 0; i < fila.Length; i++)
                {
                    if (fila[i] == null)
                    {
                        fila[i] = numero;
                        Console.WriteLine($"Número {numero} inserido com sucesso.");
                        return;
                    }
                }
            }
        }

        private bool EstaCheia()
        {
            if (fila[fila.Length - 1] != null)
            {
                Console.WriteLine("Fila cheia!");
                return true;
            }
            return false;
        }

        private bool EstaVazia()
        {
            if (fila[0] == null)
            {
                Console.WriteLine("Fila vazia!");
                return true;
            }
            return false;
        }

        public void Exibir()
        {
            if (!EstaVazia())
            {
                foreach (var item in fila)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void Desenfileirar()
        {
            if (!EstaVazia())
            {
                for (int i = 0; i < fila.Length - 1; i++)
                {
                    fila[i] = fila[i + 1];
                }

                fila[fila.Length - 1] = null;
            }
        }
    }
}
