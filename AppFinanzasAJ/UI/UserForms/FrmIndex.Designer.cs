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
            this.btnAjustesBSantaFe = new System.Windows.Forms.Button();
            this.btnClaseMovimiento = new System.Windows.Forms.Button();
            this.btnMonedas = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnRegMovimiento = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegMovimientoBSF = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjustesBSantaFe);
            this.groupBox1.Controls.Add(this.btnClaseMovimiento);
            this.groupBox1.Controls.Add(this.btnMonedas);
            this.groupBox1.Controls.Add(this.btnCuentas);
            this.groupBox1.Location = new System.Drawing.Point(1956, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(407, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos Clave";
            // 
            // btnAjustesBSantaFe
            // 
            this.btnAjustesBSantaFe.Location = new System.Drawing.Point(11, 198);
            this.btnAjustesBSantaFe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAjustesBSantaFe.Name = "btnAjustesBSantaFe";
            this.btnAjustesBSantaFe.Size = new System.Drawing.Size(383, 42);
            this.btnAjustesBSantaFe.TabIndex = 3;
            this.btnAjustesBSantaFe.Text = "Ajustes B. Santa Fe";
            this.btnAjustesBSantaFe.UseVisualStyleBackColor = true;
            this.btnAjustesBSantaFe.Click += new System.EventHandler(this.btnAjustesBSantaFe_Click);
            // 
            // btnClaseMovimiento
            // 
            this.btnClaseMovimiento.Location = new System.Drawing.Point(13, 144);
            this.btnClaseMovimiento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClaseMovimiento.Name = "btnClaseMovimiento";
            this.btnClaseMovimiento.Size = new System.Drawing.Size(383, 42);
            this.btnClaseMovimiento.TabIndex = 2;
            this.btnClaseMovimiento.Text = "Clases de Movimiento";
            this.btnClaseMovimiento.UseVisualStyleBackColor = true;
            this.btnClaseMovimiento.Click += new System.EventHandler(this.btnClaseMovimiento_Click);
            // 
            // btnMonedas
            // 
            this.btnMonedas.Location = new System.Drawing.Point(13, 90);
            this.btnMonedas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMonedas.Name = "btnMonedas";
            this.btnMonedas.Size = new System.Drawing.Size(383, 42);
            this.btnMonedas.TabIndex = 1;
            this.btnMonedas.Text = "Monedas";
            this.btnMonedas.UseVisualStyleBackColor = true;
            this.btnMonedas.Click += new System.EventHandler(this.btnMonedas_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.Location = new System.Drawing.Point(13, 37);
            this.btnCuentas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(383, 42);
            this.btnCuentas.TabIndex = 0;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnRegMovimiento
            // 
            this.btnRegMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegMovimiento.Location = new System.Drawing.Point(13, 37);
            this.btnRegMovimiento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegMovimiento.Name = "btnRegMovimiento";
            this.btnRegMovimiento.Size = new System.Drawing.Size(293, 50);
            this.btnRegMovimiento.TabIndex = 1;
            this.btnRegMovimiento.Text = "Mov. Regular";
            this.btnRegMovimiento.UseVisualStyleBackColor = true;
            this.btnRegMovimiento.Click += new System.EventHandler(this.btnRegMovimiento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegMovimientoBSF);
            this.groupBox2.Controls.Add(this.btnRegMovimiento);
            this.groupBox2.Location = new System.Drawing.Point(15, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(336, 345);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimientos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnRegMovimientoBSF
            // 
            this.btnRegMovimientoBSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegMovimientoBSF.Location = new System.Drawing.Point(13, 109);
            this.btnRegMovimientoBSF.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegMovimientoBSF.Name = "btnRegMovimientoBSF";
            this.btnRegMovimientoBSF.Size = new System.Drawing.Size(293, 50);
            this.btnRegMovimientoBSF.TabIndex = 2;
            this.btnRegMovimientoBSF.Text = "Mov. B. Santa Fe";
            this.btnRegMovimientoBSF.UseVisualStyleBackColor = true;
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2387, 1062);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmIndex";
            this.Text = "App Finanzas Personales AJ";
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnMonedas;
        private System.Windows.Forms.Button btnClaseMovimiento;
        private System.Windows.Forms.Button btnRegMovimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAjustesBSantaFe;
        private System.Windows.Forms.Button btnRegMovimientoBSF;
    }
}

