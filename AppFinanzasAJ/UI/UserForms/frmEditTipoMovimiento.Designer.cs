namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmEditTipoMovimiento
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
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.radEgreso = new System.Windows.Forms.RadioButton();
            this.radIngreso = new System.Windows.Forms.RadioButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.radEgreso);
            this.grpTipo.Controls.Add(this.radIngreso);
            this.grpTipo.Location = new System.Drawing.Point(20, 73);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(318, 48);
            this.grpTipo.TabIndex = 9;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo de Movimiento";
            // 
            // radEgreso
            // 
            this.radEgreso.AutoSize = true;
            this.radEgreso.Location = new System.Drawing.Point(183, 19);
            this.radEgreso.Name = "radEgreso";
            this.radEgreso.Size = new System.Drawing.Size(58, 17);
            this.radEgreso.TabIndex = 1;
            this.radEgreso.TabStop = true;
            this.radEgreso.Text = "Egreso";
            this.radEgreso.UseVisualStyleBackColor = true;
            // 
            // radIngreso
            // 
            this.radIngreso.AutoSize = true;
            this.radIngreso.Location = new System.Drawing.Point(65, 19);
            this.radIngreso.Name = "radIngreso";
            this.radIngreso.Size = new System.Drawing.Size(60, 17);
            this.radIngreso.TabIndex = 0;
            this.radIngreso.TabStop = true;
            this.radIngreso.Text = "Ingreso";
            this.radIngreso.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(129, 38);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(209, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 32);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(154, 128);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 32);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmEditTipoMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 169);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmEditTipoMovimiento";
            this.Text = "frmEditTipoMovimiento";
            this.Load += new System.EventHandler(this.frmEditTipoMovimiento_Load);
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton radEgreso;
        private System.Windows.Forms.RadioButton radIngreso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}