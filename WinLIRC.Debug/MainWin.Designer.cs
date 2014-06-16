namespace WinLIRC.Debug
{
    partial class MainWin
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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMessage});
            this.StatusBar.Location = new System.Drawing.Point(0, 551);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(792, 22);
            this.StatusBar.TabIndex = 2;
            // 
            // StatusMessage
            // 
            this.StatusMessage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusMessage.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(746, 17);
            this.StatusMessage.Spring = true;
            this.StatusMessage.Text = "Ready";
            this.StatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.StatusBar);
            this.IsMdiContainer = true;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinLIRC.NET Debug Console";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusMessage;
    }
}

