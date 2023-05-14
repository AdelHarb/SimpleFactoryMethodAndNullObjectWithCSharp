namespace Factory.Core.Payment
{
    public class CreditCard : IPaymentMethod
    {
        public PaymentType PaymentType => PaymentType.CreditCard;
        public string Charge(decimal amount) => $"Charging {amount:C} to credit card.";
        
    }
}