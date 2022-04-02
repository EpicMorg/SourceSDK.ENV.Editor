using System.Diagnostics;
using System.Runtime.InteropServices;
using DarkUI.Forms;
using Octokit;

namespace SourceSDK.ENV.Editor.UI
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            this.Text = String.Format("{0} {1} ({2})", "About ::", System.Windows.Forms.Application.ProductName, System.Windows.Forms.Application.ProductVersion);
            darkLabelProductVersion.Text = String.Format("{0} ({1})", System.Windows.Forms.Application.ProductName, System.Windows.Forms.Application.ProductVersion);
            darkLabelCopyright.Text = String.Format(" Copyright {1} \u00a9 {0}", System.Windows.Forms.Application.CompanyName, DateTime.Now.Year);
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            CheckGitHubNewerVersion();
        }

        private async System.Threading.Tasks.Task CheckGitHubNewerVersion()
        {
            //Get all releases from GitHub
            //Source: https://octokitnet.readthedocs.io/en/latest/getting-started/
            GitHubClient client = new GitHubClient(new ProductHeaderValue("SourceSDK.ENV.Editor"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("EpicMorg", "SourceSDK.ENV.Editor");

            //Setup the versions
            Version latestGitHubVersion = new Version(releases[0].TagName);
            Version localVersion = new Version(System.Windows.Forms.Application.ProductVersion); //Replace this with your local version. 
                                                         //Only tested with numeric values.

            //Compare the Versions
            //Source: https://stackoverflow.com/questions/7568147/compare-version-numbers-without-using-split-function
            int versionComparison = localVersion.CompareTo(latestGitHubVersion);
            if (versionComparison < 0)
            {
                DarkUI.Forms.DarkMessageBox.ShowInformation("The version on GitHub is more up to date than this local release.", "Information",  DarkDialogButton.Ok);
                //The version on GitHub is more up to date than this local release.
            }
            else if (versionComparison > 0)
            {
                DarkUI.Forms.DarkMessageBox.ShowInformation("This local version is greater than the release version on GitHub.", "Information", DarkDialogButton.Ok);
                //This local version is greater than the release version on GitHub.
            }
            else
            {
                DarkUI.Forms.DarkMessageBox.ShowInformation("This local Version and the Version on GitHub are equal.", "Information", DarkDialogButton.Ok);
                //This local Version and the Version on GitHub are equal.
            }
        }

        private void darkButtonDonate_Click(object sender, EventArgs e)
        {
            var url = "https://ko-fi.com/epicmorg";
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
            
        }
        private void darkButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
