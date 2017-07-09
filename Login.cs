using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softchape
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!isWrong())
            {
                var user = Singleton.getInstace();
                    
                if (isAdmin())
                {
                    user.lvl = (int)UserLevel.ADMIN;
                }
                else
                {
                    user.lvl = (int)UserLevel.USER;
                }

                this.Close();
            }
            else
            {
                errorProvider1.SetError(userTextBox,
                    "Usuario/Contraseña incorrectos");
                errorProvider1.SetError(passwordTextBox,
                    "Usuario/Contraseña incorrectos");
            }
        }

        private bool isNull(Object textBox)
        {
            var box = (TextBox)textBox;

            var text = box.Text.ToLower();

            if (String.IsNullOrWhiteSpace(text))
            {
                return true;
            }

            return false;
        }

        private bool isWrong()
        {
            var userText = userTextBox.Text.ToLower();
            var passText = passwordTextBox.Text.ToLower();

            if (userText == "admin" && passText == "admin")
            {
                return false;
            }

            if (userText == "user" && passText == "user")
            {
                return false;
            }

            return true;
        }

        private bool isAdmin()
        {
            var flag = true;

            var userText = userTextBox.Text.ToLower();
            var passText = passwordTextBox.Text.ToLower();

            if (userText != "admin" && passText != "admin")
            {
                flag = false;
            }

            return flag;
        }

        private void userTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (isNull(userTextBox))
            {
                errorProvider1.SetError(userTextBox,
                    "El campo no puede estar vacio");
            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (isNull(passwordTextBox))
            {
                errorProvider1.SetError(passwordTextBox,
                    "El campo no puede estar vacio");
            }
        }
    }
}
