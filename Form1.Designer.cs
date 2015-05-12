namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pravoukutnik = new System.Windows.Forms.RadioButton();
            this.Elipsa = new System.Windows.Forms.RadioButton();
            this.Linija = new System.Windows.Forms.RadioButton();
            this.Ispuna = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Boja_ispune = new System.Windows.Forms.Button();
            this.Boja_olovke = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Olovka = new System.Windows.Forms.RadioButton();
            this.Kantica_boje = new System.Windows.Forms.CheckBox();
            this.Kanta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pravoukutnik
            // 
            this.Pravoukutnik.AutoSize = true;
            this.Pravoukutnik.Location = new System.Drawing.Point(6, 51);
            this.Pravoukutnik.Name = "Pravoukutnik";
            this.Pravoukutnik.Size = new System.Drawing.Size(82, 17);
            this.Pravoukutnik.TabIndex = 0;
            this.Pravoukutnik.TabStop = true;
            this.Pravoukutnik.Text = "Pravokutnik";
            this.Pravoukutnik.UseVisualStyleBackColor = true;
            // 
            // Elipsa
            // 
            this.Elipsa.AutoSize = true;
            this.Elipsa.Location = new System.Drawing.Point(6, 74);
            this.Elipsa.Name = "Elipsa";
            this.Elipsa.Size = new System.Drawing.Size(53, 17);
            this.Elipsa.TabIndex = 1;
            this.Elipsa.TabStop = true;
            this.Elipsa.Text = "Elipsa";
            this.Elipsa.UseVisualStyleBackColor = true;
            // 
            // Linija
            // 
            this.Linija.AutoSize = true;
            this.Linija.Location = new System.Drawing.Point(6, 98);
            this.Linija.Name = "Linija";
            this.Linija.Size = new System.Drawing.Size(49, 17);
            this.Linija.TabIndex = 2;
            this.Linija.TabStop = true;
            this.Linija.Text = "Linija";
            this.Linija.UseVisualStyleBackColor = true;
            // 
            // Ispuna
            // 
            this.Ispuna.AutoSize = true;
            this.Ispuna.Location = new System.Drawing.Point(6, 31);
            this.Ispuna.Name = "Ispuna";
            this.Ispuna.Size = new System.Drawing.Size(93, 17);
            this.Ispuna.TabIndex = 4;
            this.Ispuna.Text = "Ispuna Likova";
            this.Ispuna.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.Maroon;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.ShowHelp = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // Boja_ispune
            // 
            this.Boja_ispune.BackColor = System.Drawing.SystemColors.Window;
            this.Boja_ispune.Location = new System.Drawing.Point(99, 28);
            this.Boja_ispune.Name = "Boja_ispune";
            this.Boja_ispune.Size = new System.Drawing.Size(67, 23);
            this.Boja_ispune.TabIndex = 7;
            this.Boja_ispune.Text = "Boja";
            this.Boja_ispune.UseVisualStyleBackColor = false;
            this.Boja_ispune.Click += new System.EventHandler(this.Boja_ispune_Click);
            // 
            // Boja_olovke
            // 
            this.Boja_olovke.BackColor = System.Drawing.SystemColors.Window;
            this.Boja_olovke.Location = new System.Drawing.Point(91, 25);
            this.Boja_olovke.Name = "Boja_olovke";
            this.Boja_olovke.Size = new System.Drawing.Size(75, 23);
            this.Boja_olovke.TabIndex = 8;
            this.Boja_olovke.Text = "Boja";
            this.Boja_olovke.UseVisualStyleBackColor = false;
            this.Boja_olovke.Click += new System.EventHandler(this.Boja_olovke_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(998, 349);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Olovka
            // 
            this.Olovka.AutoSize = true;
            this.Olovka.Location = new System.Drawing.Point(6, 28);
            this.Olovka.Name = "Olovka";
            this.Olovka.Size = new System.Drawing.Size(59, 17);
            this.Olovka.TabIndex = 11;
            this.Olovka.TabStop = true;
            this.Olovka.Text = "Olovka";
            this.Olovka.UseVisualStyleBackColor = true;
            // 
            // Kantica_boje
            // 
            this.Kantica_boje.AutoSize = true;
            this.Kantica_boje.Location = new System.Drawing.Point(6, 54);
            this.Kantica_boje.Name = "Kantica_boje";
            this.Kantica_boje.Size = new System.Drawing.Size(93, 17);
            this.Kantica_boje.TabIndex = 12;
            this.Kantica_boje.Text = "Boja pozadine";
            this.Kantica_boje.UseVisualStyleBackColor = true;
            // 
            // Kanta
            // 
            this.Kanta.BackColor = System.Drawing.SystemColors.Window;
            this.Kanta.Location = new System.Drawing.Point(99, 52);
            this.Kanta.Name = "Kanta";
            this.Kanta.Size = new System.Drawing.Size(67, 23);
            this.Kanta.TabIndex = 13;
            this.Kanta.Text = "Boja";
            this.Kanta.UseVisualStyleBackColor = false;
            this.Kanta.Click += new System.EventHandler(this.Kanta_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Debljina linije";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Olovka);
            this.groupBox1.Controls.Add(this.Pravoukutnik);
            this.groupBox1.Controls.Add(this.Elipsa);
            this.groupBox1.Controls.Add(this.Linija);
            this.groupBox1.Controls.Add(this.Boja_olovke);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 129);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izaberite alat za crtanje";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Ispuna);
            this.groupBox2.Controls.Add(this.Kantica_boje);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Kanta);
            this.groupBox2.Controls.Add(this.Boja_ispune);
            this.groupBox2.Location = new System.Drawing.Point(191, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 129);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodatne opcije";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Pravoukutnik;
        private System.Windows.Forms.RadioButton Elipsa;
        private System.Windows.Forms.RadioButton Linija;
        private System.Windows.Forms.CheckBox Ispuna;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Boja_ispune;
        private System.Windows.Forms.Button Boja_olovke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Olovka;
        private System.Windows.Forms.CheckBox Kantica_boje;
        private System.Windows.Forms.Button Kanta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;

    }
}

