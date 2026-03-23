using Domain.Estruturas;

namespace Presentation.Menus
{
    public class MenuFilaSimples : IMenu
    {
        public string Name => "1";
        public string Description => "Fila Simples";

        public void Execute()
        {
            Console.Write("Tamanho da fila: ");
            int tamanho = int.Parse(Console.ReadLine());

            var fila = new FilaSimples(tamanho);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== FILA SIMPLES ===");
                Console.WriteLine("1 - Enfileirar");
                Console.WriteLine("2 - Desenfileirar");
                Console.WriteLine("3 - Exibir");
                Console.WriteLine("0 - Voltar");

                var op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Número: ");
                        fila.Enfileirar(int.Parse(Console.ReadLine()));
                        break;

                    case "2":
                        fila.Desenfileirar();
                        break;

                    case "3":
                        fila.Exibir();
                        break;

                    case "0":
                        return;
                }

                Console.WriteLine("\nPressione qualquer tecla...");
                Console.ReadKey();
            }
        }
    }
}
