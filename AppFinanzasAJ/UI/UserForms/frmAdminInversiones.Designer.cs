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
            this.btnTransformacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCerrar.Location = new System.Drawing.Point(13, 404);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(213, 33);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnTransformacion
            // 
            this.btnTransformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTransformacion.Location = new System.Drawing.Point(13, 22);
            this.btnTransformacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransformacion.Name = "btnTransformacion";
            this.btnTransformacion.Size = new System.Drawing.Size(213, 33);
            this.btnTransformacion.TabIndex = 12;
            this.btnTransformacion.Text = "Transformacion";
            this.btnTransformacion.UseVisualStyleBackColor = true;
            this.btnTransformacion.Click += new System.EventHandler(this.btnTransformacion_Click);
            // 
            // frmAdminInversiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransformacion);
            this.Controls.Add(this.btnCerrar);
            this.Name = "frmAdminInversiones";
            this.Text = "Gestion de Inversiones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnTransformacion;
    }
}