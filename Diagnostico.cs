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
    public partial class Diagnostico : Form
    {
        public Diagnostico()
        {
            InitializeComponent();
        }

        private void addMovilButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void clienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            var clienteAdpater = new bdchapacoDataSetTableAdapters.clienteTableAdapter();
            var autoAdapter = new bdchapacoDataSetTableAdapters.autoTableAdapter();

            var cod = clienteAdpater.getCodCliente(clienteTextBox.Text);

            if (cod != null)
            {
                movilComboBox.DataSource = autoAdapter.GetDataByPlaca(cod);
                movilComboBox.DisplayMember = "placa";
            }
            else
            {
                movilComboBox.DataSource = null;
                movilComboBox.Text = String.Empty;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var diagnostico = new bdchapacoDataSetTableAdapters.diagnosticoTableAdapter();

            diagnostico.Insert(detailTextBox.Text, DateTime.Now, movilComboBox.Text);

            DialogResult dialog = MessageBox.Show("Desea realizar la reparación?", "Aviso", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

            }
            else
            {
                this.Close();
            }
        }

        private void Diagnostico_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
