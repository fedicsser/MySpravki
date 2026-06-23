namespace MySpravki
{
    partial class WorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkForm));
            UpdBTN = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            logoutBTN = new Button();
            SuspendLayout();
            // 
            // UpdBTN
            // 
            UpdBTN.Location = new Point(810, 461);
            UpdBTN.Name = "UpdBTN";
            UpdBTN.Size = new Size(162, 23);
            UpdBTN.TabIndex = 5;
            UpdBTN.Text = "Обновить статусы";
            UpdBTN.UseVisualStyleBackColor = true;
/*            UpdBTN.Click += UpdBTN_Click_1;*/
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(960, 430);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // logoutBTN
            // 
            logoutBTN.Location = new Point(896, 521);
            logoutBTN.Name = "logoutBTN";
            logoutBTN.Size = new Size(75, 23);
            logoutBTN.TabIndex = 6;
            logoutBTN.Text = "выйти";
            logoutBTN.UseVisualStyleBackColor = true;
            logoutBTN.Click += logoutBTN_Click;
            // 
            // WorkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 556);
            Controls.Add(logoutBTN);
            Controls.Add(UpdBTN);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WorkForm";
            Text = "Запрвшиваемые спарвки";
            ResumeLayout(false);
        }

        #endregion

        private Button UpdBTN;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button logoutBTN;
    }
}