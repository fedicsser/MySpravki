using System;
using System.Windows.Forms;

namespace MySpravki
{
    public partial class RequestForm : Form
    {
        private Proof currentProof;
        public RequestForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            textBox4.Visible = false;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Произвольная справка")
            {
                textBox4.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
            }
        }

        //Запрос на создание спаравки
        private void requestBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(richTextBox1.Text) ||
                    numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else if (comboBox1.Text != "2-НДФЛ" && comboBox1.Text != "О месте работы и стаже" && comboBox1.Text != "О среднем заработке" && comboBox1.Text != "Произвольная справка")
                {
                    MessageBox.Show("Не верный тип спрвки");
                }
                else
                {
                    int type = 0;
                    string other = "";

                    switch (comboBox1.Text)
                    {
                        case "2-НДФЛ":
                            type = 1;
                            break;
                        case "О месте работы и стаже":
                            type = 2;
                            break;
                        case "О среднем заработке":
                            type = 3;
                            break;
                        case "Произвольная справка":
                            type = 4;
                            other = textBox4.Text;
                            break;
                    }

                    if (type == 4 && string.IsNullOrWhiteSpace(other))
                    {
                        MessageBox.Show("Укажите текст произвольной справки");
                    }

                    currentProof = new Proof(
                        LoginForm.userId,
                        textBox1.Text,
                        textBox2.Text,
                        textBox3.Text,
                        type,
                        other,
                        (int)numericUpDown1.Value,
                        richTextBox1.Text
                    );


                    bool saved = currentProof.SaveToDatabase();

                    if (saved)
                    {

                        MessageBox.Show("Запрос успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        richTextBox1.Clear();
                        numericUpDown1.Value = 1;
                        comboBox1.SelectedIndex = -1;
                        textBox4.Visible = false;
                        currentProof = null;

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Не удалось сохранить запрос в БД!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}