namespace ue4ModuleCreator
{
    partial class MainForm
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
            this.projectPathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseProjectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RefreshPluginListButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ModuleLocationComboBox = new System.Windows.Forms.ComboBox();
            this.moduleNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateModuleButton = new System.Windows.Forms.Button();
            this.projectPathErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectPathErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // projectPathTextBox
            // 
            this.projectPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.projectPathTextBox.BackColor = System.Drawing.Color.White;
            this.projectPathTextBox.Location = new System.Drawing.Point(123, 10);
            this.projectPathTextBox.Name = "projectPathTextBox";
            this.projectPathTextBox.Size = new System.Drawing.Size(293, 20);
            this.projectPathTextBox.TabIndex = 1;
            // 
            // BrowseProjectButton
            // 
            this.BrowseProjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseProjectButton.Location = new System.Drawing.Point(462, 8);
            this.BrowseProjectButton.Name = "BrowseProjectButton";
            this.BrowseProjectButton.Size = new System.Drawing.Size(74, 23);
            this.BrowseProjectButton.TabIndex = 0;
            this.BrowseProjectButton.Text = "Browse";
            this.BrowseProjectButton.UseVisualStyleBackColor = true;
            this.BrowseProjectButton.Click += new System.EventHandler(this.BrowseProjectButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ue4 Project Path";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.RefreshPluginListButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BrowseProjectButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.projectPathTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ModuleLocationComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.moduleNameBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CreateModuleButton, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 161);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // RefreshPluginListButton
            // 
            this.RefreshPluginListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshPluginListButton.Location = new System.Drawing.Point(462, 88);
            this.RefreshPluginListButton.Name = "RefreshPluginListButton";
            this.RefreshPluginListButton.Size = new System.Drawing.Size(74, 23);
            this.RefreshPluginListButton.TabIndex = 3;
            this.RefreshPluginListButton.Text = "Refresh";
            this.RefreshPluginListButton.UseVisualStyleBackColor = true;
            this.RefreshPluginListButton.Click += new System.EventHandler(this.RefreshPluginListButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ModuleLocation";
            // 
            // ModuleLocationComboBox
            // 
            this.ModuleLocationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModuleLocationComboBox.FormattingEnabled = true;
            this.ModuleLocationComboBox.Location = new System.Drawing.Point(123, 89);
            this.ModuleLocationComboBox.Name = "ModuleLocationComboBox";
            this.ModuleLocationComboBox.Size = new System.Drawing.Size(293, 21);
            this.ModuleLocationComboBox.TabIndex = 2;
            // 
            // moduleNameBox
            // 
            this.moduleNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.moduleNameBox.Location = new System.Drawing.Point(123, 130);
            this.moduleNameBox.Name = "moduleNameBox";
            this.moduleNameBox.Size = new System.Drawing.Size(293, 20);
            this.moduleNameBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Module Name";
            // 
            // CreateModuleButton
            // 
            this.CreateModuleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateModuleButton.Location = new System.Drawing.Point(462, 128);
            this.CreateModuleButton.Name = "CreateModuleButton";
            this.CreateModuleButton.Size = new System.Drawing.Size(74, 23);
            this.CreateModuleButton.TabIndex = 5;
            this.CreateModuleButton.Text = "Create";
            this.CreateModuleButton.UseVisualStyleBackColor = true;
            this.CreateModuleButton.Click += new System.EventHandler(this.CreateModuleButton_Click);
            // 
            // projectPathErrorProvider
            // 
            this.projectPathErrorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 185);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "UE4 Module Creator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectPathErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox projectPathTextBox;
        private System.Windows.Forms.Button BrowseProjectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox moduleNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ModuleLocationComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateModuleButton;
        private System.Windows.Forms.Button RefreshPluginListButton;
        private System.Windows.Forms.ErrorProvider projectPathErrorProvider;
    }
}

