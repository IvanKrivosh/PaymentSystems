namespace PaymentSystems
{
    class PaymentSystemOne : IPaymentSystem
    {
        private readonly string _domain;
        private readonly HashCalculator _hashCalculator;

        public PaymentSystemOne(string domain, HashCalculator hashCalculator)
        {
            Utils.ValidationParams(domain, hashCalculator);

            _domain = domain;
            _hashCalculator = hashCalculator;
        }

        public string GetPayingLink(Order order)
        {
            return $"{_domain}/order?amount={order.Amount}RUB&hash={_hashCalculator.GetHash(order.Id.ToString())}";
        }
    }
}
