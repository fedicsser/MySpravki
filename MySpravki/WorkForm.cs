using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MySpravki
{
    public partial class WorkForm : Form
    {
        private string proofsFolderPath = @"C:\Users\fedics\source\repos\MySpravki\MySpravki\proofs\";

        public WorkForm()
        {
            InitializeComponent();

            if (!Directory.Exists(proofsFolderPath))
            {
                Directory.CreateDirectory(proofsFolderPath);
            }

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

                List<Proof> proofs = Proof.GetProofsForWorker();

                if (proofs.Count == 0)
                {
                    Label emptyLabel = new Label();
                    emptyLabel.Text = "Нет активных заявок.";
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
                        cardPanel.Height = 200;
                        cardPanel.BorderStyle = BorderStyle.FixedSingle;
                        cardPanel.BackColor = Color.White;
                        cardPanel.Padding = new Padding(10);
                        cardPanel.Margin = new Padding(10, 5, 10, 5);

                        Label lblName = new Label();
                        lblName.Text = $"Сотрудник: {proof.Surname} {proof.Name} {proof.Patronymic}";
                        lblName.Font = new Font("Arial", 10, FontStyle.Bold);
                        lblName.Location = new Point(10, 10);
                        lblName.Size = new Size(400, 25);
                        cardPanel.Controls.Add(lblName);

                        Label lblDate = new Label();
                        lblDate.Text = $"Создана: {proof.CreatedAt.ToString("dd.MM.yyyy HH:mm")}";
                        lblDate.Font = new Font("Arial", 10);
                        lblDate.Location = new Point(450, 10);
                        lblDate.Size = new Size(230, 25);
                        cardPanel.Controls.Add(lblDate);

                        Label lblType = new Label();
                        lblType.Text = $"Тип: {proof.GetTypeName()}";
                        lblType.Font = new Font("Arial", 10);
                        lblType.Location = new Point(10, 45);
                        lblType.Size = new Size(250, 25);
                        cardPanel.Controls.Add(lblType);

                        if (proof.Type == 4 && !string.IsNullOrEmpty(proof.Other))
                        {
                            Label lblOther = new Label();
                            lblOther.Text = $"Вид справки: {proof.Other}";
                            lblOther.Font = new Font("Arial", 9);
                            lblOther.ForeColor = Color.DarkGray;
                            lblOther.Location = new Point(270, 45);
                            lblOther.Size = new Size(350, 25);
                            cardPanel.Controls.Add(lblOther);
                        }

                        Label lblCount = new Label();
                        lblCount.Text = $"Количество: {proof.Count} шт.";
                        lblCount.Font = new Font("Arial", 10);
                        lblCount.Location = new Point(10, 80);
                        lblCount.Size = new Size(150, 25);
                        cardPanel.Controls.Add(lblCount);

                        Label lblReason = new Label();
                        lblReason.Text = $"Причина: {proof.Reason}";
                        lblReason.Font = new Font("Arial", 10);
                        lblReason.Location = new Point(200, 80);
                        lblReason.Size = new Size(400, 25);
                        cardPanel.Controls.Add(lblReason);

                        Label lblStatus = new Label();
                        lblStatus.Text = $"Статус: {proof.Status}";
                        lblStatus.Font = new Font("Arial", 10, FontStyle.Bold);

                        if (proof.Status == "отправлено")
                        {
                            lblStatus.ForeColor = Color.OrangeRed;
                        }
                        else if (proof.Status == "В работе")
                        {
                            lblStatus.ForeColor = Color.Blue;
                        }
                        else if (proof.Status == "завершено")
                        {
                            lblStatus.ForeColor = Color.Green;
                        }

                        lblStatus.Location = new Point(10, 115);
                        lblStatus.Size = new Size(200, 25);
                        cardPanel.Controls.Add(lblStatus);

                        if (proof.Status == "отправлено")
                        {
                            Button takeWorkBtn = new Button();
                            takeWorkBtn.Text = "Взять в работу";
                            takeWorkBtn.Size = new Size(120, 30);
                            takeWorkBtn.Location = new Point(680, 10);
                            takeWorkBtn.BackColor = Color.LightBlue;
                            takeWorkBtn.FlatStyle = FlatStyle.Flat;
                            takeWorkBtn.Tag = proof;
                            takeWorkBtn.Click += TakeWorkBtn_Click;
                            cardPanel.Controls.Add(takeWorkBtn);
                        }

                        if (proof.Status == "В работе")
                        {
                            Button uploadBtn = new Button();
                            uploadBtn.Text = "Загрузить справку";
                            uploadBtn.Size = new Size(120, 30);
                            uploadBtn.Location = new Point(680, 10);
                            uploadBtn.BackColor = Color.LightGreen;
                            uploadBtn.FlatStyle = FlatStyle.Flat;
                            uploadBtn.Tag = proof;
                            uploadBtn.Click += UploadBtn_Click;
                            cardPanel.Controls.Add(uploadBtn);
                        }

                        if (proof.Status == "завершено")
                        {
                            Label lblCompleted = new Label();
                            lblCompleted.Text = $"Выполнена: {proof.CompletedIn.ToString("dd.MM.yyyy HH:mm")}";
                            lblCompleted.Font = new Font("Arial", 10);
                            lblCompleted.ForeColor = Color.Green;
                            lblCompleted.Location = new Point(250, 115);
                            lblCompleted.Size = new Size(250, 25);
                            cardPanel.Controls.Add(lblCompleted);

                            if (!string.IsNullOrEmpty(proof.Path))
                            {
                                Label lblPath = new Label();
                                lblPath.Text = $"Файл: {Path.GetFileName(proof.Path)}";
                                lblPath.Font = new Font("Arial", 9);
                                lblPath.ForeColor = Color.Blue;
                                lblPath.Location = new Point(550, 115);
                                lblPath.Size = new Size(300, 25);
                                cardPanel.Controls.Add(lblPath);
                            }
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

        private void TakeWorkBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Proof proof = (Proof)btn.Tag;

            if (proof.UpdateStatus("В работе"))
            {
                LoadProofs();
                MessageBox.Show($"Заявка #{proof.Id} взята в работу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Proof proof = (Proof)btn.Tag;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите файл справки";
                openFileDialog.Filter = "Изображения и PDF|*.png;*.jpg;*.jpeg;*.pdf|PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|PDF Document|*.pdf";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string fileExtension = Path.GetExtension(openFileDialog.FileName);
                        string newFileName = $"proof_{proof.Id}_{DateTime.Now:yyyyMMdd_HHmmss}{fileExtension}";
                        string savePath = Path.Combine(proofsFolderPath, newFileName);

                        File.Copy(openFileDialog.FileName, savePath, true);

                        if (proof.UpdatePath(savePath))
                        {
                            LoadProofs();
                            MessageBox.Show($"Справка для заявки #{proof.Id} успешно загружена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdBTN_Click(object sender, EventArgs e)
        {
            LoadProofs();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lg = new LoginForm();
            lg.Show();
        }
    }
}