using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MySpravki
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            LoadProofs();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            RequestForm requestForm = new RequestForm();
            requestForm.FormClosed += RequestForm_FormClosed;
            requestForm.ShowDialog();
        }

        private void RequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadProofs();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadProofs()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();

                int userId = LoginForm.userId;

                List<Proof> proofs = Proof.GetUserProofs(userId);

                if (proofs.Count == 0)
                {
                    Label emptyLabel = new Label();
                    emptyLabel.Text = "У вас пока нет заявок.\nНажмите кнопку 'Создать заявку' для добавления.";
                    emptyLabel.Font = new Font("Arial", 12);
                    emptyLabel.ForeColor = Color.Gray;
                    emptyLabel.Size = new Size(400, 60);
                    emptyLabel.TextAlign = ContentAlignment.MiddleCenter;
                    emptyLabel.Location = new Point(50, 50);
                    flowLayoutPanel1.Controls.Add(emptyLabel);
                }
                else
                {
                    foreach (Proof proof in proofs)
                    {
                        Panel cardPanel = new Panel();
                        cardPanel.Width = flowLayoutPanel1.Width - 10;
                        cardPanel.Height = 100;
                        cardPanel.BorderStyle = BorderStyle.FixedSingle;
                        cardPanel.BackColor = Color.White;
                        cardPanel.Padding = new Padding(10);
                        cardPanel.Margin = new Padding(10, 5, 10, 5);

                        // 1 линия
                        Label lblId = new Label();
                        lblId.Text = $"ID заявки: {proof.Id}";
                        lblId.Font = new Font("Arial", 12, FontStyle.Bold);
                        lblId.Location = new Point(10, 10);
                        lblId.Size = new Size(150, 25);
                        cardPanel.Controls.Add(lblId);

                        Label lblDate = new Label();
                        lblDate.Text = $"Создана: {proof.CreatedAt.ToString("dd.MM.yyyy HH:mm")}";
                        lblDate.Font = new Font("Arial", 10);
                        lblDate.Location = new Point(200, 10);
                        lblDate.Size = new Size(230, 25);
                        cardPanel.Controls.Add(lblDate);

                        //2 линия
                        Label lblType = new Label();
                        lblType.Text = $"Тип: {proof.GetTypeName()}";
                        lblType.Font = new Font("Arial", 10);
                        lblType.Location = new Point(10, 45);
                        lblType.Size = new Size(250, 25);
                        cardPanel.Controls.Add(lblType);

                        if (proof.Type == 4 && !string.IsNullOrEmpty(proof.Other))
                        {
                            Label lblOther = new Label();
                            lblOther.Text = $"Запрашиваемый вид: {proof.Other}";
                            lblOther.Font = new Font("Arial", 9);
                            lblOther.ForeColor = Color.Black;
                            lblOther.Location = new Point(270, 45);
                            lblOther.Size = new Size(350, 25);
                            cardPanel.Controls.Add(lblOther);
                        }

                        //3 Линия
                        Label lblCount = new Label();
                        lblCount.Text = $"Количество: {proof.Count} шт.";
                        lblCount.Font = new Font("Arial", 10);
                        lblCount.Location = new Point(10, 80);
                        lblCount.Size = new Size(150, 25);
                        cardPanel.Controls.Add(lblCount);


                        Label lblStatus = new Label();
                        lblStatus.Text = $"Статус: {proof.Status}";
                        lblStatus.Font = new Font("Arial", 10, FontStyle.Bold);

                        if (proof.Status == "отправлено")
                        {
                            lblStatus.ForeColor = Color.OrangeRed;
                        }
                        else if (proof.Status == "завершено")
                        {
                            lblStatus.ForeColor = Color.Green;
                        }
                        else if (proof.Status == "В работе")
                        {
                            lblStatus.ForeColor = Color.Red;
                        }

                        lblStatus.Location = new Point(450, 45);
                        lblStatus.Size = new Size(200, 25);
                        cardPanel.Controls.Add(lblStatus);

                        if (proof.Status == "завершено")
                        {
                            if (!string.IsNullOrEmpty(proof.Path))
                            {
                                Label lblPath = new Label();
                                lblPath.Text = $"Справка: {proof.Path}";
                                lblPath.Font = new Font("Arial", 9);
                                lblPath.ForeColor = Color.Blue;
                                lblPath.Location = new Point(680, 45);
                                lblPath.Size = new Size(200, 25);
                                cardPanel.Controls.Add(lblPath);
                            }

                            Label lblCompleted = new Label();
                            lblCompleted.Text = $"Выполнена: {proof.CompletedIn.ToString("dd.MM.yyyy HH:mm")}";
                            lblCompleted.Font = new Font("Arial", 10);
                            lblCompleted.Location = new Point(450, 80);
                            lblCompleted.Size = new Size(250, 25);
                            cardPanel.Controls.Add(lblCompleted);
                        }

                        flowLayoutPanel1.Controls.Add(cardPanel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заявок: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdBTN_Click(object sender, EventArgs e)
        {
            LoadProofs();
        }
    }
}