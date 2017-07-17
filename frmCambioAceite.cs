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
    public partial class frmCambioAceite : Form{
        public frmCambioAceite(){
            InitializeComponent();
        }
        #region variables
        public int vcodcliente = 1;
        public string vplaca = "";
        double total = 0;
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
        
        #endregion
        global gl = new global();
        private void frmCambioAceite_Load(object sender, EventArgs e){
            txtci.Focus();
        }
        private void lklagregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            reg = new Registro();
            reg.ShowDialog();
        }

        private void txtci_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter) { 
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

        private void btnsalir_Click(object sender, EventArgs e){
            Close();
        }

        private void btnguardar_Click(object sender, EventArgs e){

        }
    }
}
