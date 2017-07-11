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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        private void okCodButton_Click(object sender, EventArgs e)
        {
            var clienteAdapter = new bdchapacoDataSetTableAdapters.clienteTableAdapter();
            var autoAdapter = new bdchapacoDataSetTableAdapters.autoTableAdapter();

            try
            {
                var cod = clienteAdapter.getCodCliente(codTextBox.Text);

                ciTextBox.Text = clienteAdapter.getCarnet((short)cod);
                nameTextBox.Text = (string)clienteAdapter.getNombre((short)cod);
                lastTextBox.Text = clienteAdapter.getApellidos((short)cod);
                telfTextBox.Text = clienteAdapter.getCelular((short)cod);

                movilComboBox.DataSource = autoAdapter.GetDataByPlaca(cod);
                movilComboBox.DisplayMember = "placa";

                var placa = movilComboBox.Text;

                plateTextBox.Text = autoAdapter.getPlaca(placa);
                colorTextBox.Text = autoAdapter.getColor(placa);
                modelTextBox.Text = autoAdapter.getModelo(placa);
                yearTextBox.Text = autoAdapter.getAño(placa) + "";
                brandTextBox.Text = autoAdapter.getMarca(placa);
            }
            catch (Exception error)
            {
                ciTextBox.Text = String.Empty;
                nameTextBox.Text = String.Empty;
                lastTextBox.Text = String.Empty;
                telfTextBox.Text = String.Empty;

                plateTextBox.Text = String.Empty;
                colorTextBox.Text = String.Empty;
                modelTextBox.Text = String.Empty;
                yearTextBox.Text = String.Empty;
                brandTextBox.Text = String.Empty;
                movilComboBox.Text = String.Empty;
            }
        }

        private void movilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var autoAdapter = new bdchapacoDataSetTableAdapters.autoTableAdapter();

            var placa = movilComboBox.Text;

            plateTextBox.Text = autoAdapter.getPlaca(placa);
            colorTextBox.Text = autoAdapter.getColor(placa);
            modelTextBox.Text = autoAdapter.getModelo(placa);
            yearTextBox.Text = autoAdapter.getAño(placa) + "";
            brandTextBox.Text = autoAdapter.getMarca(placa);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var clienteAdapter = new bdchapacoDataSetTableAdapters.clienteTableAdapter();
            var autoAdapter = new bdchapacoDataSetTableAdapters.autoTableAdapter();

            var cod = clienteAdapter.getCodCliente(codTextBox.Text);

            clienteAdapter.updateCliente(nameTextBox.Text, lastTextBox.Text, ciTextBox.Text, telfTextBox.Text, (short)cod);

            var placa = autoAdapter.getPlaca(plateTextBox.Text);

            autoAdapter.UpdateAuto(plateTextBox.Text, modelTextBox.Text, colorTextBox.Text, brandTextBox.Text, Convert.ToInt32(yearTextBox.Text), placa);

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
