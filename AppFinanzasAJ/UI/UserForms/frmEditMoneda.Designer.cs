namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmEditMoneda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.radCripto = new System.Windows.Forms.RadioButton();
            this.radFIAT = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtSimbolo.Location = new System.Drawing.Point(125, 73);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(209, 20);
            this.txtSimbolo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Simbolo";
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.radCripto);
            this.grpTipo.Controls.Add(this.radFIAT);
            this.grpTipo.Location = new System.Drawing.Point(16, 111);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(318, 48);
            this.grpTipo.TabIndex = 4;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo de Moneda";
            // 
            // radCripto
            // 
            this.radCripto.AutoSize = true;
            this.radCripto.Location = new System.Drawing.Point(183, 19);
            this.radCripto.Name = "radCripto";
            this.radCripto.Size = new System.Drawing.Size(65, 17);
            this.radCripto.TabIndex = 1;
            this.radCripto.TabStop = true;
            this.radCripto.Text = "CRIPTO";
            this.radCripto.UseVisualStyleBackColor = true;
            // 
            // radFIAT
            // 
            this.radFIAT.AutoSize = true;
            this.radFIAT.Location = new System.Drawing.Point(65, 19);
            this.radFIAT.Name = "radFIAT";
            this.radFIAT.Size = new System.Drawing.Size(48, 17);
            this.radFIAT.TabIndex = 0;
            this.radFIAT.TabStop = true;
            this.radFIAT.Text = "FIAT";
            this.radFIAT.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(150, 166);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 32);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(245, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEditMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 218);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.txtSimbolo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmEditMoneda";
            this.Text = "Edicion de Moneda";
            this.Load += new System.EventHandler(this.frmEditMoneda_Load);
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton radCripto;
        private System.Windows.Forms.RadioButton radFIAT;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}