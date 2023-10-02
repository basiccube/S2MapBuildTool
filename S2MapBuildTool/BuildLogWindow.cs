namespace S2MapBuildTool
{
    public partial class BuildLogWindow : Form
    {
        public string BuildLog;
        public BuildLogWindow()
        {
            InitializeComponent();
        }

        private void BuildLogWindow_Load(object sender, EventArgs e)
        {
            UpdateLogText();
        }

        public void UpdateLogText()
        {
            LogTextBox.Text = BuildLog;
        }
    }
}
