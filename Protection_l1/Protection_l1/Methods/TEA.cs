using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionMethods.Methods
{
    class TEA
    {
        string str_check = "";
        internal List<string> EncryptString(string text, string key)
        {
            List<string> result = new List<string>();
            string result_text = string.Empty;
            if (key.Length > 1)
            {
                uint[] formattedKey = FormatKey(key);

                if (text.Length % 2 != 0) text += '\0';
                byte[] dataBytes = ASCIIEncoding.ASCII.GetBytes(text);


                uint[] tempData = new uint[2];
                for (int i = 0; i < dataBytes.Length; i += 2)
                {
                    tempData[0] = dataBytes[i];
                    tempData[1] = dataBytes[i + 1];
                    Encode(tempData, formattedKey);
                    result_text += ConvertUIntToString(tempData[0]) + ConvertUIntToString(tempData[1]);
                }

                result.Add(result_text);
                str_check = result_text;
                int k = result_text.Length;
                result.Add(key);
            }
            else MessageBox.Show("Введите ключ(ТЕА)");
            return result;
        }

        internal void Encode(uint[] v, uint[] k)
        {
            uint y = v[0];
            uint z = v[1];
            uint sum = 0;
            uint delta = 0x9e3779b9;
            uint n = 32;

            while (n-- > 0)
            {
                sum += delta;
                y += (z << 4) + k[0] ^ z + sum ^ (z >> 5) + k[1];
                z += (y << 4) + k[2] ^ y + sum ^ (y >> 5) + k[3];
            }

            v[0] = y;
            v[1] = z;
        }

        internal string Decrypt(string text, string key)
        {
            string decipheredString = "";
            if (key.Length > 1)
            {
                uint[] formattedKey = FormatKey(key);

                int x = 0;
                uint[] tempData = new uint[2];
                byte[] dataBytes = new byte[text.Length / 4];

                int code;
                for (int i = 0; i < text.Length; i += code / char.MaxValue + 1)
                    code = char.ConvertToUtf32(text, i);

                int textLength = text.Length;
                try
                {
                    for (int i = 0; i < text.Length; i += 8)
                    {
                        tempData[0] = ConvertStringToUInt(text.Substring(i, 4));
                        tempData[1] = ConvertStringToUInt(text.Substring(i + 4, 4));
                        Decode(tempData, formattedKey);
                        dataBytes[x++] = (byte)tempData[0];
                        dataBytes[x++] = (byte)tempData[1];
                    }
                }
                catch (Exception e)
                { MessageBox.Show(e.ToString()); }
                decipheredString = System.Text.Encoding.ASCII.GetString(dataBytes, 0, dataBytes.Length);
                if (decipheredString[decipheredString.Length - 1] == '\0')
                    decipheredString = decipheredString.Substring(0, decipheredString.Length - 1);
            }
            else MessageBox.Show("Введите ключ(ТЕА)");
            return decipheredString;
        }
        internal void Decode(uint[] v, uint[] k)
        {
            uint y = v[0];
            uint z = v[1];
            uint sum;
            uint delta = 0x9e3779b9;
            sum = delta << 5;
            uint n = 32;
            while (n-- > 0)
            {
                z -= (y << 4) + k[2] ^ y + sum ^ (y >> 5) + k[3];
                y -= (z << 4) + k[0] ^ z + sum ^ (z >> 5) + k[1];
                sum -= delta;
            }

            v[0] = y;
            v[1] = z;
        }

        internal uint[] FormatKey(string key)
        {
            key = key.PadRight(16, '0').Substring(0, 16);
            uint[] formattedKey = new uint[4];
            int j = 0;
            for (int i = 0; i < key.Length; i += 4)
                formattedKey[j++] = ConvertStringToUInt(key.Substring(i, 4));

            return formattedKey;
        }

        internal string ConvertUIntToString(uint Input)
        {
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            output.Append((char)((Input & 0xFF)+32));
            output.Append((char)(((Input >> 8) & 0xFF)+32));
            output.Append((char)(((Input >> 16) & 0xFF)+32));
            output.Append((char)(((Input >> 24) & 0xFF)+32));
            return output.ToString();
        }

        internal uint ConvertStringToUInt(string Input)
        {
            uint output;
            output = ((uint)Input[0])-32;
            output += ((((uint)(Input[1]))-32) << 8);
            output += ((((uint)(Input[2]))-32) << 16);
            output += ((((uint)(Input[3]))-32) << 24);
            return output;
        }
    }
}