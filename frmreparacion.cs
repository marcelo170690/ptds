using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using softchape.dstablasTableAdapters;

namespace softchape{
    public partial class frmreparacion : Form{
        #region variables
        public int codigo=0;
        public string nc="";
        #endregion
        #region clases
        TAmaterial tam = new TAmaterial();
        TAmecanico tamec = new TAmecanico();
        TAayudante taay = new TAayudante();
        dstablas ds = new dstablas();
        material mat;
        #endregion
        #region funciones
        void CargarMaterial(){
            tam.Fill(ds.material);
            cmbmaterial.DataSource = ds.material;
            cmbmaterial.DisplayMember = "nombre";
            cmbmaterial.ValueMember = "codmat";
        }
        void CargarMecanico() {
            tamec.Fill(ds.mecanico);
            cmbmecanico.DataSource = ds.mecanico;
            cmbmecanico.DisplayMember="nombre";
            cmbmecanico.ValueMember = "codmec";
        }
        void CargarAyudante() {
            taay.Fill(ds.ayudante);
            cmbayudante.DataSource = ds.ayudante;
            cmbayudante.DisplayMember = "nombre";
            cmbayudante.ValueMember = "codayu";
        }
        #endregion
        public frmreparacion(){
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){
            
        }

        private void cmbmaterial_SelectedIndexChanged(object sender, EventArgs e){
            try{
                mat = new material(Convert.ToInt32(cmbmaterial.SelectedValue));
            }catch (Exception){
                
            }
        }
        double totalmaterial() {
            double x = 0;
            for (int i = 0; i < dgvmaterial.Rows.Count; i++){
                x = x + Convert.ToDouble(dgvmaterial.Rows[i].Cells[2].Value.ToString()) * Convert.ToDouble(dgvmaterial.Rows[i].Cells[3].Value.ToString());
            }
            return x;
        }
        bool existe(string x) {
            for (int i = 0; i < dgvmaterial.Rows.Count; i++){
                if (x.Equals(dgvmaterial.Rows[i].Cells[1].Value.ToString()))
                    return true;
            }
            return false;
        }
        private void button2_Click(object sender, EventArgs e){
            if (Convert.ToInt32(txtcant.Text) > mat.get_cantidad()){
                MessageBox.Show("No puede agregar una cantidad mayor a la exitente", "TITULO AQUI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcant.Select();
                txtcant.Focus();
            }else{
                if (!existe(cmbmaterial.Text)) {
                    dgvmaterial.Rows.Add(cmbmaterial.SelectedValue.ToString(), cmbmaterial.Text, mat.get_costo().ToString(), txtcant.Text);
                    lbltotalmaterial.Text = totalmaterial().ToString();
                    txtcant.Value = 1;
                    cmbmaterial.Focus();
                }else{
                    MessageBox.Show("Ya agrego este material, edite xfavor", "TITULO AQUI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void frmreparacion_Load(object sender, EventArgs e){
            CargarAyudante();
            CargarMaterial();
            CargarMecanico();
            cmbayudante.Text = "SISTEMA DE TRANSMISION";
        }

        private void txtcant_TextChanged(object sender, EventArgs e){

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
