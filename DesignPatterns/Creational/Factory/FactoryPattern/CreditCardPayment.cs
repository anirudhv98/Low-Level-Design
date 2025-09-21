namespace FactoryPattern;

/// <summary>
/// CreditCardPayment class
/// </summary>
public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Payment of ${amount} made using credit card");
    }
}