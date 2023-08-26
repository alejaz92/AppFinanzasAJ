namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmAdminClaseMovimiento
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
            this.txtAgregarIngreso = new System.Windows.Forms.TextBox();
            this.btnEliminarIngreso = new System.Windows.Forms.Button();
            this.btnAgregarIngreso = new System.Windows.Forms.Button();
            this.lstIngresos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgregarEgreso = new System.Windows.Forms.TextBox();
            this.btnEliminarEgreso = new System.Windows.Forms.Button();
            this.brnAgregarEgreso = new System.Windows.Forms.Button();
            this.lstEgresos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAgregarIngreso
            // 
            this.txtAgregarIngreso.Location = new System.Drawing.Point(11, 27);
            this.txtAgregarIngreso.Name = "txtAgregarIngreso";
            this.txtAgregarIngreso.Size = new System.Drawing.Size(151, 20);
            this.txtAgregarIngreso.TabIndex = 9;
            // 
            // btnEliminarIngreso
            // 
            this.btnEliminarIngreso.Location = new System.Drawing.Point(25, 175);
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.Size = new System.Drawing.Size(137, 25);
            this.btnEliminarIngreso.TabIndex = 7;
            this.btnEliminarIngreso.Text = "Eliminar";
            this.btnEliminarIngreso.UseVisualStyleBackColor = true;
            this.btnEliminarIngreso.Click += new System.EventHandler(this.btnEliminarIngreso_Click);
            // 
            // btnAgregarIngreso
            // 
            this.btnAgregarIngreso.Location = new System.Drawing.Point(24, 53);
            this.btnAgregarIngreso.Name = "btnAgregarIngreso";
            this.btnAgregarIngreso.Size = new System.Drawing.Size(137, 25);
            this.btnAgregarIngreso.TabIndex = 6;
            this.btnAgregarIngreso.Text = "Agregar";
            this.btnAgregarIngreso.UseVisualStyleBackColor = true;
            this.btnAgregarIngreso.Click += new System.EventHandler(this.btnAgregarIngreso_Click);
            // 
            // lstIngresos
            // 
            this.lstIngresos.FormattingEnabled = true;
            this.lstIngresos.Location = new System.Drawing.Point(175, 27);
            this.lstIngresos.Name = "lstIngresos";
            this.lstIngresos.Size = new System.Drawing.Size(215, 173);
            this.lstIngresos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingresos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(91, 410);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(202, 42);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Egresos";
            // 
            // txtAgregarEgreso
            // 
            this.txtAgregarEgreso.Location = new System.Drawing.Point(11, 231);
            this.txtAgregarEgreso.Name = "txtAgregarEgreso";
            this.txtAgregarEgreso.Size = new System.Drawing.Size(151, 20);
            this.txtAgregarEgreso.TabIndex = 14;
            // 
            // btnEliminarEgreso
            // 
            this.btnEliminarEgreso.Location = new System.Drawing.Point(32, 379);
            this.btnEliminarEgreso.Name = "btnEliminarEgreso";
            this.btnEliminarEgreso.Size = new System.Drawing.Size(137, 25);
            this.btnEliminarEgreso.TabIndex = 13;
            this.btnEliminarEgreso.Text = "Eliminar";
            this.btnEliminarEgreso.UseVisualStyleBackColor = true;
            this.btnEliminarEgreso.Click += new System.EventHandler(this.btnEliminarEgreso_Click);
            // 
            // brnAgregarEgreso
            // 
            this.brnAgregarEgreso.Location = new System.Drawing.Point(24, 257);
            this.brnAgregarEgreso.Name = "brnAgregarEgreso";
            this.brnAgregarEgreso.Size = new System.Drawing.Size(137, 25);
            this.brnAgregarEgreso.TabIndex = 12;
            this.brnAgregarEgreso.Text = "Agregar";
            this.brnAgregarEgreso.UseVisualStyleBackColor = true;
            this.brnAgregarEgreso.Click += new System.EventHandler(this.brnAgregarEgreso_Click);
            // 
            // lstEgresos
            // 
            this.lstEgresos.FormattingEnabled = true;
            this.lstEgresos.Location = new System.Drawing.Point(175, 231);
            this.lstEgresos.Name = "lstEgresos";
            this.lstEgresos.Size = new System.Drawing.Size(215, 173);
            this.lstEgresos.TabIndex = 11;
            // 
            // frmAdminClaseMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAgregarEgreso);
            this.Controls.Add(this.btnEliminarEgreso);
            this.Controls.Add(this.brnAgregarEgreso);
            this.Controls.Add(this.lstEgresos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAgregarIngreso);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminarIngreso);
            this.Controls.Add(this.btnAgregarIngreso);
            this.Controls.Add(this.lstIngresos);
            this.Name = "frmAdminClaseMovimiento";
            this.Text = "Administracion de Clases de Movimiento";
            this.Load += new System.EventHandler(this.frmAdminClaseMovimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgregarIngreso;
        private System.Windows.Forms.Button btnEliminarIngreso;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.ListBox lstIngresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgregarEgreso;
        private System.Windows.Forms.Button btnEliminarEgreso;
        private System.Windows.Forms.Button brnAgregarEgreso;
        private System.Windows.Forms.ListBox lstEgresos;
    }
}