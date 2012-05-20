namespace MorphoOp
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
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwarcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dylatacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientMorfologicznyDylatacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtracjaMaskaPrewittaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.otworzObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.obrazWePictureBox = new System.Windows.Forms.PictureBox();
            this.obrazWyPictureBox = new System.Windows.Forms.PictureBox();
            this.zamkniecieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.erozjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.filtracjaMaskaSobelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gradientMorfologicznyErozjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualnyElementLabel = new System.Windows.Forms.Label();
            this.daneElementuLabel = new System.Windows.Forms.Label();
            this.zapiszObrazWyjściowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.operacjaToolStripMenuItem,
            this.pomocToolStripMenuItem1});
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
            this.zapiszObrazWyjściowyToolStripMenuItem,
            this.toolStripSeparator1,
            this.koniecToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.pomocToolStripMenuItem.Text = "Element strukturalny";
            // 
            // operacjaToolStripMenuItem
            // 
            this.operacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwarcieToolStripMenuItem,
            this.zamkniecieToolStripMenuItem,
            this.toolStripSeparator2,
            this.dylatacjaToolStripMenuItem,
            this.erozjaToolStripMenuItem,
            this.toolStripSeparator3,
            this.filtracjaMaskaPrewittaToolStripMenuItem,
            this.filtracjaMaskaSobelaToolStripMenuItem,
            this.toolStripSeparator4,
            this.gradientMorfologicznyDylatacjaToolStripMenuItem,
            this.gradientMorfologicznyErozjaToolStripMenuItem});
            this.operacjaToolStripMenuItem.Name = "operacjaToolStripMenuItem";
            this.operacjaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operacjaToolStripMenuItem.Text = "Operacja";
            // 
            // otwarcieToolStripMenuItem
            // 
            this.otwarcieToolStripMenuItem.Name = "otwarcieToolStripMenuItem";
            this.otwarcieToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.otwarcieToolStripMenuItem.Text = "Otwarcie";
            // 
            // dylatacjaToolStripMenuItem
            // 
            this.dylatacjaToolStripMenuItem.Name = "dylatacjaToolStripMenuItem";
            this.dylatacjaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.dylatacjaToolStripMenuItem.Text = "Dylatacja";
            // 
            // gradientMorfologicznyDylatacjaToolStripMenuItem
            // 
            this.gradientMorfologicznyDylatacjaToolStripMenuItem.Name = "gradientMorfologicznyDylatacjaToolStripMenuItem";
            this.gradientMorfologicznyDylatacjaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.gradientMorfologicznyDylatacjaToolStripMenuItem.Text = "Gradient morfologiczny (dylatacja)";
            // 
            // filtracjaMaskaPrewittaToolStripMenuItem
            // 
            this.filtracjaMaskaPrewittaToolStripMenuItem.Name = "filtracjaMaskaPrewittaToolStripMenuItem";
            this.filtracjaMaskaPrewittaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.filtracjaMaskaPrewittaToolStripMenuItem.Text = "Filtracja maską Prewitta";
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            // 
            // otworzObrazToolStripMenuItem
            // 
            this.otworzObrazToolStripMenuItem.Name = "otworzObrazToolStripMenuItem";
            this.otworzObrazToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.otworzObrazToolStripMenuItem.Text = "Otwórz obraz";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // obrazWePictureBox
            // 
            this.obrazWePictureBox.Location = new System.Drawing.Point(15, 78);
            this.obrazWePictureBox.Name = "obrazWePictureBox";
            this.obrazWePictureBox.Size = new System.Drawing.Size(256, 256);
            this.obrazWePictureBox.TabIndex = 1;
            this.obrazWePictureBox.TabStop = false;
            // 
            // obrazWyPictureBox
            // 
            this.obrazWyPictureBox.Location = new System.Drawing.Point(320, 78);
            this.obrazWyPictureBox.Name = "obrazWyPictureBox";
            this.obrazWyPictureBox.Size = new System.Drawing.Size(256, 256);
            this.obrazWyPictureBox.TabIndex = 2;
            this.obrazWyPictureBox.TabStop = false;
            // 
            // zamkniecieToolStripMenuItem
            // 
            this.zamkniecieToolStripMenuItem.Name = "zamkniecieToolStripMenuItem";
            this.zamkniecieToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.zamkniecieToolStripMenuItem.Text = "Zamknięcie";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(254, 6);
            // 
            // erozjaToolStripMenuItem
            // 
            this.erozjaToolStripMenuItem.Name = "erozjaToolStripMenuItem";
            this.erozjaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.erozjaToolStripMenuItem.Text = "Erozja";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(254, 6);
            // 
            // filtracjaMaskaSobelaToolStripMenuItem
            // 
            this.filtracjaMaskaSobelaToolStripMenuItem.Name = "filtracjaMaskaSobelaToolStripMenuItem";
            this.filtracjaMaskaSobelaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.filtracjaMaskaSobelaToolStripMenuItem.Text = "Filtracja maską Sobela";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(254, 6);
            // 
            // gradientMorfologicznyErozjaToolStripMenuItem
            // 
            this.gradientMorfologicznyErozjaToolStripMenuItem.Name = "gradientMorfologicznyErozjaToolStripMenuItem";
            this.gradientMorfologicznyErozjaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.gradientMorfologicznyErozjaToolStripMenuItem.Text = "Gradient morfologiczny (erozja)";
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
            this.daneElementuLabel.Size = new System.Drawing.Size(37, 13);
            this.daneElementuLabel.TabIndex = 4;
            this.daneElementuLabel.Text = "DANE";
            // 
            // zapiszObrazWyjściowyToolStripMenuItem
            // 
            this.zapiszObrazWyjściowyToolStripMenuItem.Name = "zapiszObrazWyjściowyToolStripMenuItem";
            this.zapiszObrazWyjściowyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.zapiszObrazWyjściowyToolStripMenuItem.Text = "Zapisz obraz wyjściowy";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 346);
            this.Controls.Add(this.daneElementuLabel);
            this.Controls.Add(this.aktualnyElementLabel);
            this.Controls.Add(this.obrazWyPictureBox);
            this.Controls.Add(this.obrazWePictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MorhoOp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwarcieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dylatacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradientMorfologicznyDylatacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtracjaMaskaPrewittaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otworzObrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zamkniecieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem erozjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem filtracjaMaskaSobelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.PictureBox obrazWePictureBox;
        private System.Windows.Forms.PictureBox obrazWyPictureBox;
        private System.Windows.Forms.ToolStripMenuItem gradientMorfologicznyErozjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszObrazWyjściowyToolStripMenuItem;
        private System.Windows.Forms.Label aktualnyElementLabel;
        private System.Windows.Forms.Label daneElementuLabel;
    }
}

