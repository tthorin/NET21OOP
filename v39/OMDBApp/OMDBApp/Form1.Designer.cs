namespace OMDBApp
{

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultListBox = new System.Windows.Forms.ListBox();
            this.posterPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.moreButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.movieInfotextBox = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(279, 23);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(375, 392);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(297, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultListBox
            // 
            this.searchResultListBox.FormattingEnabled = true;
            this.searchResultListBox.ItemHeight = 15;
            this.searchResultListBox.Items.AddRange(new object[] {
            "Search result..."});
            this.searchResultListBox.Location = new System.Drawing.Point(635, 640);
            this.searchResultListBox.Name = "searchResultListBox";
            this.searchResultListBox.Size = new System.Drawing.Size(360, 154);
            this.searchResultListBox.TabIndex = 2;
            this.searchResultListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // posterPictureBox
            // 
            this.posterPictureBox.Location = new System.Drawing.Point(795, 59);
            this.posterPictureBox.Name = "posterPictureBox";
            this.posterPictureBox.Size = new System.Drawing.Size(249, 309);
            this.posterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.posterPictureBox.TabIndex = 6;
            this.posterPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search results:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 269);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // moreButton
            // 
            this.moreButton.Location = new System.Drawing.Point(297, 269);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(75, 23);
            this.moreButton.TabIndex = 4;
            this.moreButton.Text = "More";
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Awaiting search result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 299);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(360, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // movieInfotextBox
            // 
            this.movieInfotextBox.Location = new System.Drawing.Point(379, 59);
            this.movieInfotextBox.Multiline = true;
            this.movieInfotextBox.Name = "movieInfotextBox";
            this.movieInfotextBox.Size = new System.Drawing.Size(410, 202);
            this.movieInfotextBox.TabIndex = 12;
            this.movieInfotextBox.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 59);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(360, 202);
            this.treeView1.TabIndex = 13;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1081, 861);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.movieInfotextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posterPictureBox);
            this.Controls.Add(this.searchResultListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OMDB";
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox searchResultListBox;
        private System.Windows.Forms.PictureBox posterPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button moreButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox movieInfotextBox;
        private System.Windows.Forms.TreeView treeView1;
    }
}

