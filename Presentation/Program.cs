using Presentation.menus;
using Presentation.Menus;

while (true)
{
    try
    {
        var menus = new List<IMenu>
        {
            new MenuFilaSimples(),
            new MenuFilaDinamica(),
            new MenuPilhaSimples(),
            new MenuPilhaDinamica()
        };

        var menuPrincipal = new MainMenu(menus);
        menuPrincipal.Executar();

        break;
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex.Message);
        Console.ReadKey();
    }
}