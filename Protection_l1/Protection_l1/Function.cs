using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
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

        public string OpenFile()
        {
            string textfile = null;
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "D:\\Project_lab\\GitHub\\Repos\\TheDevelopmentOfMeansOfProtection";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("windows-1251"));
                            while (!reader.EndOfStream)
                            {
                                textfile += reader.ReadLine();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            return textfile;
        }
    }
}
