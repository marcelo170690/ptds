namespace softchape
{
    partial class frmCambioAceite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lklagregar = new System.Windows.Forms.LinkLabel();
            this.btbnagregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbvehiculo = new System.Windows.Forms.ComboBox();
            this.txtci = new System.Windows.Forms.TextBox();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lklagregar);
            this.groupBox2.Controls.Add(this.btbnagregar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbvehiculo);
            this.groupBox2.Controls.Add(this.txtci);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "VehÍculos";
            // 
            // lklagregar
            // 
            this.lklagregar.AutoSize = true;
            this.lklagregar.Location = new System.Drawing.Point(16, 84);
            this.lklagregar.Name = "lklagregar";
            this.lklagregar.Size = new System.Drawing.Size(161, 20);
            this.lklagregar.TabIndex = 2;
            this.lklagregar.TabStop = true;
            this.lklagregar.Text = "El cliente no existe";
            this.lklagregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklagregar_LinkClicked);
            // 
            // btbnagregar
            // 
            this.btbnagregar.Location = new System.Drawing.Point(303, 79);
            this.btbnagregar.Name = "btbnagregar";
            this.btbnagregar.Size = new System.Drawing.Size(192, 31);
            this.btbnagregar.TabIndex = 3;
            this.btbnagregar.Text = "AGREGAR VEHICULO";
            this.btbnagregar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cédula de Identidad";
            // 
            // cmbvehiculo
            // 
            this.cmbvehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvehiculo.FormattingEnabled = true;
            this.cmbvehiculo.Location = new System.Drawing.Point(207, 49);
            this.cmbvehiculo.Name = "cmbvehiculo";
            this.cmbvehiculo.Size = new System.Drawing.Size(288, 28);
            this.cmbvehiculo.TabIndex = 1;
            // 
            // txtci
            // 
            this.txtci.Location = new System.Drawing.Point(20, 49);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(165, 32);
            this.txtci.TabIndex = 2;
            this.txtci.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtci_KeyDown);
            this.txtci.Leave += new System.EventHandler(this.txtci_Leave);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.txtobservaciones.Location = new System.Drawing.Point(20, 117);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(336, 144);
            this.txtobservaciones.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observaciones";
            // 
            // cmbmarca
            // 
            this.cmbmarca.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.cmbmarca.FormattingEnabled = true;
            this.cmbmarca.Items.AddRange(new object[] {
            "CASTROL",
            "PEENZIOL",
            "MOBIL1",
            "MOBIL2",
            "MOBIL 3",
            "AMSOIL",
            "PETROBRAS",
            "PREMIUN GLS",
            "NOCHS DDS"});
            this.cmbmarca.Location = new System.Drawing.Point(133, 25);
            this.cmbmarca.Name = "cmbmarca";
            this.cmbmarca.Size = new System.Drawing.Size(176, 28);
            this.cmbmarca.TabIndex = 0;
            this.cmbmarca.Text = "CASTROL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca Aceite";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcosto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbmarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtobservaciones);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Cambio Aceite";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsalir);
            this.groupBox3.Controls.Add(this.btnguardar);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.groupBox3.Location = new System.Drawing.Point(391, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 245);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = global::softchape.Properties.Resources.salir1;
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(17, 116);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(92, 85);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = global::softchape.Properties.Resources.guardar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(17, 25);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(92, 85);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(76, 59);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(77, 32);
            this.txtcosto.TabIndex = 6;
            this.txtcosto.Text = "0";
            this.txtcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcosto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Costo";
            // 
            // frmCambioAceite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 446);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmCambioAceite";
            this.Load += new System.EventHandler(this.frmCambioAceite_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lklagregar;
        private System.Windows.Forms.Button btbnagregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbvehiculo;
        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbmarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcosto;
    }
}