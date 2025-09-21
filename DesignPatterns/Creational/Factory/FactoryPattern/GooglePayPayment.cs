namespace FactoryPattern;

/// <summary>
/// GooglePayPayment class
/// </summary>
public class GooglePayPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Payment of ${amount} made using Google Pay");
    }
}