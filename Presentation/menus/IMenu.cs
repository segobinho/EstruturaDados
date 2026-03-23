namespace Presentation.Menus
{
    public interface IMenu
    {
        string Name { get; }
        string Description { get; }
        void Execute();
    }
}
