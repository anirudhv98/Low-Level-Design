using AbstractFactoryPattern;

/// <summary>
/// MacCheckbox class
/// </summary>
public class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering mac checkbox..."); ;
    }
}