namespace PaymentSystems
{
    interface IPaymentSystem
    {
        public string GetPayingLink(Order order);
    }
}
