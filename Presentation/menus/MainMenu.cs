namespace Presentation.Menus
{
    public class MainMenu
    {
        private readonly List<IMenu> _menus;

        public MainMenu(List<IMenu> menus)
        {
            _menus = menus;
        }

        public void Executar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENU ===");

                foreach (var menu in _menus)
                {
                    Console.WriteLine($"{menu.Name} - {menu.Description}");
                }

                Console.WriteLine("0 - Sair");

                var opcao = Console.ReadLine();

                if (opcao == "0")
                    return;

                var menuSelecionado = _menus
                    .FirstOrDefault(m => m.Name == opcao);

                if (menuSelecionado != null)
                {
                    menuSelecionado.Execute();
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                }
            }
        }
    }
}
