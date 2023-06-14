namespace AdoptaATuNuevaMascota
{
    partial class Adoptar_Animal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adoptar_Animal));
            this.label1 = new System.Windows.Forms.Label();
            this.nombrepersona = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edadpersona = new System.Windows.Forms.TextBox();
            this.genero = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.animalseleccionado = new System.Windows.Forms.Label();
            this.DATOS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numtelefo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DE LA PERSONA";
            // 
            // nombrepersona
            // 
            this.nombrepersona.Location = new System.Drawing.Point(410, 68);
            this.nombrepersona.Name = "nombrepersona";
            this.nombrepersona.Size = new System.Drawing.Size(378, 20);
            this.nombrepersona.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "EDAD";
            // 
            // edadpersona
            // 
            this.edadpersona.Location = new System.Drawing.Point(410, 112);
            this.edadpersona.Name = "edadpersona";
            this.edadpersona.Size = new System.Drawing.Size(100, 20);
            this.edadpersona.TabIndex = 3;
            // 
            // genero
            // 
            this.genero.FormattingEnabled = true;
            this.genero.Items.AddRange(new object[] {
            "MUJER",
            "HOMBRE",
            "OTRO"});
            this.genero.Location = new System.Drawing.Point(667, 111);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(121, 21);
            this.genero.TabIndex = 4;
            this.genero.Text = "GENERO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(572, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "LISTA DE ANIMALES EN ADOPCION";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.animalseleccionado);
            this.panel1.Controls.Add(this.DATOS);
            this.panel1.Location = new System.Drawing.Point(410, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 100);
            this.panel1.TabIndex = 6;
            // 
            // animalseleccionado
            // 
            this.animalseleccionado.AutoSize = true;
            this.animalseleccionado.Location = new System.Drawing.Point(17, 27);
            this.animalseleccionado.Name = "animalseleccionado";
            this.animalseleccionado.Size = new System.Drawing.Size(144, 13);
            this.animalseleccionado.TabIndex = 1;
            this.animalseleccionado.Text = "NINGUNO SELECCIONADO";
            // 
            // DATOS
            // 
            this.DATOS.AutoSize = true;
            this.DATOS.Location = new System.Drawing.Point(14, 10);
            this.DATOS.Name = "DATOS";
            this.DATOS.Size = new System.Drawing.Size(111, 13);
            this.DATOS.TabIndex = 0;
            this.DATOS.Text = "DATOS DEL ANIMAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. TELEFONICO";
            // 
            // numtelefo
            // 
            this.numtelefo.Location = new System.Drawing.Point(410, 165);
            this.numtelefo.Name = "numtelefo";
            this.numtelefo.Size = new System.Drawing.Size(378, 20);
            this.numtelefo.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(410, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "ADOPTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.adoptar);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdoptaATuNuevaMascota.Properties.Resources.circulo_logo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(613, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 65);
            this.button2.TabIndex = 11;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.salir);
            // 
            // Adoptar_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numtelefo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.edadpersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombrepersona);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adoptar_Animal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adoptar Animal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombrepersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edadpersona;
        private System.Windows.Forms.ComboBox genero;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DATOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numtelefo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label animalseleccionado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}