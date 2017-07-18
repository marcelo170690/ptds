namespace softchape
{
    partial class frmlimpieza
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
            this.txtci = new System.Windows.Forms.TextBox();
            this.cmbvehiculo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btbnagregar = new System.Windows.Forms.Button();
            this.lklagregar = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtengrasado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbfumigado = new System.Windows.Forms.CheckBox();
            this.cbengrasado = new System.Windows.Forms.CheckBox();
            this.txtfumigado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtenserado = new System.Windows.Forms.TextBox();
            this.txtlimpinte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbencerado = new System.Windows.Forms.CheckBox();
            this.cbinterior = new System.Windows.Forms.CheckBox();
            this.cbpulido = new System.Windows.Forms.CheckBox();
            this.txtpulido = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblparcial = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtci
            // 
            this.txtci.Location = new System.Drawing.Point(20, 49);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(165, 32);
            this.txtci.TabIndex = 0;
            this.txtci.TextChanged += new System.EventHandler(this.txtci_TextChanged);
            this.txtci.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtci_KeyDown);
            this.txtci.Leave += new System.EventHandler(this.txtci_Leave);
            // 
            // cmbvehiculo
            // 
            this.cmbvehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvehiculo.FormattingEnabled = true;
            this.cmbvehiculo.Location = new System.Drawing.Point(207, 49);
            this.cmbvehiculo.Name = "cmbvehiculo";
            this.cmbvehiculo.Size = new System.Drawing.Size(288, 28);
            this.cmbvehiculo.TabIndex = 1;
            this.cmbvehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbvehiculo_SelectedIndexChanged);
            this.cmbvehiculo.ValueMemberChanged += new System.EventHandler(this.cmbvehiculo_ValueMemberChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cédula de Identidad";
            // 
            // btbnagregar
            // 
            this.btbnagregar.Location = new System.Drawing.Point(303, 79);
            this.btbnagregar.Name = "btbnagregar";
            this.btbnagregar.Size = new System.Drawing.Size(192, 31);
            this.btbnagregar.TabIndex = 3;
            this.btbnagregar.Text = "AGREGAR VEHICULO";
            this.btbnagregar.UseVisualStyleBackColor = true;
            this.btbnagregar.Click += new System.EventHandler(this.btbnagregar_Click);
            // 
            // lklagregar
            // 
            this.lklagregar.AutoSize = true;
            this.lklagregar.Location = new System.Drawing.Point(16, 84);
            this.lklagregar.Name = "lklagregar";
            this.lklagregar.Size = new System.Drawing.Size(161, 20);
            this.lklagregar.TabIndex = 4;
            this.lklagregar.TabStop = true;
            this.lklagregar.Text = "El cliente no existe";
            this.lklagregar.Visible = false;
            this.lklagregar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklagregar_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "VehÍculos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lklagregar);
            this.groupBox1.Controls.Add(this.btbnagregar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbvehiculo);
            this.groupBox1.Controls.Add(this.txtci);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtengrasado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbfumigado);
            this.groupBox2.Controls.Add(this.cbengrasado);
            this.groupBox2.Controls.Add(this.txtfumigado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LIMPIEZA";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // txtengrasado
            // 
            this.txtengrasado.Enabled = false;
            this.txtengrasado.Location = new System.Drawing.Point(165, 94);
            this.txtengrasado.Name = "txtengrasado";
            this.txtengrasado.Size = new System.Drawing.Size(109, 32);
            this.txtengrasado.TabIndex = 15;
            this.txtengrasado.TextChanged += new System.EventHandler(this.txtengrasado_TextChanged);
            this.txtengrasado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtengrasado_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "  Servicio  ";
            // 
            // cbfumigado
            // 
            this.cbfumigado.AutoSize = true;
            this.cbfumigado.Location = new System.Drawing.Point(14, 60);
            this.cbfumigado.Name = "cbfumigado";
            this.cbfumigado.Size = new System.Drawing.Size(114, 24);
            this.cbfumigado.TabIndex = 13;
            this.cbfumigado.Text = "FUMIGADO";
            this.cbfumigado.UseVisualStyleBackColor = true;
            this.cbfumigado.CheckedChanged += new System.EventHandler(this.cbfumigado_CheckedChanged);
            // 
            // cbengrasado
            // 
            this.cbengrasado.AutoSize = true;
            this.cbengrasado.Location = new System.Drawing.Point(14, 96);
            this.cbengrasado.Name = "cbengrasado";
            this.cbengrasado.Size = new System.Drawing.Size(126, 24);
            this.cbengrasado.TabIndex = 12;
            this.cbengrasado.Text = "ENGRASADO";
            this.cbengrasado.UseVisualStyleBackColor = true;
            this.cbengrasado.CheckedChanged += new System.EventHandler(this.cbengrasado_CheckedChanged);
            // 
            // txtfumigado
            // 
            this.txtfumigado.Enabled = false;
            this.txtfumigado.Location = new System.Drawing.Point(165, 58);
            this.txtfumigado.Name = "txtfumigado";
            this.txtfumigado.Size = new System.Drawing.Size(109, 32);
            this.txtfumigado.TabIndex = 8;
            this.txtfumigado.TextChanged += new System.EventHandler(this.txtfumigado_TextChanged);
            this.txtfumigado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "  Costo  ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtenserado);
            this.groupBox3.Controls.Add(this.txtlimpinte);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbencerado);
            this.groupBox3.Controls.Add(this.cbinterior);
            this.groupBox3.Controls.Add(this.cbpulido);
            this.groupBox3.Controls.Add(this.txtpulido);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(306, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 167);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MAS SERVICIOS";
            this.groupBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "  Costo  ";
            // 
            // txtenserado
            // 
            this.txtenserado.Enabled = false;
            this.txtenserado.Location = new System.Drawing.Point(199, 122);
            this.txtenserado.Name = "txtenserado";
            this.txtenserado.Size = new System.Drawing.Size(153, 32);
            this.txtenserado.TabIndex = 18;
            this.txtenserado.TextChanged += new System.EventHandler(this.txtenserado_TextChanged);
            this.txtenserado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tenserado_KeyPress);
            // 
            // txtlimpinte
            // 
            this.txtlimpinte.Enabled = false;
            this.txtlimpinte.Location = new System.Drawing.Point(199, 87);
            this.txtlimpinte.Name = "txtlimpinte";
            this.txtlimpinte.Size = new System.Drawing.Size(153, 32);
            this.txtlimpinte.TabIndex = 17;
            this.txtlimpinte.TextChanged += new System.EventHandler(this.txtlimpinte_TextChanged);
            this.txtlimpinte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlimpinte_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "  Servicio  ";
            // 
            // cbencerado
            // 
            this.cbencerado.AutoSize = true;
            this.cbencerado.Location = new System.Drawing.Point(15, 124);
            this.cbencerado.Name = "cbencerado";
            this.cbencerado.Size = new System.Drawing.Size(114, 24);
            this.cbencerado.TabIndex = 14;
            this.cbencerado.Text = "ENCERADO";
            this.cbencerado.UseVisualStyleBackColor = true;
            this.cbencerado.CheckedChanged += new System.EventHandler(this.cbencerado_CheckedChanged);
            // 
            // cbinterior
            // 
            this.cbinterior.AutoSize = true;
            this.cbinterior.Location = new System.Drawing.Point(15, 89);
            this.cbinterior.Name = "cbinterior";
            this.cbinterior.Size = new System.Drawing.Size(178, 24);
            this.cbinterior.TabIndex = 13;
            this.cbinterior.Text = "LIMPIEZA INTERIOR";
            this.cbinterior.UseVisualStyleBackColor = true;
            this.cbinterior.CheckedChanged += new System.EventHandler(this.cbinterior_CheckedChanged);
            // 
            // cbpulido
            // 
            this.cbpulido.AutoSize = true;
            this.cbpulido.Location = new System.Drawing.Point(15, 54);
            this.cbpulido.Name = "cbpulido";
            this.cbpulido.Size = new System.Drawing.Size(86, 24);
            this.cbpulido.TabIndex = 12;
            this.cbpulido.Text = "PULIDO";
            this.cbpulido.UseVisualStyleBackColor = true;
            this.cbpulido.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtpulido
            // 
            this.txtpulido.Enabled = false;
            this.txtpulido.Location = new System.Drawing.Point(199, 52);
            this.txtpulido.Name = "txtpulido";
            this.txtpulido.Size = new System.Drawing.Size(153, 32);
            this.txtpulido.TabIndex = 8;
            this.txtpulido.TextChanged += new System.EventHandler(this.txtpulido_TextChanged);
            this.txtpulido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpulido_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbltotal);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.lblparcial);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtdescuento);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(685, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 167);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "COSTO TOTAL";
            this.groupBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox4_Paint);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(174, 117);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(25, 25);
            this.lbltotal.TabIndex = 20;
            this.lbltotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "TOTAL";
            // 
            // lblparcial
            // 
            this.lblparcial.AutoSize = true;
            this.lblparcial.Location = new System.Drawing.Point(174, 41);
            this.lblparcial.Name = "lblparcial";
            this.lblparcial.Size = new System.Drawing.Size(19, 20);
            this.lblparcial.TabIndex = 18;
            this.lblparcial.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "DESCUENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "COSTO PARCIAL";
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(173, 73);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(109, 32);
            this.txtdescuento.TabIndex = 15;
            this.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdescuento.TextChanged += new System.EventHandler(this.txtdescuento_TextChanged);
            this.txtdescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescuento_KeyPress);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = global::softchape.Properties.Resources.salir1;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(900, 323);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(90, 90);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackgroundImage = global::softchape.Properties.Resources.guardar;
            this.btnfinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfinalizar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.Location = new System.Drawing.Point(805, 323);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(90, 90);
            this.btnfinalizar.TabIndex = 17;
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtobservaciones);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(519, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(471, 132);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OBSERVACIONES";
            this.groupBox5.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox5_Paint);
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(12, 26);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(449, 95);
            this.txtobservaciones.TabIndex = 0;
            // 
            // frmlimpieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 420);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmlimpieza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmlimpieza_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.ComboBox cmbvehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbnagregar;
        private System.Windows.Forms.LinkLabel lklagregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtfumigado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbfumigado;
        private System.Windows.Forms.CheckBox cbengrasado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtpulido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtenserado;
        private System.Windows.Forms.TextBox txtlimpinte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbencerado;
        private System.Windows.Forms.CheckBox cbinterior;
        private System.Windows.Forms.CheckBox cbpulido;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblparcial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.TextBox txtengrasado;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtobservaciones;

    }
}