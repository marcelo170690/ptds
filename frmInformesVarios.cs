using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using softchape.ds_informesTableAdapters;
using softchape.bdchapacoDataSetTableAdapters;

namespace softchape{
    public partial class frmInformesVarios : Form{
        public frmInformesVarios(){
            InitializeComponent();
        }
        #region tablas
        todosTableAdapter tato = new todosTableAdapter();
        ds_informes ds = new ds_informes();
        reparacionTableAdapter tarep = new reparacionTableAdapter();
        servicioTableAdapter taser = new servicioTableAdapter();
        CaceiteTableAdapter tacac = new CaceiteTableAdapter();
        #endregion
        #region formularios
        InfReciboLimpieza limp;
        frmReciboReparacion repa;
        global gl = new global();
        #endregion
        #region funciones
        string placaX(int cod, string tipo){
            if (tipo.Equals("1"))
                return tacac.f_placaX(cod).ToString();   
            if (tipo.Equals("2"))
                return tarep.f_placaX(cod).ToString();   
            else
                return taser.f_placaX(cod).ToString();   
        }
        void cargar() {
            tato.todos(ds.todos);
            dgvtodos.DataSource=ds.todos;
            dgvtodos.Columns[0].Visible = false;
            dgvtodos.Columns[3].Visible = false;
        }
        void color() {
            int o = dgvtodos.Rows.Count;
            for (int i = 0; i < o; i++){
                if (dgvtodos.Rows[i].Cells[3].Value.ToString()=="1")
                    dgvtodos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                if (dgvtodos.Rows[i].Cells[3].Value.ToString().Equals("2"))
                    dgvtodos.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                if (dgvtodos.Rows[i].Cells[3].Value.ToString().Equals("3"))
                    dgvtodos.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
            }
        }
        #endregion
        private void frmInformesVarios_Load(object sender, EventArgs e){
            cargar();
            color();
        }

        private void button1_Click(object sender, EventArgs e){
            Close();
        }

        private void btnimprimir_Click(object sender, EventArgs e){
            try{
                int vcod=Convert.ToInt32(dgvtodos.CurrentRow.Cells[0].Value.ToString());
                string vplaca=placaX(vcod,dgvtodos.CurrentRow.Cells[3].Value.ToString());
                //MessageBox.Show("codigo: " + vcod + ", placa: " + vplaca + ", tipo: " + dgvtodos.CurrentRow.Cells[3].Value.ToString());
                if (dgvtodos.CurrentRow.Cells[3].Value.ToString().Equals("1"))
                    MessageBox.Show("Esta aun de prueba");
                if (dgvtodos.CurrentRow.Cells[3].Value.ToString().Equals("2")){
                    repa = new frmReciboReparacion();
                    repa.vplaca = vplaca;
                    repa.vcodrep = vcod;
                    repa.ShowDialog();
                }
                if (dgvtodos.CurrentRow.Cells[3].Value.ToString().Equals("3")) {
                    limp = new InfReciboLimpieza();
                    limp.vplaca = vplaca;
                    limp.vcodser = vcod;
                    limp.ShowDialog();
                }
            }catch (Exception x){
                MessageBox.Show(x.Message);
            }
        }

        private void frmInformesVarios_Activated(object sender, EventArgs e){
            cargar();
            color();
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox3, e.Graphics, Color.Black, Color.Black);
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox1, e.Graphics, Color.Black, Color.Black);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox2, e.Graphics, Color.Black, Color.Black);
        }
    }
}
