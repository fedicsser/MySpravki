namespace MySpravki
{
    partial class RequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            comboBox1 = new ComboBox();
            requestBTN = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2-НДФЛ", "О месте работы и стаже", "О среднем заработке", "Произвольная справка" });
            comboBox1.Location = new Point(70, 233);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 23);
            comboBox1.TabIndex = 0;
            // 
            // requestBTN
            // 
            requestBTN.Location = new Point(113, 496);
            requestBTN.Name = "requestBTN";
            requestBTN.Size = new Size(75, 23);
            requestBTN.TabIndex = 1;
            requestBTN.Text = "Запорсить";
            requestBTN.UseVisualStyleBackColor = true;
            requestBTN.Click += requestBTN_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 73);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 117);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 161);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Очество";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(70, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 215);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Вид справки";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(70, 262);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 23);
            textBox4.TabIndex = 9;
            textBox4.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(70, 361);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(167, 117);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 343);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 11;
            label5.Text = "Причина запроса";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 299);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 12;
            label6.Text = "кол-во экземпляров";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(70, 317);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(80, 20);
            label7.Name = "label7";
            label7.Size = new Size(147, 23);
            label7.TabIndex = 14;
            label7.Text = "Запрос справки";
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 574);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(requestBTN);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RequestForm";
            Text = "Запрос спарвки";
            Load += RequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button requestBTN;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private RichTextBox richTextBox1;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label label7;
    }
}