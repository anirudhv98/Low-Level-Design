namespace FactoryPattern;

/// <summary>
/// PayPalPayment class
/// </summary>
public class PayPalPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Payment of ${amount} made using PayPal");
    }
}