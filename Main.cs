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
    public partial class Main : Form{
        public Main(){
            InitializeComponent();
        }
        #region formularios
        frmlimpieza limp;
        frmCambioAceite frmca;
        frmInformesVarios frmiv;
        #endregion
        private void Main_Shown(object sender, EventArgs e){

        }

        private void button1_Click(object sender, EventArgs e){

        }

        private void button1_Click_1(object sender, EventArgs e){
            
        }

        private void editClienteButton_Click(object sender, EventArgs e){
            var registro = new Registro();
            registro.Show();    
        }

        private void button2_Click(object sender, EventArgs e){
            var diagnostico = new Diagnostico();
            diagnostico.Show();
        }

        private void button1_Click_2(object sender, EventArgs e){
            var editar = new Editar();
            editar.Show();
        }

        private void Main_Load(object sender, EventArgs e){

        }

        private void button3_Click(object sender, EventArgs e){
            limp = new frmlimpieza();
            limp.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e){
            frmca = new frmCambioAceite();
            frmca.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e){
            frmiv = new frmInformesVarios();
            frmiv.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Auxiliar auxiliar = new Auxiliar();
            auxiliar.Show();
        }
    }
}
