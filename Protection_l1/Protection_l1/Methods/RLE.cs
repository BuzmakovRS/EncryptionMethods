using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionMethods.Methods
{
    static class RLE
    {
        public static List<string> Encode(string text)
        {
            List<string> result = new List<string>();
            byte[] arr = ASCIIEncoding.ASCII.GetBytes(text);
            List<int> rList = new List<int>();
            if (arr.Length > 4)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int difCount = 0, eqCount = 1;
                    if ((i == arr.Length - 1) || (i < arr.Length - 1) && arr[i] != arr[i + 1])
                    {
                        List<int> tempData = new List<int>();
                        while ((i == arr.Length - 1) || ((i + 1 < arr.Length) && arr[i] != arr[i + 1]))
                        {
                            difCount++;
                            tempData.Add(arr[i]);
                            i++;
                        }
                        if (difCount > 1) rList.Add(0);
                        rList.Add(difCount);
                        rList.AddRange(tempData);
                        i--;
                    }
                    else if ((i + 1 < arr.Length) && arr[i] == arr[i + 1])
                    {
                        while ((i + 1 < arr.Length) && arr[i] == arr[i + 1])
                        {
                            eqCount++;
                            i++;
                        }
                        rList.Add(eqCount);

                        rList.Add(arr[i]);

                    }

                }
            }
            else rList.AddRange(arr.Select(x => (int)x));
            result.Add(string.Join(" ", rList.ToArray()));

            return result;
        }

        public static string Decode(string text)
        {
            StringBuilder temp_result = new StringBuilder();
            string result = "";
            try
            {
                int[] array = text.Split(' ').
                    Where(x => !string.IsNullOrWhiteSpace(x)).
                    Select(x => int.Parse(x)).ToArray();

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    i++;
                    count = array[i++];
                    for (int j = i; j < i + count; j++)
                    {
                        temp_result.Insert(temp_result.Length, array[j].ToString() + " ");
                    }
                    i += count;
                }
                else
                {
                    count = array[i++];
                    temp_result.Insert(temp_result.Length, array[i].ToString() + " ", count);
                }
            }
            result = temp_result.ToString();
            }
            catch (Exception ex)
            { System.Windows.Forms.MessageBox.Show(ex.ToString()); }
            return result;
        }
    }
}
