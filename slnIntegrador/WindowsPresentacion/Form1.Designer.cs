namespace WindowsPresentacion
{
    partial class ClinicaApp
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
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.gridPacientes = new System.Windows.Forms.DataGridView();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.medicosClinicos = new System.Windows.Forms.ListBox();
            this.habitaciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Location = new System.Drawing.Point(12, 59);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(343, 124);
            this.gridMedicos.TabIndex = 0;
            // 
            // gridPacientes
            // 
            this.gridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacientes.Location = new System.Drawing.Point(12, 246);
            this.gridPacientes.Name = "gridPacientes";
            this.gridPacientes.Size = new System.Drawing.Size(343, 124);
            this.gridPacientes.TabIndex = 1;
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicos.Location = new System.Drawing.Point(135, 20);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(93, 26);
            this.lblMedicos.TabIndex = 2;
            this.lblMedicos.Text = "Medicos";
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.Location = new System.Drawing.Point(135, 203);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(102, 26);
            this.lblPacientes.TabIndex = 3;
            this.lblPacientes.Text = "Pacientes";
            // 
            // medicosClinicos
            // 
            this.medicosClinicos.Cursor = System.Windows.Forms.Cursors.No;
            this.medicosClinicos.FormattingEnabled = true;
            this.medicosClinicos.Location = new System.Drawing.Point(395, 59);
            this.medicosClinicos.Name = "medicosClinicos";
            this.medicosClinicos.Size = new System.Drawing.Size(228, 121);
            this.medicosClinicos.TabIndex = 4;
            // 
            // habitaciones
            // 
            this.habitaciones.FormattingEnabled = true;
            this.habitaciones.Location = new System.Drawing.Point(395, 246);
            this.habitaciones.Name = "habitaciones";
            this.habitaciones.Size = new System.Drawing.Size(228, 121);
            this.habitaciones.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medicos Clinicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Habitaciones";
            // 
            // ClinicaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(655, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.habitaciones);
            this.Controls.Add(this.medicosClinicos);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.gridPacientes);
            this.Controls.Add(this.gridMedicos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ClinicaApp";
            this.Text = "ClinicaApp";
            this.Load += new System.EventHandler(this.Mostrar);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.DataGridView gridPacientes;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.ListBox medicosClinicos;
        private System.Windows.Forms.ListBox habitaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

