namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmIntMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntMoneda));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cboFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCtaEgreso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadEgreso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboActivoEgreso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboActivoIngreso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadIngreso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCtaIngreso = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cboFecha);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1048, 73);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "GestionMovimiento";
            // 
            // cboFecha
            // 
            this.cboFecha.Location = new System.Drawing.Point(134, 35);
            this.cboFecha.Margin = new System.Windows.Forms.Padding(4);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(323, 22);
            this.cboFecha.TabIndex = 3;
            this.cboFecha.ValueChanged += new System.EventHandler(this.cboFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(706, 258);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(173, 59);
            this.btnInsertar.TabIndex = 25;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(887, 258);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(173, 59);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCtaEgreso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCantidadEgreso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboActivoEgreso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(489, 147);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Egreso";
            // 
            // cboCtaEgreso
            // 
            this.cboCtaEgreso.FormattingEnabled = true;
            this.cboCtaEgreso.Location = new System.Drawing.Point(144, 66);
            this.cboCtaEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboCtaEgreso.Name = "cboCtaEgreso";
            this.cboCtaEgreso.Size = new System.Drawing.Size(323, 24);
            this.cboCtaEgreso.TabIndex = 7;
            this.cboCtaEgreso.SelectedIndexChanged += new System.EventHandler(this.cboCtaEgreso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cuenta";
            // 
            // txtCantidadEgreso
            // 
            this.txtCantidadEgreso.Location = new System.Drawing.Point(144, 98);
            this.txtCantidadEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadEgreso.Name = "txtCantidadEgreso";
            this.txtCantidadEgreso.Size = new System.Drawing.Size(323, 22);
            this.txtCantidadEgreso.TabIndex = 10;
            this.txtCantidadEgreso.TextChanged += new System.EventHandler(this.txtCantidadEgreso_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto";
            // 
            // cboActivoEgreso
            // 
            this.cboActivoEgreso.FormattingEnabled = true;
            this.cboActivoEgreso.Location = new System.Drawing.Point(144, 34);
            this.cboActivoEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboActivoEgreso.Name = "cboActivoEgreso";
            this.cboActivoEgreso.Size = new System.Drawing.Size(323, 24);
            this.cboActivoEgreso.TabIndex = 4;
            this.cboActivoEgreso.SelectedIndexChanged += new System.EventHandler(this.cboActivoEgreso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Activo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Activo";
            // 
            // cboActivoIngreso
            // 
            this.cboActivoIngreso.FormattingEnabled = true;
            this.cboActivoIngreso.Location = new System.Drawing.Point(144, 34);
            this.cboActivoIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboActivoIngreso.Name = "cboActivoIngreso";
            this.cboActivoIngreso.Size = new System.Drawing.Size(323, 24);
            this.cboActivoIngreso.TabIndex = 4;
            this.cboActivoIngreso.SelectedIndexChanged += new System.EventHandler(this.cboActivoIngreso_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Monto";
            // 
            // txtCantidadIngreso
            // 
            this.txtCantidadIngreso.Location = new System.Drawing.Point(144, 98);
            this.txtCantidadIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadIngreso.Name = "txtCantidadIngreso";
            this.txtCantidadIngreso.Size = new System.Drawing.Size(323, 22);
            this.txtCantidadIngreso.TabIndex = 10;
            this.txtCantidadIngreso.TextChanged += new System.EventHandler(this.txtCantidadIngreso_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cuenta";
            // 
            // cboCtaIngreso
            // 
            this.cboCtaIngreso.FormattingEnabled = true;
            this.cboCtaIngreso.Location = new System.Drawing.Point(144, 66);
            this.cboCtaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.cboCtaIngreso.Name = "cboCtaIngreso";
            this.cboCtaIngreso.Size = new System.Drawing.Size(323, 24);
            this.cboCtaIngreso.TabIndex = 7;
            this.cboCtaIngreso.SelectedIndexChanged += new System.EventHandler(this.cboCtaIngreso_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboCtaIngreso);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCantidadIngreso);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cboActivoIngreso);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(571, 92);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(489, 147);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingreso";
            // 
            // frmIntMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 332);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIntMoneda";
            this.Text = "Intercambio de Monedas";
            this.Load += new System.EventHandler(this.frmIntMoneda_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker cboFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCtaEgreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadEgreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboActivoEgreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboActivoIngreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidadIngreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCtaIngreso;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}