using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LogTextBox.Text = BuildLog;
        }
    }
}
