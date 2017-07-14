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
    public partial class InfReciboLimpieza : Form{
        public InfReciboLimpieza(){
            InitializeComponent();
        }
        public string vplaca="";
        public int vcodser = 0;
        private void InfReciboLimpieza_Load(object sender, EventArgs e){
            // TODO: esta línea de código carga datos en la tabla 'ds_informes.InfCliente' Puede moverla o quitarla según sea necesario.
            this.InfClienteTableAdapter.DetalleCliente(this.ds_informes.InfCliente,vplaca);
            // TODO: esta línea de código carga datos en la tabla 'ds_informes.InfServicio' Puede moverla o quitarla según sea necesario.
            this.InfServicioTableAdapter.DetalleServicioLimpieza(this.ds_informes.InfServicio,vcodser);
            // TODO: esta línea de código carga datos en la tabla 'ds_informes.InfTdetalle' Puede moverla o quitarla según sea necesario.
            this.InfTdetalleTableAdapter.DetalleLimpieza(this.ds_informes.InfTdetalle, vcodser);

            this.reportViewer1.RefreshReport();
        }
    }
}
