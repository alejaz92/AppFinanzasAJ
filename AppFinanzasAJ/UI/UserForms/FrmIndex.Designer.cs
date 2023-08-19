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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMonedas = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnTipoMovimiento = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTipoMovimiento);
            this.groupBox1.Controls.Add(this.btnMonedas);
            this.groupBox1.Controls.Add(this.btnCuentas);
            this.groupBox1.Location = new System.Drawing.Point(1067, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos Clave";
            // 
            // btnMonedas
            // 
            this.btnMonedas.Location = new System.Drawing.Point(7, 49);
            this.btnMonedas.Name = "btnMonedas";
            this.btnMonedas.Size = new System.Drawing.Size(209, 23);
            this.btnMonedas.TabIndex = 1;
            this.btnMonedas.Text = "Monedas";
            this.btnMonedas.UseVisualStyleBackColor = true;
            this.btnMonedas.Click += new System.EventHandler(this.btnMonedas_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.Location = new System.Drawing.Point(7, 20);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(209, 23);
            this.btnCuentas.TabIndex = 0;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnTipoMovimiento
            // 
            this.btnTipoMovimiento.Location = new System.Drawing.Point(7, 78);
            this.btnTipoMovimiento.Name = "btnTipoMovimiento";
            this.btnTipoMovimiento.Size = new System.Drawing.Size(209, 23);
            this.btnTipoMovimiento.TabIndex = 2;
            this.btnTipoMovimiento.Text = "Tipos de Movimiento";
            this.btnTipoMovimiento.UseVisualStyleBackColor = true;
            this.btnTipoMovimiento.Click += new System.EventHandler(this.btnTipoMovimiento_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 633);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmIndex";
            this.Text = "App Finanzas Personales AJ";
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnMonedas;
        private System.Windows.Forms.Button btnTipoMovimiento;
    }
}

