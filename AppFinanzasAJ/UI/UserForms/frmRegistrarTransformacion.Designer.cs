namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmRegistrarTransformacion
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboCtaEgreso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboCtaIngreso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoEgreso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radEgreso = new System.Windows.Forms.RadioButton();
            this.radIngreso = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radBolsa = new System.Windows.Forms.RadioButton();
            this.radCrypto = new System.Windows.Forms.RadioButton();
            this.cboActivoEgreso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboActivoIngreso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Enabled = false;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(697, 315);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(173, 59);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(878, 315);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(173, 59);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cboFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1021, 284);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Movimiento";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboActivoEgreso);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cboCtaEgreso);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtMontoEgreso);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(23, 121);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(460, 130);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Egreso";
            // 
            // cboCtaEgreso
            // 
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboActivoIngreso);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cboCtaIngreso);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(553, 131);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(460, 120);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso";
            // 
            // cboCtaIngreso
            // 
            this.cboCtaIngreso.FormattingEnabled = true;
            this.cboCtaIngreso.Location = new System.Drawing.Point(128, 15);
            this.cboCtaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboCtaIngreso.Name = "cboCtaIngreso";
            this.cboCtaIngreso.Size = new System.Drawing.Size(323, 24);
            this.cboCtaIngreso.TabIndex = 5;
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
            // txtMontoEgreso
            // 
            this.txtMontoEgreso.Location = new System.Drawing.Point(126, 100);
            this.txtMontoEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoEgreso.Name = "txtMontoEgreso";
            this.txtMontoEgreso.Size = new System.Drawing.Size(321, 22);
            this.txtMontoEgreso.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto Egreso";
            // 
            // cboFecha
            // 
            this.cboFecha.Location = new System.Drawing.Point(151, 88);
            this.cboFecha.Margin = new System.Windows.Forms.Padding(4);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(323, 22);
            this.cboFecha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radEgreso);
            this.groupBox2.Controls.Add(this.radIngreso);
            this.groupBox2.Location = new System.Drawing.Point(108, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(300, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Movimiento";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radBolsa);
            this.groupBox5.Controls.Add(this.radCrypto);
            this.groupBox5.Location = new System.Drawing.Point(625, 46);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(300, 57);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo Inversion";
            // 
            // radBolsa
            // 
            this.radBolsa.AutoSize = true;
            this.radBolsa.Location = new System.Drawing.Point(189, 23);
            this.radBolsa.Margin = new System.Windows.Forms.Padding(4);
            this.radBolsa.Name = "radBolsa";
            this.radBolsa.Size = new System.Drawing.Size(63, 20);
            this.radBolsa.TabIndex = 1;
            this.radBolsa.TabStop = true;
            this.radBolsa.Text = "Bolsa";
            this.radBolsa.UseVisualStyleBackColor = true;
            this.radBolsa.CheckedChanged += new System.EventHandler(this.radBolsa_CheckedChanged);
            // 
            // radCrypto
            // 
            this.radCrypto.AutoSize = true;
            this.radCrypto.Location = new System.Drawing.Point(8, 23);
            this.radCrypto.Margin = new System.Windows.Forms.Padding(4);
            this.radCrypto.Name = "radCrypto";
            this.radCrypto.Size = new System.Drawing.Size(67, 20);
            this.radCrypto.TabIndex = 0;
            this.radCrypto.TabStop = true;
            this.radCrypto.Text = "Crypto";
            this.radCrypto.UseVisualStyleBackColor = true;
            this.radCrypto.CheckedChanged += new System.EventHandler(this.radCrypto_CheckedChanged);
            // 
            // cboActivoEgreso
            // 
            this.cboActivoEgreso.FormattingEnabled = true;
            this.cboActivoEgreso.Location = new System.Drawing.Point(126, 58);
            this.cboActivoEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboActivoEgreso.Name = "cboActivoEgreso";
            this.cboActivoEgreso.Size = new System.Drawing.Size(323, 24);
            this.cboActivoEgreso.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Activo Egreso";
            // 
            // cboActivoIngreso
            // 
            this.cboActivoIngreso.FormattingEnabled = true;
            this.cboActivoIngreso.Location = new System.Drawing.Point(128, 48);
            this.cboActivoIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboActivoIngreso.Name = "cboActivoIngreso";
            this.cboActivoIngreso.Size = new System.Drawing.Size(323, 24);
            this.cboActivoIngreso.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Activo Ingreso";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 22);
            this.textBox1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Monto Ingreso";
            // 
            // frmRegistrarTransformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 399);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarTransformacion";
            this.Text = "frmRegistrarTransformacion";
            this.Load += new System.EventHandler(this.frmRegistrarTransformacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboCtaEgreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboCtaIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoEgreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker cboFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radEgreso;
        private System.Windows.Forms.RadioButton radIngreso;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radBolsa;
        private System.Windows.Forms.RadioButton radCrypto;
        private System.Windows.Forms.ComboBox cboActivoEgreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboActivoIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}