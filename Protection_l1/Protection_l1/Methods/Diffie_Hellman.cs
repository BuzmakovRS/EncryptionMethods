using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protection_l1
{
    class Diffie_Hellman
    {
        Function func = new Function();

        public BigInteger x = new BigInteger();     //x
        public BigInteger y = new BigInteger();     //y
        public BigInteger q = new BigInteger();
        public BigInteger v = new BigInteger();     //n

        internal List<string> diffieHellman(string text, string xs, string ys, string qs, string vs)
        {
            List<string> result = new List<string>();
            string result_text = String.Empty;
            if (BigInteger.TryParse(xs, out x) && BigInteger.TryParse(ys, out y) &&
                BigInteger.TryParse(qs, out q) && BigInteger.TryParse(vs, out v))
            {

                BigInteger Kx = 0, Ky = 0;

                if (func.IsTheNumberSimple(x) && func.IsTheNumberSimple(y) &&
                        func.IsTheNumberSimple(q) && func.IsTheNumberSimple(v))
                {
                    BigInteger A = BigInteger.ModPow(q, x, v);
                    BigInteger B = BigInteger.ModPow(q, y, v);
                    Kx = BigInteger.ModPow(B, x, v);
                    Ky = BigInteger.ModPow(A, y, v);
                    result_text = diffieHellman_Encode(text, Kx);
                    result.Add(result_text);
                    result.Add(Kx.ToString());
                }
            }
            else MessageBox.Show("Проверьте корректность x и y(числовой формат)");
            return result;
        }

        internal string diffieHellman_Encode(string str, BigInteger k)
        {
            string result = "";
            BigInteger c;
            for (int i = 0; i < str.Length; i++)
            {
                BigInteger m = (BigInteger)(str[i]);
                c = BigInteger.Pow(m, (int)k);
                result += (c.ToString()) + " ";
            }
            return result;
        }

        internal string diffieHellman_Decode(string str, string ks)
        {
            string result = "";
            BigInteger c;
            long ch;
            int k = Convert.ToInt32(ks);
            string[] Array_str = str.Split(' ');

            for (int i = 0; i < Array_str.Length - 1; i++)
            {
                BigInteger.TryParse(Array_str[i], out c);
                ch = (long)Math.Round(Math.Exp(BigInteger.Log(c) / k));
                result += Convert.ToChar(ch);
            }
            return result;

        }
    }
}
