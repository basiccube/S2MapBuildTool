namespace S2MapBuildTool
{
    partial class BuildLogWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildLogWindow));
            LogTextBox = new TextBox();
            SuspendLayout();
            // 
            // LogTextBox
            // 
            LogTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogTextBox.Location = new Point(12, 12);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            LogTextBox.ScrollBars = ScrollBars.Both;
            LogTextBox.Size = new Size(529, 340);
            LogTextBox.TabIndex = 0;
            // 
            // BuildLogWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 364);
            Controls.Add(LogTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(400, 400);
            Name = "BuildLogWindow";
            Text = "Map Build Log";
            Load += BuildLogWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LogTextBox;
    }
}