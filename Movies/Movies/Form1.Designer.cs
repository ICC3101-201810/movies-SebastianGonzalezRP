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
            this.LB1 = new System.Windows.Forms.ListBox();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.LB2 = new System.Windows.Forms.ListBox();
            this.L3 = new System.Windows.Forms.Label();
            this.LB3 = new System.Windows.Forms.ListBox();
            this.L4 = new System.Windows.Forms.Label();
            this.LB4 = new System.Windows.Forms.ListBox();
            this.L5 = new System.Windows.Forms.Label();
            this.LB5 = new System.Windows.Forms.ListBox();
            this.L6 = new System.Windows.Forms.Label();
            this.LB6 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BEstudios
            // 
            this.BEstudios.Location = new System.Drawing.Point(394, 241);
            this.BEstudios.Name = "BEstudios";
            this.BEstudios.Size = new System.Drawing.Size(87, 25);
            this.BEstudios.TabIndex = 11;
            this.BEstudios.Text = "Estudios";
            this.BEstudios.UseVisualStyleBackColor = true;
            this.BEstudios.Click += new System.EventHandler(this.BEstudios_Click);
            // 
            // BProductores
            // 
            this.BProductores.Location = new System.Drawing.Point(297, 241);
            this.BProductores.Name = "BProductores";
            this.BProductores.Size = new System.Drawing.Size(91, 25);
            this.BProductores.TabIndex = 10;
            this.BProductores.Text = "Productores";
            this.BProductores.UseVisualStyleBackColor = true;
            this.BProductores.Click += new System.EventHandler(this.BProductores_Click);
            // 
            // BDirectores
            // 
            this.BDirectores.Location = new System.Drawing.Point(211, 241);
            this.BDirectores.Name = "BDirectores";
            this.BDirectores.Size = new System.Drawing.Size(80, 25);
            this.BDirectores.TabIndex = 9;
            this.BDirectores.Text = "Directores";
            this.BDirectores.UseVisualStyleBackColor = true;
            this.BDirectores.Click += new System.EventHandler(this.BDirectores_Click);
            // 
            // BActores
            // 
            this.BActores.Location = new System.Drawing.Point(122, 241);
            this.BActores.Name = "BActores";
            this.BActores.Size = new System.Drawing.Size(83, 25);
            this.BActores.TabIndex = 8;
            this.BActores.Text = "Actores";
            this.BActores.UseVisualStyleBackColor = true;
            this.BActores.Click += new System.EventHandler(this.BActores_Click);
            // 
            // BPelicula
            // 
            this.BPelicula.Location = new System.Drawing.Point(25, 241);
            this.BPelicula.Name = "BPelicula";
            this.BPelicula.Size = new System.Drawing.Size(91, 25);
            this.BPelicula.TabIndex = 7;
            this.BPelicula.Text = "Pelicula";
            this.BPelicula.UseVisualStyleBackColor = true;
            this.BPelicula.Click += new System.EventHandler(this.BPelicula_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(494, 20);
            this.textBox1.TabIndex = 6;
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.Location = new System.Drawing.Point(12, 55);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(86, 160);
            this.LB1.TabIndex = 12;
            this.LB1.Visible = false;
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(9, 39);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(44, 13);
            this.L1.TabIndex = 13;
            this.L1.Text = "Nombre";
            this.L1.Visible = false;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(92, 39);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(44, 13);
            this.L2.TabIndex = 15;
            this.L2.Text = "Director";
            this.L2.Visible = false;
            // 
            // LB2
            // 
            this.LB2.FormattingEnabled = true;
            this.LB2.Location = new System.Drawing.Point(95, 55);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(86, 160);
            this.LB2.TabIndex = 14;
            this.LB2.Visible = false;
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Location = new System.Drawing.Point(174, 39);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(43, 13);
            this.L3.TabIndex = 17;
            this.L3.Text = "Estreno";
            this.L3.Visible = false;
            // 
            // LB3
            // 
            this.LB3.FormattingEnabled = true;
            this.LB3.Location = new System.Drawing.Point(177, 55);
            this.LB3.Name = "LB3";
            this.LB3.Size = new System.Drawing.Size(86, 160);
            this.LB3.TabIndex = 16;
            this.LB3.Visible = false;
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Location = new System.Drawing.Point(254, 39);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(63, 13);
            this.L4.TabIndex = 19;
            this.L4.Text = "Descripcion";
            this.L4.Visible = false;
            // 
            // LB4
            // 
            this.LB4.FormattingEnabled = true;
            this.LB4.Location = new System.Drawing.Point(257, 55);
            this.LB4.Name = "LB4";
            this.LB4.Size = new System.Drawing.Size(86, 160);
            this.LB4.TabIndex = 18;
            this.LB4.Visible = false;
            // 
            // L5
            // 
            this.L5.AutoSize = true;
            this.L5.Location = new System.Drawing.Point(335, 39);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(66, 13);
            this.L5.TabIndex = 21;
            this.L5.Text = "Presupuesto";
            this.L5.Visible = false;
            // 
            // LB5
            // 
            this.LB5.FormattingEnabled = true;
            this.LB5.Location = new System.Drawing.Point(338, 55);
            this.LB5.Name = "LB5";
            this.LB5.Size = new System.Drawing.Size(86, 160);
            this.LB5.TabIndex = 20;
            this.LB5.Visible = false;
            // 
            // L6
            // 
            this.L6.AutoSize = true;
            this.L6.Location = new System.Drawing.Point(417, 39);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(42, 13);
            this.L6.TabIndex = 23;
            this.L6.Text = "Estudio";
            this.L6.Visible = false;
            // 
            // LB6
            // 
            this.LB6.FormattingEnabled = true;
            this.LB6.Location = new System.Drawing.Point(420, 55);
            this.LB6.Name = "LB6";
            this.LB6.Size = new System.Drawing.Size(86, 160);
            this.LB6.TabIndex = 22;
            this.LB6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 278);
            this.Controls.Add(this.L6);
            this.Controls.Add(this.LB6);
            this.Controls.Add(this.L5);
            this.Controls.Add(this.LB5);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.LB4);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.LB3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.LB1);
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
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.ListBox LB2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.ListBox LB3;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.ListBox LB4;
        private System.Windows.Forms.Label L5;
        private System.Windows.Forms.ListBox LB5;
        private System.Windows.Forms.Label L6;
        private System.Windows.Forms.ListBox LB6;
    }
}

