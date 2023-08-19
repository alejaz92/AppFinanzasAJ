namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmTipoMovimiento
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
            this.btnEditarI = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminarI = new System.Windows.Forms.Button();
            this.btnAgregarI = new System.Windows.Forms.Button();
            this.lstTipoIngreso = new System.Windows.Forms.ListBox();
            this.lstTipoEgreso = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditarE = new System.Windows.Forms.Button();
            this.btnEliminarE = new System.Windows.Forms.Button();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditarI
            // 
            this.btnEditarI.Location = new System.Drawing.Point(12, 93);
            this.btnEditarI.Name = "btnEditarI";
            this.btnEditarI.Size = new System.Drawing.Size(202, 42);
            this.btnEditarI.TabIndex = 13;
            this.btnEditarI.Text = "Editar";
            this.btnEditarI.UseVisualStyleBackColor = true;
            this.btnEditarI.Click += new System.EventHandler(this.btnEditarI_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(11, 436);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(202, 42);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminarI
            // 
            this.btnEliminarI.Location = new System.Drawing.Point(11, 141);
            this.btnEliminarI.Name = "btnEliminarI";
            this.btnEliminarI.Size = new System.Drawing.Size(202, 42);
            this.btnEliminarI.TabIndex = 11;
            this.btnEliminarI.Text = "Eliminar";
            this.btnEliminarI.UseVisualStyleBackColor = true;
            this.btnEliminarI.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarI
            // 
            this.btnAgregarI.Location = new System.Drawing.Point(12, 45);
            this.btnAgregarI.Name = "btnAgregarI";
            this.btnAgregarI.Size = new System.Drawing.Size(202, 42);
            this.btnAgregarI.TabIndex = 10;
            this.btnAgregarI.Text = "Agregar";
            this.btnAgregarI.UseVisualStyleBackColor = true;
            this.btnAgregarI.Click += new System.EventHandler(this.btnAgregarI_Click);
            // 
            // lstTipoIngreso
            // 
            this.lstTipoIngreso.FormattingEnabled = true;
            this.lstTipoIngreso.Location = new System.Drawing.Point(220, 45);
            this.lstTipoIngreso.Name = "lstTipoIngreso";
            this.lstTipoIngreso.Size = new System.Drawing.Size(215, 186);
            this.lstTipoIngreso.TabIndex = 9;
            // 
            // lstTipoEgreso
            // 
            this.lstTipoEgreso.FormattingEnabled = true;
            this.lstTipoEgreso.Location = new System.Drawing.Point(220, 252);
            this.lstTipoEgreso.Name = "lstTipoEgreso";
            this.lstTipoEgreso.Size = new System.Drawing.Size(215, 186);
            this.lstTipoEgreso.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Egreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ingreso";
            // 
            // btnEditarE
            // 
            this.btnEditarE.Location = new System.Drawing.Point(12, 300);
            this.btnEditarE.Name = "btnEditarE";
            this.btnEditarE.Size = new System.Drawing.Size(202, 42);
            this.btnEditarE.TabIndex = 19;
            this.btnEditarE.Text = "Editar";
            this.btnEditarE.UseVisualStyleBackColor = true;
            this.btnEditarE.Click += new System.EventHandler(this.btnEditarE_Click);
            // 
            // btnEliminarE
            // 
            this.btnEliminarE.Location = new System.Drawing.Point(11, 348);
            this.btnEliminarE.Name = "btnEliminarE";
            this.btnEliminarE.Size = new System.Drawing.Size(202, 42);
            this.btnEliminarE.TabIndex = 18;
            this.btnEliminarE.Text = "Eliminar";
            this.btnEliminarE.UseVisualStyleBackColor = true;
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.Location = new System.Drawing.Point(12, 252);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(202, 42);
            this.btnAgregarE.TabIndex = 17;
            this.btnAgregarE.Text = "Agregar";
            this.btnAgregarE.UseVisualStyleBackColor = true;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // frmTipoMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 490);
            this.Controls.Add(this.btnEditarE);
            this.Controls.Add(this.btnEliminarE);
            this.Controls.Add(this.btnAgregarE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTipoEgreso);
            this.Controls.Add(this.btnEditarI);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminarI);
            this.Controls.Add(this.btnAgregarI);
            this.Controls.Add(this.lstTipoIngreso);
            this.Name = "frmTipoMovimiento";
            this.Text = "frmTipoMovimiento";
            this.Load += new System.EventHandler(this.frmTipoMovimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarI;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminarI;
        private System.Windows.Forms.Button btnAgregarI;
        private System.Windows.Forms.ListBox lstTipoIngreso;
        private System.Windows.Forms.ListBox lstTipoEgreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditarE;
        private System.Windows.Forms.Button btnEliminarE;
        private System.Windows.Forms.Button btnAgregarE;
    }
}