using Domain.Estruturas;

namespace Presentation.Menus
{
    public class MenuFilaDinamica : IMenu
    {
        public string Name => "2";
        public string Description => "Fila Dinâmica";

        public void Execute()
        {
            var fila = new FilaDinamica();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== FILA DINÂMICA ===");
                Console.WriteLine("1 - Enfileirar");
                Console.WriteLine("2 - Desenfileirar");
                Console.WriteLine("3 - Exibir");
                Console.WriteLine("0 - Voltar");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o número: ");
                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            fila.Enfileirar(numero);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;

                    case "2":
                        fila.Desenfileirar();
                        break;

                    case "3":
                        fila.Exibir();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla...");
                Console.ReadKey();
            }
        }
    }
}
