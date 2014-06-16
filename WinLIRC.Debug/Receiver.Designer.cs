namespace WinLIRC.Debug
{
    partial class Receiver
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
            this.lvSignals = new System.Windows.Forms.ListView();
            this.colTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRemoteName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRemoteKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKeyCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKeyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRepeatCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSignals
            // 
            this.lvSignals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTimestamp,
            this.colRemoteName,
            this.colRemoteKey,
            this.colKeyCode,
            this.colKeyName,
            this.colRepeatCount});
            this.lvSignals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSignals.FullRowSelect = true;
            this.lvSignals.GridLines = true;
            this.lvSignals.Location = new System.Drawing.Point(3, 3);
            this.lvSignals.MultiSelect = false;
            this.lvSignals.Name = "lvSignals";
            this.lvSignals.ShowGroups = false;
            this.lvSignals.Size = new System.Drawing.Size(786, 437);
            this.lvSignals.TabIndex = 0;
            this.lvSignals.UseCompatibleStateImageBehavior = false;
            this.lvSignals.View = System.Windows.Forms.View.Details;
            // 
            // colTimestamp
            // 
            this.colTimestamp.Text = "Timestamp";
            this.colTimestamp.Width = 150;
            // 
            // colRemoteName
            // 
            this.colRemoteName.Text = "Remote Name";
            this.colRemoteName.Width = 100;
            // 
            // colRemoteKey
            // 
            this.colRemoteKey.Text = "Remote Key";
            this.colRemoteKey.Width = 100;
            // 
            // colKeyCode
            // 
            this.colKeyCode.Text = "Key Code";
            this.colKeyCode.Width = 150;
            // 
            // colKeyName
            // 
            this.colKeyName.Text = "Key Name";
            this.colKeyName.Width = 100;
            // 
            // colRepeatCount
            // 
            this.colRepeatCount.Text = "Repeat Count";
            this.colRepeatCount.Width = 100;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lvSignals, 0, 0);
            this.tlpMain.Controls.Add(this.tlpActions, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Size = new System.Drawing.Size(792, 473);
            this.tlpMain.TabIndex = 1;
            // 
            // tlpActions
            // 
            this.tlpActions.ColumnCount = 4;
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpActions.Controls.Add(this.btnStop, 2, 0);
            this.tlpActions.Controls.Add(this.btnStart, 1, 0);
            this.tlpActions.Controls.Add(this.btnClose, 3, 0);
            this.tlpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpActions.Location = new System.Drawing.Point(0, 443);
            this.tlpActions.Margin = new System.Windows.Forms.Padding(0);
            this.tlpActions.Name = "tlpActions";
            this.tlpActions.RowCount = 1;
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpActions.Size = new System.Drawing.Size(792, 30);
            this.tlpActions.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(595, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 24);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.OnStop);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(495, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 24);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.OnStart);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(695, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 24);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnClose);
            // 
            // Receiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.tlpMain);
            this.Name = "Receiver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinLIRC.NET Signal Receiver";
            this.tlpMain.ResumeLayout(false);
            this.tlpActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSignals;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpActions;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader colTimestamp;
        private System.Windows.Forms.ColumnHeader colRemoteName;
        private System.Windows.Forms.ColumnHeader colRemoteKey;
        private System.Windows.Forms.ColumnHeader colKeyCode;
        private System.Windows.Forms.ColumnHeader colKeyName;
        private System.Windows.Forms.ColumnHeader colRepeatCount;
    }
}