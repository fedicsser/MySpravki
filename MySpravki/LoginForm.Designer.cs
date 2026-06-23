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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lgbtn
            // 
            lgbtn.Location = new Point(126, 384);
            lgbtn.Name = "lgbtn";
            lgbtn.Size = new Size(75, 23);
            lgbtn.TabIndex = 0;
            lgbtn.Text = "Войти";
            lgbtn.UseVisualStyleBackColor = true;
            lgbtn.Click += lgbtn_Click;
            // 
            // loginT
            // 
            loginT.Location = new Point(113, 140);
            loginT.Name = "loginT";
            loginT.Size = new Size(100, 23);
            loginT.TabIndex = 1;
            loginT.TextChanged += textBox1_TextChanged;
            // 
            // passwprdT
            // 
            passwprdT.Location = new Point(113, 227);
            passwprdT.Name = "passwprdT";
            passwprdT.PasswordChar = '*';
            passwprdT.Size = new Size(100, 23);
            passwprdT.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 121);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 209);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "пароль";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwprdT);
            Controls.Add(loginT);
            Controls.Add(lgbtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lgbtn;
        private TextBox loginT;
        private TextBox passwprdT;
        private Label label1;
        private Label label2;
    }
}