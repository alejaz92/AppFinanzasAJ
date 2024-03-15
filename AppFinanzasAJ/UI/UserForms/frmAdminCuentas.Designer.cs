namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmAdminCuentas
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
            this.lstCuentas = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtAddCta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoAct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstCuentas
            // 
            this.lstCuentas.FormattingEnabled = true;
            this.lstCuentas.ItemHeight = 16;
            this.lstCuentas.Location = new System.Drawing.Point(303, 44);
            this.lstCuentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCuentas.Name = "lstCuentas";
            this.lstCuentas.Size = new System.Drawing.Size(285, 452);
            this.lstCuentas.TabIndex = 0;
            this.lstCuentas.SelectedIndexChanged += new System.EventHandler(this.lstCuentas_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 121);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(269, 52);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(16, 384);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(269, 52);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(15, 443);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(269, 52);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtAddCta
            // 
            this.txtAddCta.Location = new System.Drawing.Point(83, 89);
            this.txtAddCta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddCta.Name = "txtAddCta";
            this.txtAddCta.Size = new System.Drawing.Size(200, 22);
            this.txtAddCta.TabIndex = 4;
            this.txtAddCta.TextChanged += new System.EventHandler(this.txtAddCta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // cboTipoAct
            // 
            this.cboTipoAct.FormattingEnabled = true;
            this.cboTipoAct.Location = new System.Drawing.Point(16, 44);
            this.cboTipoAct.Name = "cboTipoAct";
            this.cboTipoAct.Size = new System.Drawing.Size(267, 24);
            this.cboTipoAct.TabIndex = 12;
            this.cboTipoAct.SelectedIndexChanged += new System.EventHandler(this.cboTipoAct_SelectedIndexChanged);
            // 
            // frmAdminCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 524);
            this.Controls.Add(this.cboTipoAct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddCta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstCuentas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdminCuentas";
            this.Text = "Administracion de Cuentas";
            this.Load += new System.EventHandler(this.frmAdminCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCuentas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtAddCta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoAct;
    }
}