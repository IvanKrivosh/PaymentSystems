using PaymentSystems;

Order order = new Order(1, 12000);
List<IPaymentSystem> paymentSystems = new List<IPaymentSystem>()
{
    new PaymentSystemOne("pay.system1.ru", new CalculatorMD5()),
    new PaymentSystemTwo("order.system2.ru", new CalculatorMD5()),
    new PaymentSystemThree("system3.com", new CalculatorSHA1(), "1234567890")
};

foreach (var paymentSystem in paymentSystems)
    Console.WriteLine(paymentSystem.GetPayingLink(order));


