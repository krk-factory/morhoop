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
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwarcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dylatacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientMorfologicznyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtracjaMaskaPrewittaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.koniecToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
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
            this.dylatacjaToolStripMenuItem,
            this.gradientMorfologicznyToolStripMenuItem,
            this.filtracjaMaskaPrewittaToolStripMenuItem});
            this.operacjaToolStripMenuItem.Name = "operacjaToolStripMenuItem";
            this.operacjaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.operacjaToolStripMenuItem.Text = "Operacja";
            // 
            // otwarcieToolStripMenuItem
            // 
            this.otwarcieToolStripMenuItem.Name = "otwarcieToolStripMenuItem";
            this.otwarcieToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.otwarcieToolStripMenuItem.Text = "Otwarcie";
            // 
            // dylatacjaToolStripMenuItem
            // 
            this.dylatacjaToolStripMenuItem.Name = "dylatacjaToolStripMenuItem";
            this.dylatacjaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dylatacjaToolStripMenuItem.Text = "Dylatacja";
            // 
            // gradientMorfologicznyToolStripMenuItem
            // 
            this.gradientMorfologicznyToolStripMenuItem.Name = "gradientMorfologicznyToolStripMenuItem";
            this.gradientMorfologicznyToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.gradientMorfologicznyToolStripMenuItem.Text = "Gradient morfologiczny";
            // 
            // filtracjaMaskaPrewittaToolStripMenuItem
            // 
            this.filtracjaMaskaPrewittaToolStripMenuItem.Name = "filtracjaMaskaPrewittaToolStripMenuItem";
            this.filtracjaMaskaPrewittaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.filtracjaMaskaPrewittaToolStripMenuItem.Text = "Filtracja maska Prewitta";
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 354);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MorpoOp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem gradientMorfologicznyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtracjaMaskaPrewittaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
    }
}

