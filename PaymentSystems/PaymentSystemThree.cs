namespace PaymentSystems
{
    class PaymentSystemThree : IPaymentSystem
    {
        private readonly string _domain;
        private readonly string _secretKey;
        private readonly HashCalculator _hashCalculator;

        public PaymentSystemThree(string domain, HashCalculator hashCalculator, string secretKey)
        {
            Utils.ValidationParams(domain, hashCalculator, secretKey);

            _domain = domain;
            _hashCalculator = hashCalculator;
            _secretKey = secretKey;
        }

        public string GetPayingLink(Order order)
        {
            return $"{_domain}/pay?amount={order.Amount}&curency=RUB&hash={_hashCalculator.GetHash($"{order.Amount}{order.Id}{_secretKey}")}";
        }
    }
}
