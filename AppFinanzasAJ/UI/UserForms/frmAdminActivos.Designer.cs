namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmAdminActivos
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
            this.lstActivos = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnMonedaPrincipal = new System.Windows.Forms.Button();
            this.btnMonedaRef = new System.Windows.Forms.Button();
            this.cboTipoAct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(17, 449);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(269, 52);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(19, 390);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(269, 52);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 97);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(269, 52);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstActivos
            // 
            this.lstActivos.FormattingEnabled = true;
            this.lstActivos.ItemHeight = 16;
            this.lstActivos.Location = new System.Drawing.Point(299, 50);
            this.lstActivos.Margin = new System.Windows.Forms.Padding(4);
            this.lstActivos.Name = "lstActivos";
            this.lstActivos.Size = new System.Drawing.Size(285, 452);
            this.lstActivos.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(16, 157);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(269, 52);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnMonedaPrincipal
            // 
            this.btnMonedaPrincipal.Location = new System.Drawing.Point(16, 216);
            this.btnMonedaPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonedaPrincipal.Name = "btnMonedaPrincipal";
            this.btnMonedaPrincipal.Size = new System.Drawing.Size(269, 52);
            this.btnMonedaPrincipal.TabIndex = 9;
            this.btnMonedaPrincipal.Text = "Moneda Principal";
            this.btnMonedaPrincipal.UseVisualStyleBackColor = true;
            this.btnMonedaPrincipal.Click += new System.EventHandler(this.btnMonedaPrincipal_Click);
            // 
            // btnMonedaRef
            // 
            this.btnMonedaRef.Location = new System.Drawing.Point(13, 276);
            this.btnMonedaRef.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonedaRef.Name = "btnMonedaRef";
            this.btnMonedaRef.Size = new System.Drawing.Size(269, 52);
            this.btnMonedaRef.TabIndex = 10;
            this.btnMonedaRef.Text = "Moneda Referencia";
            this.btnMonedaRef.UseVisualStyleBackColor = true;
            this.btnMonedaRef.Click += new System.EventHandler(this.btnMonedaRef_Click);
            // 
            // cboTipoAct
            // 
            this.cboTipoAct.FormattingEnabled = true;
            this.cboTipoAct.Location = new System.Drawing.Point(19, 50);
            this.cboTipoAct.Name = "cboTipoAct";
            this.cboTipoAct.Size = new System.Drawing.Size(267, 24);
            this.cboTipoAct.TabIndex = 11;
            this.cboTipoAct.SelectedIndexChanged += new System.EventHandler(this.cboTipoAct_SelectedIndexChanged);
            // 
            // frmAdminActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 517);
            this.Controls.Add(this.cboTipoAct);
            this.Controls.Add(this.btnMonedaRef);
            this.Controls.Add(this.btnMonedaPrincipal);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstActivos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminActivos";
            this.Text = "Administracion de Monedas";
            this.Load += new System.EventHandler(this.frmAdminActivos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstActivos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnMonedaPrincipal;
        private System.Windows.Forms.Button btnMonedaRef;
        private System.Windows.Forms.ComboBox cboTipoAct;
    }
}