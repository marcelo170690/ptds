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
    public partial class frmReciboReparacion : Form{
        public frmReciboReparacion(){
            InitializeComponent();
        }
        public string vplaca = "";
        public int vcodrep = 0;
        private void frmReciboReparacion_Load(object sender, EventArgs e){
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'ds_informes.InfCliente' Puede moverla o quitarla según sea necesario.
                this.InfClienteTableAdapter.DetalleCliente(this.ds_informes.InfCliente, vplaca);
                // TODO: esta línea de código carga datos en la tabla 'ds_informes.InfReparacion' Puede moverla o quitarla según sea necesario.
                this.InfReparacionTableAdapter.DetalleReparacion(this.ds_informes.InfReparacion, vcodrep);
                // TODO: esta línea de código carga datos en la tabla 'ds_informes.InfDetalle' Puede moverla o quitarla según sea necesario.
                this.InfDetalleTableAdapter.DetalleDetalle(this.ds_informes.InfDetalle, vcodrep);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ll)
            {
                MessageBox.Show(ll.ToString());
            }
            
        }
    }
}
