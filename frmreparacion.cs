using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using softchape.bdchapacoDataSetTableAdapters;

namespace softchape{
    public partial class frmreparacion : Form{
        public frmreparacion(){
            InitializeComponent();
        }
        #region variables
        public string nc="MARCELO CHOQUE PACHECO";
        public string vplaca = "595PPO";
        int vcodmec = 0;
        int vcodayu = 0;
        double total = 0;
        #endregion
        #region clases
        detalleTableAdapter det = new detalleTableAdapter();
        materialTableAdapter tam = new materialTableAdapter();
        mecanicoTableAdapter tamec = new mecanicoTableAdapter();
        ayudanteTableAdapter taay = new ayudanteTableAdapter();
        reparacionTableAdapter tarep = new reparacionTableAdapter();
        bdchapacoDataSet ds = new bdchapacoDataSet();
        material mat=new material(1);
        global gl = new global();
        #endregion
        #region funciones
        void limpiar() {
            txtcosto.Clear();
            txtdescuento.Clear();
            lblTOTAL.Text="0";
            dgvmaterial.Rows.Clear();
            nudcant.Focus();
            txtonbservacion.Clear();
        }
        int CantMat() { 
            return (dgvmaterial.Rows.Count);
        }
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
        #endregion
        #region formularios
        frmReciboReparacion finf;
        #endregion
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){
            
        }

        private void frmreparacion_Load(object sender, EventArgs e){
            CargarAyudante();
            CargarMaterial();
            CargarMecanico();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e){
            if (Convert.ToInt32(nudcant.Value.ToString()) > mat.get_cantidad()){
                MessageBox.Show("No puede agregar una cantidad mayor a la exitente", "TITULO AQUI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nudcant.Select();
                nudcant.Focus();
            }else{
                if (!existe(cmbmaterial.Text)) {
                    dgvmaterial.Rows.Add(cmbmaterial.SelectedValue.ToString(), cmbmaterial.Text, mat.get_costo().ToString(), nudcant.Text);
                    lbltotalmaterial.Text = totalmaterial().ToString();
                    nudcant.Value = 1;
                    cmbmaterial.Focus();
                }else{
                    MessageBox.Show("Ya agrego este material, edite xfavor", "TITULO AQUI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cmbmaterial_SelectedIndexChanged(object sender, EventArgs e){
            try{
                mat = new material(Convert.ToInt32(cmbmaterial.SelectedValue.ToString()));
            }catch (Exception){
                
            }
        }

        private void btnguardar_Click(object sender, EventArgs e){
            if (txtdescuento.Text == "")
                txtdescuento.Text = "0";
            if (CantMat() == 0 || lblTOTAL.Text == "0") {
                MessageBox.Show("Debe terminar ","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else{
                try{
                    tarep.Insert(DateTime.Now, 1, Convert.ToInt32(vcodmec), Convert.ToInt32(vcodayu), Convert.ToDouble(txtdescuento.Text), total, txtonbservacion.Text, cmbreparacion.Text);
                    int max = Convert.ToInt32(tarep.f_maxcodrep());
                    for (int i = 0; i < CantMat(); i++){
                        det.Insert(max, Convert.ToInt32(dgvmaterial.Rows[i].Cells[0].Value.ToString()), Convert.ToInt32(dgvmaterial.Rows[i].Cells[3].Value.ToString()));
                    }
                    limpiar();
                    if (MessageBox.Show("Desea imprimir el recibo?", "titulo aqui", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        finf = new frmReciboReparacion();
                        finf.vplaca = vplaca;
                        finf.vcodrep = max;
                        try
                        {
                            finf.ShowDialog();
                        }
                        catch (Exception vv)
                        {
                            MessageBox.Show(vv.ToString());
                        }
                        
                    }
                    if (MessageBox.Show("Desea realizar otro registro de reparacion?", "titulo aqui", MessageBoxButtons.YesNo) == DialogResult.No)
                        Close();
                }catch (Exception mm){
                    MessageBox.Show(mm.Message);
                }
            }        
        }

        

        private void cmbmecanico_SelectedIndexChanged(object sender, EventArgs e){
            
        }

        private void cmbayudante_SelectedIndexChanged(object sender, EventArgs e){
            try{
                vcodayu = Convert.ToInt32(cmbayudante.SelectedValue.ToString());
            }catch (Exception){
                
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void cmbmaterial_SelectedValueChanged(object sender, EventArgs e){
            try{
                vcodmec = Convert.ToInt32(cmbmaterial.SelectedValue.ToString());
            }catch (Exception){
                
            }
        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e){
            gl.decimales(e);
        }

        private void txtdescuento_TextChanged(object sender, EventArgs e){
            try{
                double costo = 0;
                double detalle = 0;
                if (txtcosto.Text == "")
                    costo = 0;
                else
                    costo = Convert.ToDouble(txtcosto.Text);
                if (lbltotalmaterial.Text == "0")
                    detalle = 0;
                else
                    detalle = Convert.ToDouble(lbltotalmaterial.Text);
                total = costo - Convert.ToDouble(txtdescuento.Text)+Convert.ToDouble(lbltotalmaterial.Text);
                lblTOTAL.Text = total.ToString();
            }catch (Exception){
                
                
            }
        }

        private void txtcosto_TextChanged(object sender, EventArgs e){
            try{
                double descuento = 0;
                double detalle = 0;
                if (txtdescuento.Text == "")
                    descuento = 0;
                else
                    descuento = Convert.ToDouble(txtdescuento.Text);
                if (lbltotalmaterial.Text=="0")
                    detalle = 0;
                else
                    detalle = Convert.ToDouble(lbltotalmaterial.Text);
                total = descuento + Convert.ToDouble(txtcosto.Text) + Convert.ToDouble(lbltotalmaterial.Text);
                lblTOTAL.Text = total.ToString();
            }catch (Exception){
                
                
            }
            
        }

        private void txtdescuento_KeyPress(object sender, KeyPressEventArgs e){
            gl.decimales(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
            Close();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox1, e.Graphics, Color.Black, Color.Black);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox2, e.Graphics, Color.Black, Color.Black);
        }

        private void groupBox8_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox8, e.Graphics, Color.Black, Color.Black);
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox3, e.Graphics, Color.Black, Color.Black);
        }

        private void groupBox5_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox5, e.Graphics, Color.Black, Color.Black);
        }

        private void groupBox6_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox6, e.Graphics, Color.Black, Color.Black);
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox4, e.Graphics, Color.Black, Color.Black);
        }

        private void groupBox9_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox9, e.Graphics, Color.Black, Color.Black);
        }

        private void groupBox7_Paint(object sender, PaintEventArgs e)
        {
            gl.DrawGroupBox(groupBox7, e.Graphics, Color.Black, Color.Black);
        }
    }
}
