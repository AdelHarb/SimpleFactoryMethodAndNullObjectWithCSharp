namespace Factory.Core.Payment
{
    public class DebitCard : IPaymentMethod
    {
        public PaymentType PaymentType => PaymentType.DebitCard;
        public string Charge(decimal amount) => $"Charging {amount:C} to debit card.";
    }
}