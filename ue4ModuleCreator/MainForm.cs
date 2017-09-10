using System;
using System.ComponentModel;
using System.Windows.Forms;
using ue4ModuleCreator.Properties;

namespace ue4ModuleCreator
{
    public partial class MainForm : Form
    {
        private readonly Ue4ProjectController projectController;

        public MainForm()
        {
            InitializeComponent();

            projectPathTextBox.Validating += new CancelEventHandler(ProjectPathTextBox_Validating);

            projectController = new Ue4ProjectController();
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
                
                ProjectPathTextBox_Validating(null, null);
            }
        }

        protected void ProjectPathTextBox_Validating(object sender, CancelEventArgs e)
        {
            projectController.InitializeWithProjectPath(projectPathTextBox.Text);
            if (projectController.IsProjectPathValid())
            {
                projectPathErrorProvider.SetError(projectPathTextBox, "");
                RefreshPluginListButton_Click(null, null);
            }
            else
            {
                projectPathErrorProvider.SetError(projectPathTextBox, "Can't find .uproject file in given path!");
            }
        }

        private void RefreshPluginListButton_Click(object sender, EventArgs e)
        {
            ModuleLocationComboBox.Items.Clear();
            if (projectController != null && projectController.IsProjectPathValid())
            {
                string[] possibleModuleLocationList = projectController.GetPossibleModuleLocationList().ToArray();
                // ReSharper disable once CoVariantArrayConversion
                ModuleLocationComboBox.Items.AddRange(possibleModuleLocationList);
            }
        }

        private void CreateModuleButton_Click(object sender, EventArgs e)
        {
            if (moduleNameBox.Text.Equals(""))
            {
                projectPathErrorProvider.SetError(moduleNameBox, "Module name can't be empty!");
            }
            else
            {
                projectPathErrorProvider.SetError(moduleNameBox, "");
            }

            if (projectController != null && projectController.IsProjectPathValid())
            {
                string selectedItem = (string) ModuleLocationComboBox.SelectedItem;
                string moduleParentPath = projectController.GetPathForModuleLocation(selectedItem);
                Ue4ModuleCreator moduleCreator = new Ue4ModuleCreator(moduleParentPath, moduleNameBox.Text, !projectController.IsMainGameModuleSelected(selectedItem));
                moduleCreator.CreateModule();
            }
        }
    }
}
