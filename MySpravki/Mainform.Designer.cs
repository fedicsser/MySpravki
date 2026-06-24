namespace MySpravki
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            flowLayoutPanel1 = new FlowLayoutPanel();
            addBTN = new Button();
            UpdBTN = new Button();
            logoutBTN = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 35);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(960, 430);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(12, 484);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(162, 23);
            addBTN.TabIndex = 1;
            addBTN.Text = "Запросить справку";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // UpdBTN
            // 
            UpdBTN.Location = new Point(193, 484);
            UpdBTN.Name = "UpdBTN";
            UpdBTN.Size = new Size(162, 23);
            UpdBTN.TabIndex = 2;
            UpdBTN.Text = "Обновить статусы";
            UpdBTN.UseVisualStyleBackColor = true;
            UpdBTN.Click += UpdBTN_Click;
            // 
            // logoutBTN
            // 
            logoutBTN.Location = new Point(897, 531);
            logoutBTN.Name = "logoutBTN";
            logoutBTN.Size = new Size(75, 23);
            logoutBTN.TabIndex = 3;
            logoutBTN.Text = "выйти";
            logoutBTN.UseVisualStyleBackColor = true;
            logoutBTN.Click += logoutBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 23);
            label1.TabIndex = 4;
            label1.Text = "Запрошенные справки";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(label1);
            Controls.Add(logoutBTN);
            Controls.Add(UpdBTN);
            Controls.Add(addBTN);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мои Справки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button addBTN;
        private Button UpdBTN;
        private Button logoutBTN;
        private Label label1;
    }
}