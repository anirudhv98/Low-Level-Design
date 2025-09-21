namespace AbstractFactoryPattern;

/// <summary>
/// WindowsCheckbox class
/// </summary>
public class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering windows checkbox..."); ;
    }
}