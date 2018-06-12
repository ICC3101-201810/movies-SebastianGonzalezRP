namespace Movies
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
            this.BEstudios = new System.Windows.Forms.Button();
            this.BProductores = new System.Windows.Forms.Button();
            this.BDirectores = new System.Windows.Forms.Button();
            this.BActores = new System.Windows.Forms.Button();
            this.BPelicula = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BEstudios
            // 
            this.BEstudios.Location = new System.Drawing.Point(380, 241);
            this.BEstudios.Name = "BEstudios";
            this.BEstudios.Size = new System.Drawing.Size(86, 25);
            this.BEstudios.TabIndex = 11;
            this.BEstudios.Text = "Estudios";
            this.BEstudios.UseVisualStyleBackColor = true;
            // 
            // BProductores
            // 
            this.BProductores.Location = new System.Drawing.Point(288, 241);
            this.BProductores.Name = "BProductores";
            this.BProductores.Size = new System.Drawing.Size(86, 25);
            this.BProductores.TabIndex = 10;
            this.BProductores.Text = "Productores";
            this.BProductores.UseVisualStyleBackColor = true;
            // 
            // BDirectores
            // 
            this.BDirectores.Location = new System.Drawing.Point(196, 241);
            this.BDirectores.Name = "BDirectores";
            this.BDirectores.Size = new System.Drawing.Size(86, 25);
            this.BDirectores.TabIndex = 9;
            this.BDirectores.Text = "Directores";
            this.BDirectores.UseVisualStyleBackColor = true;
            // 
            // BActores
            // 
            this.BActores.Location = new System.Drawing.Point(104, 241);
            this.BActores.Name = "BActores";
            this.BActores.Size = new System.Drawing.Size(86, 25);
            this.BActores.TabIndex = 8;
            this.BActores.Text = "Actores";
            this.BActores.UseVisualStyleBackColor = true;
            // 
            // BPelicula
            // 
            this.BPelicula.Location = new System.Drawing.Point(12, 241);
            this.BPelicula.Name = "BPelicula";
            this.BPelicula.Size = new System.Drawing.Size(86, 25);
            this.BPelicula.TabIndex = 7;
            this.BPelicula.Text = "Pelicula";
            this.BPelicula.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 278);
            this.Controls.Add(this.BEstudios);
            this.Controls.Add(this.BProductores);
            this.Controls.Add(this.BDirectores);
            this.Controls.Add(this.BActores);
            this.Controls.Add(this.BPelicula);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BEstudios;
        private System.Windows.Forms.Button BProductores;
        private System.Windows.Forms.Button BDirectores;
        private System.Windows.Forms.Button BActores;
        private System.Windows.Forms.Button BPelicula;
        private System.Windows.Forms.TextBox textBox1;
    }
}

