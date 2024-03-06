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
            this.btnClaseMovimiento = new System.Windows.Forms.Button();
            this.btnMonedas = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnRegMovimiento = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTarjetas = new System.Windows.Forms.Button();
            this.btnMovTarjeta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTarjetas);
            this.groupBox1.Controls.Add(this.btnClaseMovimiento);
            this.groupBox1.Controls.Add(this.btnMonedas);
            this.groupBox1.Controls.Add(this.btnCuentas);
            this.groupBox1.Location = new System.Drawing.Point(864, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(296, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos Clave";
            // 
            // btnClaseMovimiento
            // 
            this.btnClaseMovimiento.Location = new System.Drawing.Point(9, 96);
            this.btnClaseMovimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClaseMovimiento.Name = "btnClaseMovimiento";
            this.btnClaseMovimiento.Size = new System.Drawing.Size(279, 28);
            this.btnClaseMovimiento.TabIndex = 2;
            this.btnClaseMovimiento.Text = "Clases de Movimiento";
            this.btnClaseMovimiento.UseVisualStyleBackColor = true;
            this.btnClaseMovimiento.Click += new System.EventHandler(this.btnClaseMovimiento_Click);
            // 
            // btnMonedas
            // 
            this.btnMonedas.Location = new System.Drawing.Point(9, 60);
            this.btnMonedas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMonedas.Name = "btnMonedas";
            this.btnMonedas.Size = new System.Drawing.Size(279, 28);
            this.btnMonedas.TabIndex = 1;
            this.btnMonedas.Text = "Monedas";
            this.btnMonedas.UseVisualStyleBackColor = true;
            this.btnMonedas.Click += new System.EventHandler(this.btnMonedas_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.Location = new System.Drawing.Point(9, 25);
            this.btnCuentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(279, 28);
            this.btnCuentas.TabIndex = 0;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnRegMovimiento
            // 
            this.btnRegMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegMovimiento.Location = new System.Drawing.Point(9, 25);
            this.btnRegMovimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegMovimiento.Name = "btnRegMovimiento";
            this.btnRegMovimiento.Size = new System.Drawing.Size(213, 33);
            this.btnRegMovimiento.TabIndex = 1;
            this.btnRegMovimiento.Text = "Mov. Regular";
            this.btnRegMovimiento.UseVisualStyleBackColor = true;
            this.btnRegMovimiento.Click += new System.EventHandler(this.btnRegMovimiento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMovTarjeta);
            this.groupBox2.Controls.Add(this.btnRegMovimiento);
            this.groupBox2.Location = new System.Drawing.Point(11, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(244, 230);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimientos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.Location = new System.Drawing.Point(9, 132);
            this.btnTarjetas.Margin = new System.Windows.Forms.Padding(4);
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(279, 28);
            this.btnTarjetas.TabIndex = 3;
            this.btnTarjetas.Text = "Tarjetas";
            this.btnTarjetas.UseVisualStyleBackColor = true;
            this.btnTarjetas.Click += new System.EventHandler(this.btnTarjetas_Click);
            // 
            // btnMovTarjeta
            // 
            this.btnMovTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMovTarjeta.Location = new System.Drawing.Point(9, 66);
            this.btnMovTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovTarjeta.Name = "btnMovTarjeta";
            this.btnMovTarjeta.Size = new System.Drawing.Size(213, 33);
            this.btnMovTarjeta.TabIndex = 2;
            this.btnMovTarjeta.Text = "Mov. Tarjeta";
            this.btnMovTarjeta.UseVisualStyleBackColor = true;
            this.btnMovTarjeta.Click += new System.EventHandler(this.btnMovTarjeta_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnTarjetas;
        private System.Windows.Forms.Button btnMovTarjeta;
    }
}

