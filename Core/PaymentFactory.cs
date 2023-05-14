namespace Factory.Core.Payment
{
    public class PaymentFactory
    {
        public IPaymentMethod GetPaymentMethod(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CreditCard:
                    return new CreditCard();
                case PaymentType.DebitCard:
                    return new DebitCard();
                default:
                    return new ZeroPayment();
            }
        }
    }
}