namespace FactoryPattern;

/// <summary>
/// Payment Factory
/// </summary>
public class PaymentFactory
{
    public static IPayment Create(PaymentMethod payment)
    {
        switch (payment)
        {
            case PaymentMethod.CreditCard:
                return new CreditCardPayment();

            case PaymentMethod.PayPal:
                return new PayPalPayment();

            case PaymentMethod.GooglePay:
                return new GooglePayPayment();

            default:
                throw new NotImplementedException("Payment method is not implemented");
        }
    }
}