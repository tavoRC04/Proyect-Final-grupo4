namespace SistemaMedico
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTxtBxTratamiento = new System.Windows.Forms.RichTextBox();
            this.labelTratamiento = new System.Windows.Forms.Label();
            this.richTxtBxDiagnostico = new System.Windows.Forms.RichTextBox();
            this.labelDiagnostico = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelPregunta);
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Controls.Add(this.btnSi);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 348);
            this.panel1.TabIndex = 0;
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Font = new System.Drawing.Font("Cambria", 12F);
            this.labelPregunta.Location = new System.Drawing.Point(37, 50);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(208, 19);
            this.labelPregunta.TabIndex = 2;
            this.labelPregunta.Text = "¿El paciente presenta fiebre?";
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNo.Location = new System.Drawing.Point(101, 146);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.Location = new System.Drawing.Point(101, 94);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(75, 23);
            this.btnSi.TabIndex = 0;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnReiniciar);
            this.panel2.Controls.Add(this.richTxtBxTratamiento);
            this.panel2.Controls.Add(this.labelTratamiento);
            this.panel2.Controls.Add(this.richTxtBxDiagnostico);
            this.panel2.Controls.Add(this.labelDiagnostico);
            this.panel2.Location = new System.Drawing.Point(326, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 348);
            this.panel2.TabIndex = 1;
            // 
            // richTxtBxTratamiento
            // 
            this.richTxtBxTratamiento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBxTratamiento.Location = new System.Drawing.Point(41, 162);
            this.richTxtBxTratamiento.Name = "richTxtBxTratamiento";
            this.richTxtBxTratamiento.Size = new System.Drawing.Size(241, 111);
            this.richTxtBxTratamiento.TabIndex = 4;
            this.richTxtBxTratamiento.Text = "";
            // 
            // labelTratamiento
            // 
            this.labelTratamiento.AutoSize = true;
            this.labelTratamiento.Font = new System.Drawing.Font("Cambria", 12F);
            this.labelTratamiento.Location = new System.Drawing.Point(37, 124);
            this.labelTratamiento.Name = "labelTratamiento";
            this.labelTratamiento.Size = new System.Drawing.Size(97, 19);
            this.labelTratamiento.TabIndex = 3;
            this.labelTratamiento.Text = "Tratamiento:";
            // 
            // richTxtBxDiagnostico
            // 
            this.richTxtBxDiagnostico.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBxDiagnostico.Location = new System.Drawing.Point(40, 63);
            this.richTxtBxDiagnostico.Name = "richTxtBxDiagnostico";
            this.richTxtBxDiagnostico.Size = new System.Drawing.Size(241, 58);
            this.richTxtBxDiagnostico.TabIndex = 2;
            this.richTxtBxDiagnostico.Text = "";
            // 
            // labelDiagnostico
            // 
            this.labelDiagnostico.AutoSize = true;
            this.labelDiagnostico.Font = new System.Drawing.Font("Cambria", 12F);
            this.labelDiagnostico.Location = new System.Drawing.Point(37, 35);
            this.labelDiagnostico.Name = "labelDiagnostico";
            this.labelDiagnostico.Size = new System.Drawing.Size(94, 19);
            this.labelDiagnostico.TabIndex = 0;
            this.labelDiagnostico.Text = "Diagnostico:";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnReiniciar.Location = new System.Drawing.Point(113, 288);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(109, 48);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar Diagnostico";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMedico.Properties.Resources.enfermedad;
            this.pictureBox1.Location = new System.Drawing.Point(77, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(705, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDiagnostico;
        private System.Windows.Forms.RichTextBox richTxtBxDiagnostico;
        private System.Windows.Forms.RichTextBox richTxtBxTratamiento;
        private System.Windows.Forms.Label labelTratamiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

