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
            this.posterPictureBox = new System.Windows.Forms.PictureBox();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.moreButton = new System.Windows.Forms.Button();
            this.resultCountLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.movieInfotextBox = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.plotCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.posterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(279, 23);
            this.searchTextBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(378, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "&Clear All";
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
            // posterPictureBox
            // 
            this.posterPictureBox.Location = new System.Drawing.Point(378, 59);
            this.posterPictureBox.Name = "posterPictureBox";
            this.posterPictureBox.Size = new System.Drawing.Size(360, 471);
            this.posterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.posterPictureBox.TabIndex = 6;
            this.posterPictureBox.TabStop = false;
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(12, 41);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(82, 15);
            this.searchResultLabel.TabIndex = 4;
            this.searchResultLabel.Text = "Search results:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 269);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // moreButton
            // 
            this.moreButton.Location = new System.Drawing.Point(297, 269);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(75, 23);
            this.moreButton.TabIndex = 8;
            this.moreButton.Text = "More";
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultCountLabel
            // 
            this.resultCountLabel.AutoSize = true;
            this.resultCountLabel.Location = new System.Drawing.Point(93, 273);
            this.resultCountLabel.Name = "resultCountLabel";
            this.resultCountLabel.Size = new System.Drawing.Size(123, 15);
            this.resultCountLabel.TabIndex = 7;
            this.resultCountLabel.Text = "Awaiting search result";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 299);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(360, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // movieInfotextBox
            // 
            this.movieInfotextBox.Location = new System.Drawing.Point(12, 328);
            this.movieInfotextBox.Multiline = true;
            this.movieInfotextBox.Name = "movieInfotextBox";
            this.movieInfotextBox.ReadOnly = true;
            this.movieInfotextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.movieInfotextBox.Size = new System.Drawing.Size(360, 202);
            this.movieInfotextBox.TabIndex = 10;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 59);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(360, 202);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            // 
            // plotCheckBox
            // 
            this.plotCheckBox.AutoSize = true;
            this.plotCheckBox.Location = new System.Drawing.Point(459, 14);
            this.plotCheckBox.Name = "plotCheckBox";
            this.plotCheckBox.Size = new System.Drawing.Size(91, 19);
            this.plotCheckBox.TabIndex = 3;
            this.plotCheckBox.Text = "Get full plot.";
            this.plotCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(753, 546);
            this.Controls.Add(this.plotCheckBox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.movieInfotextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.resultCountLabel);
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.posterPictureBox);
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
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.PictureBox posterPictureBox;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label resultCountLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox movieInfotextBox;
        internal System.Windows.Forms.TextBox searchTextBox;
        internal System.Windows.Forms.Button moreButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox plotCheckBox;
    }
}

