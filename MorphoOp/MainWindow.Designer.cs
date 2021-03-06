﻿namespace MorphoOp
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otworzObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszObrazWyjsciowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementStrukturalnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erozjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dylatacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.otwarcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamkniecieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gradientMorfologicznyDylatacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientMorfologicznyErozjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeBezESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtracjaZMaskaPrewittaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtracjaZMaskaSobelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazWejsciowyPictureBox = new System.Windows.Forms.PictureBox();
            this.obrazWyjsciowyPictureBox = new System.Windows.Forms.PictureBox();
            this.aktualnyElementLabel = new System.Windows.Forms.Label();
            this.daneElementuLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWejsciowyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWyjsciowyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.elementStrukturalnyToolStripMenuItem,
            this.operacjaToolStripMenuItem,
            this.operacjeBezESToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otworzObrazToolStripMenuItem,
            this.zapiszObrazWyjsciowyToolStripMenuItem,
            this.toolStripSeparator1,
            this.koniecToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otworzObrazToolStripMenuItem
            // 
            this.otworzObrazToolStripMenuItem.Name = "otworzObrazToolStripMenuItem";
            this.otworzObrazToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.otworzObrazToolStripMenuItem.Text = "Otwórz obraz";
            this.otworzObrazToolStripMenuItem.Click += new System.EventHandler(this.otworzObrazToolStripMenuItem_Click);
            // 
            // zapiszObrazWyjsciowyToolStripMenuItem
            // 
            this.zapiszObrazWyjsciowyToolStripMenuItem.Name = "zapiszObrazWyjsciowyToolStripMenuItem";
            this.zapiszObrazWyjsciowyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.zapiszObrazWyjsciowyToolStripMenuItem.Text = "Zapisz obraz wyjściowy";
            this.zapiszObrazWyjsciowyToolStripMenuItem.Click += new System.EventHandler(this.zapiszObrazWyjsciowyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // elementStrukturalnyToolStripMenuItem
            // 
            this.elementStrukturalnyToolStripMenuItem.Name = "elementStrukturalnyToolStripMenuItem";
            this.elementStrukturalnyToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.elementStrukturalnyToolStripMenuItem.Text = "Element strukturalny";
            this.elementStrukturalnyToolStripMenuItem.Click += new System.EventHandler(this.elementStrukturalnyToolStripMenuItem_Click);
            // 
            // operacjaToolStripMenuItem
            // 
            this.operacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erozjaToolStripMenuItem,
            this.dylatacjaToolStripMenuItem,
            this.toolStripSeparator2,
            this.otwarcieToolStripMenuItem,
            this.zamkniecieToolStripMenuItem,
            this.toolStripSeparator4,
            this.gradientMorfologicznyDylatacjaToolStripMenuItem,
            this.gradientMorfologicznyErozjaToolStripMenuItem});
            this.operacjaToolStripMenuItem.Name = "operacjaToolStripMenuItem";
            this.operacjaToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.operacjaToolStripMenuItem.Text = "Operacje z ES";
            // 
            // erozjaToolStripMenuItem
            // 
            this.erozjaToolStripMenuItem.Name = "erozjaToolStripMenuItem";
            this.erozjaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.erozjaToolStripMenuItem.Text = "Erozja";
            this.erozjaToolStripMenuItem.Click += new System.EventHandler(this.erozjaToolStripMenuItem_Click);
            // 
            // dylatacjaToolStripMenuItem
            // 
            this.dylatacjaToolStripMenuItem.Name = "dylatacjaToolStripMenuItem";
            this.dylatacjaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.dylatacjaToolStripMenuItem.Text = "Dylatacja";
            this.dylatacjaToolStripMenuItem.Click += new System.EventHandler(this.dylatacjaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(254, 6);
            // 
            // otwarcieToolStripMenuItem
            // 
            this.otwarcieToolStripMenuItem.Name = "otwarcieToolStripMenuItem";
            this.otwarcieToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.otwarcieToolStripMenuItem.Text = "Otwarcie";
            this.otwarcieToolStripMenuItem.Click += new System.EventHandler(this.otwarcieToolStripMenuItem_Click);
            // 
            // zamkniecieToolStripMenuItem
            // 
            this.zamkniecieToolStripMenuItem.Name = "zamkniecieToolStripMenuItem";
            this.zamkniecieToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.zamkniecieToolStripMenuItem.Text = "Zamknięcie";
            this.zamkniecieToolStripMenuItem.Click += new System.EventHandler(this.zamkniecieToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(254, 6);
            // 
            // gradientMorfologicznyDylatacjaToolStripMenuItem
            // 
            this.gradientMorfologicznyDylatacjaToolStripMenuItem.Name = "gradientMorfologicznyDylatacjaToolStripMenuItem";
            this.gradientMorfologicznyDylatacjaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.gradientMorfologicznyDylatacjaToolStripMenuItem.Text = "Gradient morfologiczny (dylatacja)";
            this.gradientMorfologicznyDylatacjaToolStripMenuItem.Click += new System.EventHandler(this.gradientMorfologicznyDylatacjaToolStripMenuItem_Click);
            // 
            // gradientMorfologicznyErozjaToolStripMenuItem
            // 
            this.gradientMorfologicznyErozjaToolStripMenuItem.Name = "gradientMorfologicznyErozjaToolStripMenuItem";
            this.gradientMorfologicznyErozjaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.gradientMorfologicznyErozjaToolStripMenuItem.Text = "Gradient morfologiczny (erozja)";
            this.gradientMorfologicznyErozjaToolStripMenuItem.Click += new System.EventHandler(this.gradientMorfologicznyErozjaToolStripMenuItem_Click);
            // 
            // operacjeBezESToolStripMenuItem
            // 
            this.operacjeBezESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtracjaZMaskaPrewittaToolStripMenuItem,
            this.filtracjaZMaskaSobelaToolStripMenuItem});
            this.operacjeBezESToolStripMenuItem.Name = "operacjeBezESToolStripMenuItem";
            this.operacjeBezESToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.operacjeBezESToolStripMenuItem.Text = "Operacje bez ES";
            // 
            // filtracjaZMaskaPrewittaToolStripMenuItem
            // 
            this.filtracjaZMaskaPrewittaToolStripMenuItem.Name = "filtracjaZMaskaPrewittaToolStripMenuItem";
            this.filtracjaZMaskaPrewittaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.filtracjaZMaskaPrewittaToolStripMenuItem.Text = "Filtracja z maską Prewitta";
            this.filtracjaZMaskaPrewittaToolStripMenuItem.Click += new System.EventHandler(this.filtracjaZMaskaPrewittaToolStripMenuItem_Click);
            // 
            // filtracjaZMaskaSobelaToolStripMenuItem
            // 
            this.filtracjaZMaskaSobelaToolStripMenuItem.Name = "filtracjaZMaskaSobelaToolStripMenuItem";
            this.filtracjaZMaskaSobelaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.filtracjaZMaskaSobelaToolStripMenuItem.Text = "Filtracja z maską Sobela";
            this.filtracjaZMaskaSobelaToolStripMenuItem.Click += new System.EventHandler(this.filtracjaZMaskaSobelaToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.pomocToolStripMenuItem.Text = "O programie";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // obrazWejsciowyPictureBox
            // 
            this.obrazWejsciowyPictureBox.Location = new System.Drawing.Point(15, 78);
            this.obrazWejsciowyPictureBox.Name = "obrazWejsciowyPictureBox";
            this.obrazWejsciowyPictureBox.Size = new System.Drawing.Size(256, 256);
            this.obrazWejsciowyPictureBox.TabIndex = 1;
            this.obrazWejsciowyPictureBox.TabStop = false;
            // 
            // obrazWyjsciowyPictureBox
            // 
            this.obrazWyjsciowyPictureBox.Location = new System.Drawing.Point(320, 78);
            this.obrazWyjsciowyPictureBox.Name = "obrazWyjsciowyPictureBox";
            this.obrazWyjsciowyPictureBox.Size = new System.Drawing.Size(256, 256);
            this.obrazWyjsciowyPictureBox.TabIndex = 2;
            this.obrazWyjsciowyPictureBox.TabStop = false;
            // 
            // aktualnyElementLabel
            // 
            this.aktualnyElementLabel.AutoSize = true;
            this.aktualnyElementLabel.Location = new System.Drawing.Point(12, 40);
            this.aktualnyElementLabel.Name = "aktualnyElementLabel";
            this.aktualnyElementLabel.Size = new System.Drawing.Size(150, 13);
            this.aktualnyElementLabel.TabIndex = 3;
            this.aktualnyElementLabel.Text = "Używany element strukturalny:";
            // 
            // daneElementuLabel
            // 
            this.daneElementuLabel.AutoSize = true;
            this.daneElementuLabel.Location = new System.Drawing.Point(179, 40);
            this.daneElementuLabel.Name = "daneElementuLabel";
            this.daneElementuLabel.Size = new System.Drawing.Size(36, 13);
            this.daneElementuLabel.TabIndex = 4;
            this.daneElementuLabel.Text = "BRAK";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 346);
            this.Controls.Add(this.daneElementuLabel);
            this.Controls.Add(this.aktualnyElementLabel);
            this.Controls.Add(this.obrazWyjsciowyPictureBox);
            this.Controls.Add(this.obrazWejsciowyPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(604, 384);
            this.MinimumSize = new System.Drawing.Size(604, 384);
            this.Name = "MainWindow";
            this.Text = "MorhoOp";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWejsciowyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWyjsciowyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementStrukturalnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwarcieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dylatacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradientMorfologicznyDylatacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otworzObrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zamkniecieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem erozjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.PictureBox obrazWejsciowyPictureBox;
        private System.Windows.Forms.PictureBox obrazWyjsciowyPictureBox;
        private System.Windows.Forms.ToolStripMenuItem gradientMorfologicznyErozjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszObrazWyjsciowyToolStripMenuItem;
        private System.Windows.Forms.Label aktualnyElementLabel;
        private System.Windows.Forms.Label daneElementuLabel;
        private System.Windows.Forms.ToolStripMenuItem operacjeBezESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtracjaZMaskaPrewittaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtracjaZMaskaSobelaToolStripMenuItem;
    }
}

