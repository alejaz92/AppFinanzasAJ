namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmSaldosGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaldosGeneral));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalDolar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPesos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoActivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboActivo = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalDolar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(6, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 71);
            this.panel2.TabIndex = 3;
            // 
            // lblTotalDolar
            // 
            this.lblTotalDolar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalDolar.AutoSize = true;
            this.lblTotalDolar.Location = new System.Drawing.Point(4, 32);
            this.lblTotalDolar.Name = "lblTotalDolar";
            this.lblTotalDolar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalDolar.Size = new System.Drawing.Size(118, 29);
            this.lblTotalDolar.TabIndex = 2;
            this.lblTotalDolar.Text = "10000,50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "En Dolares";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalPesos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 71);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalPesos
            // 
            this.lblTotalPesos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPesos.AutoSize = true;
            this.lblTotalPesos.Location = new System.Drawing.Point(3, 29);
            this.lblTotalPesos.Name = "lblTotalPesos";
            this.lblTotalPesos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPesos.Size = new System.Drawing.Size(118, 29);
            this.lblTotalPesos.TabIndex = 2;
            this.lblTotalPesos.Text = "10000,50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "En Pesos";
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panMenu.Controls.Add(this.label3);
            this.panMenu.Controls.Add(this.cboTipoActivo);
            this.panMenu.Controls.Add(this.label2);
            this.panMenu.Controls.Add(this.cboActivo);
            this.panMenu.Controls.Add(this.btnSalir);
            this.panMenu.Controls.Add(this.groupBox1);
            this.panMenu.Location = new System.Drawing.Point(0, -1);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(251, 419);
            this.panMenu.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo Activo";
            // 
            // cboTipoActivo
            // 
            this.cboTipoActivo.FormattingEnabled = true;
            this.cboTipoActivo.Location = new System.Drawing.Point(5, 230);
            this.cboTipoActivo.Name = "cboTipoActivo";
            this.cboTipoActivo.Size = new System.Drawing.Size(236, 26);
            this.cboTipoActivo.TabIndex = 21;
            this.cboTipoActivo.SelectedIndexChanged += new System.EventHandler(this.cboTipoActivo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Activo";
            // 
            // cboActivo
            // 
            this.cboActivo.FormattingEnabled = true;
            this.cboActivo.Location = new System.Drawing.Point(5, 280);
            this.cboActivo.Name = "cboActivo";
            this.cboActivo.Size = new System.Drawing.Size(236, 26);
            this.cboActivo.TabIndex = 4;
            this.cboActivo.SelectedIndexChanged += new System.EventHandler(this.cboActivo_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(3, 386);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(243, 33);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.AllowUserToResizeColumns = false;
            this.dgvCuentas.AllowUserToResizeRows = false;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Monto});
            this.dgvCuentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvCuentas.Location = new System.Drawing.Point(247, 2);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.RowHeadersVisible = false;
            this.dgvCuentas.RowHeadersWidth = 51;
            this.dgvCuentas.RowTemplate.Height = 24;
            this.dgvCuentas.ShowCellErrors = false;
            this.dgvCuentas.ShowCellToolTips = false;
            this.dgvCuentas.ShowEditingIcon = false;
            this.dgvCuentas.ShowRowErrors = false;
            this.dgvCuentas.Size = new System.Drawing.Size(315, 416);
            this.dgvCuentas.TabIndex = 17;
            // 
            // Cuenta
            // 
            this.Cuenta.Frozen = true;
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            this.Cuenta.Width = 193;
            // 
            // Monto
            // 
            this.Monto.Frozen = true;
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 119;
            // 
            // frmSaldosGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(563, 418);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.panMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSaldosGeneral";
            this.Text = "frmSaldosGeneral";
            this.Load += new System.EventHandler(this.frmSaldosGeneral_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalDolar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPesos;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboActivo;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTipoActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}