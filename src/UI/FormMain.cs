using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceSDK.ENV.Editor.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = String.Format("{0} ({1})", System.Windows.Forms.Application.ProductName, System.Windows.Forms.Application.ProductVersion); ;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            checkAll();
            folderBrowserDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //set defaut directory
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkAll();
            MessageBox.Show("Information updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout? frmAbout = new();
            frmAbout.ShowDialog();
        }

        #region checks
        private void checkAll()
        {
            checkVMod();
            checkVProject();
            checkVGame();
            checkVContent();
            checkVTools();
        }
        private void checkVMod()
        {
            var value = Environment.GetEnvironmentVariable("VMod", EnvironmentVariableTarget.User);
            if (value == null)
            {
                textBoxVMod.Text = value;
                pictureBoxVMod.Image = Properties.Resources.cancel;
            }
            else
            {
                textBoxVMod.Text = value;
                pictureBoxVMod.Image = Properties.Resources.done;
            }
        }
        private void checkVProject()
        {
            var value = Environment.GetEnvironmentVariable("VProject", EnvironmentVariableTarget.User);
            if (value == null)
            {
                textBoxVProject.Text = value;
                pictureBoxVProject.Image = Properties.Resources.cancel;
            }
            else
            {
                textBoxVProject.Text = value;
                pictureBoxVProject.Image = Properties.Resources.done;
            }
        }
        private void checkVGame()
        {
            var value = Environment.GetEnvironmentVariable("VGame", EnvironmentVariableTarget.User);
            if (value == null)
            {
                textBoxVGame.Text = value;
                pictureBoxVGame.Image = Properties.Resources.cancel;
            }
            else
            {
                textBoxVGame.Text = value;
                pictureBoxVGame.Image = Properties.Resources.done;
            }
        }
        private void checkVContent()
        {
            var value = Environment.GetEnvironmentVariable("VContent", EnvironmentVariableTarget.User);
            if (value == null)
            {
                textBoxVContent.Text = value;
                pictureBoxVContent.Image = Properties.Resources.cancel;
            }
            else
            {
                textBoxVContent.Text = value;
                pictureBoxVContent.Image = Properties.Resources.done;
            }
        }
        private void checkVTools()
        {
            var value = Environment.GetEnvironmentVariable("VTools", EnvironmentVariableTarget.User);
            if (value == null)
            {
                textBoxVTools.Text = value;
                pictureBoxVTools.Image = Properties.Resources.cancel;
            }
            else
            {
                textBoxVTools.Text = value;
                pictureBoxVTools.Image = Properties.Resources.done;
            }
        }
        #endregion

        #region reset
        private void resetAll()
        {
            resetVMod();
            resetVProject();
            resetVGame();
            resetVContent();
            resetVTools();
        }

        private void resetVMod()
        {
            try
            {
                pictureBoxVMod.Image = Properties.Resources.wait;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Environment.SetEnvironmentVariable("VMod", null, EnvironmentVariableTarget.User);
                    checkVMod();
                }
                catch
                {
                    checkVMod();
                }

                MessageBox.Show("VMod successfully cleared and Information updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Something went wrong and VMod was not successfully deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
            }
        }

        private void resetVProject()
        {
            try
            {
                pictureBoxVProject.Image = Properties.Resources.wait;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Environment.SetEnvironmentVariable("VProject", null, EnvironmentVariableTarget.User);
                    checkVProject();
                }
                catch
                {
                    checkVProject();
                }

                MessageBox.Show("VProject successfully cleared and Information updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Something went wrong and VProject was not successfully deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
            }
        }

        private void resetVGame()
        {
            try
            {
                pictureBoxVGame.Image = Properties.Resources.wait;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Environment.SetEnvironmentVariable("VGame", null, EnvironmentVariableTarget.User);
                    checkVGame();
                }
                catch
                {
                    checkVGame();
                }

                MessageBox.Show("VGame successfully cleared and Information updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Something went wrong and VGame was not successfully deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
            }
        }

        private void resetVContent()
        {
            try
            {
                pictureBoxVContent.Image = Properties.Resources.wait;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Environment.SetEnvironmentVariable("VContent", null, EnvironmentVariableTarget.User);
                    checkVContent();
                }
                catch
                {
                    checkVContent();
                }

                MessageBox.Show("VContent successfully cleared and Information updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Something went wrong and VContent was not successfully deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
            }
        }

        private void resetVTools()
        {
            try
            {
                pictureBoxVTools.Image = Properties.Resources.wait;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Environment.SetEnvironmentVariable("VTools", null, EnvironmentVariableTarget.User);
                    checkVTools();
                }
                catch
                {
                    checkVTools();
                }

                MessageBox.Show("VTools successfully cleared and Information updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Something went wrong and VTools was not successfully deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion

        #region apply
        private void applyVMod()
        {
            try
            {
                pictureBoxVMod.Image = Properties.Resources.wait;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Environment.SetEnvironmentVariable("VMod", textBoxVMod.Text, EnvironmentVariableTarget.User);
                    checkVMod();
                }
                catch
                {
                    checkVMod();
                }

                MessageBox.Show("VMod successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Something went wrong and VMod was not successfully updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
            }
        }

        private void applyVProject()
        {
            try
            {
                pictureBoxVProject.Image = Properties.Resources.wait;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Environment.SetEnvironmentVariable("VProject", textBoxVProject.Text, EnvironmentVariableTarget.User);
                    checkVProject();
                }
                catch
                {
                    checkVProject();
                }

                MessageBox.Show("VProject successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Something went wrong and VProject was not successfully updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
            }
        }

        private void applyVGame()
        {
            try
            {
                pictureBoxVGame.Image = Properties.Resources.wait;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Environment.SetEnvironmentVariable("VGame", textBoxVGame.Text, EnvironmentVariableTarget.User);
                    checkVGame();
                }
                catch
                {
                    checkVGame();
                }

                MessageBox.Show("VGame successfully cleared updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Something went wrong and VGame was not successfully updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
            }
        }

        private void applyVContent()
        {
            try
            {
                pictureBoxVContent.Image = Properties.Resources.wait;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Environment.SetEnvironmentVariable("VContent", textBoxVContent.Text, EnvironmentVariableTarget.User);
                    checkVContent();
                }
                catch
                {
                    checkVContent();
                }

                MessageBox.Show("VContent successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Something went wrong and VContent was not successfully updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
            }
        }

        private void applyVTools()
        {
            try
            {
                pictureBoxVTools.Image = Properties.Resources.wait;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Environment.SetEnvironmentVariable("VTools", textBoxVTools.Text, EnvironmentVariableTarget.User);
                    checkVTools();
                }
                catch
                {
                    checkVTools();
                }

                MessageBox.Show("VTools successfully cleared updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Something went wrong and VTools was not successfully updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region btn-reset
        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                resetAll();
            }
        }
        private void buttonResetVMod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                resetVMod();
            }
           
        }

        private void buttonResetVProject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                resetVProject();
            }
        }

        private void buttonResetVGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                resetVGame();
            }
        }

        private void buttonResetVContent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                resetVContent();
            }
        }

        private void buttonResetVTools_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                resetVTools();
            }
        }
        #endregion
            
        #region btn-browse
        private void buttonBrowseVProject_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog()== DialogResult.OK)
            {
                textBoxVProject.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBrowseVGame_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxVGame.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBrowseVContent_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxVContent.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBrowseVTools_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxVTools.Text = folderBrowserDialog.SelectedPath;
            }
        }
        #endregion

        #region btn-apply
        private void buttonApplyVMod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                applyVMod();
            }
        }

        private void buttonApplyVProject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                applyVProject();
            }
        }

        private void buttonApplyVGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                applyVGame();
            }
        }

        private void buttonApplyVContent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                applyVContent();
            }
        }

        private void buttonApplyVTools_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                applyVTools();
            }
        }
        #endregion

    }
}
