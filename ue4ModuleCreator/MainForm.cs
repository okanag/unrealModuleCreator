using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ue4ModuleCreator.Properties;

namespace ue4ModuleCreator
{
    public partial class MainForm : Form
    {
        private Ue4ProjectController ProjectController;

        public MainForm()
        {
            InitializeComponent();

            projectPathTextBox.Validating += new CancelEventHandler(ProjectPathTextBox_Validating);

            ProjectController = new Ue4ProjectController();
        }

        private void BrowseProjectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = Resources.MainForm_projectPathFolderBrowserDescription
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                projectPathTextBox.Text = folderBrowserDialog.SelectedPath;

                ProjectController.InitializeWithProjectPath(projectPathTextBox.Text);
                ProjectPathTextBox_Validating(null, null);
            }
        }

        protected void ProjectPathTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ProjectController.IsProjectPathValid())
            {
                projectPathErrorProvider.SetError(projectPathTextBox, "Can't find .uproject file in given path!");
            }
            else
            {
                projectPathErrorProvider.SetError(projectPathTextBox, "");
            }
        }

        private void RefreshPluginListButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateModuleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
