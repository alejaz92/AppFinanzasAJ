namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmGestTarjeta
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
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimaCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagoTarjeta = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRecurrente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.tarjeta,
            this.claseMov,
            this.detalle,
            this.cuotas,
            this.moneda,
            this.monto,
            this.PrimerCuota,
            this.ultimaCuota,
            this.montoCuota});
            this.dgLista.Location = new System.Drawing.Point(233, 23);
            this.dgLista.MultiSelect = false;
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.RowHeadersVisible = false;
            this.dgLista.RowHeadersWidth = 51;
            this.dgLista.RowTemplate.Height = 24;
            this.dgLista.RowTemplate.ReadOnly = true;
            this.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgLista.ShowCellErrors = false;
            this.dgLista.ShowCellToolTips = false;
            this.dgLista.ShowEditingIcon = false;
            this.dgLista.ShowRowErrors = false;
            this.dgLista.Size = new System.Drawing.Size(1400, 523);
            this.dgLista.TabIndex = 6;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 70;
            // 
            // tarjeta
            // 
            this.tarjeta.HeaderText = "Tarjeta";
            this.tarjeta.MinimumWidth = 6;
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.ReadOnly = true;
            this.tarjeta.Width = 90;
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
            this.detalle.Width = 200;
            // 
            // cuotas
            // 
            this.cuotas.HeaderText = "Cuotas";
            this.cuotas.MinimumWidth = 6;
            this.cuotas.Name = "cuotas";
            this.cuotas.ReadOnly = true;
            this.cuotas.Width = 80;
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
            this.monto.Width = 80;
            // 
            // PrimerCuota
            // 
            this.PrimerCuota.HeaderText = "Primer Cuota";
            this.PrimerCuota.MinimumWidth = 6;
            this.PrimerCuota.Name = "PrimerCuota";
            this.PrimerCuota.ReadOnly = true;
            this.PrimerCuota.Width = 80;
            // 
            // ultimaCuota
            // 
            this.ultimaCuota.HeaderText = "Ult. Cuota";
            this.ultimaCuota.MinimumWidth = 6;
            this.ultimaCuota.Name = "ultimaCuota";
            this.ultimaCuota.ReadOnly = true;
            this.ultimaCuota.Width = 80;
            // 
            // montoCuota
            // 
            this.montoCuota.HeaderText = "Monto Cuota";
            this.montoCuota.MinimumWidth = 6;
            this.montoCuota.Name = "montoCuota";
            this.montoCuota.ReadOnly = true;
            this.montoCuota.Width = 125;
            // 
            // btnPagoTarjeta
            // 
            this.btnPagoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPagoTarjeta.Location = new System.Drawing.Point(13, 64);
            this.btnPagoTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagoTarjeta.Name = "btnPagoTarjeta";
            this.btnPagoTarjeta.Size = new System.Drawing.Size(213, 33);
            this.btnPagoTarjeta.TabIndex = 7;
            this.btnPagoTarjeta.Text = "Pago Tarjeta";
            this.btnPagoTarjeta.UseVisualStyleBackColor = true;
            this.btnPagoTarjeta.Click += new System.EventHandler(this.btnPagoTarjeta_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNuevo.Location = new System.Drawing.Point(13, 23);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(213, 33);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCerrar.Location = new System.Drawing.Point(13, 513);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(213, 33);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRecurrente
            // 
            this.btnRecurrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecurrente.Location = new System.Drawing.Point(13, 105);
            this.btnRecurrente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecurrente.Name = "btnRecurrente";
            this.btnRecurrente.Size = new System.Drawing.Size(213, 33);
            this.btnRecurrente.TabIndex = 11;
            this.btnRecurrente.Text = "Editar Recurrente";
            this.btnRecurrente.UseVisualStyleBackColor = true;
            this.btnRecurrente.Click += new System.EventHandler(this.btnRecurrente_Click);
            // 
            // frmGestTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 565);
            this.Controls.Add(this.btnRecurrente);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnPagoTarjeta);
            this.Controls.Add(this.dgLista);
            this.Name = "frmGestTarjeta";
            this.Text = "Gestion de Tarjetas";
            this.Activated += new System.EventHandler(this.frmGestTarjeta_Activated);
            this.Load += new System.EventHandler(this.frmGestTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.Button btnPagoTarjeta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn claseMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimaCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCuota;
        private System.Windows.Forms.Button btnRecurrente;
    }
}