namespace SourceSDK.ENV.Editor.UI
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.darkLabelProductVersion = new DarkUI.Controls.DarkLabel();
            this.darkButtonOK = new DarkUI.Controls.DarkButton();
            this.darkLabelCopyright = new DarkUI.Controls.DarkLabel();
            this.darkButtonDonate = new DarkUI.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SourceSDK.ENV.Editor.Properties.Resources.crowbar_64;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // darkLabelProductVersion
            // 
            this.darkLabelProductVersion.AutoSize = true;
            this.darkLabelProductVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.darkLabelProductVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabelProductVersion.Location = new System.Drawing.Point(82, 12);
            this.darkLabelProductVersion.Name = "darkLabelProductVersion";
            this.darkLabelProductVersion.Size = new System.Drawing.Size(241, 16);
            this.darkLabelProductVersion.TabIndex = 2;
            this.darkLabelProductVersion.Text = "Application.ProductName (0.0.0.0)";
            // 
            // darkButtonOK
            // 
            this.darkButtonOK.Location = new System.Drawing.Point(262, 64);
            this.darkButtonOK.Name = "darkButtonOK";
            this.darkButtonOK.Padding = new System.Windows.Forms.Padding(5);
            this.darkButtonOK.Size = new System.Drawing.Size(75, 23);
            this.darkButtonOK.TabIndex = 3;
            this.darkButtonOK.Text = "OK";
            this.darkButtonOK.Click += new System.EventHandler(this.darkButtonOK_Click);
            // 
            // darkLabelCopyright
            // 
            this.darkLabelCopyright.AutoSize = true;
            this.darkLabelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.darkLabelCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabelCopyright.Location = new System.Drawing.Point(82, 37);
            this.darkLabelCopyright.Name = "darkLabelCopyright";
            this.darkLabelCopyright.Size = new System.Drawing.Size(194, 15);
            this.darkLabelCopyright.TabIndex = 2;
            this.darkLabelCopyright.Text = "Copyright (Company) (c) Year";
            // 
            // darkButtonDonate
            // 
            this.darkButtonDonate.Location = new System.Drawing.Point(82, 64);
            this.darkButtonDonate.Name = "darkButtonDonate";
            this.darkButtonDonate.Padding = new System.Windows.Forms.Padding(5);
            this.darkButtonDonate.Size = new System.Drawing.Size(75, 23);
            this.darkButtonDonate.TabIndex = 3;
            this.darkButtonDonate.Text = "Donate";
            this.darkButtonDonate.Click += new System.EventHandler(this.darkButtonDonate_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(349, 99);
            this.Controls.Add(this.darkButtonDonate);
            this.Controls.Add(this.darkButtonOK);
            this.Controls.Add(this.darkLabelCopyright);
            this.Controls.Add(this.darkLabelProductVersion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private DarkUI.Controls.DarkLabel darkLabelProductVersion;
        private DarkUI.Controls.DarkButton darkButtonOK;
        private DarkUI.Controls.DarkLabel darkLabelCopyright;
        private DarkUI.Controls.DarkButton darkButtonDonate;
    }
}