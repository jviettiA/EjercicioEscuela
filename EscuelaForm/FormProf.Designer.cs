namespace EscuelaForm
{
    partial class FormProf
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarProf = new System.Windows.Forms.Button();
            this.gridProfesor = new System.Windows.Forms.DataGridView();
            this.lstbProfesor = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProf
            // 
            this.btnAgregarProf.Location = new System.Drawing.Point(43, 12);
            this.btnAgregarProf.Name = "btnAgregarProf";
            this.btnAgregarProf.Size = new System.Drawing.Size(124, 36);
            this.btnAgregarProf.TabIndex = 0;
            this.btnAgregarProf.Text = "Agregar Profesores";
            this.btnAgregarProf.UseVisualStyleBackColor = true;
            this.btnAgregarProf.Click += new System.EventHandler(this.btnAgregarProf_Click);
            // 
            // gridProfesor
            // 
            this.gridProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfesor.Location = new System.Drawing.Point(12, 120);
            this.gridProfesor.Name = "gridProfesor";
            this.gridProfesor.Size = new System.Drawing.Size(422, 206);
            this.gridProfesor.TabIndex = 1;
            // 
            // lstbProfesor
            // 
            this.lstbProfesor.FormattingEnabled = true;
            this.lstbProfesor.Location = new System.Drawing.Point(523, 114);
            this.lstbProfesor.Name = "lstbProfesor";
            this.lstbProfesor.Size = new System.Drawing.Size(218, 212);
            this.lstbProfesor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbProfesor);
            this.Controls.Add(this.gridProfesor);
            this.Controls.Add(this.btnAgregarProf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProf;
        private System.Windows.Forms.DataGridView gridProfesor;
        private System.Windows.Forms.ListBox lstbProfesor;
    }
}

