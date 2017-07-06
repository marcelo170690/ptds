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

namespace softchape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dstablas ds = new dstablas();
        TAcliente tac = new TAcliente();
        private void Form1_Load(object sender, EventArgs e)
        {
            tac.Fill(ds.cliente);
            dataGridView1.DataSource = ds.cliente;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hola";
        }
    }
}
