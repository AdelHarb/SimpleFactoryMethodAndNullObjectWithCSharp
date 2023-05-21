namespace Factory.Core.Payment
{
    public class ZeroPayment : IPaymentMethod
    {
        public PaymentType PaymentType => PaymentType.ZeroPayment;
        public string Charge(decimal amount) => $"Charging {amount:C} to zero payment.";
    }
}