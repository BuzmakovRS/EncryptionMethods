namespace Encryption
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_result_chiper = new System.Windows.Forms.TextBox();
            this.textBox_result_decryption = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.perform1 = new System.Windows.Forms.Button();
            this.buttonClear1 = new System.Windows.Forms.Button();
            this.perform2 = new System.Windows.Forms.Button();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_TEA_key = new System.Windows.Forms.TextBox();
            this.label_TEA_key = new System.Windows.Forms.Label();
            this.button_TEA_key = new System.Windows.Forms.Button();
            this.button_qv = new System.Windows.Forms.Button();
            this.label_var = new System.Windows.Forms.Label();
            this.textBox_v = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label_v = new System.Windows.Forms.Label();
            this.label_q = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.button_xy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_message1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_TEA_key2 = new System.Windows.Forms.TextBox();
            this.label_TEA_key2 = new System.Windows.Forms.Label();
            this.label_keys = new System.Windows.Forms.Label();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.label_k = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.label_e = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label_message2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Зашифровать:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(409, 45);
            this.textBox1.TabIndex = 4;
            // 
            // textBox_result_chiper
            // 
            this.textBox_result_chiper.Location = new System.Drawing.Point(11, 87);
            this.textBox_result_chiper.Multiline = true;
            this.textBox_result_chiper.Name = "textBox_result_chiper";
            this.textBox_result_chiper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_result_chiper.Size = new System.Drawing.Size(412, 61);
            this.textBox_result_chiper.TabIndex = 5;
            // 
            // textBox_result_decryption
            // 
            this.textBox_result_decryption.Location = new System.Drawing.Point(11, 109);
            this.textBox_result_decryption.Multiline = true;
            this.textBox_result_decryption.Name = "textBox_result_decryption";
            this.textBox_result_decryption.Size = new System.Drawing.Size(417, 45);
            this.textBox_result_decryption.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 25);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(417, 58);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Расшифровать:";
            // 
            // perform1
            // 
            this.perform1.Location = new System.Drawing.Point(434, 138);
            this.perform1.Name = "perform1";
            this.perform1.Size = new System.Drawing.Size(86, 27);
            this.perform1.TabIndex = 10;
            this.perform1.Text = "Выполнить";
            this.perform1.UseVisualStyleBackColor = true;
            this.perform1.Click += new System.EventHandler(this.perform1_Click);
            // 
            // buttonClear1
            // 
            this.buttonClear1.Location = new System.Drawing.Point(523, 138);
            this.buttonClear1.Name = "buttonClear1";
            this.buttonClear1.Size = new System.Drawing.Size(80, 27);
            this.buttonClear1.TabIndex = 11;
            this.buttonClear1.Text = "Очистить";
            this.buttonClear1.UseVisualStyleBackColor = true;
            this.buttonClear1.Click += new System.EventHandler(this.Clear1_Click);
            // 
            // perform2
            // 
            this.perform2.Location = new System.Drawing.Point(434, 127);
            this.perform2.Name = "perform2";
            this.perform2.Size = new System.Drawing.Size(86, 27);
            this.perform2.TabIndex = 12;
            this.perform2.Text = "Выполнить";
            this.perform2.UseVisualStyleBackColor = true;
            this.perform2.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonClear2
            // 
            this.buttonClear2.Location = new System.Drawing.Point(523, 127);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(80, 27);
            this.buttonClear2.TabIndex = 13;
            this.buttonClear2.Text = "Очистить";
            this.buttonClear2.UseVisualStyleBackColor = true;
            this.buttonClear2.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_TEA_key);
            this.panel1.Controls.Add(this.label_TEA_key);
            this.panel1.Controls.Add(this.button_TEA_key);
            this.panel1.Controls.Add(this.button_qv);
            this.panel1.Controls.Add(this.label_var);
            this.panel1.Controls.Add(this.textBox_v);
            this.panel1.Controls.Add(this.textBox_q);
            this.panel1.Controls.Add(this.label_v);
            this.panel1.Controls.Add(this.label_q);
            this.panel1.Controls.Add(this.label_y);
            this.panel1.Controls.Add(this.label_x);
            this.panel1.Controls.Add(this.textBox_y);
            this.panel1.Controls.Add(this.textBox_x);
            this.panel1.Controls.Add(this.button_xy);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label_message1);
            this.panel1.Controls.Add(this.textBox_result_chiper);
            this.panel1.Controls.Add(this.perform1);
            this.panel1.Controls.Add(this.buttonClear1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(791, 176);
            this.panel1.TabIndex = 14;
            // 
            // textBox_TEA_key
            // 
            this.textBox_TEA_key.Location = new System.Drawing.Point(662, 128);
            this.textBox_TEA_key.Name = "textBox_TEA_key";
            this.textBox_TEA_key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_TEA_key.Size = new System.Drawing.Size(116, 20);
            this.textBox_TEA_key.TabIndex = 34;
            // 
            // label_TEA_key
            // 
            this.label_TEA_key.AutoSize = true;
            this.label_TEA_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TEA_key.Location = new System.Drawing.Point(609, 131);
            this.label_TEA_key.Name = "label_TEA_key";
            this.label_TEA_key.Size = new System.Drawing.Size(51, 13);
            this.label_TEA_key.TabIndex = 33;
            this.label_TEA_key.Text = "TEA_key";
            // 
            // button_TEA_key
            // 
            this.button_TEA_key.Location = new System.Drawing.Point(434, 97);
            this.button_TEA_key.Name = "button_TEA_key";
            this.button_TEA_key.Size = new System.Drawing.Size(86, 35);
            this.button_TEA_key.TabIndex = 32;
            this.button_TEA_key.Text = "Сгенеривать ключ (TEA)";
            this.button_TEA_key.UseVisualStyleBackColor = true;
            this.button_TEA_key.Click += new System.EventHandler(this.button_TEA_key_Click);
            // 
            // button_qv
            // 
            this.button_qv.Location = new System.Drawing.Point(523, 49);
            this.button_qv.Name = "button_qv";
            this.button_qv.Size = new System.Drawing.Size(80, 42);
            this.button_qv.TabIndex = 31;
            this.button_qv.Text = "Сгенеривать q и v";
            this.button_qv.UseVisualStyleBackColor = true;
            this.button_qv.Click += new System.EventHandler(this.button_qv_Click);
            // 
            // label_var
            // 
            this.label_var.AutoSize = true;
            this.label_var.Location = new System.Drawing.Point(672, 3);
            this.label_var.Name = "label_var";
            this.label_var.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_var.Size = new System.Drawing.Size(76, 13);
            this.label_var.TabIndex = 30;
            this.label_var.Text = "Переменные:";
            // 
            // textBox_v
            // 
            this.textBox_v.Location = new System.Drawing.Point(662, 101);
            this.textBox_v.Name = "textBox_v";
            this.textBox_v.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_v.Size = new System.Drawing.Size(116, 20);
            this.textBox_v.TabIndex = 29;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(662, 75);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_q.Size = new System.Drawing.Size(116, 20);
            this.textBox_q.TabIndex = 28;
            // 
            // label_v
            // 
            this.label_v.AutoSize = true;
            this.label_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_v.Location = new System.Drawing.Point(621, 104);
            this.label_v.Name = "label_v";
            this.label_v.Size = new System.Drawing.Size(35, 13);
            this.label_v.TabIndex = 27;
            this.label_v.Text = "DH_v";
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_q.Location = new System.Drawing.Point(621, 78);
            this.label_q.Name = "label_q";
            this.label_q.Size = new System.Drawing.Size(35, 13);
            this.label_q.TabIndex = 26;
            this.label_q.Text = "DH_q";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_y.Location = new System.Drawing.Point(644, 54);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(12, 13);
            this.label_y.TabIndex = 25;
            this.label_y.Text = "y";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_x.Location = new System.Drawing.Point(644, 26);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(12, 13);
            this.label_x.TabIndex = 24;
            this.label_x.Text = "x";
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(662, 49);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_y.Size = new System.Drawing.Size(116, 20);
            this.textBox_y.TabIndex = 23;
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(662, 23);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_x.Size = new System.Drawing.Size(116, 20);
            this.textBox_x.TabIndex = 22;
            // 
            // button_xy
            // 
            this.button_xy.Location = new System.Drawing.Point(434, 49);
            this.button_xy.Name = "button_xy";
            this.button_xy.Size = new System.Drawing.Size(86, 42);
            this.button_xy.TabIndex = 21;
            this.button_xy.Text = "Сгенеривать x и y";
            this.button_xy.UseVisualStyleBackColor = true;
            this.button_xy.Click += new System.EventHandler(this.button_xy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 3);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Выберите метод";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(434, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label_message1
            // 
            this.label_message1.AutoSize = true;
            this.label_message1.Location = new System.Drawing.Point(11, 155);
            this.label_message1.Name = "label_message1";
            this.label_message1.Size = new System.Drawing.Size(35, 13);
            this.label_message1.TabIndex = 18;
            this.label_message1.Text = "label6";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_TEA_key2);
            this.panel2.Controls.Add(this.label_TEA_key2);
            this.panel2.Controls.Add(this.label_keys);
            this.panel2.Controls.Add(this.textBox_k);
            this.panel2.Controls.Add(this.label_k);
            this.panel2.Controls.Add(this.label_n);
            this.panel2.Controls.Add(this.label_e);
            this.panel2.Controls.Add(this.textBox_n);
            this.panel2.Controls.Add(this.textBox_d);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label_message2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox_result_decryption);
            this.panel2.Controls.Add(this.buttonClear2);
            this.panel2.Controls.Add(this.perform2);
            this.panel2.Location = new System.Drawing.Point(0, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 183);
            this.panel2.TabIndex = 15;
            // 
            // textBox_TEA_key2
            // 
            this.textBox_TEA_key2.Location = new System.Drawing.Point(662, 104);
            this.textBox_TEA_key2.Name = "textBox_TEA_key2";
            this.textBox_TEA_key2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_TEA_key2.Size = new System.Drawing.Size(116, 20);
            this.textBox_TEA_key2.TabIndex = 36;
            // 
            // label_TEA_key2
            // 
            this.label_TEA_key2.AutoSize = true;
            this.label_TEA_key2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TEA_key2.Location = new System.Drawing.Point(609, 107);
            this.label_TEA_key2.Name = "label_TEA_key2";
            this.label_TEA_key2.Size = new System.Drawing.Size(51, 13);
            this.label_TEA_key2.TabIndex = 35;
            this.label_TEA_key2.Text = "TEA_key";
            // 
            // label_keys
            // 
            this.label_keys.AutoSize = true;
            this.label_keys.Location = new System.Drawing.Point(688, 6);
            this.label_keys.Name = "label_keys";
            this.label_keys.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_keys.Size = new System.Drawing.Size(42, 13);
            this.label_keys.TabIndex = 32;
            this.label_keys.Text = "Ключи:";
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(662, 78);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_k.Size = new System.Drawing.Size(116, 20);
            this.textBox_k.TabIndex = 31;
            // 
            // label_k
            // 
            this.label_k.AutoSize = true;
            this.label_k.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_k.Location = new System.Drawing.Point(640, 81);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(13, 13);
            this.label_k.TabIndex = 30;
            this.label_k.Text = "k";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_n.Location = new System.Drawing.Point(640, 55);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(13, 13);
            this.label_n.TabIndex = 28;
            this.label_n.Text = "n";
            // 
            // label_e
            // 
            this.label_e.AutoSize = true;
            this.label_e.Location = new System.Drawing.Point(640, 29);
            this.label_e.Name = "label_e";
            this.label_e.Size = new System.Drawing.Size(13, 13);
            this.label_e.TabIndex = 23;
            this.label_e.Text = "d";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(662, 52);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(116, 20);
            this.textBox_n.TabIndex = 27;
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(662, 26);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(116, 20);
            this.textBox_d.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Дешифрование";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(434, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(169, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // label_message2
            // 
            this.label_message2.AutoSize = true;
            this.label_message2.Location = new System.Drawing.Point(11, 158);
            this.label_message2.Name = "label_message2";
            this.label_message2.Size = new System.Drawing.Size(35, 13);
            this.label_message2.TabIndex = 20;
            this.label_message2.Text = "label8";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Шифрование данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_result_chiper;
        private System.Windows.Forms.TextBox textBox_result_decryption;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button perform1;
        private System.Windows.Forms.Button buttonClear1;
        private System.Windows.Forms.Button perform2;
        private System.Windows.Forms.Button buttonClear2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_message1;
        private System.Windows.Forms.Label label_message2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Button button_xy;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Label label_e;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.TextBox textBox_v;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Label label_v;
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Button button_qv;
        private System.Windows.Forms.Label label_var;
        private System.Windows.Forms.Label label_keys;
        private System.Windows.Forms.TextBox textBox_TEA_key;
        private System.Windows.Forms.Label label_TEA_key;
        private System.Windows.Forms.Button button_TEA_key;
        private System.Windows.Forms.TextBox textBox_TEA_key2;
        private System.Windows.Forms.Label label_TEA_key2;
    }
}

