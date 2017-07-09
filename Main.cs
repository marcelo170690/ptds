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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            var user = Singleton.getInstance();

            var userText = (user.lvl == (int)UserLevel.ADMIN) ?
                "Administrador" : "Usuario";

            label1.Text = "Nivel de usuario: " + userText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new softchape.Login();
            login.Show();

            this.Close();
        }
    }
}
