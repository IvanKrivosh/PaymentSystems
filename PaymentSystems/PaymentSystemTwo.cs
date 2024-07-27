namespace PaymentSystems
{
    class PaymentSystemTwo : IPaymentSystem
    {
        private readonly string _domain;
        private readonly HashCalculator _hashCalculator;

        public PaymentSystemTwo(string domain, HashCalculator hashCalculator)
        {
            Utils.ValidationParams(domain, hashCalculator);

            _domain = domain;
            _hashCalculator = hashCalculator;
        }

        public string GetPayingLink(Order order)
        {            
            return $"{_domain}/pay?hash={_hashCalculator.GetHash($"{order.Id}{order.Amount}")}";
        }
    }
}
