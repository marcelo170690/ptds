namespace softchape
{
    partial class Diagnostico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.movilComboBox = new System.Windows.Forms.ComboBox();
            this.addMovilButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.detailTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIAGNOSTICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CI CLIENTE";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteTextBox.Location = new System.Drawing.Point(12, 96);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(242, 26);
            this.clienteTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "MOVILIDAD";
            // 
            // movilComboBox
            // 
            this.movilComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movilComboBox.FormattingEnabled = true;
            this.movilComboBox.Location = new System.Drawing.Point(260, 96);
            this.movilComboBox.Name = "movilComboBox";
            this.movilComboBox.Size = new System.Drawing.Size(251, 28);
            this.movilComboBox.TabIndex = 4;
            // 
            // addMovilButton
            // 
            this.addMovilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovilButton.Location = new System.Drawing.Point(213, 139);
            this.addMovilButton.Name = "addMovilButton";
            this.addMovilButton.Size = new System.Drawing.Size(298, 33);
            this.addMovilButton.TabIndex = 5;
            this.addMovilButton.Text = "AGREGAR NUEVA MOVILIDAD";
            this.addMovilButton.UseVisualStyleBackColor = true;
            this.addMovilButton.Click += new System.EventHandler(this.addMovilButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.detailTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(17, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 177);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "DETALLE";
            // 
            // detailTextBox
            // 
            this.detailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailTextBox.Location = new System.Drawing.Point(13, 32);
            this.detailTextBox.Multiline = true;
            this.detailTextBox.Name = "detailTextBox";
            this.detailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detailTextBox.Size = new System.Drawing.Size(464, 129);
            this.detailTextBox.TabIndex = 8;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(12, 427);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(125, 33);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "ACEPTAR";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(386, 427);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 33);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "CANCELAR";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 472);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addMovilButton);
            this.Controls.Add(this.movilComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Diagnostico";
            this.Text = "Diagnostico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox movilComboBox;
        private System.Windows.Forms.Button addMovilButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox detailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}