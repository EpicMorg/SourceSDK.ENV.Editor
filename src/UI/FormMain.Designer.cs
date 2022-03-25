namespace SourceSDK.ENV.Editor.UI
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxVMod = new System.Windows.Forms.GroupBox();
            this.buttonResetVMod = new System.Windows.Forms.Button();
            this.buttonApplyVMod = new System.Windows.Forms.Button();
            this.textBoxVMod = new System.Windows.Forms.TextBox();
            this.pictureBoxVMod = new System.Windows.Forms.PictureBox();
            this.groupBoxVProject = new System.Windows.Forms.GroupBox();
            this.buttonBrowseVProject = new System.Windows.Forms.Button();
            this.buttonResetVProject = new System.Windows.Forms.Button();
            this.buttonApplyVProject = new System.Windows.Forms.Button();
            this.textBoxVProject = new System.Windows.Forms.TextBox();
            this.pictureBoxVProject = new System.Windows.Forms.PictureBox();
            this.groupBoxVGame = new System.Windows.Forms.GroupBox();
            this.buttonBrowseVGame = new System.Windows.Forms.Button();
            this.buttonResetVGame = new System.Windows.Forms.Button();
            this.buttonApplyVGame = new System.Windows.Forms.Button();
            this.textBoxVGame = new System.Windows.Forms.TextBox();
            this.pictureBoxVGame = new System.Windows.Forms.PictureBox();
            this.groupBoxVContent = new System.Windows.Forms.GroupBox();
            this.buttonBrowseVContent = new System.Windows.Forms.Button();
            this.buttonResetVContent = new System.Windows.Forms.Button();
            this.buttonApplyVContent = new System.Windows.Forms.Button();
            this.textBoxVContent = new System.Windows.Forms.TextBox();
            this.pictureBoxVContent = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonBrowseVTools = new System.Windows.Forms.Button();
            this.buttonResetVTools = new System.Windows.Forms.Button();
            this.buttonApplyVTools = new System.Windows.Forms.Button();
            this.textBoxVTools = new System.Windows.Forms.TextBox();
            this.pictureBoxVTools = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.groupBoxVMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVMod)).BeginInit();
            this.groupBoxVProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVProject)).BeginInit();
            this.groupBoxVGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVGame)).BeginInit();
            this.groupBoxVContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVContent)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVTools)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(653, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::SourceSDK.ENV.Editor.Properties.Resources.refresh16;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SourceSDK.ENV.Editor.Properties.Resources.power_on;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::SourceSDK.ENV.Editor.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBoxVMod
            // 
            this.groupBoxVMod.Controls.Add(this.buttonResetVMod);
            this.groupBoxVMod.Controls.Add(this.buttonApplyVMod);
            this.groupBoxVMod.Controls.Add(this.textBoxVMod);
            this.groupBoxVMod.Controls.Add(this.pictureBoxVMod);
            this.groupBoxVMod.Location = new System.Drawing.Point(12, 27);
            this.groupBoxVMod.Name = "groupBoxVMod";
            this.groupBoxVMod.Size = new System.Drawing.Size(629, 87);
            this.groupBoxVMod.TabIndex = 1;
            this.groupBoxVMod.TabStop = false;
            this.groupBoxVMod.Text = "VMod (SSDK)";
            // 
            // buttonResetVMod
            // 
            this.buttonResetVMod.Image = global::SourceSDK.ENV.Editor.Properties.Resources.remove;
            this.buttonResetVMod.Location = new System.Drawing.Point(467, 51);
            this.buttonResetVMod.Name = "buttonResetVMod";
            this.buttonResetVMod.Size = new System.Drawing.Size(75, 23);
            this.buttonResetVMod.TabIndex = 2;
            this.buttonResetVMod.UseVisualStyleBackColor = true;
            // 
            // buttonApplyVMod
            // 
            this.buttonApplyVMod.Image = global::SourceSDK.ENV.Editor.Properties.Resources.check;
            this.buttonApplyVMod.Location = new System.Drawing.Point(548, 51);
            this.buttonApplyVMod.Name = "buttonApplyVMod";
            this.buttonApplyVMod.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyVMod.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonApplyVMod, "asdss");
            this.buttonApplyVMod.UseVisualStyleBackColor = true;
            // 
            // textBoxVMod
            // 
            this.textBoxVMod.Location = new System.Drawing.Point(28, 22);
            this.textBoxVMod.Name = "textBoxVMod";
            this.textBoxVMod.PlaceholderText = "MyMod";
            this.textBoxVMod.Size = new System.Drawing.Size(595, 23);
            this.textBoxVMod.TabIndex = 1;
            // 
            // pictureBoxVMod
            // 
            this.pictureBoxVMod.Image = global::SourceSDK.ENV.Editor.Properties.Resources.cancel;
            this.pictureBoxVMod.Location = new System.Drawing.Point(6, 26);
            this.pictureBoxVMod.Name = "pictureBoxVMod";
            this.pictureBoxVMod.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxVMod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxVMod.TabIndex = 0;
            this.pictureBoxVMod.TabStop = false;
            // 
            // groupBoxVProject
            // 
            this.groupBoxVProject.Controls.Add(this.buttonBrowseVProject);
            this.groupBoxVProject.Controls.Add(this.buttonResetVProject);
            this.groupBoxVProject.Controls.Add(this.buttonApplyVProject);
            this.groupBoxVProject.Controls.Add(this.textBoxVProject);
            this.groupBoxVProject.Controls.Add(this.pictureBoxVProject);
            this.groupBoxVProject.Location = new System.Drawing.Point(12, 120);
            this.groupBoxVProject.Name = "groupBoxVProject";
            this.groupBoxVProject.Size = new System.Drawing.Size(629, 87);
            this.groupBoxVProject.TabIndex = 1;
            this.groupBoxVProject.TabStop = false;
            this.groupBoxVProject.Text = "VProject (SSDK)";
            // 
            // buttonBrowseVProject
            // 
            this.buttonBrowseVProject.Location = new System.Drawing.Point(548, 22);
            this.buttonBrowseVProject.Name = "buttonBrowseVProject";
            this.buttonBrowseVProject.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseVProject.TabIndex = 3;
            this.buttonBrowseVProject.Text = "...";
            this.buttonBrowseVProject.UseVisualStyleBackColor = true;
            // 
            // buttonResetVProject
            // 
            this.buttonResetVProject.Image = global::SourceSDK.ENV.Editor.Properties.Resources.remove;
            this.buttonResetVProject.Location = new System.Drawing.Point(467, 51);
            this.buttonResetVProject.Name = "buttonResetVProject";
            this.buttonResetVProject.Size = new System.Drawing.Size(75, 23);
            this.buttonResetVProject.TabIndex = 2;
            this.buttonResetVProject.UseVisualStyleBackColor = true;
            // 
            // buttonApplyVProject
            // 
            this.buttonApplyVProject.Image = global::SourceSDK.ENV.Editor.Properties.Resources.check;
            this.buttonApplyVProject.Location = new System.Drawing.Point(548, 51);
            this.buttonApplyVProject.Name = "buttonApplyVProject";
            this.buttonApplyVProject.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyVProject.TabIndex = 2;
            this.buttonApplyVProject.UseVisualStyleBackColor = true;
            // 
            // textBoxVProject
            // 
            this.textBoxVProject.Location = new System.Drawing.Point(28, 22);
            this.textBoxVProject.Name = "textBoxVProject";
            this.textBoxVProject.PlaceholderText = "C:\\Program Files\\Steam\\steamapps\\sourcemods\\MyMod";
            this.textBoxVProject.Size = new System.Drawing.Size(514, 23);
            this.textBoxVProject.TabIndex = 1;
            // 
            // pictureBoxVProject
            // 
            this.pictureBoxVProject.Image = global::SourceSDK.ENV.Editor.Properties.Resources.cancel;
            this.pictureBoxVProject.Location = new System.Drawing.Point(6, 26);
            this.pictureBoxVProject.Name = "pictureBoxVProject";
            this.pictureBoxVProject.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxVProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxVProject.TabIndex = 0;
            this.pictureBoxVProject.TabStop = false;
            // 
            // groupBoxVGame
            // 
            this.groupBoxVGame.Controls.Add(this.buttonBrowseVGame);
            this.groupBoxVGame.Controls.Add(this.buttonResetVGame);
            this.groupBoxVGame.Controls.Add(this.buttonApplyVGame);
            this.groupBoxVGame.Controls.Add(this.textBoxVGame);
            this.groupBoxVGame.Controls.Add(this.pictureBoxVGame);
            this.groupBoxVGame.Location = new System.Drawing.Point(12, 213);
            this.groupBoxVGame.Name = "groupBoxVGame";
            this.groupBoxVGame.Size = new System.Drawing.Size(629, 87);
            this.groupBoxVGame.TabIndex = 1;
            this.groupBoxVGame.TabStop = false;
            this.groupBoxVGame.Text = "VGame (SFM)";
            // 
            // buttonBrowseVGame
            // 
            this.buttonBrowseVGame.Location = new System.Drawing.Point(548, 22);
            this.buttonBrowseVGame.Name = "buttonBrowseVGame";
            this.buttonBrowseVGame.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseVGame.TabIndex = 3;
            this.buttonBrowseVGame.Text = "...";
            this.buttonBrowseVGame.UseVisualStyleBackColor = true;
            // 
            // buttonResetVGame
            // 
            this.buttonResetVGame.Image = global::SourceSDK.ENV.Editor.Properties.Resources.remove;
            this.buttonResetVGame.Location = new System.Drawing.Point(467, 51);
            this.buttonResetVGame.Name = "buttonResetVGame";
            this.buttonResetVGame.Size = new System.Drawing.Size(75, 23);
            this.buttonResetVGame.TabIndex = 2;
            this.buttonResetVGame.UseVisualStyleBackColor = true;
            // 
            // buttonApplyVGame
            // 
            this.buttonApplyVGame.Image = global::SourceSDK.ENV.Editor.Properties.Resources.check;
            this.buttonApplyVGame.Location = new System.Drawing.Point(548, 51);
            this.buttonApplyVGame.Name = "buttonApplyVGame";
            this.buttonApplyVGame.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyVGame.TabIndex = 2;
            this.buttonApplyVGame.UseVisualStyleBackColor = true;
            // 
            // textBoxVGame
            // 
            this.textBoxVGame.Location = new System.Drawing.Point(28, 22);
            this.textBoxVGame.Name = "textBoxVGame";
            this.textBoxVGame.PlaceholderText = "C:\\Program Files\\Steam\\steamapps\\common\\SourceFilmmaker\\game";
            this.textBoxVGame.Size = new System.Drawing.Size(514, 23);
            this.textBoxVGame.TabIndex = 1;
            // 
            // pictureBoxVGame
            // 
            this.pictureBoxVGame.Image = global::SourceSDK.ENV.Editor.Properties.Resources.cancel;
            this.pictureBoxVGame.Location = new System.Drawing.Point(6, 26);
            this.pictureBoxVGame.Name = "pictureBoxVGame";
            this.pictureBoxVGame.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxVGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxVGame.TabIndex = 0;
            this.pictureBoxVGame.TabStop = false;
            // 
            // groupBoxVContent
            // 
            this.groupBoxVContent.Controls.Add(this.buttonBrowseVContent);
            this.groupBoxVContent.Controls.Add(this.buttonResetVContent);
            this.groupBoxVContent.Controls.Add(this.buttonApplyVContent);
            this.groupBoxVContent.Controls.Add(this.textBoxVContent);
            this.groupBoxVContent.Controls.Add(this.pictureBoxVContent);
            this.groupBoxVContent.Location = new System.Drawing.Point(12, 306);
            this.groupBoxVContent.Name = "groupBoxVContent";
            this.groupBoxVContent.Size = new System.Drawing.Size(629, 87);
            this.groupBoxVContent.TabIndex = 1;
            this.groupBoxVContent.TabStop = false;
            this.groupBoxVContent.Text = "VContent (SFM)";
            // 
            // buttonBrowseVContent
            // 
            this.buttonBrowseVContent.Location = new System.Drawing.Point(548, 22);
            this.buttonBrowseVContent.Name = "buttonBrowseVContent";
            this.buttonBrowseVContent.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseVContent.TabIndex = 3;
            this.buttonBrowseVContent.Text = "...";
            this.buttonBrowseVContent.UseVisualStyleBackColor = true;
            // 
            // buttonResetVContent
            // 
            this.buttonResetVContent.Image = global::SourceSDK.ENV.Editor.Properties.Resources.remove;
            this.buttonResetVContent.Location = new System.Drawing.Point(467, 51);
            this.buttonResetVContent.Name = "buttonResetVContent";
            this.buttonResetVContent.Size = new System.Drawing.Size(75, 23);
            this.buttonResetVContent.TabIndex = 2;
            this.buttonResetVContent.UseVisualStyleBackColor = true;
            // 
            // buttonApplyVContent
            // 
            this.buttonApplyVContent.Image = global::SourceSDK.ENV.Editor.Properties.Resources.check;
            this.buttonApplyVContent.Location = new System.Drawing.Point(548, 51);
            this.buttonApplyVContent.Name = "buttonApplyVContent";
            this.buttonApplyVContent.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyVContent.TabIndex = 2;
            this.buttonApplyVContent.UseVisualStyleBackColor = true;
            // 
            // textBoxVContent
            // 
            this.textBoxVContent.Location = new System.Drawing.Point(28, 22);
            this.textBoxVContent.Name = "textBoxVContent";
            this.textBoxVContent.PlaceholderText = "C:\\Program Files\\Steam\\steamapps\\common\\SourceFilmmaker\\content";
            this.textBoxVContent.Size = new System.Drawing.Size(514, 23);
            this.textBoxVContent.TabIndex = 1;
            // 
            // pictureBoxVContent
            // 
            this.pictureBoxVContent.Image = global::SourceSDK.ENV.Editor.Properties.Resources.cancel;
            this.pictureBoxVContent.Location = new System.Drawing.Point(6, 26);
            this.pictureBoxVContent.Name = "pictureBoxVContent";
            this.pictureBoxVContent.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxVContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxVContent.TabIndex = 0;
            this.pictureBoxVContent.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonBrowseVTools);
            this.groupBox5.Controls.Add(this.buttonResetVTools);
            this.groupBox5.Controls.Add(this.buttonApplyVTools);
            this.groupBox5.Controls.Add(this.textBoxVTools);
            this.groupBox5.Controls.Add(this.pictureBoxVTools);
            this.groupBox5.Location = new System.Drawing.Point(12, 399);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(629, 87);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VTools (SFM)";
            // 
            // buttonBrowseVTools
            // 
            this.buttonBrowseVTools.Location = new System.Drawing.Point(548, 22);
            this.buttonBrowseVTools.Name = "buttonBrowseVTools";
            this.buttonBrowseVTools.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseVTools.TabIndex = 3;
            this.buttonBrowseVTools.Text = "...";
            this.buttonBrowseVTools.UseVisualStyleBackColor = true;
            // 
            // buttonResetVTools
            // 
            this.buttonResetVTools.Image = global::SourceSDK.ENV.Editor.Properties.Resources.remove;
            this.buttonResetVTools.Location = new System.Drawing.Point(467, 51);
            this.buttonResetVTools.Name = "buttonResetVTools";
            this.buttonResetVTools.Size = new System.Drawing.Size(75, 23);
            this.buttonResetVTools.TabIndex = 2;
            this.buttonResetVTools.UseVisualStyleBackColor = true;
            // 
            // buttonApplyVTools
            // 
            this.buttonApplyVTools.Image = global::SourceSDK.ENV.Editor.Properties.Resources.check;
            this.buttonApplyVTools.Location = new System.Drawing.Point(548, 51);
            this.buttonApplyVTools.Name = "buttonApplyVTools";
            this.buttonApplyVTools.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyVTools.TabIndex = 2;
            this.buttonApplyVTools.UseVisualStyleBackColor = true;
            // 
            // textBoxVTools
            // 
            this.textBoxVTools.Location = new System.Drawing.Point(28, 22);
            this.textBoxVTools.Name = "textBoxVTools";
            this.textBoxVTools.PlaceholderText = "C:\\Program Files\\Steam\\steamapps\\common\\SourceFilmmaker\\game\\sdktools";
            this.textBoxVTools.Size = new System.Drawing.Size(514, 23);
            this.textBoxVTools.TabIndex = 1;
            // 
            // pictureBoxVTools
            // 
            this.pictureBoxVTools.Image = global::SourceSDK.ENV.Editor.Properties.Resources.cancel;
            this.pictureBoxVTools.Location = new System.Drawing.Point(6, 26);
            this.pictureBoxVTools.Name = "pictureBoxVTools";
            this.pictureBoxVTools.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxVTools.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxVTools.TabIndex = 0;
            this.pictureBoxVTools.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 502);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBoxVContent);
            this.Controls.Add(this.groupBoxVGame);
            this.Controls.Add(this.groupBoxVProject);
            this.Controls.Add(this.groupBoxVMod);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.toolTip.SetToolTip(this, "asd");
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxVMod.ResumeLayout(false);
            this.groupBoxVMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVMod)).EndInit();
            this.groupBoxVProject.ResumeLayout(false);
            this.groupBoxVProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVProject)).EndInit();
            this.groupBoxVGame.ResumeLayout(false);
            this.groupBoxVGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVGame)).EndInit();
            this.groupBoxVContent.ResumeLayout(false);
            this.groupBoxVContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVContent)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox groupBoxVMod;
        private Button buttonResetVMod;
        private Button buttonApplyVMod;
        private TextBox textBoxVMod;
        private PictureBox pictureBoxVMod;
        private GroupBox groupBoxVProject;
        private Button buttonBrowseVProject;
        private Button buttonResetVProject;
        private Button buttonApplyVProject;
        private TextBox textBoxVProject;
        private PictureBox pictureBoxVProject;
        private GroupBox groupBoxVGame;
        private Button buttonBrowseVGame;
        private Button buttonResetVGame;
        private Button buttonApplyVGame;
        private TextBox textBoxVGame;
        private PictureBox pictureBoxVGame;
        private GroupBox groupBoxVContent;
        private Button buttonBrowseVContent;
        private Button buttonResetVContent;
        private Button buttonApplyVContent;
        private TextBox textBoxVContent;
        private PictureBox pictureBoxVContent;
        private GroupBox groupBox5;
        private Button buttonBrowseVTools;
        private Button buttonResetVTools;
        private Button buttonApplyVTools;
        private TextBox textBoxVTools;
        private PictureBox pictureBoxVTools;
        private ToolTip toolTip;
    }
}