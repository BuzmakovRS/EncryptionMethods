using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using EncryptionMethods.Methods;

namespace Encryption
{
    public partial class Form1 : Form
    {
        Lazy<RSA> method_Rsa = new Lazy<RSA>();
        Lazy<Diffie_Hellman> method_DH = new Lazy<Diffie_Hellman>();
        Lazy<TEA> method_Tea = new Lazy<TEA>();
        Lazy<ParityCheck> method_ParityCheck = new Lazy<ParityCheck>();
        Function func = new Function();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_message1.Text = "";
            label_message2.Text = "";
            comboBox1.Items.Add("Перестановки");
            comboBox1.Items.Add("RSA");
            comboBox1.Items.Add("Диффи-Хеллмана");
            comboBox1.Items.Add("TEA");
            comboBox1.Items.Add("Бит четности");
            comboBox1.Items.Add("RLE");
            comboBox1.SelectedItem = "Перестановка";
            comboBox2.Items.Add("Перестановка");
            comboBox2.Items.Add("RSA");
            comboBox2.Items.Add("Диффи-Хеллмана");
            comboBox2.Items.Add("TEA");
            comboBox2.Items.Add("Бит четности");
            comboBox2.Items.Add("RLE");
        }

        //Сгенерировать х и у
        private void button_xy_Click(object sender, EventArgs e)
        {
            BigInteger x = func.GenerationOfNumbers(6);
            BigInteger y = func.GenerationOfNumbers(6);
            textBox_x.Text = x.ToString();
            textBox_y.Text = y.ToString();
        }
        private void button_qv_Click(object sender, EventArgs e)
        {
            BigInteger q = func.GenerationOfNumbers(1);
            BigInteger v = func.GenerationOfNumbers(1);
            textBox_q.Text = q.ToString();
            textBox_v.Text = v.ToString();
        }
        // Зашифровать
        private void perform1_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            try
            {
                string chiper = comboBox1.SelectedItem.ToString();

                if (textBox1.Text.Length > 0)
                {
                    switch (chiper)
                    {
                        case "Перестановки":
                            result.Add(func.permutationСipher(textBox1.Text));
                            break;
                        case "RSA":
                            result = method_Rsa.Value.EncryptionRsa(textBox1.Text, textBox_x.Text, textBox_y.Text);
                            textBox_d.Text = result[1];
                            textBox_n.Text = result[2];
                            break;
                        case "Диффи-Хеллмана":
                            result = method_DH.Value.diffieHellman(textBox1.Text, textBox_x.Text, textBox_y.Text,
                            textBox_q.Text, textBox_v.Text);
                            textBox_k.Text = result[1];
                            break;
                        case "TEA":
                            result = method_Tea.Value.EncryptString(textBox1.Text, textBox_TEA_key.Text);
                            textBox_TEA_key2.Text = result[1];
                            break;
                        case "Бит четности":
                            result = method_ParityCheck.Value.Encoding(textBox1.Text);
                            break;
                        case "RLE":
                            result = RLE.Encode(textBox1.Text);
                            break;
                    }
                    textBox_result_chiper.Text = result[0];
                }
                else
                {
                    MessageBox.Show("Введите текст");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox_result_chiper.Clear();
        }

        // Расшифровать
        private void button3_Click(object sender, EventArgs e)
        {
            textBox_result_decryption.Clear();
            string result = String.Empty;
            string chiper = comboBox2.SelectedItem.ToString();
            if (chiper.Length != 0)
            {
                if (textBox2.Text.Length > 0)
                {
                    switch (chiper)
                    {
                        case "Перестановка":
                            result = func.permutationСipher(textBox2.Text);
                            break;
                        case "RSA":
                            result = method_Rsa.Value.DecryptionRsa(textBox2.Text, textBox_d.Text, textBox_n.Text);

                            break;
                        case "Диффи-Хеллмана":
                            result = method_DH.Value.diffieHellman_Decode(textBox2.Text, textBox_k.Text);
                            break;
                        case "TEA":
                            result = method_Tea.Value.Decrypt(textBox2.Text, textBox_TEA_key2.Text);
                            break;
                        case "Бит четности":
                            result = method_ParityCheck.Value.Decoding(textBox2.Text);
                            break;
                        case "RLE":
                            result = RLE.Decode(textBox2.Text);
                            break;
                    }
                    textBox_result_decryption.Text = result;
                }
                else
                {
                    label_message2.Text = "Пустая строка";
                }
            }
            else MessageBox.Show("Выберите метод!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_result_decryption.Clear();
            textBox2.Clear();
        }
        private void button_TEA_key_Click(object sender, EventArgs e)
        {
            int key = (int)(func.GenerationOfNumbers(2));
            string binaryKey = Convert.ToString(key, 2);
            textBox_TEA_key.Text = binaryKey.ToString();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = func.OpenFile();
        }
    }
}

