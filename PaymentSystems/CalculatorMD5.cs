using System.Security.Cryptography;

namespace PaymentSystems
{
    class CalculatorMD5 : HashCalculator
    {
        protected override HashAlgorithm GetHashAlgorithm()
        {
            return MD5.Create();
        }
    }
}
