namespace MorphoOp
{
    partial class WybierzElementStrukturalny
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
            this.wyborElementuComboBox = new System.Windows.Forms.ComboBox();
            this.typElementuLabel = new System.Windows.Forms.Label();
            this.promienLubBokLabel = new System.Windows.Forms.Label();
            this.nachylenieLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.potwierdzButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wyborElementuComboBox
            // 
            this.wyborElementuComboBox.FormattingEnabled = true;
            this.wyborElementuComboBox.Location = new System.Drawing.Point(123, 15);
            this.wyborElementuComboBox.Name = "wyborElementuComboBox";
            this.wyborElementuComboBox.Size = new System.Drawing.Size(121, 21);
            this.wyborElementuComboBox.TabIndex = 0;
            // 
            // typElementuLabel
            // 
            this.typElementuLabel.AutoSize = true;
            this.typElementuLabel.Location = new System.Drawing.Point(12, 15);
            this.typElementuLabel.Name = "typElementuLabel";
            this.typElementuLabel.Size = new System.Drawing.Size(74, 13);
            this.typElementuLabel.TabIndex = 1;
            this.typElementuLabel.Text = "Typ elementu:";
            // 
            // promienLubBokLabel
            // 
            this.promienLubBokLabel.AutoSize = true;
            this.promienLubBokLabel.Location = new System.Drawing.Point(12, 49);
            this.promienLubBokLabel.Name = "promienLubBokLabel";
            this.promienLubBokLabel.Size = new System.Drawing.Size(51, 13);
            this.promienLubBokLabel.TabIndex = 2;
            this.promienLubBokLabel.Text = "Wielkość";
            // 
            // nachylenieLabel
            // 
            this.nachylenieLabel.AutoSize = true;
            this.nachylenieLabel.Location = new System.Drawing.Point(12, 86);
            this.nachylenieLabel.Name = "nachylenieLabel";
            this.nachylenieLabel.Size = new System.Drawing.Size(51, 13);
            this.nachylenieLabel.TabIndex = 3;
            this.nachylenieLabel.Text = "Wielkość";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 5;
            // 
            // potwierdzButton
            // 
            this.potwierdzButton.Location = new System.Drawing.Point(169, 127);
            this.potwierdzButton.Name = "potwierdzButton";
            this.potwierdzButton.Size = new System.Drawing.Size(75, 23);
            this.potwierdzButton.TabIndex = 6;
            this.potwierdzButton.Text = "OK";
            this.potwierdzButton.UseVisualStyleBackColor = true;
            this.potwierdzButton.Click += new System.EventHandler(this.potwierdzButton_Click);
            // 
            // WybierzElementStrukturalny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 162);
            this.ControlBox = false;
            this.Controls.Add(this.potwierdzButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nachylenieLabel);
            this.Controls.Add(this.promienLubBokLabel);
            this.Controls.Add(this.typElementuLabel);
            this.Controls.Add(this.wyborElementuComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WybierzElementStrukturalny";
            this.Text = "Wybierz element strukturalny";
            this.Load += new System.EventHandler(this.WybierzElementStrukturalny_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox wyborElementuComboBox;
        private System.Windows.Forms.Label typElementuLabel;
        private System.Windows.Forms.Label promienLubBokLabel;
        private System.Windows.Forms.Label nachylenieLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button potwierdzButton;
    }
}