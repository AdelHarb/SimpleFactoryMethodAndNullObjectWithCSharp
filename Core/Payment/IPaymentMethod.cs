namespace Factory.Core.Payment;

public interface IPaymentMethod
{
    PaymentType PaymentType { get; }
    string Charge(decimal amount);
}