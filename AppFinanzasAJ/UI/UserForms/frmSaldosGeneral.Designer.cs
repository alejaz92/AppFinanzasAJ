namespace AppFinanzasAJ.UI.UserForms
{
    partial class frmSaldosGeneral
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalDolar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPesos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnTenenciasMonetarias = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panTenenciasMonetarias = new System.Windows.Forms.Panel();
            this.cboActivoTenencias = new System.Windows.Forms.ComboBox();
            this.charTenencias1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.panTenenciasMonetarias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charTenencias1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalDolar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(6, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 71);
            this.panel2.TabIndex = 3;
            // 
            // lblTotalDolar
            // 
            this.lblTotalDolar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalDolar.AutoSize = true;
            this.lblTotalDolar.Location = new System.Drawing.Point(4, 32);
            this.lblTotalDolar.Name = "lblTotalDolar";
            this.lblTotalDolar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalDolar.Size = new System.Drawing.Size(118, 29);
            this.lblTotalDolar.TabIndex = 2;
            this.lblTotalDolar.Text = "10000,50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "En Dolares";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalPesos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 71);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalPesos
            // 
            this.lblTotalPesos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPesos.AutoSize = true;
            this.lblTotalPesos.Location = new System.Drawing.Point(3, 29);
            this.lblTotalPesos.Name = "lblTotalPesos";
            this.lblTotalPesos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalPesos.Size = new System.Drawing.Size(118, 29);
            this.lblTotalPesos.TabIndex = 2;
            this.lblTotalPesos.Text = "10000,50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "En Pesos";
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panMenu.Controls.Add(this.btnTenenciasMonetarias);
            this.panMenu.Controls.Add(this.btnSalir);
            this.panMenu.Controls.Add(this.groupBox1);
            this.panMenu.Location = new System.Drawing.Point(0, -1);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(243, 693);
            this.panMenu.TabIndex = 16;
            // 
            // btnTenenciasMonetarias
            // 
            this.btnTenenciasMonetarias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTenenciasMonetarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTenenciasMonetarias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTenenciasMonetarias.Location = new System.Drawing.Point(0, 203);
            this.btnTenenciasMonetarias.Margin = new System.Windows.Forms.Padding(4);
            this.btnTenenciasMonetarias.Name = "btnTenenciasMonetarias";
            this.btnTenenciasMonetarias.Size = new System.Drawing.Size(243, 33);
            this.btnTenenciasMonetarias.TabIndex = 18;
            this.btnTenenciasMonetarias.Text = "Tenencias Monetarias";
            this.btnTenenciasMonetarias.UseVisualStyleBackColor = false;
            this.btnTenenciasMonetarias.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(0, 660);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(243, 33);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panTenenciasMonetarias
            // 
            this.panTenenciasMonetarias.Controls.Add(this.cboActivoTenencias);
            this.panTenenciasMonetarias.Controls.Add(this.charTenencias1);
            this.panTenenciasMonetarias.Location = new System.Drawing.Point(247, 3);
            this.panTenenciasMonetarias.Name = "panTenenciasMonetarias";
            this.panTenenciasMonetarias.Size = new System.Drawing.Size(1173, 689);
            this.panTenenciasMonetarias.TabIndex = 17;
            // 
            // cboActivoTenencias
            // 
            this.cboActivoTenencias.FormattingEnabled = true;
            this.cboActivoTenencias.Location = new System.Drawing.Point(0, 0);
            this.cboActivoTenencias.Name = "cboActivoTenencias";
            this.cboActivoTenencias.Size = new System.Drawing.Size(547, 26);
            this.cboActivoTenencias.TabIndex = 1;
            this.cboActivoTenencias.SelectedIndexChanged += new System.EventHandler(this.cboActivoTenencias_SelectedIndexChanged);
            // 
            // charTenencias1
            // 
            this.charTenencias1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.charTenencias1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charTenencias1.Legends.Add(legend1);
            this.charTenencias1.Location = new System.Drawing.Point(0, 27);
            this.charTenencias1.Name = "charTenencias1";
            this.charTenencias1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.charTenencias1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.charTenencias1.Series.Add(series1);
            this.charTenencias1.Size = new System.Drawing.Size(547, 358);
            this.charTenencias1.TabIndex = 0;
            this.charTenencias1.Text = "Distribucion monetaria";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            title1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Distribucion Monetaria";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            title1.Text = "Distribución Monetaria";
            this.charTenencias1.Titles.Add(title1);
            // 
            // frmSaldosGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1421, 692);
            this.Controls.Add(this.panTenenciasMonetarias);
            this.Controls.Add(this.panMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSaldosGeneral";
            this.Text = "frmSaldosGeneral";
            this.Load += new System.EventHandler(this.frmSaldosGeneral_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panMenu.ResumeLayout(false);
            this.panTenenciasMonetarias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charTenencias1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalDolar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPesos;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panTenenciasMonetarias;
        private System.Windows.Forms.Button btnTenenciasMonetarias;
        private System.Windows.Forms.DataVisualization.Charting.Chart charTenencias1;
        private System.Windows.Forms.ComboBox cboActivoTenencias;
    }
}