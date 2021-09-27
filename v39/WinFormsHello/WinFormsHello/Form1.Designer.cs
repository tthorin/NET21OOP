namespace WinFormsHello
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
            this.clickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickMe
            // 
            this.clickMe.AutoSize = true;
            this.clickMe.BackColor = System.Drawing.Color.Transparent;
            this.clickMe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clickMe.BackgroundImage")));
            this.clickMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clickMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickMe.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clickMe.Location = new System.Drawing.Point(12, 12);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(844, 444);
            this.clickMe.TabIndex = 0;
            this.clickMe.Text = "Click Me!";
            this.clickMe.UseVisualStyleBackColor = false;
            this.clickMe.Click += new System.EventHandler(this.clickMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 468);
            this.Controls.Add(this.clickMe);
            this.Name = "Form1";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickMe;
    }
}

