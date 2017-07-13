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
    public partial class frmlimpieza : Form{
        public frmlimpieza(){
            InitializeComponent();
        }
        #region variables
        public int vcodcliente=1;
        public string vplaca = "";
        double total = 0;
        #endregion
        #region clases
        global gl = new global();
        #endregion
        #region formularios
        Registro reg;
        #endregion
        #region tablas
        bdchapacoDataSet ds = new bdchapacoDataSet();
        autoTableAdapter taa = new autoTableAdapter();
        clienteTableAdapter tac = new clienteTableAdapter();
        servicioTableAdapter taser = new servicioTableAdapter();
        tdetalleTableAdapter tadet = new tdetalleTableAdapter();
        #endregion
        #region funciones
        void CargarVehiculo() {
            taa.MaestroVehiculo(ds.auto,vcodcliente);
            cmbvehiculo.DataSource = ds.auto;
            cmbvehiculo.DisplayMember = "detalle";
            cmbvehiculo.ValueMember = "placa";
        }
        void CargarCliente() {
            tac.Fill(ds.cliente);
            
        }
        double verificar_txt(string x) {
            if (x.Equals(""))
            {
                return 0;
            }
            else
                return Convert.ToDouble(x);
        }
        void limpiar() {
            cbencerado.Checked = false;
            cbengrasado.Checked = false;
            cbfumigado.Checked = false;
            cbpulido.Checked = false;
            cbinterior.Checked = false;
        }
        void GuardarDetalle(TextBox tx, CheckBox x, int max) {
            if (x.Checked)
                tadet.Insert(max, verificar_txt(tx.Text), x.Text);
        }
        #endregion
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e){
            gl.decimales(e);
        }

        private void frmlimpieza_Load(object sender, EventArgs e){
            CargarVehiculo();
        }

        private void btbnagregar_Click(object sender, EventArgs e){
            MessageBox.Show("agregar frm agregar_vehiculo aqui");
        }

        private void lklagregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            reg = new Registro();
            reg.ciTextBox.Text=txtci.Text;
            reg.ShowDialog();
        }

        private void txtci_Leave(object sender, EventArgs e){
            try{
                vcodcliente = Convert.ToInt32(tac.getCodCliente(txtci.Text));
                CargarVehiculo();
                vplaca = cmbvehiculo.SelectedValue.ToString();
            }catch (Exception){

            }
            if (cmbvehiculo.Text == "")
                lklagregar.Visible = true;
            else
                lklagregar.Visible = false;
        }

        private void txtci_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter) { 
                try{
                    vcodcliente = Convert.ToInt32(tac.getCodCliente(txtci.Text));
                    CargarVehiculo();
                    vplaca = cmbvehiculo.SelectedValue.ToString();
                }catch (Exception){
                    
                }
            }

        }

        private void cmbvehiculo_SelectedIndexChanged(object sender, EventArgs e){

        }

        private void cmbvehiculo_ValueMemberChanged(object sender, EventArgs e){
            try{
                vplaca = cmbvehiculo.SelectedValue.ToString();
            }catch (Exception){
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vplaca);
        }

        private void cbfumigado_CheckedChanged(object sender, EventArgs e){
            if (cbfumigado.Checked)
                txtfumigado.Enabled = true;
            else 
                txtfumigado.Enabled = false;
            txtfumigado.Text = "0";
        }

        private void cbengrasado_CheckedChanged(object sender, EventArgs e){
            if (cbengrasado.Checked)
                txtengrasado.Enabled = true;
            else 
                txtengrasado.Enabled = false;
            txtengrasado.Text = "0";
        }

        private void txtengrasado_KeyPress(object sender, KeyPressEventArgs e){
            gl.decimales(e);
        }

        private void button2_Click(object sender, EventArgs e){
            limpiar();
        }

        private void txtci_TextChanged(object sender, EventArgs e){

        }

        private void txtpulido_KeyPress(object sender, KeyPressEventArgs e){
            gl.decimales(e);
        }

        private void txtlimpinte_KeyPress(object sender, KeyPressEventArgs e){
            gl.decimales(e);
        }

        private void tenserado_KeyPress(object sender, KeyPressEventArgs e){
            gl.decimales(e);
        }

        private void txtdescuento_KeyPress(object sender, KeyPressEventArgs e){
            gl.decimales(e);
        }

        private void txtfumigado_TextChanged(object sender, EventArgs e){
            try{
                total = verificar_txt(txtfumigado.Text) + verificar_txt(txtengrasado.Text) + verificar_txt(txtpulido.Text) + verificar_txt(txtlimpinte.Text) + verificar_txt(txtenserado.Text)-verificar_txt(txtdescuento.Text);
                lblparcial.Text = (total + verificar_txt(txtdescuento.Text)).ToString();
                lbltotal.Text = total.ToString();
            }catch (Exception){
                
            }
        }

        private void txtengrasado_TextChanged(object sender, EventArgs e){
            try{
                total = verificar_txt(txtfumigado.Text) + verificar_txt(txtengrasado.Text) + verificar_txt(txtpulido.Text) + verificar_txt(txtlimpinte.Text) + verificar_txt(txtenserado.Text) - verificar_txt(txtdescuento.Text);
                lblparcial.Text = (total + verificar_txt(txtdescuento.Text)).ToString();
                lbltotal.Text = total.ToString();
            }catch (Exception){
                
            }
        }

        private void txtpulido_TextChanged(object sender, EventArgs e){
            try{
                total = verificar_txt(txtfumigado.Text) + verificar_txt(txtengrasado.Text) + verificar_txt(txtpulido.Text) + verificar_txt(txtlimpinte.Text) + verificar_txt(txtenserado.Text) - verificar_txt(txtdescuento.Text);
                lblparcial.Text = (total + verificar_txt(txtdescuento.Text)).ToString();
                lbltotal.Text = total.ToString();
            }catch (Exception){
                
            }
        }

        private void txtlimpinte_TextChanged(object sender, EventArgs e){
            try{
                total = verificar_txt(txtfumigado.Text) + verificar_txt(txtengrasado.Text) + verificar_txt(txtpulido.Text) + verificar_txt(txtlimpinte.Text) + verificar_txt(txtenserado.Text) - verificar_txt(txtdescuento.Text);
                lblparcial.Text = (total + verificar_txt(txtdescuento.Text)).ToString();
                lbltotal.Text = total.ToString();
            }catch (Exception){
                
            }
        }

        private void txtenserado_TextChanged(object sender, EventArgs e){
            try{
                total = verificar_txt(txtfumigado.Text) + verificar_txt(txtengrasado.Text) + verificar_txt(txtpulido.Text) + verificar_txt(txtlimpinte.Text) + verificar_txt(txtenserado.Text) - verificar_txt(txtdescuento.Text);
                lblparcial.Text = (total + verificar_txt(txtdescuento.Text)).ToString();
                lbltotal.Text = total.ToString();
            }catch (Exception){

            }
        }

        private void txtdescuento_TextChanged(object sender, EventArgs e){
            try{
                total = verificar_txt(txtfumigado.Text) + verificar_txt(txtengrasado.Text) + verificar_txt(txtpulido.Text) + verificar_txt(txtlimpinte.Text) + verificar_txt(txtenserado.Text) - verificar_txt(txtdescuento.Text);
                lblparcial.Text = (total + verificar_txt(txtdescuento.Text)).ToString();
                lbltotal.Text = total.ToString();
            }catch (Exception){
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e){
            if (cbpulido.Checked)
                txtpulido.Enabled = true;
            else 
                txtpulido.Enabled = false;
            txtpulido.Text = "0";
        }

        private void cbinterior_CheckedChanged(object sender, EventArgs e){
            if (cbinterior.Checked)
                txtlimpinte.Enabled = true;
            else 
                txtlimpinte.Enabled = false;
            txtlimpinte.Text = "0";
        }

        private void cbencerado_CheckedChanged(object sender, EventArgs e){
            if (cbencerado.Checked)
                txtenserado.Enabled = true;
            else
                txtenserado.Enabled = false;
            txtenserado.Text = "0";
        }

        private void btnfinalizar_Click(object sender, EventArgs e){
            if (total == 0) {
                MessageBox.Show("No puede concluir ","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }else{
                Int32 max = 0;
                taser.Insert(DateTime.Now, verificar_txt(txtdescuento.Text), vplaca, txtobservaciones.Text);
                max = Convert.ToInt32(taser.f_max());
                GuardarDetalle(txtfumigado, cbfumigado, max);
                GuardarDetalle(txtengrasado, cbengrasado, max);
                GuardarDetalle(txtpulido, cbpulido, max);
                GuardarDetalle(txtlimpinte, cbinterior, max);
                GuardarDetalle(txtenserado, cbencerado, max);
                if (MessageBox.Show("Desea imprimir la el recibo?", "titulo aqui", MessageBoxButtons.YesNo) == DialogResult.No)
                    Close();
            }
        }
    }
}
