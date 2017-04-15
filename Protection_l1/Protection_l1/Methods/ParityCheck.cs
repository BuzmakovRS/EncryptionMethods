using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionMethods.Methods
{
    class ParityCheck
    {
        internal List<string> Encoding(string text)
        {
            List<string> result = new List<string>();
            string result_str = String.Empty;
            string binaryCode = GetBinaryCode(text);

            for (int i = 0; i < binaryCode.Length; i += 8)
            {
                string s = binaryCode.Substring(i, 8);
                int sum = s.Sum(x => char.IsDigit(x) ? int.Parse(x.ToString()) : 0);
                if (sum % 2 != 0)
                    s += 1;
                else s += 0;
                result_str += s;
            }
            result.Add(result_str);
            return result;
        }

        internal string GetBinaryCode(string str)
        {
            string binaryCode = String.Empty;
            string tempCode = String.Empty;
            byte[] codeArray = ASCIIEncoding.ASCII.GetBytes(str);
            for (int i = 0; i < codeArray.Length; i++)
            {
                tempCode = Convert.ToString((int)codeArray[i], 2);
                if (tempCode.Length < 8) tempCode = tempCode.PadLeft(8, '0');
                binaryCode += tempCode;
            }
            return binaryCode;
        }

        internal string Decoding(string text)
        {
            string result = string.Empty, tempData = "";
            string error = "";
            if (text.Length % 9 == 0)
            {
                for (int i = 0; i < text.Length; i += 9)
                {
                    int sum = text.Substring(i, 9).Sum(x => char.IsDigit(x) ? int.Parse(x.ToString()) : 0);
                    if (sum % 2 != 0)
                    {
                        error += "| Eror: [" + i.ToString() + ": " + text.Substring(i, 9) + "] |\n";
                    }
                    tempData += text.Substring(i, 8);
                }
                for (int i = 0; i < tempData.Length; i += 8)
                {
                    int code = Convert.ToInt32(tempData.Substring(i, 8), 2);
                    result += (char)code;
                }
            }
            else System.Windows.Forms.MessageBox.Show("Строка не соответствует нужной\n длинне! [кратной 9]");
            if (error.Length > 0) System.Windows.Forms.MessageBox.Show(error);
            return result;
        }
    }
}
