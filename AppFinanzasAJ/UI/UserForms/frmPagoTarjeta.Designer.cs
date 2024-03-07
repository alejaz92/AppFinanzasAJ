namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmPagoTarjeta
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cboTarjeta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPesos = new System.Windows.Forms.RadioButton();
            this.radDolar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(376, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(401, 340);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cboTarjeta
            // 
            this.cboTarjeta.FormattingEnabled = true;
            this.cboTarjeta.Location = new System.Drawing.Point(98, 41);
            this.cboTarjeta.Name = "cboTarjeta";
            this.cboTarjeta.Size = new System.Drawing.Size(247, 24);
            this.cboTarjeta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarjeta";
            // 
            // cboFecha
            // 
            this.cboFecha.Location = new System.Drawing.Point(98, 81);
            this.cboFecha.Margin = new System.Windows.Forms.Padding(4);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(247, 22);
            this.cboFecha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDolar);
            this.groupBox1.Controls.Add(this.radPesos);
            this.groupBox1.Location = new System.Drawing.Point(16, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 88);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moneda Pago";
            // 
            // radPesos
            // 
            this.radPesos.AutoSize = true;
            this.radPesos.Location = new System.Drawing.Point(23, 40);
            this.radPesos.Name = "radPesos";
            this.radPesos.Size = new System.Drawing.Size(67, 20);
            this.radPesos.TabIndex = 0;
            this.radPesos.TabStop = true;
            this.radPesos.Text = "Pesos";
            this.radPesos.UseVisualStyleBackColor = true;
            // 
            // radDolar
            // 
            this.radDolar.AutoSize = true;
            this.radDolar.Location = new System.Drawing.Point(175, 40);
            this.radDolar.Name = "radDolar";
            this.radDolar.Size = new System.Drawing.Size(113, 20);
            this.radDolar.TabIndex = 1;
            this.radDolar.TabStop = true;
            this.radDolar.Text = "Pesos + Dolar";
            this.radDolar.UseVisualStyleBackColor = true;
            // 
            // frmPagoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTarjeta);
            this.Controls.Add(this.listView1);
            this.Name = "frmPagoTarjeta";
            this.Text = "Registrar Pago de Tarjeta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cboTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker cboFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDolar;
        private System.Windows.Forms.RadioButton radPesos;
    }
}