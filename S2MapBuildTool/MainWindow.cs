using S2MapBuildTool.Properties;
using System.Diagnostics;
using System.Dynamic;
using System.Timers;

namespace S2MapBuildTool
{
    public partial class MainWindow : Form
    {
        public string BuildOutputLog;
        BuildLogWindow BuildWindow = new();
        System.Timers.Timer BuildLogTimer = new(100);
        public MainWindow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            var ResourceCompilerProc = Process.GetProcessesByName("resourcecompiler");
            if (ResourceCompilerProc.Length > 0)
                MessageBox.Show("A build is currently in progress.", "Source 2 Map Build Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (ResourceCompilerProc.Length == 0)
            {
                DisableUI();
                Process ResCompilerCreatedProc = new();
                ResCompilerCreatedProc.StartInfo.FileName = Settings.Default.ResCompiler;
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-threads");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("1");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-fshallow");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-maxtextureres");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("256");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-dxlevel");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("110");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-quiet");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-unbufferedio");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-i");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add(Settings.Default.VMapFile);
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-noassert");
                if (Settings.Default.BuildWorld)
                    ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-world");
                if (Settings.Default.EntsOnly)
                    ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-entities");
                if (!Settings.Default.EntsOnly)
                {
                    if (Settings.Default.NoPhysSettle)
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-nosettle");
                    if (Settings.Default.BakeLightmaps)
                    {
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-bakelighting");
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-lightmapMaxResolution");
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add(Settings.Default.LightmapResolution.ToString());
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-lightmapDoWeld");
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-lightmapVRadQuality");
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add(Settings.Default.LightmapQuality.ToString());
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-lightmapLocalCompile");
                        if (Settings.Default.LightmapCompressionDisabled)
                            ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-lightmapCompressionDisabled");
                        if (Settings.Default.LightmapDisableFiltering)
                            ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-lightmapDisableFiltering");
                        if (Settings.Default.DisableLightingCalculations)
                            ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-disableLightingCalculations");
                        if (Settings.Default.LightmapCPU)
                            ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-lightmapcpu");
                    }
                    else
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-nolightmap");
                    if (Settings.Default.BuildPhys)
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-phys");
                    if (Settings.Default.BuildVis)
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-vis");
                    if (Settings.Default.BuildNav)
                        ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-nav");
                }
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-retail");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-breakpad");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-nop4");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add("-outroot");
                ResCompilerCreatedProc.StartInfo.ArgumentList.Add(Settings.Default.OutputDir);
                ResCompilerCreatedProc.EnableRaisingEvents = true;
                //ResCompilerCreatedProc.StartInfo.RedirectStandardOutput = true;
                ResCompilerCreatedProc.Exited += new EventHandler(BuildFinished);
                ResCompilerCreatedProc.Start();
                /* BuildLogTimer.AutoReset = true;
                BuildLogTimer.Start();
                BuildWindow.ControlBox = false;
                BuildWindow.Show();
                BuildLogTimer.Elapsed += (o, ea) =>
                {
                    BuildOutputLog = ResCompilerCreatedProc.StandardOutput.ReadToEnd();
                    BuildWindow.BuildLog = BuildOutputLog;
                    BuildWindow.UpdateLogText();
                };
                new Thread(() =>
                {
                    BuildOutputLog = ResCompilerCreatedProc.StandardOutput.ReadToEnd();
                }).Start(); */
            }
        }

        private void DisableUI()
        {
            TabControl.Enabled = false;
            SaveConfigButton.Enabled = false;
            LoadConfigButton.Enabled = false;
            BuildButton.Enabled = false;
            ViewLogButton.Enabled = false;
        }

        private void EnableUI()
        {
            TabControl.Enabled = true;
            SaveConfigButton.Enabled = true;
            LoadConfigButton.Enabled = true;
            BuildButton.Enabled = true;
        }

        private void BuildFinished(object sender, EventArgs e)
        {
            BuildLogTimer.Stop();
            BuildWindow.Hide();
            MessageBox.Show("Build done!", "Source 2 Map Build Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ViewLogButton.Enabled = true;
            EnableUI();
        }

        private void RCFileBrowser_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RCFileTextBox.Text = RCFileBrowser.FileName;
        }

        private void RCFileBrowseButton_Click(object sender, EventArgs e)
        {
            RCFileBrowser.ShowDialog();
        }

        private void RCFileTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.ResCompiler = RCFileTextBox.Text;
        }

        private void SaveConfigButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            MessageBox.Show("Current configuration saved.", "Source 2 Map Build Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadConfiguration()
        {
            Settings.Default.Reload();
            RCFileTextBox.Text = Settings.Default.ResCompiler;
            VMapFileTextBox.Text = Settings.Default.VMapFile;
            OutputDirTextBox.Text = Settings.Default.OutputDir;
            BuildWorldOption.Checked = Settings.Default.BuildWorld;
            EntsOnlyOption.Checked = Settings.Default.EntsOnly;
            NoSettleCheckbox.Checked = Settings.Default.NoPhysSettle;
            BuildPhysCheckbox.Checked = Settings.Default.BuildPhys;
            BuildVisCheckbox.Checked = Settings.Default.BuildVis;
            BuildNavCheckbox.Checked = Settings.Default.BuildNav;
            ((Control)LightmapTab).Enabled = !Settings.Default.EntsOnly;
            NoSettleCheckbox.Enabled = !Settings.Default.EntsOnly;
            BuildPhysCheckbox.Enabled = !Settings.Default.EntsOnly;
            BuildVisCheckbox.Enabled = !Settings.Default.EntsOnly;
            BuildNavCheckbox.Enabled = !Settings.Default.EntsOnly;
            BakeLightmapCheckbox.Checked = Settings.Default.BakeLightmaps;
            LightmapSettingsGroupbox.Enabled = Settings.Default.BakeLightmaps;
            LightmapCPUCheckbox.Checked = Settings.Default.LightmapCPU;
            LightmapResCombobox.SelectedIndex = LightmapResCombobox.FindStringExact(Settings.Default.LightmapResolution.ToString());
            LightmapQualityCombobox.SelectedIndex = Settings.Default.LightmapQuality;
            DisableCompressionCheckbox.Checked = Settings.Default.LightmapCompressionDisabled;
            DisableNoiseRemovalCheckbox.Checked = Settings.Default.LightmapDisableFiltering;
            DisableLightCalcCheckbox.Checked = Settings.Default.DisableLightingCalculations;
        }

        private void LoadConfigButton_Click(object sender, EventArgs e)
        {
            LoadConfiguration();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
        }

        private void VMapFileBrowser_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VMapFileTextBox.Text = VMapFileBrowser.FileName;
        }

        private void VMapBrowseButton_Click(object sender, EventArgs e)
        {
            VMapFileBrowser.ShowDialog();
        }

        private void VMapFileTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.VMapFile = VMapFileTextBox.Text;
        }

        private void OutputDirTextBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.OutputDir = OutputDirTextBox.Text;
        }

        private void OutputDirBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult OutputDirResult = OutputDirBrowser.ShowDialog();
            if (OutputDirResult == DialogResult.OK)
            {
                OutputDirTextBox.Text = OutputDirBrowser.SelectedPath;
            }
        }

        private void LightmapCPUCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.LightmapCPU = LightmapCPUCheckbox.Checked;
        }

        private void BakeLightmapCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.BakeLightmaps = BakeLightmapCheckbox.Checked;
            LightmapSettingsGroupbox.Enabled = Settings.Default.BakeLightmaps;
        }

        private void LightmapResCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            Settings.Default.LightmapResolution = int.Parse(LightmapResCombobox.SelectedItem.ToString());
        }

        private void BuildWorldOption_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.BuildWorld = BuildWorldOption.Checked;
        }

        private void EntsOnlyOption_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.EntsOnly = EntsOnlyOption.Checked;
            ((Control)LightmapTab).Enabled = !Settings.Default.EntsOnly;
            NoSettleCheckbox.Enabled = !Settings.Default.EntsOnly;
            BuildPhysCheckbox.Enabled = !Settings.Default.EntsOnly;
            BuildVisCheckbox.Enabled = !Settings.Default.EntsOnly;
            BuildNavCheckbox.Enabled = !Settings.Default.EntsOnly;
        }

        private void NoSettleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.NoPhysSettle = NoSettleCheckbox.Checked;
        }

        private void BuildPhysCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.BuildPhys = BuildPhysCheckbox.Checked;
        }

        private void BuildVisCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.BuildVis = BuildVisCheckbox.Checked;
        }

        private void BuildNavCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.BuildNav = BuildNavCheckbox.Checked;
        }

        private void LightmapQualityCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            Settings.Default.LightmapQuality = LightmapQualityCombobox.SelectedIndex;
        }

        private void DisableCompressionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.LightmapCompressionDisabled = DisableCompressionCheckbox.Checked;
        }

        private void DisableNoiseRemovalCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.LightmapDisableFiltering = DisableNoiseRemovalCheckbox.Checked;
        }

        private void DisableLightCalcCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.DisableLightingCalculations = DisableLightCalcCheckbox.Checked;
        }

        private void ViewLogButton_Click(object sender, EventArgs e)
        {
            BuildLogWindow LogWindow = new();
            LogWindow.BuildLog = BuildOutputLog;
            LogWindow.ShowDialog();
        }
    }
}