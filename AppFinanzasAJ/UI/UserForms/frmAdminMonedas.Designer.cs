namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmAdminMonedas
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstMonedas = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnMonedaPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(13, 365);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(202, 42);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(14, 317);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(202, 42);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(202, 42);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstMonedas
            // 
            this.lstMonedas.FormattingEnabled = true;
            this.lstMonedas.Location = new System.Drawing.Point(224, 41);
            this.lstMonedas.Name = "lstMonedas";
            this.lstMonedas.Size = new System.Drawing.Size(215, 368);
            this.lstMonedas.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 89);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(202, 42);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnMonedaPrincipal
            // 
            this.btnMonedaPrincipal.Location = new System.Drawing.Point(12, 137);
            this.btnMonedaPrincipal.Name = "btnMonedaPrincipal";
            this.btnMonedaPrincipal.Size = new System.Drawing.Size(202, 42);
            this.btnMonedaPrincipal.TabIndex = 9;
            this.btnMonedaPrincipal.Text = "Moneda Principal";
            this.btnMonedaPrincipal.UseVisualStyleBackColor = true;
            this.btnMonedaPrincipal.Click += new System.EventHandler(this.btnMonedaPrincipal_Click);
            // 
            // frmAdminMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 420);
            this.Controls.Add(this.btnMonedaPrincipal);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstMonedas);
            this.Name = "frmAdminMonedas";
            this.Text = "frmAdminMonedas";
            this.Load += new System.EventHandler(this.frmAdminMonedas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstMonedas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnMonedaPrincipal;
    }
}