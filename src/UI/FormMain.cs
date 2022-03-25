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
            this.Text = String.Format("{0} ({1})", Application.ProductName, Application.ProductVersion); ;
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
                pictureBoxVMod.Image = Properties.Resources.wait;
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
                pictureBoxVMod.Image = Properties.Resources.wait;
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

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            checkAll();
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

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to reset all envs?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
    }
}
