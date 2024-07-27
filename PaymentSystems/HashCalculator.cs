using System.Security.Cryptography;
using System.Text;

namespace PaymentSystems
{
    abstract class HashCalculator
    {
        public string GetHash(string input)
        {
            Utils.ValidationParams(input);

            HashAlgorithm hashAlgorithm = GetHashAlgorithm();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = hashAlgorithm.ComputeHash(inputBytes);

            return Convert.ToHexString(hashBytes);
        }

        protected abstract HashAlgorithm GetHashAlgorithm();        
    }
}
