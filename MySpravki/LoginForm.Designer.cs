namespace MySpravki
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lgbtn = new Button();
            loginT = new TextBox();
            passwprdT = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lgbtn
            // 
            lgbtn.FlatStyle = FlatStyle.Popup;
            lgbtn.Location = new Point(139, 339);
            lgbtn.Name = "lgbtn";
            lgbtn.Size = new Size(75, 23);
            lgbtn.TabIndex = 0;
            lgbtn.Text = "Войти";
            lgbtn.UseVisualStyleBackColor = true;
            lgbtn.Click += lgbtn_Click;
            // 
            // loginT
            // 
            loginT.BackColor = SystemColors.Window;
            loginT.BorderStyle = BorderStyle.FixedSingle;
            loginT.Location = new Point(94, 141);
            loginT.Name = "loginT";
            loginT.Size = new Size(157, 23);
            loginT.TabIndex = 1;
            loginT.TextChanged += textBox1_TextChanged;
            // 
            // passwprdT
            // 
            passwprdT.Location = new Point(94, 211);
            passwprdT.Name = "passwprdT";
            passwprdT.PasswordChar = '*';
            passwprdT.Size = new Size(157, 23);
            passwprdT.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(35, 19);
            label3.Name = "label3";
            label3.Size = new Size(273, 27);
            label3.TabIndex = 5;
            label3.Text = "Система запроса справок";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(114, 76);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 6;
            label4.Text = "Авторизация";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(94, 119);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 7;
            label5.Text = "Логин";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(94, 189);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 8;
            label1.Text = "Пароль";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(344, 461);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passwprdT);
            Controls.Add(loginT);
            Controls.Add(lgbtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lgbtn;
        private TextBox loginT;
        private TextBox passwprdT;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
    }
}