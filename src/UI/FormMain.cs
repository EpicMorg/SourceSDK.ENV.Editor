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

        private void checkAll()
        {
            checkVMod();
            checkVProject();
        }
        private void checkVMod()
        {
            var value = Environment.GetEnvironmentVariable("VMod", EnvironmentVariableTarget.User);
            if (value == null)
            {
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
                pictureBoxVProject.Image = Properties.Resources.cancel;
            }
            else
            {
                textBoxVProject.Text = value;
                pictureBoxVProject.Image = Properties.Resources.done;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            checkAll();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkAll();
        }
    }
}
