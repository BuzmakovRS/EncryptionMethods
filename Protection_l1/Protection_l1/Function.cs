using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Protection_l1
{
    public class Function
    {
        //------------------------------------------------------------------------------------------------------------
        //Метод перестановки

        public string permutationСipher(string str)
        {
            string result = String.Empty;
            for (int i = 1; i < str.Length; i += 2)
            {
                result += str[i].ToString() + str[i - 1].ToString();
            }
            if (str.Length % 2 != 0)
                result += str[str.Length - 1];
            return result;
        }
        //------------------------------------------------------------------------------------------------------------
        public BigInteger GenerationOfNumbers(int n)
        {
            BigInteger p;
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[n];
            do
            {
                rng.GetBytes(bytes);
                p = BigInteger.Abs(new BigInteger(bytes));
            } while (!IsTheNumberSimple(p));
            return p;
        }

        public bool IsTheNumberSimple(BigInteger n)
        {
            var lim = (n > 16) ? Convert.ToInt64(Math.Ceiling(Math.Exp(BigInteger.Log(n) / 2))) : n;
            for (long i = 2; i < lim; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
