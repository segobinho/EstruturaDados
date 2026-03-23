namespace Presentation.menus
{
    public interface IMenu
    {
        string Name { get; }
        string Description { get; }
        void Execute();
    }
}
