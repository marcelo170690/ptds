namespace softchape
{
    partial class Main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editClienteButton = new System.Windows.Forms.Button();
            this.signupClienteButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::softchape.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.editClienteButton);
            this.panel1.Controls.Add(this.signupClienteButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(451, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 100);
            this.panel1.TabIndex = 2;
            // 
            // editClienteButton
            // 
            this.editClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClienteButton.Location = new System.Drawing.Point(45, 59);
            this.editClienteButton.Name = "editClienteButton";
            this.editClienteButton.Size = new System.Drawing.Size(190, 36);
            this.editClienteButton.TabIndex = 5;
            this.editClienteButton.Text = "EDITAR CLIENTE";
            this.editClienteButton.UseVisualStyleBackColor = true;
            this.editClienteButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // signupClienteButton
            // 
            this.signupClienteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.signupClienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupClienteButton.ForeColor = System.Drawing.Color.White;
            this.signupClienteButton.Location = new System.Drawing.Point(45, 3);
            this.signupClienteButton.Name = "signupClienteButton";
            this.signupClienteButton.Size = new System.Drawing.Size(190, 36);
            this.signupClienteButton.TabIndex = 4;
            this.signupClienteButton.Text = "REGISTRAR CLIENTE";
            this.signupClienteButton.UseVisualStyleBackColor = false;
            this.signupClienteButton.Click += new System.EventHandler(this.editClienteButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::softchape.Properties.Resources.addUser;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 299);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "SERVICIOS AUTOMOTRICES";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(484, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "EDITAR CLIENTE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signupClienteButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editClienteButton;
        private System.Windows.Forms.Button button2;
    }
}