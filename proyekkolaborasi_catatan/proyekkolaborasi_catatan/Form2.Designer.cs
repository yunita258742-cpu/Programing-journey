namespace proyekkolaborasi_catatan
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(181, 38);
            label3.TabIndex = 2;
            label3.Text = "Catatan Baru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 106);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 3;
            label4.Text = "Judul";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(420, 31);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 168);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 5;
            label5.Text = "Folder";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(420, 33);
            comboBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 7;
            label6.Text = "Isi singkat";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 260);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(417, 122);
            textBox2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 385);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 9;
            label7.Text = "Pengingat";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 413);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(417, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(320, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(12, 527);
            button3.Name = "button3";
            button3.Size = new Size(417, 64);
            button3.TabIndex = 13;
            button3.Text = "Buat Catatan";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(444, 641);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}