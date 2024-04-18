namespace AppFinanzasAJ
{
    partial class FrmIndex
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndex));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCuentasActivos = new System.Windows.Forms.Button();
            this.btnTarjetas = new System.Windows.Forms.Button();
            this.btnClaseMovimiento = new System.Windows.Forms.Button();
            this.btnActivos = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnRegMovimiento = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReintegros = new System.Windows.Forms.Button();
            this.btnInversiones = new System.Windows.Forms.Button();
            this.btnMovTarjeta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgUltMovs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPBI = new System.Windows.Forms.Button();
            this.btnSaldos = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUltMovs)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCuentasActivos);
            this.groupBox1.Controls.Add(this.btnTarjetas);
            this.groupBox1.Controls.Add(this.btnClaseMovimiento);
            this.groupBox1.Controls.Add(this.btnActivos);
            this.groupBox1.Controls.Add(this.btnCuentas);
            this.groupBox1.Location = new System.Drawing.Point(11, 347);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(244, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos Clave";
            // 
            // btnCuentasActivos
            // 
            this.btnCuentasActivos.Location = new System.Drawing.Point(8, 96);
            this.btnCuentasActivos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCuentasActivos.Name = "btnCuentasActivos";
            this.btnCuentasActivos.Size = new System.Drawing.Size(228, 28);
            this.btnCuentasActivos.TabIndex = 4;
            this.btnCuentasActivos.Text = "Cuentas - Activos";
            this.btnCuentasActivos.UseVisualStyleBackColor = true;
            this.btnCuentasActivos.Click += new System.EventHandler(this.btnCuentasActivos_Click);
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.Location = new System.Drawing.Point(9, 168);
            this.btnTarjetas.Margin = new System.Windows.Forms.Padding(4);
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(228, 28);
            this.btnTarjetas.TabIndex = 3;
            this.btnTarjetas.Text = "Tarjetas";
            this.btnTarjetas.UseVisualStyleBackColor = true;
            this.btnTarjetas.Click += new System.EventHandler(this.btnTarjetas_Click);
            // 
            // btnClaseMovimiento
            // 
            this.btnClaseMovimiento.Location = new System.Drawing.Point(9, 132);
            this.btnClaseMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnClaseMovimiento.Name = "btnClaseMovimiento";
            this.btnClaseMovimiento.Size = new System.Drawing.Size(228, 28);
            this.btnClaseMovimiento.TabIndex = 2;
            this.btnClaseMovimiento.Text = "Clases de Movimiento";
            this.btnClaseMovimiento.UseVisualStyleBackColor = true;
            this.btnClaseMovimiento.Click += new System.EventHandler(this.btnClaseMovimiento_Click);
            // 
            // btnActivos
            // 
            this.btnActivos.Location = new System.Drawing.Point(9, 60);
            this.btnActivos.Margin = new System.Windows.Forms.Padding(4);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Size = new System.Drawing.Size(228, 28);
            this.btnActivos.TabIndex = 1;
            this.btnActivos.Text = "Activos";
            this.btnActivos.UseVisualStyleBackColor = true;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.Location = new System.Drawing.Point(9, 25);
            this.btnCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(228, 28);
            this.btnCuentas.TabIndex = 0;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnRegMovimiento
            // 
            this.btnRegMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegMovimiento.Location = new System.Drawing.Point(10, 28);
            this.btnRegMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegMovimiento.Name = "btnRegMovimiento";
            this.btnRegMovimiento.Size = new System.Drawing.Size(213, 33);
            this.btnRegMovimiento.TabIndex = 1;
            this.btnRegMovimiento.Text = "Mov. Regular";
            this.btnRegMovimiento.UseVisualStyleBackColor = true;
            this.btnRegMovimiento.Click += new System.EventHandler(this.btnRegMovimiento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReintegros);
            this.groupBox2.Controls.Add(this.btnInversiones);
            this.groupBox2.Controls.Add(this.btnMovTarjeta);
            this.groupBox2.Controls.Add(this.btnRegMovimiento);
            this.groupBox2.Location = new System.Drawing.Point(11, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(237, 195);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimientos";
            // 
            // btnReintegros
            // 
            this.btnReintegros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReintegros.Location = new System.Drawing.Point(8, 110);
            this.btnReintegros.Margin = new System.Windows.Forms.Padding(4);
            this.btnReintegros.Name = "btnReintegros";
            this.btnReintegros.Size = new System.Drawing.Size(213, 33);
            this.btnReintegros.TabIndex = 4;
            this.btnReintegros.Text = "Reintegros";
            this.btnReintegros.UseVisualStyleBackColor = true;
            this.btnReintegros.Click += new System.EventHandler(this.btnReintegros_Click);
            // 
            // btnInversiones
            // 
            this.btnInversiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInversiones.Location = new System.Drawing.Point(8, 151);
            this.btnInversiones.Margin = new System.Windows.Forms.Padding(4);
            this.btnInversiones.Name = "btnInversiones";
            this.btnInversiones.Size = new System.Drawing.Size(213, 33);
            this.btnInversiones.TabIndex = 3;
            this.btnInversiones.Text = "Inversiones";
            this.btnInversiones.UseVisualStyleBackColor = true;
            this.btnInversiones.Click += new System.EventHandler(this.btnInversiones_Click);
            // 
            // btnMovTarjeta
            // 
            this.btnMovTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMovTarjeta.Location = new System.Drawing.Point(10, 69);
            this.btnMovTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovTarjeta.Name = "btnMovTarjeta";
            this.btnMovTarjeta.Size = new System.Drawing.Size(213, 33);
            this.btnMovTarjeta.TabIndex = 2;
            this.btnMovTarjeta.Text = "Mov. Tarjeta";
            this.btnMovTarjeta.UseVisualStyleBackColor = true;
            this.btnMovTarjeta.Click += new System.EventHandler(this.btnMovTarjeta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(20, 561);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(213, 33);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgUltMovs
            // 
            this.dgUltMovs.AllowUserToAddRows = false;
            this.dgUltMovs.AllowUserToDeleteRows = false;
            this.dgUltMovs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUltMovs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.tipoMov,
            this.claseMov,
            this.detalle,
            this.cuenta,
            this.moneda,
            this.monto,
            this.idMovimiento});
            this.dgUltMovs.Location = new System.Drawing.Point(263, 35);
            this.dgUltMovs.MultiSelect = false;
            this.dgUltMovs.Name = "dgUltMovs";
            this.dgUltMovs.ReadOnly = true;
            this.dgUltMovs.RowHeadersVisible = false;
            this.dgUltMovs.RowHeadersWidth = 51;
            this.dgUltMovs.RowTemplate.Height = 24;
            this.dgUltMovs.RowTemplate.ReadOnly = true;
            this.dgUltMovs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgUltMovs.ShowCellErrors = false;
            this.dgUltMovs.ShowCellToolTips = false;
            this.dgUltMovs.ShowEditingIcon = false;
            this.dgUltMovs.ShowRowErrors = false;
            this.dgUltMovs.Size = new System.Drawing.Size(1105, 559);
            this.dgUltMovs.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ultimos Movimientos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPBI);
            this.groupBox3.Controls.Add(this.btnSaldos);
            this.groupBox3.Location = new System.Drawing.Point(11, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 108);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estadisticas";
            // 
            // btnPBI
            // 
            this.btnPBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPBI.Location = new System.Drawing.Point(9, 63);
            this.btnPBI.Margin = new System.Windows.Forms.Padding(4);
            this.btnPBI.Name = "btnPBI";
            this.btnPBI.Size = new System.Drawing.Size(213, 33);
            this.btnPBI.TabIndex = 4;
            this.btnPBI.Text = "Tablero PBI";
            this.btnPBI.UseVisualStyleBackColor = true;
            this.btnPBI.Click += new System.EventHandler(this.btnPBI_Click);
            // 
            // btnSaldos
            // 
            this.btnSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaldos.Location = new System.Drawing.Point(9, 22);
            this.btnSaldos.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaldos.Name = "btnSaldos";
            this.btnSaldos.Size = new System.Drawing.Size(213, 33);
            this.btnSaldos.TabIndex = 3;
            this.btnSaldos.Text = "Saldos";
            this.btnSaldos.UseVisualStyleBackColor = true;
            this.btnSaldos.Click += new System.EventHandler(this.btnSaldos_Click);
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 70;
            // 
            // tipoMov
            // 
            this.tipoMov.HeaderText = "Tipo Mov.";
            this.tipoMov.MinimumWidth = 6;
            this.tipoMov.Name = "tipoMov";
            this.tipoMov.ReadOnly = true;
            this.tipoMov.Width = 65;
            // 
            // claseMov
            // 
            this.claseMov.HeaderText = "Clase Mov.";
            this.claseMov.MinimumWidth = 6;
            this.claseMov.Name = "claseMov";
            this.claseMov.ReadOnly = true;
            this.claseMov.Width = 150;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalle";
            this.detalle.MinimumWidth = 6;
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 230;
            // 
            // cuenta
            // 
            this.cuenta.HeaderText = "Cuenta";
            this.cuenta.MinimumWidth = 6;
            this.cuenta.Name = "cuenta";
            this.cuenta.ReadOnly = true;
            this.cuenta.Width = 125;
            // 
            // moneda
            // 
            this.moneda.HeaderText = "Moneda";
            this.moneda.MinimumWidth = 6;
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            this.moneda.Width = 90;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 75;
            // 
            // idMovimiento
            // 
            this.idMovimiento.HeaderText = "idMovimiento";
            this.idMovimiento.MinimumWidth = 6;
            this.idMovimiento.Name = "idMovimiento";
            this.idMovimiento.ReadOnly = true;
            this.idMovimiento.Visible = false;
            this.idMovimiento.Width = 125;
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1380, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUltMovs);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIndex";
            this.Text = "App Finanzas Personales AJ";
            this.Activated += new System.EventHandler(this.FrmIndex_Activated);
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUltMovs)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnActivos;
        private System.Windows.Forms.Button btnClaseMovimiento;
        private System.Windows.Forms.Button btnRegMovimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTarjetas;
        private System.Windows.Forms.Button btnMovTarjeta;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgUltMovs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaldos;
        private System.Windows.Forms.Button btnInversiones;
        private System.Windows.Forms.Button btnCuentasActivos;
        private System.Windows.Forms.Button btnPBI;
        private System.Windows.Forms.Button btnReintegros;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn claseMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovimiento;
    }
}

