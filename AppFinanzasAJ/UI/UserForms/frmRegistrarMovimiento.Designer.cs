namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmRegistrarMovimiento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboClaseEgreso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCtaEgreso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboClaseIngreso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCtaIngreso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radIntercambio = new System.Windows.Forms.RadioButton();
            this.radEgreso = new System.Windows.Forms.RadioButton();
            this.radIngreso = new System.Windows.Forms.RadioButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtDetalle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboMoneda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(18, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Movimiento";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboClaseEgreso);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cboCtaEgreso);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(9, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 74);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Egreso";
            // 
            // cboClaseEgreso
            // 
            this.cboClaseEgreso.Enabled = false;
            this.cboClaseEgreso.FormattingEnabled = true;
            this.cboClaseEgreso.Location = new System.Drawing.Point(96, 47);
            this.cboClaseEgreso.Name = "cboClaseEgreso";
            this.cboClaseEgreso.Size = new System.Drawing.Size(243, 21);
            this.cboClaseEgreso.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Clase Egreso";
            // 
            // cboCtaEgreso
            // 
            this.cboCtaEgreso.Enabled = false;
            this.cboCtaEgreso.FormattingEnabled = true;
            this.cboCtaEgreso.Location = new System.Drawing.Point(96, 16);
            this.cboCtaEgreso.Name = "cboCtaEgreso";
            this.cboCtaEgreso.Size = new System.Drawing.Size(243, 21);
            this.cboCtaEgreso.TabIndex = 7;
            this.cboCtaEgreso.SelectedIndexChanged += new System.EventHandler(this.cboCtaEgreso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cuenta Egreso";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(106, 272);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(242, 20);
            this.txtDetalle.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Detalle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboClaseIngreso);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboCtaIngreso);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(9, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 66);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso";
            // 
            // cboClaseIngreso
            // 
            this.cboClaseIngreso.Enabled = false;
            this.cboClaseIngreso.FormattingEnabled = true;
            this.cboClaseIngreso.Location = new System.Drawing.Point(96, 39);
            this.cboClaseIngreso.Name = "cboClaseIngreso";
            this.cboClaseIngreso.Size = new System.Drawing.Size(243, 21);
            this.cboClaseIngreso.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Clase Ingreso";
            // 
            // cboCtaIngreso
            // 
            this.cboCtaIngreso.Enabled = false;
            this.cboCtaIngreso.FormattingEnabled = true;
            this.cboCtaIngreso.Location = new System.Drawing.Point(96, 12);
            this.cboCtaIngreso.Name = "cboCtaIngreso";
            this.cboCtaIngreso.Size = new System.Drawing.Size(243, 21);
            this.cboCtaIngreso.TabIndex = 5;
            this.cboCtaIngreso.SelectedIndexChanged += new System.EventHandler(this.cboCtaIngreso_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cuenta Ingreso";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(106, 308);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(242, 20);
            this.txtMonto.TabIndex = 10;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto";
            // 
            // cboMoneda
            // 
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(105, 98);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(243, 21);
            this.cboMoneda.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Moneda";
            // 
            // cboFecha
            // 
            this.cboFecha.Location = new System.Drawing.Point(105, 71);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(243, 20);
            this.cboFecha.TabIndex = 3;
            this.cboFecha.ValueChanged += new System.EventHandler(this.cboFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radIntercambio);
            this.groupBox2.Controls.Add(this.radEgreso);
            this.groupBox2.Controls.Add(this.radIngreso);
            this.groupBox2.Location = new System.Drawing.Point(18, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Movimiento";
            // 
            // radIntercambio
            // 
            this.radIntercambio.AutoSize = true;
            this.radIntercambio.Location = new System.Drawing.Point(244, 19);
            this.radIntercambio.Name = "radIntercambio";
            this.radIntercambio.Size = new System.Drawing.Size(80, 17);
            this.radIntercambio.TabIndex = 2;
            this.radIntercambio.TabStop = true;
            this.radIntercambio.Text = "Intercambio";
            this.radIntercambio.UseVisualStyleBackColor = true;
            this.radIntercambio.CheckedChanged += new System.EventHandler(this.radIntercambio_CheckedChanged);
            // 
            // radEgreso
            // 
            this.radEgreso.AutoSize = true;
            this.radEgreso.Location = new System.Drawing.Point(142, 19);
            this.radEgreso.Name = "radEgreso";
            this.radEgreso.Size = new System.Drawing.Size(58, 17);
            this.radEgreso.TabIndex = 1;
            this.radEgreso.TabStop = true;
            this.radEgreso.Text = "Egreso";
            this.radEgreso.UseVisualStyleBackColor = true;
            this.radEgreso.CheckedChanged += new System.EventHandler(this.radEgreso_CheckedChanged);
            // 
            // radIngreso
            // 
            this.radIngreso.AutoSize = true;
            this.radIngreso.Location = new System.Drawing.Point(6, 19);
            this.radIngreso.Name = "radIngreso";
            this.radIngreso.Size = new System.Drawing.Size(60, 17);
            this.radIngreso.TabIndex = 0;
            this.radIngreso.TabStop = true;
            this.radIngreso.Text = "Ingreso";
            this.radIngreso.UseVisualStyleBackColor = true;
            this.radIngreso.CheckedChanged += new System.EventHandler(this.radIngreso_CheckedChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(255, 378);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(130, 48);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Enabled = false;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(119, 378);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(130, 48);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // frmRegistrarMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 438);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarMovimiento";
            this.Text = "Registrar Movimiento";
            this.Load += new System.EventHandler(this.frmRegistrarMovimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker cboFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radEgreso;
        private System.Windows.Forms.RadioButton radIngreso;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCtaEgreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCtaIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radIntercambio;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboClaseEgreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboClaseIngreso;
        private System.Windows.Forms.Label label6;
    }
}