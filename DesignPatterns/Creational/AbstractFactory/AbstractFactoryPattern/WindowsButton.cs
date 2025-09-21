namespace AbstractFactoryPattern;

/// <summary>
/// WindowsButton class
/// </summary>
public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering windows button...");
    }
}