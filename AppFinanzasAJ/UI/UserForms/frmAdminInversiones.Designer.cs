namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmAdminInversiones
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMovCrypto = new System.Windows.Forms.Button();
            this.btnMovBolsa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCerrar.Location = new System.Drawing.Point(13, 137);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(213, 33);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMovCrypto
            // 
            this.btnMovCrypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMovCrypto.Location = new System.Drawing.Point(13, 36);
            this.btnMovCrypto.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovCrypto.Name = "btnMovCrypto";
            this.btnMovCrypto.Size = new System.Drawing.Size(213, 33);
            this.btnMovCrypto.TabIndex = 12;
            this.btnMovCrypto.Text = "Mov. Crypto";
            this.btnMovCrypto.UseVisualStyleBackColor = true;
            this.btnMovCrypto.Click += new System.EventHandler(this.btnMovCrypto_Click);
            // 
            // btnMovBolsa
            // 
            this.btnMovBolsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMovBolsa.Location = new System.Drawing.Point(13, 77);
            this.btnMovBolsa.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovBolsa.Name = "btnMovBolsa";
            this.btnMovBolsa.Size = new System.Drawing.Size(213, 33);
            this.btnMovBolsa.TabIndex = 13;
            this.btnMovBolsa.Text = "Mov. Bolsa";
            this.btnMovBolsa.UseVisualStyleBackColor = true;
            this.btnMovBolsa.Click += new System.EventHandler(this.btnMovBolsa_Click);
            // 
            // frmAdminInversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 189);
            this.Controls.Add(this.btnMovBolsa);
            this.Controls.Add(this.btnMovCrypto);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmAdminInversiones";
            this.Text = "Gestion de Inversiones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMovCrypto;
        private System.Windows.Forms.Button btnMovBolsa;
    }
}