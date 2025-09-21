using FactoryPattern;

IPayment payment = PaymentFactory.Create(PaymentMethod.CreditCard);
payment.Pay(100);

payment = PaymentFactory.Create(PaymentMethod.PayPal);
payment.Pay(50);

payment = PaymentFactory.Create(PaymentMethod.GooglePay);
payment.Pay(20);

