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
    public partial class AgregarAuto : Form
    {
        public string carnet;
        public short codCliente;
        public string nombre;

        public AgregarAuto()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AgregarAuto_Load(object sender, EventArgs e)
        {
            label4.Text = codCliente + "";
            label5.Text = nombre;
            label11.Text = carnet;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var autoAdapter = new bdchapacoDataSetTableAdapters.autoTableAdapter();
            var clienteAdapter = new bdchapacoDataSetTableAdapters.clienteTableAdapter();

            autoAdapter.Insert(plateTextBox.Text, modelTextBox.Text, colorTextBox.Text, brandTextBox.Text, codCliente, yearTextBox.Text);

            MessageBox.Show("Auto agregado correctamente");

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
