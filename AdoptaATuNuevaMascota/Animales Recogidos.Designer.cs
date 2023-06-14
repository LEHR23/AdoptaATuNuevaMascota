namespace AdoptaATuNuevaMascota
{
    partial class Animales_Recogidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animales_Recogidos));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxAUX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAUX1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tipodeanimal = new System.Windows.Forms.ComboBox();
            this.rancho = new System.Windows.Forms.ComboBox();
            this.añorescate = new System.Windows.Forms.ComboBox();
            this.mesrescate = new System.Windows.Forms.ComboBox();
            this.diarescate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreAnimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.laslistas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(644, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar Animales";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.mostrar);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(644, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 95);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar Nuevo Animal";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.agregaranimal);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(644, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 95);
            this.button4.TabIndex = 3;
            this.button4.Text = "Regresar Al Menú";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.regresarmenu);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBoxAUX2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxAUX1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.tipodeanimal);
            this.panel1.Controls.Add(this.rancho);
            this.panel1.Controls.Add(this.añorescate);
            this.panel1.Controls.Add(this.mesrescate);
            this.panel1.Controls.Add(this.diarescate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.edad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nombreAnimal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 426);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LARGO",
            "MEDIANO",
            "CORTO"});
            this.comboBox1.Location = new System.Drawing.Point(9, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.Text = "TAMAÑO DEL PICO";
            this.comboBox1.Visible = false;
            // 
            // textBoxAUX2
            // 
            this.textBoxAUX2.Location = new System.Drawing.Point(175, 304);
            this.textBoxAUX2.Name = "textBoxAUX2";
            this.textBoxAUX2.Size = new System.Drawing.Size(80, 20);
            this.textBoxAUX2.TabIndex = 42;
            this.textBoxAUX2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 41;
            this.label6.Visible = false;
            // 
            // textBoxAUX1
            // 
            this.textBoxAUX1.Location = new System.Drawing.Point(9, 304);
            this.textBoxAUX1.Name = "textBoxAUX1";
            this.textBoxAUX1.Size = new System.Drawing.Size(110, 20);
            this.textBoxAUX1.TabIndex = 40;
            this.textBoxAUX1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 39;
            this.label5.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(135, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "NUEVO RANCHO";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.agregarrancho);
            // 
            // tipodeanimal
            // 
            this.tipodeanimal.FormattingEnabled = true;
            this.tipodeanimal.Items.AddRange(new object[] {
            "PERRO",
            "GATO",
            "AVE",
            "COCODRILO"});
            this.tipodeanimal.Location = new System.Drawing.Point(131, 134);
            this.tipodeanimal.Name = "tipodeanimal";
            this.tipodeanimal.Size = new System.Drawing.Size(121, 21);
            this.tipodeanimal.TabIndex = 37;
            this.tipodeanimal.Text = "TIPO DE ANIMAL";
            this.tipodeanimal.SelectedIndexChanged += new System.EventHandler(this.tipodeanimal_SelectedIndexChanged);
            // 
            // rancho
            // 
            this.rancho.FormattingEnabled = true;
            this.rancho.Location = new System.Drawing.Point(12, 171);
            this.rancho.Name = "rancho";
            this.rancho.Size = new System.Drawing.Size(83, 21);
            this.rancho.TabIndex = 36;
            this.rancho.Text = "RANCHOS";
            // 
            // añorescate
            // 
            this.añorescate.FormattingEnabled = true;
            this.añorescate.Location = new System.Drawing.Point(175, 243);
            this.añorescate.Name = "añorescate";
            this.añorescate.Size = new System.Drawing.Size(81, 21);
            this.añorescate.TabIndex = 35;
            this.añorescate.Text = "AÑO";
            // 
            // mesrescate
            // 
            this.mesrescate.FormattingEnabled = true;
            this.mesrescate.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.mesrescate.Location = new System.Drawing.Point(77, 243);
            this.mesrescate.Name = "mesrescate";
            this.mesrescate.Size = new System.Drawing.Size(80, 21);
            this.mesrescate.TabIndex = 34;
            this.mesrescate.Text = "MES";
            // 
            // diarescate
            // 
            this.diarescate.FormattingEnabled = true;
            this.diarescate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.diarescate.Location = new System.Drawing.Point(9, 243);
            this.diarescate.Name = "diarescate";
            this.diarescate.Size = new System.Drawing.Size(50, 21);
            this.diarescate.TabIndex = 33;
            this.diarescate.Text = "DIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "FECHA DE RESCATE";
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(9, 135);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(77, 20);
            this.edad.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "EDAD";
            // 
            // nombreAnimal
            // 
            this.nombreAnimal.Location = new System.Drawing.Point(9, 80);
            this.nombreAnimal.Name = "nombreAnimal";
            this.nombreAnimal.Size = new System.Drawing.Size(250, 20);
            this.nombreAnimal.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "NOMBRE DEL ANIMAL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdoptaATuNuevaMascota.Properties.Resources._58775;
            this.pictureBox2.Location = new System.Drawing.Point(295, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 365);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.Location = new System.Drawing.Point(141, 338);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 65);
            this.button7.TabIndex = 14;
            this.button7.Text = "CANCELAR";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.cancelaragregar);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.Location = new System.Drawing.Point(9, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 65);
            this.button6.TabIndex = 13;
            this.button6.Text = "AGREGAR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.agregar);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 420);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            this.panel2.Click += new System.EventHandler(this.mostrar);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdoptaATuNuevaMascota.Properties.Resources.perrosygatos_1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.laslistas);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(318, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 394);
            this.panel3.TabIndex = 0;
            // 
            // laslistas
            // 
            this.laslistas.AutoSize = true;
            this.laslistas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laslistas.Location = new System.Drawing.Point(33, 70);
            this.laslistas.Name = "laslistas";
            this.laslistas.Size = new System.Drawing.Size(196, 15);
            this.laslistas.TabIndex = 1;
            this.laslistas.Text = "NO HAY ANIMALES REGISTRADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "LISTA DE TODOS LOS ANIMALES";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::AdoptaATuNuevaMascota.Properties.Resources.dyjfjrjr;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(24, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(614, 409);
            this.panel4.TabIndex = 6;
            // 
            // Animales_Recogidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Animales_Recogidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animales Recogidos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label laslistas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxAUX2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAUX1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox tipodeanimal;
        private System.Windows.Forms.ComboBox rancho;
        private System.Windows.Forms.ComboBox añorescate;
        private System.Windows.Forms.ComboBox mesrescate;
        private System.Windows.Forms.ComboBox diarescate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel4;
    }
}