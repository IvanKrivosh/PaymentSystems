using System.Security.Cryptography;

namespace PaymentSystems
{
    class CalculatorSHA1 : HashCalculator
    {
        protected override HashAlgorithm GetHashAlgorithm()
        {
            return SHA1.Create();
        }
    }
}
