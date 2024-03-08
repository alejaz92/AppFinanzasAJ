namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmPagoTarjeta
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cboTarjeta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDolar = new System.Windows.Forms.RadioButton();
            this.radPesos = new System.Windows.Forms.RadioButton();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGtosTarj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cboMesPago = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(376, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(401, 428);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cboTarjeta
            // 
            this.cboTarjeta.FormattingEnabled = true;
            this.cboTarjeta.Location = new System.Drawing.Point(98, 41);
            this.cboTarjeta.Name = "cboTarjeta";
            this.cboTarjeta.Size = new System.Drawing.Size(247, 24);
            this.cboTarjeta.TabIndex = 1;
            this.cboTarjeta.SelectedIndexChanged += new System.EventHandler(this.cboTarjeta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarjeta";
            // 
            // cboFecha
            // 
            this.cboFecha.Location = new System.Drawing.Point(98, 102);
            this.cboFecha.Margin = new System.Windows.Forms.Padding(4);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(247, 22);
            this.cboFecha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDolar);
            this.groupBox1.Controls.Add(this.radPesos);
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moneda Pago";
            // 
            // radDolar
            // 
            this.radDolar.AutoSize = true;
            this.radDolar.Location = new System.Drawing.Point(175, 40);
            this.radDolar.Name = "radDolar";
            this.radDolar.Size = new System.Drawing.Size(113, 20);
            this.radDolar.TabIndex = 1;
            this.radDolar.TabStop = true;
            this.radDolar.Text = "Pesos + Dolar";
            this.radDolar.UseVisualStyleBackColor = true;
            // 
            // radPesos
            // 
            this.radPesos.AutoSize = true;
            this.radPesos.Location = new System.Drawing.Point(23, 40);
            this.radPesos.Name = "radPesos";
            this.radPesos.Size = new System.Drawing.Size(67, 20);
            this.radPesos.TabIndex = 0;
            this.radPesos.TabStop = true;
            this.radPesos.Text = "Pesos";
            this.radPesos.UseVisualStyleBackColor = true;
            // 
            // cboCuenta
            // 
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(98, 140);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(247, 24);
            this.cboCuenta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Erogaciones";
            // 
            // txtPesos
            // 
            this.txtPesos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtPesos.Location = new System.Drawing.Point(98, 292);
            this.txtPesos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(247, 22);
            this.txtPesos.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pago Pesos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDolar
            // 
            this.txtDolar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtDolar.Location = new System.Drawing.Point(98, 333);
            this.txtDolar.Margin = new System.Windows.Forms.Padding(4);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(247, 22);
            this.txtDolar.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 339);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pago Dolar";
            // 
            // txtGtosTarj
            // 
            this.txtGtosTarj.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtGtosTarj.Enabled = false;
            this.txtGtosTarj.Location = new System.Drawing.Point(98, 376);
            this.txtGtosTarj.Margin = new System.Windows.Forms.Padding(4);
            this.txtGtosTarj.Name = "txtGtosTarj";
            this.txtGtosTarj.Size = new System.Drawing.Size(247, 22);
            this.txtGtosTarj.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gtos. Tarjeta";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Enabled = false;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(18, 446);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(146, 43);
            this.btnInsertar.TabIndex = 16;
            this.btnInsertar.Text = "Registrar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(199, 446);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(146, 43);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cboMesPago
            // 
            this.cboMesPago.Location = new System.Drawing.Point(98, 72);
            this.cboMesPago.Margin = new System.Windows.Forms.Padding(4);
            this.cboMesPago.Name = "cboMesPago";
            this.cboMesPago.Size = new System.Drawing.Size(247, 22);
            this.cboMesPago.TabIndex = 19;
            this.cboMesPago.ValueChanged += new System.EventHandler(this.cboMesPago_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mes Pago";
            // 
            // frmPagoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.cboMesPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtGtosTarj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCuenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTarjeta);
            this.Controls.Add(this.listView1);
            this.Name = "frmPagoTarjeta";
            this.Text = "Registrar Pago de Tarjeta";
            this.Load += new System.EventHandler(this.frmPagoTarjeta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cboTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker cboFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDolar;
        private System.Windows.Forms.RadioButton radPesos;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGtosTarj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker cboMesPago;
        private System.Windows.Forms.Label label8;
    }
}