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
    public partial class Auxiliar : Form
    {
        bdchapacoDataSetTableAdapters.clienteTableAdapter clienteAdapter = new bdchapacoDataSetTableAdapters.clienteTableAdapter();

        bdchapacoDataSetTableAdapters.autoTableAdapter autoAdapter = new bdchapacoDataSetTableAdapters.autoTableAdapter();

        auxiliarTableAdapters.autoTableAdapter autoTable = new auxiliarTableAdapters.autoTableAdapter();

        auxiliarTableAdapters.clienteTableAdapter clienteTable = new auxiliarTableAdapters.clienteTableAdapter();

        auxiliarTableAdapters.AuxilioVehicularTableAdapter auxilioTable = new auxiliarTableAdapters.AuxilioVehicularTableAdapter();

        String precio = "100";
        String tipo = "Remolque";

        public Auxiliar()
        {
            InitializeComponent();
        }

        private void modelTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                var cod = clienteAdapter.getCodCliente(ciTextBox.Text);

                movilidadComboBox.DataSource = autoAdapter.GetDataByPlaca(cod);
                movilidadComboBox.DisplayMember = "placa";
            }
            catch (Exception error)
            {

            }
        }

        private void addNuevoClienteButton_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }

        private void addNuevoAutoButton_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarAuto agregarAuto = new AgregarAuto();
                agregarAuto.codCliente = (short)clienteAdapter.getCodCliente(ciTextBox.Text);
                agregarAuto.nombre = clienteAdapter.getNombre((short)clienteAdapter.getCodCliente(ciTextBox.Text)).ToString() + " " + clienteAdapter.getApellidos((short)clienteAdapter.getCodCliente(ciTextBox.Text)).ToString();
                agregarAuto.carnet = ciTextBox.Text;
                agregarAuto.Show();
            }
            catch (Exception error)
            {

            }
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RadioButton radioButton = (RadioButton)sender;

                switch (radioButton.Text)
                {
                    case "REMOLQUE":
                        tipo = "Remolque";
                        precio = "100";
                        break;
                    case "PARCHADO DE LLANTAS":
                        tipo = "Parcahdo de llantas";
                        precio = "150";
                        break;
                    case "AIRE A NEUMATICOS":
                        tipo = "Aire a neumaticos";
                        precio = "200";
                        break;
                    case "SERVICIO ELECTRICO BASICO":
                        tipo = "Servicio electrico basico";
                        precio = "250";
                        break;
                }

                label6.Text = precio + "Bs.";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                auxilioTable.Insert(movilidadComboBox.Text, direccionTextBox.Text, tipo, precio, ciTextBox.Text);

                MessageBox.Show("Registrado");

                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error + "");
            }
        }
    }
}
