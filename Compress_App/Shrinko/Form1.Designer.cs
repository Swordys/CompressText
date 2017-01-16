namespace Shrinko
{
    partial class compressWrap
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
            this.resBox = new System.Windows.Forms.RichTextBox();
            this.inptBox = new System.Windows.Forms.TextBox();
            this.checkIt = new System.Windows.Forms.Button();
            this.readStuff = new System.Windows.Forms.Button();
            this.FileSize = new System.Windows.Forms.Label();
            this.sizeOfFile = new System.Windows.Forms.TextBox();
            this.compressFile = new System.Windows.Forms.Button();
            this.decompressFile = new System.Windows.Forms.Button();
            this.analitcsFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resBox
            // 
            this.resBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resBox.Location = new System.Drawing.Point(12, 91);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(440, 203);
            this.resBox.TabIndex = 0;
            this.resBox.Text = "";
            this.resBox.TextChanged += new System.EventHandler(this.resBox_TextChanged);
            // 
            // inptBox
            // 
            this.inptBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inptBox.Location = new System.Drawing.Point(15, 20);
            this.inptBox.Name = "inptBox";
            this.inptBox.Size = new System.Drawing.Size(277, 20);
            this.inptBox.TabIndex = 1;
            this.inptBox.TextChanged += new System.EventHandler(this.inptBox_TextChanged);
            // 
            // checkIt
            // 
            this.checkIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkIt.Location = new System.Drawing.Point(298, 13);
            this.checkIt.Name = "checkIt";
            this.checkIt.Size = new System.Drawing.Size(74, 32);
            this.checkIt.TabIndex = 2;
            this.checkIt.Text = "Open";
            this.checkIt.UseVisualStyleBackColor = true;
            this.checkIt.Click += new System.EventHandler(this.checkIt_Click);
            // 
            // readStuff
            // 
            this.readStuff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.readStuff.Location = new System.Drawing.Point(378, 13);
            this.readStuff.Name = "readStuff";
            this.readStuff.Size = new System.Drawing.Size(74, 32);
            this.readStuff.TabIndex = 3;
            this.readStuff.Text = "Read";
            this.readStuff.UseVisualStyleBackColor = true;
            this.readStuff.Click += new System.EventHandler(this.readStuff_Click);
            // 
            // FileSize
            // 
            this.FileSize.AutoSize = true;
            this.FileSize.Location = new System.Drawing.Point(12, 66);
            this.FileSize.Name = "FileSize";
            this.FileSize.Size = new System.Drawing.Size(27, 13);
            this.FileSize.TabIndex = 4;
            this.FileSize.Text = "Size";
            // 
            // sizeOfFile
            // 
            this.sizeOfFile.Location = new System.Drawing.Point(45, 63);
            this.sizeOfFile.Name = "sizeOfFile";
            this.sizeOfFile.Size = new System.Drawing.Size(46, 20);
            this.sizeOfFile.TabIndex = 5;
            this.sizeOfFile.TextChanged += new System.EventHandler(this.sizeOfFile_TextChanged);
            // 
            // compressFile
            // 
            this.compressFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compressFile.Location = new System.Drawing.Point(298, 51);
            this.compressFile.Name = "compressFile";
            this.compressFile.Size = new System.Drawing.Size(74, 32);
            this.compressFile.TabIndex = 6;
            this.compressFile.Text = "Compress";
            this.compressFile.UseVisualStyleBackColor = true;
            this.compressFile.Click += new System.EventHandler(this.computeFile_Click);
            // 
            // decompressFile
            // 
            this.decompressFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.decompressFile.Location = new System.Drawing.Point(378, 52);
            this.decompressFile.Name = "decompressFile";
            this.decompressFile.Size = new System.Drawing.Size(74, 31);
            this.decompressFile.TabIndex = 7;
            this.decompressFile.Text = "Decompress";
            this.decompressFile.UseVisualStyleBackColor = true;
            this.decompressFile.Click += new System.EventHandler(this.decompressFile_Click);
            // 
            // analitcsFile
            // 
            this.analitcsFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.analitcsFile.Location = new System.Drawing.Point(209, 51);
            this.analitcsFile.Name = "analitcsFile";
            this.analitcsFile.Size = new System.Drawing.Size(83, 32);
            this.analitcsFile.TabIndex = 8;
            this.analitcsFile.Text = "Analitics";
            this.analitcsFile.UseVisualStyleBackColor = true;
            this.analitcsFile.Click += new System.EventHandler(this.analitcsFile_Click);
            // 
            // compressWrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 306);
            this.Controls.Add(this.analitcsFile);
            this.Controls.Add(this.decompressFile);
            this.Controls.Add(this.compressFile);
            this.Controls.Add(this.sizeOfFile);
            this.Controls.Add(this.FileSize);
            this.Controls.Add(this.readStuff);
            this.Controls.Add(this.checkIt);
            this.Controls.Add(this.inptBox);
            this.Controls.Add(this.resBox);
            this.MinimumSize = new System.Drawing.Size(480, 345);
            this.Name = "compressWrap";
            this.Text = "Compress App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox resBox;
        private System.Windows.Forms.TextBox inptBox;
        private System.Windows.Forms.Button checkIt;
        private System.Windows.Forms.Button readStuff;
        private System.Windows.Forms.Label FileSize;
        private System.Windows.Forms.TextBox sizeOfFile;
        private System.Windows.Forms.Button compressFile;
        private System.Windows.Forms.Button decompressFile;
        private System.Windows.Forms.Button analitcsFile;
    }
}

