using Domain.Estruturas;

namespace Presentation.Menus
{
    public class MenuPilhaDinamica : IMenu
    {
        public string Name => "4";
        public string Description => "Pilha Dinâmica";

        public void Execute()
        {
            var pilha = new PilhaDinamica();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== PILHA DINÂMICA ===");
                Console.WriteLine("1 - Empilhar");
                Console.WriteLine("2 - Desempilhar");
                Console.WriteLine("3 - Ver topo");
                Console.WriteLine("4 - Exibir");
                Console.WriteLine("0 - Voltar");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o número: ");
                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            pilha.Empilhar(numero);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;

                    case "2":
                        var removido = pilha.Desempilhar();
                        if (removido != null)
                            Console.WriteLine($"Removido: {removido}");
                        break;

                    case "3":
                        var topo = pilha.Topo();
                        if (topo != null)
                            Console.WriteLine($"Topo: {topo}");
                        break;

                    case "4":
                        pilha.Exibir();
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