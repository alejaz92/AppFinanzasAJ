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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarMovimiento));
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
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(489, 427);
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
            this.groupBox4.Location = new System.Drawing.Point(12, 236);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(460, 91);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Egreso";
            // 
            // cboClaseEgreso
            // 
            this.cboClaseEgreso.Enabled = false;
            this.cboClaseEgreso.FormattingEnabled = true;
            this.cboClaseEgreso.Location = new System.Drawing.Point(128, 58);
            this.cboClaseEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboClaseEgreso.Name = "cboClaseEgreso";
            this.cboClaseEgreso.Size = new System.Drawing.Size(323, 24);
            this.cboClaseEgreso.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Clase Egreso";
            // 
            // cboCtaEgreso
            // 
            this.cboCtaEgreso.Enabled = false;
            this.cboCtaEgreso.FormattingEnabled = true;
            this.cboCtaEgreso.Location = new System.Drawing.Point(128, 20);
            this.cboCtaEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboCtaEgreso.Name = "cboCtaEgreso";
            this.cboCtaEgreso.Size = new System.Drawing.Size(323, 24);
            this.cboCtaEgreso.TabIndex = 7;
            this.cboCtaEgreso.SelectedIndexChanged += new System.EventHandler(this.cboCtaEgreso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cuenta Egreso";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(141, 335);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(321, 22);
            this.txtDetalle.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 345);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Detalle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboClaseIngreso);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboCtaIngreso);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 155);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(460, 81);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso";
            // 
            // cboClaseIngreso
            // 
            this.cboClaseIngreso.Enabled = false;
            this.cboClaseIngreso.FormattingEnabled = true;
            this.cboClaseIngreso.Location = new System.Drawing.Point(128, 48);
            this.cboClaseIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboClaseIngreso.Name = "cboClaseIngreso";
            this.cboClaseIngreso.Size = new System.Drawing.Size(323, 24);
            this.cboClaseIngreso.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Clase Ingreso";
            // 
            // cboCtaIngreso
            // 
            this.cboCtaIngreso.Enabled = false;
            this.cboCtaIngreso.FormattingEnabled = true;
            this.cboCtaIngreso.Location = new System.Drawing.Point(128, 15);
            this.cboCtaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboCtaIngreso.Name = "cboCtaIngreso";
            this.cboCtaIngreso.Size = new System.Drawing.Size(323, 24);
            this.cboCtaIngreso.TabIndex = 5;
            this.cboCtaIngreso.SelectedIndexChanged += new System.EventHandler(this.cboCtaIngreso_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cuenta Ingreso";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(141, 379);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(321, 22);
            this.txtMonto.TabIndex = 10;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto";
            // 
            // cboMoneda
            // 
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(140, 121);
            this.cboMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(323, 24);
            this.cboMoneda.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Moneda";
            // 
            // cboFecha
            // 
            this.cboFecha.Location = new System.Drawing.Point(140, 87);
            this.cboFecha.Margin = new System.Windows.Forms.Padding(4);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(323, 22);
            this.cboFecha.TabIndex = 3;
            this.cboFecha.ValueChanged += new System.EventHandler(this.cboFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radIntercambio);
            this.groupBox2.Controls.Add(this.radEgreso);
            this.groupBox2.Controls.Add(this.radIngreso);
            this.groupBox2.Location = new System.Drawing.Point(24, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(440, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Movimiento";
            // 
            // radIntercambio
            // 
            this.radIntercambio.AutoSize = true;
            this.radIntercambio.Location = new System.Drawing.Point(325, 23);
            this.radIntercambio.Margin = new System.Windows.Forms.Padding(4);
            this.radIntercambio.Name = "radIntercambio";
            this.radIntercambio.Size = new System.Drawing.Size(98, 20);
            this.radIntercambio.TabIndex = 2;
            this.radIntercambio.TabStop = true;
            this.radIntercambio.Text = "Intercambio";
            this.radIntercambio.UseVisualStyleBackColor = true;
            this.radIntercambio.CheckedChanged += new System.EventHandler(this.radIntercambio_CheckedChanged);
            // 
            // radEgreso
            // 
            this.radEgreso.AutoSize = true;
            this.radEgreso.Location = new System.Drawing.Point(189, 23);
            this.radEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.radEgreso.Name = "radEgreso";
            this.radEgreso.Size = new System.Drawing.Size(72, 20);
            this.radEgreso.TabIndex = 1;
            this.radEgreso.TabStop = true;
            this.radEgreso.Text = "Egreso";
            this.radEgreso.UseVisualStyleBackColor = true;
            this.radEgreso.CheckedChanged += new System.EventHandler(this.radEgreso_CheckedChanged);
            // 
            // radIngreso
            // 
            this.radIngreso.AutoSize = true;
            this.radIngreso.Location = new System.Drawing.Point(8, 23);
            this.radIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.radIngreso.Name = "radIngreso";
            this.radIngreso.Size = new System.Drawing.Size(73, 20);
            this.radIngreso.TabIndex = 0;
            this.radIngreso.TabStop = true;
            this.radIngreso.Text = "Ingreso";
            this.radIngreso.UseVisualStyleBackColor = true;
            this.radIngreso.CheckedChanged += new System.EventHandler(this.radIngreso_CheckedChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(340, 465);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(173, 59);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Enabled = false;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(159, 465);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(173, 59);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // frmRegistrarMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 539);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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