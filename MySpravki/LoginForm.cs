using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySpravki
{
    public partial class LoginForm : Form
    {
        public static int userId;
        public LoginForm()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lgbtn_Click(object sender, EventArgs e)
        {
            if(loginT.Text == "" ||  passwprdT.Text == "")
            {
                MessageBox.Show("Заполни все поля");
            }
            else
            {
                try
                {
                    string authuserId = User.UserAuth(loginT.Text, passwprdT.Text);
                    if (authuserId != null)
                    {
                        MessageBox.Show("Добро пожаловать");
                        
                        userId = Convert.ToInt32(authuserId);
                        MessageBox.Show(userId.ToString());
                        this.Hide();
                        Mainform mainform = new Mainform();
                        mainform.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Не верно указан пользвоетль или пароль");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
