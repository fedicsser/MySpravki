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
            lgbtn = new Button();
            loginT = new TextBox();
            passwprdT = new TextBox();
            SuspendLayout();
            // 
            // lgbtn
            // 
            lgbtn.Location = new Point(126, 384);
            lgbtn.Name = "lgbtn";
            lgbtn.Size = new Size(75, 23);
            lgbtn.TabIndex = 0;
            lgbtn.Text = "button1";
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(passwprdT);
            Controls.Add(loginT);
            Controls.Add(lgbtn);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lgbtn;
        private TextBox loginT;
        private TextBox passwprdT;
    }
}