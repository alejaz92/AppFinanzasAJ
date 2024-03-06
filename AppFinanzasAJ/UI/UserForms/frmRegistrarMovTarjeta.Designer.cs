namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmRegistrarMovTarjeta
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
            this.cboClaseMov = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTarjeta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radRecurrente = new System.Windows.Forms.RadioButton();
            this.radUnico = new System.Windows.Forms.RadioButton();
            this.cboCuotas = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMes1 = new System.Windows.Forms.NumericUpDown();
            this.cboAnio1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.grpUltima = new System.Windows.Forms.GroupBox();
            this.cboAnio2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMes2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuotas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAnio1)).BeginInit();
            this.grpUltima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboAnio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMes2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpUltima);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboCuotas);
            this.groupBox1.Controls.Add(this.cboClaseMov);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboTarjeta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDetalle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboMoneda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(489, 476);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Movimiento";
            // 
            // cboClaseMov
            // 
            this.cboClaseMov.FormattingEnabled = true;
            this.cboClaseMov.Location = new System.Drawing.Point(141, 185);
            this.cboClaseMov.Margin = new System.Windows.Forms.Padding(4);
            this.cboClaseMov.Name = "cboClaseMov";
            this.cboClaseMov.Size = new System.Drawing.Size(323, 24);
            this.cboClaseMov.TabIndex = 18;
            this.cboClaseMov.SelectedIndexChanged += new System.EventHandler(this.cboClaseMov_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Clase Movimiento";
            // 
            // cboTarjeta
            // 
            this.cboTarjeta.FormattingEnabled = true;
            this.cboTarjeta.Location = new System.Drawing.Point(141, 153);
            this.cboTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.cboTarjeta.Name = "cboTarjeta";
            this.cboTarjeta.Size = new System.Drawing.Size(323, 24);
            this.cboTarjeta.TabIndex = 16;
            this.cboTarjeta.SelectedIndexChanged += new System.EventHandler(this.cboTarjeta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tarjeta";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(140, 216);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(321, 22);
            this.txtDetalle.TabIndex = 9;
            this.txtDetalle.TextChanged += new System.EventHandler(this.txtDetalle_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Detalle";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(140, 255);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(321, 22);
            this.txtMonto.TabIndex = 10;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto Total";
            // 
            // cboMoneda
            // 
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(140, 121);
            this.cboMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(323, 24);
            this.cboMoneda.TabIndex = 4;
            this.cboMoneda.SelectedIndexChanged += new System.EventHandler(this.cboMoneda_SelectedIndexChanged);
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
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Mov.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radRecurrente);
            this.groupBox2.Controls.Add(this.radUnico);
            this.groupBox2.Location = new System.Drawing.Point(24, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(440, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Movimiento";
            // 
            // radRecurrente
            // 
            this.radRecurrente.AutoSize = true;
            this.radRecurrente.Location = new System.Drawing.Point(253, 23);
            this.radRecurrente.Margin = new System.Windows.Forms.Padding(4);
            this.radRecurrente.Name = "radRecurrente";
            this.radRecurrente.Size = new System.Drawing.Size(94, 20);
            this.radRecurrente.TabIndex = 2;
            this.radRecurrente.TabStop = true;
            this.radRecurrente.Text = "Recurrente";
            this.radRecurrente.UseVisualStyleBackColor = true;
            this.radRecurrente.CheckedChanged += new System.EventHandler(this.radRecurrente_CheckedChanged);
            // 
            // radUnico
            // 
            this.radUnico.AutoSize = true;
            this.radUnico.Location = new System.Drawing.Point(83, 23);
            this.radUnico.Margin = new System.Windows.Forms.Padding(4);
            this.radUnico.Name = "radUnico";
            this.radUnico.Size = new System.Drawing.Size(63, 20);
            this.radUnico.TabIndex = 0;
            this.radUnico.TabStop = true;
            this.radUnico.Text = "Unico";
            this.radUnico.UseVisualStyleBackColor = true;
            this.radUnico.CheckedChanged += new System.EventHandler(this.radUnico_CheckedChanged);
            // 
            // cboCuotas
            // 
            this.cboCuotas.Location = new System.Drawing.Point(141, 296);
            this.cboCuotas.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cboCuotas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(320, 22);
            this.cboCuotas.TabIndex = 20;
            this.cboCuotas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cboCuotas.ValueChanged += new System.EventHandler(this.cboCuotas_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cuotas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboAnio1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cboMes1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(24, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 58);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Primer Cuota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mes";
            // 
            // cboMes1
            // 
            this.cboMes1.Location = new System.Drawing.Point(59, 27);
            this.cboMes1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.cboMes1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cboMes1.Name = "cboMes1";
            this.cboMes1.Size = new System.Drawing.Size(115, 22);
            this.cboMes1.TabIndex = 23;
            this.cboMes1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cboMes1.ValueChanged += new System.EventHandler(this.cboMes1_ValueChanged);
            // 
            // cboAnio1
            // 
            this.cboAnio1.Location = new System.Drawing.Point(302, 27);
            this.cboAnio1.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.cboAnio1.Minimum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.cboAnio1.Name = "cboAnio1";
            this.cboAnio1.Size = new System.Drawing.Size(115, 22);
            this.cboAnio1.TabIndex = 24;
            this.cboAnio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cboAnio1.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.cboAnio1.ValueChanged += new System.EventHandler(this.cboAnio1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Año";
            // 
            // grpUltima
            // 
            this.grpUltima.Controls.Add(this.cboAnio2);
            this.grpUltima.Controls.Add(this.label10);
            this.grpUltima.Controls.Add(this.cboMes2);
            this.grpUltima.Controls.Add(this.label11);
            this.grpUltima.Location = new System.Drawing.Point(24, 400);
            this.grpUltima.Name = "grpUltima";
            this.grpUltima.Size = new System.Drawing.Size(437, 58);
            this.grpUltima.TabIndex = 26;
            this.grpUltima.TabStop = false;
            this.grpUltima.Text = "Ultima Cuota";
            // 
            // cboAnio2
            // 
            this.cboAnio2.Location = new System.Drawing.Point(302, 27);
            this.cboAnio2.Maximum = new decimal(new int[] {
            2300,
            0,
            0,
            0});
            this.cboAnio2.Name = "cboAnio2";
            this.cboAnio2.Size = new System.Drawing.Size(115, 22);
            this.cboAnio2.TabIndex = 24;
            this.cboAnio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cboAnio2.Value = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Año";
            // 
            // cboMes2
            // 
            this.cboMes2.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cboMes2.Location = new System.Drawing.Point(59, 27);
            this.cboMes2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.cboMes2.Name = "cboMes2";
            this.cboMes2.Size = new System.Drawing.Size(115, 22);
            this.cboMes2.TabIndex = 23;
            this.cboMes2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Mes";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Enabled = false;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(159, 512);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(173, 59);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(340, 512);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(173, 59);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmRegistrarMovTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 582);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarMovTarjeta";
            this.Text = "Registrar movimiento de tarjeta";
            this.Load += new System.EventHandler(this.frmRegistrarMovTarjeta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboCuotas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAnio1)).EndInit();
            this.grpUltima.ResumeLayout(false);
            this.grpUltima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboAnio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMes2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker cboFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radRecurrente;
        private System.Windows.Forms.RadioButton radUnico;
        private System.Windows.Forms.ComboBox cboTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboClaseMov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cboCuotas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown cboAnio1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown cboMes1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpUltima;
        private System.Windows.Forms.NumericUpDown cboAnio2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown cboMes2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCerrar;
    }
}