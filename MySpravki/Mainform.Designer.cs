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
            flowLayoutPanel1 = new FlowLayoutPanel();
            addBTN = new Button();
            UpdBTN = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 48);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(960, 430);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(12, 497);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(162, 23);
            addBTN.TabIndex = 1;
            addBTN.Text = "Запросить справку";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // UpdBTN
            // 
            UpdBTN.Location = new Point(810, 497);
            UpdBTN.Name = "UpdBTN";
            UpdBTN.Size = new Size(162, 23);
            UpdBTN.TabIndex = 2;
            UpdBTN.Text = "Обновить статусы";
            UpdBTN.UseVisualStyleBackColor = true;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 623);
            Controls.Add(UpdBTN);
            Controls.Add(addBTN);
            Controls.Add(flowLayoutPanel1);
            Name = "Mainform";
            Text = "Mainform";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button addBTN;
        private Button UpdBTN;
    }
}