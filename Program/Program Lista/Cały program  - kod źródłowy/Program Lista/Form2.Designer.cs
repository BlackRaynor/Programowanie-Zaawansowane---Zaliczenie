namespace Program_Lista
{
    partial class Form2
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
            this.DodajPRr = new System.Windows.Forms.Button();
            this.UsunPR = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DodajOBZ = new System.Windows.Forms.Button();
            this.OpisIt = new System.Windows.Forms.TextBox();
            this.OpisPro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NazwaIt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DodajPRr
            // 
            this.DodajPRr.Location = new System.Drawing.Point(30, 30);
            this.DodajPRr.Name = "DodajPRr";
            this.DodajPRr.Size = new System.Drawing.Size(175, 35);
            this.DodajPRr.TabIndex = 0;
            this.DodajPRr.Text = "Dodaj Produkt";
            this.DodajPRr.UseVisualStyleBackColor = true;
            this.DodajPRr.Click += new System.EventHandler(this.DodajPRr_Click);
            // 
            // UsunPR
            // 
            this.UsunPR.Location = new System.Drawing.Point(30, 75);
            this.UsunPR.Name = "UsunPR";
            this.UsunPR.Size = new System.Drawing.Size(175, 35);
            this.UsunPR.TabIndex = 1;
            this.UsunPR.Text = "Usuń Produkt";
            this.UsunPR.UseVisualStyleBackColor = true;
            this.UsunPR.Click += new System.EventHandler(this.UsunPR_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(631, 30);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(101, 352);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // DodajOBZ
            // 
            this.DodajOBZ.Location = new System.Drawing.Point(338, 198);
            this.DodajOBZ.Name = "DodajOBZ";
            this.DodajOBZ.Size = new System.Drawing.Size(100, 20);
            this.DodajOBZ.TabIndex = 4;
            this.DodajOBZ.Text = "Dodaj Obraz";
            this.DodajOBZ.UseVisualStyleBackColor = true;
            this.DodajOBZ.Click += new System.EventHandler(this.DodajOBZ_Click);
            // 
            // OpisIt
            // 
            this.OpisIt.Location = new System.Drawing.Point(315, 276);
            this.OpisIt.Multiline = true;
            this.OpisIt.Name = "OpisIt";
            this.OpisIt.Size = new System.Drawing.Size(150, 124);
            this.OpisIt.TabIndex = 5;
            this.OpisIt.TextChanged += new System.EventHandler(this.OpisIt_TextChanged);
            // 
            // OpisPro
            // 
            this.OpisPro.AutoSize = true;
            this.OpisPro.Location = new System.Drawing.Point(375, 260);
            this.OpisPro.Name = "OpisPro";
            this.OpisPro.Size = new System.Drawing.Size(28, 13);
            this.OpisPro.TabIndex = 6;
            this.OpisPro.Text = "Opis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(265, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // NazwaIt
            // 
            this.NazwaIt.Location = new System.Drawing.Point(315, 237);
            this.NazwaIt.Multiline = true;
            this.NazwaIt.Name = "NazwaIt";
            this.NazwaIt.Size = new System.Drawing.Size(150, 20);
            this.NazwaIt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nazwa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NazwaIt);
            this.Controls.Add(this.OpisPro);
            this.Controls.Add(this.OpisIt);
            this.Controls.Add(this.DodajOBZ);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.UsunPR);
            this.Controls.Add(this.DodajPRr);
            this.Name = "Form2";
            this.Text = "Baza produktów";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajPRr;
        private System.Windows.Forms.Button UsunPR;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DodajOBZ;
        private System.Windows.Forms.TextBox OpisIt;
        private System.Windows.Forms.Label OpisPro;
        private System.Windows.Forms.TextBox NazwaIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}