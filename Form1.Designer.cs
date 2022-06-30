namespace DBStringDecrypter_Framework
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
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.txtEodsFile = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncrypted.Location = new System.Drawing.Point(19, 84);
            this.txtEncrypted.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(840, 134);
            this.txtEncrypted.TabIndex = 2;
            // 
            // txtEodsFile
            // 
            this.txtEodsFile.AllowDrop = true;
            this.txtEodsFile.Location = new System.Drawing.Point(143, 19);
            this.txtEodsFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEodsFile.Name = "txtEodsFile";
            this.txtEodsFile.Size = new System.Drawing.Size(634, 23);
            this.txtEodsFile.TabIndex = 1;
            this.txtEodsFile.TextChanged += new System.EventHandler(this.txtEodsFile_TextChanged);
            this.txtEodsFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtEodsFile_DragDrop);
            this.txtEodsFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // lblPath
            // 
            this.lblPath.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPath.Location = new System.Drawing.Point(19, 9);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(128, 38);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "eods.dll Path:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEncrypt.Location = new System.Drawing.Point(14, 59);
            this.lblEncrypt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(104, 19);
            this.lblEncrypt.TabIndex = 3;
            this.lblEncrypt.Text = "Encrypted Text:";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecrypted.Location = new System.Drawing.Point(19, 270);
            this.txtDecrypted.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(840, 159);
            this.txtDecrypted.TabIndex = 3;
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDecrypt.Location = new System.Drawing.Point(14, 245);
            this.lblDecrypt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(106, 19);
            this.lblDecrypt.TabIndex = 3;
            this.lblDecrypt.Text = "Decrypted Text:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecrypt.Location = new System.Drawing.Point(244, 224);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(105, 31);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "↓ decrypt ↓";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.Location = new System.Drawing.Point(516, 224);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(105, 31);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "↑ encrypt ↑";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(784, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 441);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblDecrypt);
            this.Controls.Add(this.lblEncrypt);
            this.Controls.Add(this.txtEodsFile);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.txtEncrypted);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(890, 480);
            this.MinimumSize = new System.Drawing.Size(890, 460);
            this.Name = "Form1";
            this.Text = "Wyn链接字符串加解密工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.TextBox txtEodsFile;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblEncrypt;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label lblDecrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnBrowse;

    }
}

