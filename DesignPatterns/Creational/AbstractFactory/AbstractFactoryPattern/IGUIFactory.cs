using AbstractFactoryPattern;

/// <summary>
/// GUI Factory
/// </summary>
public interface IGUIFactory
{
    IButton CreateButton();

    ICheckbox CreateCheckbox();
}