using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protection_l1
{
    class RSA
    {
        public BigInteger p = new BigInteger();     //x
        public BigInteger q = new BigInteger();     //y
        Function func = new Function();

        internal List<string> rsaChiper(string text, string ps, string qs)
        {
            List<string> result = new List<string>();
            string result_text = String.Empty;
            if (BigInteger.TryParse(ps, out p) && BigInteger.TryParse(qs, out q))
            {
                if (func.IsTheNumberSimple(p) && func.IsTheNumberSimple(q))
                {
                    BigInteger n = BigInteger.Multiply(p, q);
                    BigInteger m = BigInteger.Multiply((p - 1), (q - 1));
                    BigInteger e = Calculate_e(m);
                    BigInteger d = Calculate_d(e, m);
                    result_text = RSA_Endoce(text, e, n);
                    string result_d = d.ToString();
                    string result_n = n.ToString();
                    result.Add(result_text);
                    result.Add(result_d);
                    result.Add(result_n);
                }
                else
                    MessageBox.Show("x или y - не простые числа!");
            }
            else
                MessageBox.Show("Проверьте корректность x и y(числовой формат)");
            return result;
        }

        internal BigInteger Calculate_e(BigInteger m)
        {
            bool b = true;
            BigInteger e = (BigInteger)Math.Round(Math.Exp(BigInteger.Log(m) / 2));
            while (b)
            {
                if (BigInteger.GreatestCommonDivisor(m, e) != 1)
                    e--;
                else { b = false; }
            }
            return e;
        }

        internal BigInteger Calculate_d(BigInteger e, BigInteger m)
        {
            BigInteger a = new BigInteger();
            a = e;
            BigInteger b = m, x = 0, d = 1;
            while (a.CompareTo(0) == 1) //a>0
            {
                BigInteger q = b / a, y = a;
                a = b % a;
                b = y;
                y = d;
                d = BigInteger.Subtract(x, (BigInteger.Multiply(q, d)));
                x = y;
            }
            x = x % m;
            if (x.CompareTo(0) == -1)   //x<0
            {
                x = (BigInteger.Add(x, m)) % m;
            }
            return x;
        }

        internal string RSA_Endoce(string s, BigInteger e, BigInteger n)
        {
            string result = String.Empty;

            BigInteger c;

            for (int i = 0; i < s.Length; i++)
            {
                BigInteger m = (BigInteger)(s[i]);
                c = BigInteger.ModPow(m, e, n);
                result += c.ToString() + ' ';
            }
            return result;
        }

        //----------------------------------------------------------------------------------------------------
        //RSA - Дешифровка
        internal string rsaDecryption(string str, string ds, string ns)
        {
            string result = String.Empty;
            BigInteger d, n;
            if (BigInteger.TryParse(ds, out d) && BigInteger.TryParse(ns, out n))
            {
                String[] text_2_array = str.Split(' ');
                List<string> input = new List<string>(text_2_array);
                result = RSA_Dedoce(input, d, n);
            }
            else MessageBox.Show("Проверьте корректность ключей(числовой формат)");
            return result;
        }

        internal string RSA_Dedoce(List<string> input, BigInteger d, BigInteger n)
        {
            string result = "";

            BigInteger m, c;
            c = new BigInteger();
            foreach (string item in input)
            {

                BigInteger.TryParse(item, out c);
                m = BigInteger.ModPow(c, d, n);
                result += Convert.ToChar((int)m);
            }

            return result;
        }

    }
}
