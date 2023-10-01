namespace S2MapBuildTool
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            BuildButton = new Button();
            SaveConfigButton = new Button();
            LoadConfigButton = new Button();
            RCFileTextBox = new TextBox();
            TabControl = new TabControl();
            SetupTab = new TabPage();
            OutputDirBrowseButton = new Button();
            OutputDirTextBox = new TextBox();
            VMapBrowseButton = new Button();
            VMapFileTextBox = new TextBox();
            RCFileBrowseButton = new Button();
            WorldTab = new TabPage();
            BuildNavCheckbox = new CheckBox();
            BuildVisCheckbox = new CheckBox();
            BuildPhysCheckbox = new CheckBox();
            NoSettleCheckbox = new CheckBox();
            EntsOnlyOption = new RadioButton();
            BuildWorldOption = new RadioButton();
            LightmapTab = new TabPage();
            LightmapSettingsGroupbox = new GroupBox();
            LightmapCPUCheckbox = new CheckBox();
            DisableLightCalcCheckbox = new CheckBox();
            LightmapResCombobox = new ComboBox();
            DisableNoiseRemovalCheckbox = new CheckBox();
            LightmapResLabel = new Label();
            DisableCompressionCheckbox = new CheckBox();
            LightmapQualityCombobox = new ComboBox();
            LightmapQualityLabel = new Label();
            BakeLightmapCheckbox = new CheckBox();
            RCFileBrowser = new OpenFileDialog();
            VMapFileBrowser = new OpenFileDialog();
            OutputDirBrowser = new FolderBrowserDialog();
            ViewLogButton = new Button();
            TabControl.SuspendLayout();
            SetupTab.SuspendLayout();
            WorldTab.SuspendLayout();
            LightmapTab.SuspendLayout();
            LightmapSettingsGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // BuildButton
            // 
            BuildButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BuildButton.Location = new Point(660, 418);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(108, 32);
            BuildButton.TabIndex = 1;
            BuildButton.Text = "Build!";
            BuildButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            BuildButton.UseVisualStyleBackColor = true;
            BuildButton.Click += BuildButton_Click;
            // 
            // SaveConfigButton
            // 
            SaveConfigButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveConfigButton.Location = new Point(160, 418);
            SaveConfigButton.Name = "SaveConfigButton";
            SaveConfigButton.Size = new Size(142, 32);
            SaveConfigButton.TabIndex = 2;
            SaveConfigButton.Text = "Save Configuration";
            SaveConfigButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveConfigButton.UseVisualStyleBackColor = true;
            SaveConfigButton.Click += SaveConfigButton_Click;
            // 
            // LoadConfigButton
            // 
            LoadConfigButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LoadConfigButton.Location = new Point(12, 418);
            LoadConfigButton.Name = "LoadConfigButton";
            LoadConfigButton.Size = new Size(142, 32);
            LoadConfigButton.TabIndex = 3;
            LoadConfigButton.Text = "Load Configuration";
            LoadConfigButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LoadConfigButton.UseVisualStyleBackColor = true;
            LoadConfigButton.Click += LoadConfigButton_Click;
            // 
            // RCFileTextBox
            // 
            RCFileTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RCFileTextBox.Location = new Point(6, 6);
            RCFileTextBox.Name = "RCFileTextBox";
            RCFileTextBox.PlaceholderText = "ResourceCompiler executable";
            RCFileTextBox.Size = new Size(740, 23);
            RCFileTextBox.TabIndex = 5;
            RCFileTextBox.TextChanged += RCFileTextBox_TextChanged;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(SetupTab);
            TabControl.Controls.Add(WorldTab);
            TabControl.Controls.Add(LightmapTab);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(760, 400);
            TabControl.TabIndex = 6;
            // 
            // SetupTab
            // 
            SetupTab.Controls.Add(OutputDirBrowseButton);
            SetupTab.Controls.Add(OutputDirTextBox);
            SetupTab.Controls.Add(VMapBrowseButton);
            SetupTab.Controls.Add(VMapFileTextBox);
            SetupTab.Controls.Add(RCFileBrowseButton);
            SetupTab.Controls.Add(RCFileTextBox);
            SetupTab.Location = new Point(4, 24);
            SetupTab.Name = "SetupTab";
            SetupTab.Padding = new Padding(3);
            SetupTab.Size = new Size(752, 372);
            SetupTab.TabIndex = 0;
            SetupTab.Text = "Setup";
            SetupTab.UseVisualStyleBackColor = true;
            // 
            // OutputDirBrowseButton
            // 
            OutputDirBrowseButton.Location = new Point(6, 175);
            OutputDirBrowseButton.Name = "OutputDirBrowseButton";
            OutputDirBrowseButton.Size = new Size(110, 35);
            OutputDirBrowseButton.TabIndex = 10;
            OutputDirBrowseButton.Text = "Browse...";
            OutputDirBrowseButton.UseVisualStyleBackColor = true;
            OutputDirBrowseButton.Click += OutputDirBrowseButton_Click;
            // 
            // OutputDirTextBox
            // 
            OutputDirTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OutputDirTextBox.Location = new Point(6, 146);
            OutputDirTextBox.Name = "OutputDirTextBox";
            OutputDirTextBox.PlaceholderText = "Output directory";
            OutputDirTextBox.Size = new Size(740, 23);
            OutputDirTextBox.TabIndex = 9;
            OutputDirTextBox.TextChanged += OutputDirTextBox_TextChanged;
            // 
            // VMapBrowseButton
            // 
            VMapBrowseButton.Location = new Point(6, 105);
            VMapBrowseButton.Name = "VMapBrowseButton";
            VMapBrowseButton.Size = new Size(110, 35);
            VMapBrowseButton.TabIndex = 8;
            VMapBrowseButton.Text = "Browse...";
            VMapBrowseButton.UseVisualStyleBackColor = true;
            VMapBrowseButton.Click += VMapBrowseButton_Click;
            // 
            // VMapFileTextBox
            // 
            VMapFileTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VMapFileTextBox.Location = new Point(6, 76);
            VMapFileTextBox.Name = "VMapFileTextBox";
            VMapFileTextBox.PlaceholderText = "VMAP file";
            VMapFileTextBox.Size = new Size(740, 23);
            VMapFileTextBox.TabIndex = 7;
            VMapFileTextBox.TextChanged += VMapFileTextBox_TextChanged;
            // 
            // RCFileBrowseButton
            // 
            RCFileBrowseButton.Location = new Point(6, 35);
            RCFileBrowseButton.Name = "RCFileBrowseButton";
            RCFileBrowseButton.Size = new Size(110, 35);
            RCFileBrowseButton.TabIndex = 6;
            RCFileBrowseButton.Text = "Browse...";
            RCFileBrowseButton.UseVisualStyleBackColor = true;
            RCFileBrowseButton.Click += RCFileBrowseButton_Click;
            // 
            // WorldTab
            // 
            WorldTab.Controls.Add(BuildNavCheckbox);
            WorldTab.Controls.Add(BuildVisCheckbox);
            WorldTab.Controls.Add(BuildPhysCheckbox);
            WorldTab.Controls.Add(NoSettleCheckbox);
            WorldTab.Controls.Add(EntsOnlyOption);
            WorldTab.Controls.Add(BuildWorldOption);
            WorldTab.Location = new Point(4, 24);
            WorldTab.Name = "WorldTab";
            WorldTab.Size = new Size(752, 372);
            WorldTab.TabIndex = 2;
            WorldTab.Text = "World";
            WorldTab.UseVisualStyleBackColor = true;
            // 
            // BuildNavCheckbox
            // 
            BuildNavCheckbox.AutoSize = true;
            BuildNavCheckbox.Location = new Point(17, 170);
            BuildNavCheckbox.Name = "BuildNavCheckbox";
            BuildNavCheckbox.Size = new Size(75, 19);
            BuildNavCheckbox.TabIndex = 5;
            BuildNavCheckbox.Text = "Build nav";
            BuildNavCheckbox.UseVisualStyleBackColor = true;
            BuildNavCheckbox.CheckedChanged += BuildNavCheckbox_CheckedChanged;
            // 
            // BuildVisCheckbox
            // 
            BuildVisCheckbox.AutoSize = true;
            BuildVisCheckbox.Location = new Point(17, 145);
            BuildVisCheckbox.Name = "BuildVisCheckbox";
            BuildVisCheckbox.Size = new Size(70, 19);
            BuildVisCheckbox.TabIndex = 4;
            BuildVisCheckbox.Text = "Build vis";
            BuildVisCheckbox.UseVisualStyleBackColor = true;
            BuildVisCheckbox.CheckedChanged += BuildVisCheckbox_CheckedChanged;
            // 
            // BuildPhysCheckbox
            // 
            BuildPhysCheckbox.AutoSize = true;
            BuildPhysCheckbox.Location = new Point(17, 120);
            BuildPhysCheckbox.Name = "BuildPhysCheckbox";
            BuildPhysCheckbox.Size = new Size(95, 19);
            BuildPhysCheckbox.TabIndex = 3;
            BuildPhysCheckbox.Text = "Build physics";
            BuildPhysCheckbox.UseVisualStyleBackColor = true;
            BuildPhysCheckbox.CheckedChanged += BuildPhysCheckbox_CheckedChanged;
            // 
            // NoSettleCheckbox
            // 
            NoSettleCheckbox.AutoSize = true;
            NoSettleCheckbox.Location = new Point(17, 82);
            NoSettleCheckbox.Name = "NoSettleCheckbox";
            NoSettleCheckbox.Size = new Size(191, 19);
            NoSettleCheckbox.TabIndex = 2;
            NoSettleCheckbox.Text = "Don't pre-settle physics objects";
            NoSettleCheckbox.UseVisualStyleBackColor = true;
            NoSettleCheckbox.CheckedChanged += NoSettleCheckbox_CheckedChanged;
            // 
            // EntsOnlyOption
            // 
            EntsOnlyOption.AutoSize = true;
            EntsOnlyOption.Location = new Point(17, 47);
            EntsOnlyOption.Name = "EntsOnlyOption";
            EntsOnlyOption.Size = new Size(89, 19);
            EntsOnlyOption.TabIndex = 1;
            EntsOnlyOption.Text = "Entities only";
            EntsOnlyOption.UseVisualStyleBackColor = true;
            EntsOnlyOption.CheckedChanged += EntsOnlyOption_CheckedChanged;
            // 
            // BuildWorldOption
            // 
            BuildWorldOption.AutoSize = true;
            BuildWorldOption.Checked = true;
            BuildWorldOption.Location = new Point(17, 22);
            BuildWorldOption.Name = "BuildWorldOption";
            BuildWorldOption.Size = new Size(85, 19);
            BuildWorldOption.TabIndex = 0;
            BuildWorldOption.TabStop = true;
            BuildWorldOption.Text = "Build world";
            BuildWorldOption.UseVisualStyleBackColor = true;
            BuildWorldOption.CheckedChanged += BuildWorldOption_CheckedChanged;
            // 
            // LightmapTab
            // 
            LightmapTab.Controls.Add(LightmapSettingsGroupbox);
            LightmapTab.Controls.Add(BakeLightmapCheckbox);
            LightmapTab.Location = new Point(4, 24);
            LightmapTab.Name = "LightmapTab";
            LightmapTab.Padding = new Padding(3);
            LightmapTab.Size = new Size(752, 372);
            LightmapTab.TabIndex = 1;
            LightmapTab.Text = "Lighting";
            LightmapTab.UseVisualStyleBackColor = true;
            // 
            // LightmapSettingsGroupbox
            // 
            LightmapSettingsGroupbox.Controls.Add(LightmapCPUCheckbox);
            LightmapSettingsGroupbox.Controls.Add(DisableLightCalcCheckbox);
            LightmapSettingsGroupbox.Controls.Add(LightmapResCombobox);
            LightmapSettingsGroupbox.Controls.Add(DisableNoiseRemovalCheckbox);
            LightmapSettingsGroupbox.Controls.Add(LightmapResLabel);
            LightmapSettingsGroupbox.Controls.Add(DisableCompressionCheckbox);
            LightmapSettingsGroupbox.Controls.Add(LightmapQualityCombobox);
            LightmapSettingsGroupbox.Controls.Add(LightmapQualityLabel);
            LightmapSettingsGroupbox.Location = new Point(16, 43);
            LightmapSettingsGroupbox.Name = "LightmapSettingsGroupbox";
            LightmapSettingsGroupbox.Size = new Size(289, 189);
            LightmapSettingsGroupbox.TabIndex = 9;
            LightmapSettingsGroupbox.TabStop = false;
            LightmapSettingsGroupbox.Text = "Lightmap generation settings";
            // 
            // LightmapCPUCheckbox
            // 
            LightmapCPUCheckbox.AutoSize = true;
            LightmapCPUCheckbox.Location = new Point(6, 22);
            LightmapCPUCheckbox.Name = "LightmapCPUCheckbox";
            LightmapCPUCheckbox.Size = new Size(205, 19);
            LightmapCPUCheckbox.TabIndex = 1;
            LightmapCPUCheckbox.Text = "Use CPU for generating lightmaps";
            LightmapCPUCheckbox.UseVisualStyleBackColor = true;
            LightmapCPUCheckbox.CheckedChanged += LightmapCPUCheckbox_CheckedChanged;
            // 
            // DisableLightCalcCheckbox
            // 
            DisableLightCalcCheckbox.AutoSize = true;
            DisableLightCalcCheckbox.Location = new Point(6, 162);
            DisableLightCalcCheckbox.Name = "DisableLightCalcCheckbox";
            DisableLightCalcCheckbox.Size = new Size(174, 19);
            DisableLightCalcCheckbox.TabIndex = 8;
            DisableLightCalcCheckbox.Text = "Disable lighting calculations";
            DisableLightCalcCheckbox.UseVisualStyleBackColor = true;
            DisableLightCalcCheckbox.CheckedChanged += DisableLightCalcCheckbox_CheckedChanged;
            // 
            // LightmapResCombobox
            // 
            LightmapResCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            LightmapResCombobox.FormattingEnabled = true;
            LightmapResCombobox.Items.AddRange(new object[] { "512", "1024", "2048", "4096", "8192" });
            LightmapResCombobox.Location = new Point(129, 47);
            LightmapResCombobox.Name = "LightmapResCombobox";
            LightmapResCombobox.Size = new Size(82, 23);
            LightmapResCombobox.TabIndex = 2;
            LightmapResCombobox.SelectedValueChanged += LightmapResCombobox_SelectedValueChanged;
            // 
            // DisableNoiseRemovalCheckbox
            // 
            DisableNoiseRemovalCheckbox.AutoSize = true;
            DisableNoiseRemovalCheckbox.Location = new Point(6, 137);
            DisableNoiseRemovalCheckbox.Name = "DisableNoiseRemovalCheckbox";
            DisableNoiseRemovalCheckbox.Size = new Size(141, 19);
            DisableNoiseRemovalCheckbox.TabIndex = 7;
            DisableNoiseRemovalCheckbox.Text = "Disable noise removal";
            DisableNoiseRemovalCheckbox.UseVisualStyleBackColor = true;
            DisableNoiseRemovalCheckbox.CheckedChanged += DisableNoiseRemovalCheckbox_CheckedChanged;
            // 
            // LightmapResLabel
            // 
            LightmapResLabel.AutoSize = true;
            LightmapResLabel.Location = new Point(6, 50);
            LightmapResLabel.Name = "LightmapResLabel";
            LightmapResLabel.Size = new Size(117, 15);
            LightmapResLabel.TabIndex = 3;
            LightmapResLabel.Text = "Lightmap Resolution";
            // 
            // DisableCompressionCheckbox
            // 
            DisableCompressionCheckbox.AutoSize = true;
            DisableCompressionCheckbox.Location = new Point(6, 112);
            DisableCompressionCheckbox.Name = "DisableCompressionCheckbox";
            DisableCompressionCheckbox.Size = new Size(135, 19);
            DisableCompressionCheckbox.TabIndex = 6;
            DisableCompressionCheckbox.Text = "Disable compression";
            DisableCompressionCheckbox.UseVisualStyleBackColor = true;
            DisableCompressionCheckbox.CheckedChanged += DisableCompressionCheckbox_CheckedChanged;
            // 
            // LightmapQualityCombobox
            // 
            LightmapQualityCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            LightmapQualityCombobox.FormattingEnabled = true;
            LightmapQualityCombobox.Items.AddRange(new object[] { "Fast", "Standard", "Final" });
            LightmapQualityCombobox.Location = new Point(129, 76);
            LightmapQualityCombobox.Name = "LightmapQualityCombobox";
            LightmapQualityCombobox.Size = new Size(82, 23);
            LightmapQualityCombobox.TabIndex = 4;
            LightmapQualityCombobox.SelectedValueChanged += LightmapQualityCombobox_SelectedValueChanged;
            // 
            // LightmapQualityLabel
            // 
            LightmapQualityLabel.AutoSize = true;
            LightmapQualityLabel.Location = new Point(6, 79);
            LightmapQualityLabel.Name = "LightmapQualityLabel";
            LightmapQualityLabel.Size = new Size(99, 15);
            LightmapQualityLabel.TabIndex = 5;
            LightmapQualityLabel.Text = "Lightmap Quality";
            // 
            // BakeLightmapCheckbox
            // 
            BakeLightmapCheckbox.AutoSize = true;
            BakeLightmapCheckbox.Location = new Point(16, 18);
            BakeLightmapCheckbox.Name = "BakeLightmapCheckbox";
            BakeLightmapCheckbox.Size = new Size(129, 19);
            BakeLightmapCheckbox.TabIndex = 0;
            BakeLightmapCheckbox.Text = "Generate lightmaps";
            BakeLightmapCheckbox.UseVisualStyleBackColor = true;
            BakeLightmapCheckbox.CheckedChanged += BakeLightmapCheckbox_CheckedChanged;
            // 
            // RCFileBrowser
            // 
            RCFileBrowser.Filter = "ResourceCompiler executable|resourcecompiler.exe";
            RCFileBrowser.Title = "Select ResourceCompiler executable";
            RCFileBrowser.FileOk += RCFileBrowser_FileOk;
            // 
            // VMapFileBrowser
            // 
            VMapFileBrowser.Filter = "Valve Map files|*.vmap";
            VMapFileBrowser.Title = "Select VMAP file to build";
            VMapFileBrowser.FileOk += VMapFileBrowser_FileOk;
            // 
            // OutputDirBrowser
            // 
            OutputDirBrowser.Description = "Select directory where the outputted VPK will be placed.";
            OutputDirBrowser.UseDescriptionForTitle = true;
            // 
            // ViewLogButton
            // 
            ViewLogButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ViewLogButton.Enabled = false;
            ViewLogButton.Location = new Point(537, 418);
            ViewLogButton.Name = "ViewLogButton";
            ViewLogButton.Size = new Size(117, 32);
            ViewLogButton.TabIndex = 8;
            ViewLogButton.Text = "View Build Log";
            ViewLogButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ViewLogButton.UseVisualStyleBackColor = true;
            ViewLogButton.Click += ViewLogButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(ViewLogButton);
            Controls.Add(TabControl);
            Controls.Add(LoadConfigButton);
            Controls.Add(SaveConfigButton);
            Controls.Add(BuildButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(570, 400);
            Name = "MainWindow";
            Text = "Source 2 Map Build Tool";
            Load += MainWindow_Load;
            TabControl.ResumeLayout(false);
            SetupTab.ResumeLayout(false);
            SetupTab.PerformLayout();
            WorldTab.ResumeLayout(false);
            WorldTab.PerformLayout();
            LightmapTab.ResumeLayout(false);
            LightmapTab.PerformLayout();
            LightmapSettingsGroupbox.ResumeLayout(false);
            LightmapSettingsGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button BuildButton;
        private Button SaveConfigButton;
        private Button LoadConfigButton;
        private TextBox RCFileTextBox;
        private TabControl TabControl;
        private TabPage SetupTab;
        private TabPage LightmapTab;
        private Button RCFileBrowseButton;
        private OpenFileDialog RCFileBrowser;
        private TextBox VMapFileTextBox;
        private Button VMapBrowseButton;
        private OpenFileDialog VMapFileBrowser;
        private TextBox OutputDirTextBox;
        private Button OutputDirBrowseButton;
        private FolderBrowserDialog OutputDirBrowser;
        private TabPage WorldTab;
        private CheckBox BakeLightmapCheckbox;
        private CheckBox LightmapCPUCheckbox;
        private Label LightmapResLabel;
        private ComboBox LightmapResCombobox;
        private RadioButton BuildWorldOption;
        private RadioButton EntsOnlyOption;
        private CheckBox NoSettleCheckbox;
        private CheckBox BuildPhysCheckbox;
        private CheckBox BuildVisCheckbox;
        private CheckBox BuildNavCheckbox;
        private ComboBox LightmapQualityCombobox;
        private Label LightmapQualityLabel;
        private CheckBox DisableCompressionCheckbox;
        private CheckBox DisableNoiseRemovalCheckbox;
        private CheckBox DisableLightCalcCheckbox;
        private GroupBox LightmapSettingsGroupbox;
        private Button ViewLogButton;
    }
}