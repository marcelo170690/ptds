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

            this.Close();
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
    }
}
