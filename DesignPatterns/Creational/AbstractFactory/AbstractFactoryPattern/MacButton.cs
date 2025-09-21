using AbstractFactoryPattern;

/// <summary>
/// MacButton class
/// </summary>
public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering mac button..."); ;
    }
}
