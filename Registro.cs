using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softchape{
    public partial class Registro : Form{
        public Registro(){
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){

        }

        private void okButton_Click(object sender, EventArgs e){
            var newCliente = new bdchapacoDataSetTableAdapters.clienteTableAdapter();
            var newAutomovil = new bdchapacoDataSetTableAdapters.autoTableAdapter();

            string name = nameTextBox.Text, last = lastTextBox.Text, ci = ciTextBox.Text, telef = telfTextBox.Text;
            string model = modelTextBox.Text, brand = brandTextBox.Text, plate = plateTextBox.Text, year = yearTextBox.Text, color = colorTextBox.Text;

            newCliente.Insert(name, last, ci, telef);

            var codCliente = newCliente.getCodCliente(ci);

            newAutomovil.Insert(plate, model, color, brand, (short)codCliente, year);

            MessageBox.Show("Cliente registrado correctamente", "Correcto", MessageBoxButtons.OK);

            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e){
            this.Close();
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            var main = new Main();
            main.Show();
        }

        private void modelTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
