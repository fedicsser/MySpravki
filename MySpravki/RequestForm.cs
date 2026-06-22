using System;
using System.Windows.Forms;

namespace MySpravki
{
    public partial class RequestForm : Form
    {
        // Переменная для хранения созданного объекта
        private Proof currentProof;

        public RequestForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;

            // Изначально скрываем поле для произвольной справки
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
                    LoginForm.userId,           // userId
                    textBox1.Text,              // name
                    textBox2.Text,              // surname
                    textBox3.Text,              // patronymic
                    type,                       // type
                    other,                      // other
                    (int)numericUpDown1.Value,  // count
                    richTextBox1.Text           // reason
                );


                bool saved = currentProof.SaveToDatabase();

                if (saved)
                {
                    MessageBox.Show($"Запрос успешно создан!");


                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    richTextBox1.Clear();
                    numericUpDown1.Value = 1;
                    comboBox1.SelectedIndex = -1;
                    textBox4.Visible = false;
                    currentProof = null;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить запрос в БД!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}