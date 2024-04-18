namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmReintegro
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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCtaOrig = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoTot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoReint = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCtaReint = new System.Windows.Forms.ComboBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(100, 33);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(219, 22);
            this.txtFecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // txtClase
            // 
            this.txtClase.Enabled = false;
            this.txtClase.Location = new System.Drawing.Point(100, 71);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(219, 22);
            this.txtClase.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clase Mov.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detalle";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Enabled = false;
            this.txtDetalle.Location = new System.Drawing.Point(100, 111);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(219, 22);
            this.txtDetalle.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuenta Orig.";
            // 
            // txtCtaOrig
            // 
            this.txtCtaOrig.Enabled = false;
            this.txtCtaOrig.Location = new System.Drawing.Point(100, 150);
            this.txtCtaOrig.Name = "txtCtaOrig";
            this.txtCtaOrig.Size = new System.Drawing.Size(219, 22);
            this.txtCtaOrig.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Monto";
            // 
            // txtMontoTot
            // 
            this.txtMontoTot.Enabled = false;
            this.txtMontoTot.Location = new System.Drawing.Point(100, 192);
            this.txtMontoTot.Name = "txtMontoTot";
            this.txtMontoTot.Size = new System.Drawing.Size(219, 22);
            this.txtMontoTot.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Monto Reint.";
            // 
            // txtMontoReint
            // 
            this.txtMontoReint.Location = new System.Drawing.Point(100, 302);
            this.txtMontoReint.Name = "txtMontoReint";
            this.txtMontoReint.Size = new System.Drawing.Size(219, 22);
            this.txtMontoReint.TabIndex = 10;
            this.txtMontoReint.TextChanged += new System.EventHandler(this.txtMontoReint_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cuenta Reint";
            // 
            // cboCtaReint
            // 
            this.cboCtaReint.FormattingEnabled = true;
            this.cboCtaReint.Location = new System.Drawing.Point(100, 266);
            this.cboCtaReint.Name = "cboCtaReint";
            this.cboCtaReint.Size = new System.Drawing.Size(219, 24);
            this.cboCtaReint.TabIndex = 14;
            this.cboCtaReint.SelectedIndexChanged += new System.EventHandler(this.cboCtaReint_SelectedIndexChanged);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Enabled = false;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(73, 358);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(119, 28);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(200, 358);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(119, 28);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmReintegro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 400);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cboCtaReint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontoReint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoTot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCtaOrig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Name = "frmReintegro";
            this.Text = "Gestion de Reintegro";
            this.Load += new System.EventHandler(this.frmReintegro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCtaOrig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontoTot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoReint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCtaReint;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCerrar;
    }
}