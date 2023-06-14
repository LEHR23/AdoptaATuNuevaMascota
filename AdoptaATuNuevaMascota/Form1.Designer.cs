namespace AdoptaATuNuevaMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listaanimales = new System.Windows.Forms.Button();
            this.adoptaranimal = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaanimales
            // 
            this.listaanimales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaanimales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listaanimales.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaanimales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listaanimales.Location = new System.Drawing.Point(555, 322);
            this.listaanimales.Name = "listaanimales";
            this.listaanimales.Size = new System.Drawing.Size(180, 67);
            this.listaanimales.TabIndex = 0;
            this.listaanimales.Text = "Animales Recogidos";
            this.listaanimales.UseVisualStyleBackColor = false;
            this.listaanimales.Click += new System.EventHandler(this.animalesrecogidos);
            // 
            // adoptaranimal
            // 
            this.adoptaranimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adoptaranimal.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptaranimal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adoptaranimal.Location = new System.Drawing.Point(311, 322);
            this.adoptaranimal.Name = "adoptaranimal";
            this.adoptaranimal.Size = new System.Drawing.Size(180, 67);
            this.adoptaranimal.TabIndex = 2;
            this.adoptaranimal.Text = "Adoptar Animal";
            this.adoptaranimal.UseVisualStyleBackColor = false;
            this.adoptaranimal.Click += new System.EventHandler(this.adoptarAnimal);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salir.Font = new System.Drawing.Font("AR JULIAN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salir.Location = new System.Drawing.Point(66, 322);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(180, 67);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salirdelsistema);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdoptaATuNuevaMascota.Properties.Resources.drluria;
            this.pictureBox1.Location = new System.Drawing.Point(182, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AdoptaATuNuevaMascota.Properties.Resources.principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.adoptaranimal);
            this.Controls.Add(this.listaanimales);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sisema De Control";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listaanimales;
        private System.Windows.Forms.Button adoptaranimal;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

