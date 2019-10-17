namespace AutoKey_Cipher
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plaintextlabel = new System.Windows.Forms.Label();
            this.plainText = new System.Windows.Forms.TextBox();
            this.encryptkeylabel = new System.Windows.Forms.Label();
            this.encryptkey = new System.Windows.Forms.TextBox();
            this.encryptbutton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(304, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to AutoKey Cipher!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.decryptionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newToolStripMenuItem.Text = "Encryption";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // decryptionToolStripMenuItem
            // 
            this.decryptionToolStripMenuItem.Name = "decryptionToolStripMenuItem";
            this.decryptionToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.decryptionToolStripMenuItem.Text = "Decryption";
            this.decryptionToolStripMenuItem.Click += new System.EventHandler(this.decryptionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.developerToolStripMenuItem.Text = "Developer";
            this.developerToolStripMenuItem.Click += new System.EventHandler(this.developerToolStripMenuItem_Click);
            // 
            // plaintextlabel
            // 
            this.plaintextlabel.AutoSize = true;
            this.plaintextlabel.BackColor = System.Drawing.Color.Transparent;
            this.plaintextlabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plaintextlabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.plaintextlabel.Location = new System.Drawing.Point(16, 341);
            this.plaintextlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plaintextlabel.Name = "plaintextlabel";
            this.plaintextlabel.Size = new System.Drawing.Size(203, 49);
            this.plaintextlabel.TabIndex = 2;
            this.plaintextlabel.Text = "Plain Text :";
            // 
            // plainText
            // 
            this.plainText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.plainText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.plainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainText.Location = new System.Drawing.Point(351, 354);
            this.plainText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(347, 30);
            this.plainText.TabIndex = 3;
            this.plainText.TextChanged += new System.EventHandler(this.plaintext_TextChanged);
            // 
            // encryptkeylabel
            // 
            this.encryptkeylabel.AutoSize = true;
            this.encryptkeylabel.BackColor = System.Drawing.Color.Transparent;
            this.encryptkeylabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptkeylabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.encryptkeylabel.Location = new System.Drawing.Point(11, 410);
            this.encryptkeylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.encryptkeylabel.Name = "encryptkeylabel";
            this.encryptkeylabel.Size = new System.Drawing.Size(282, 49);
            this.encryptkeylabel.TabIndex = 4;
            this.encryptkeylabel.Text = "Encryption Key :";
            this.encryptkeylabel.Click += new System.EventHandler(this.encryptkeylabel_Click);
            // 
            // encryptkey
            // 
            this.encryptkey.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.encryptkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.encryptkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptkey.Location = new System.Drawing.Point(351, 423);
            this.encryptkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encryptkey.Name = "encryptkey";
            this.encryptkey.Size = new System.Drawing.Size(347, 30);
            this.encryptkey.TabIndex = 5;
            this.encryptkey.TextChanged += new System.EventHandler(this.encryptkey_TextChanged);
            // 
            // encryptbutton
            // 
            this.encryptbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.encryptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.encryptbutton.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptbutton.ForeColor = System.Drawing.Color.Black;
            this.encryptbutton.Location = new System.Drawing.Point(405, 510);
            this.encryptbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encryptbutton.Name = "encryptbutton";
            this.encryptbutton.Size = new System.Drawing.Size(169, 52);
            this.encryptbutton.TabIndex = 6;
            this.encryptbutton.Text = "ENCRYPT";
            this.encryptbutton.UseVisualStyleBackColor = false;
            this.encryptbutton.Click += new System.EventHandler(this.encryptbutton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.resultLabel.Location = new System.Drawing.Point(20, 585);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(129, 31);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Result : ";
            this.resultLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AutoKey_Cipher.Properties.Resources.keyicon;
            this.pictureBox1.Location = new System.Drawing.Point(25, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 230);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(313, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 155);
            this.label2.TabIndex = 10;
            this.label2.Text = "Program Functionalities :\r\n\r\n1. Encrypt Plain Text to Cipher Text\r\n\r\n2. Decrypt C" +
    "ipher Text to Plain Text";
            // 
            // Form1
            // 
            this.AcceptButton = this.encryptbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoKey_Cipher.Properties.Resources.q438934nfsn;
            this.ClientSize = new System.Drawing.Size(956, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.encryptbutton);
            this.Controls.Add(this.encryptkey);
            this.Controls.Add(this.encryptkeylabel);
            this.Controls.Add(this.plainText);
            this.Controls.Add(this.plaintextlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoKey Cipher By Yatish";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.Label plaintextlabel;
        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.Label encryptkeylabel;
        private System.Windows.Forms.TextBox encryptkey;
        private System.Windows.Forms.Button encryptbutton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem decryptionToolStripMenuItem;
    }
}

