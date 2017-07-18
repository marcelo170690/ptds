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
            var clienteAdpater = new bdchapacoDataSetTableAdapters.clienteTableAdapter();

            AgregarAuto auto = new AgregarAuto();
            auto.codCliente = (short)clienteAdpater.getCodCliente(clienteTextBox.Text);
            auto.nombre = clienteAdpater.getNombre((short)clienteAdpater.getCodCliente(clienteTextBox.Text)).ToString() + " " + clienteAdpater.getApellidos((short)clienteAdpater.getCodCliente(clienteTextBox.Text)).ToString();
            auto.carnet = clienteTextBox.Text;

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
            var clienteAdpater = new bdchapacoDataSetTableAdapters.clienteTableAdapter();

            diagnostico.Insert(detailTextBox.Text, DateTime.Now, movilComboBox.Text);

            DialogResult dialog = MessageBox.Show("Desea realizar la reparación?", "Aviso", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                frmreparacion frm = new frmreparacion();

                frm.vplaca = movilComboBox.Text;
                frm.nc = clienteAdpater.getNombre((short)clienteAdpater.getCodCliente(clienteTextBox.Text)).ToString() + " " + clienteAdpater.getApellidos((short)clienteAdpater.getCodCliente(clienteTextBox.Text)).ToString();

                frm.Show();

                this.Close();
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
