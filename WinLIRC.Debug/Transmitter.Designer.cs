namespace WinLIRC.Debug
{
    partial class Transmitter
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
            this.tlpNumberKeys = new System.Windows.Forms.TableLayoutPanel();
            this.btnPound = new System.Windows.Forms.Button();
            this.btnNumber0 = new System.Windows.Forms.Button();
            this.btnStar = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.tlpArrows = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.btnChannelUp = new System.Windows.Forms.Button();
            this.btnChannelDown = new System.Windows.Forms.Button();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.btnArrowUp = new System.Windows.Forms.Button();
            this.btnArrowRight = new System.Windows.Forms.Button();
            this.btnArrowDown = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.tlpActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpNumberKeys.SuspendLayout();
            this.tlpArrows.SuspendLayout();
            this.tlpActions.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpNumberKeys
            // 
            this.tlpNumberKeys.ColumnCount = 3;
            this.tlpNumberKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpNumberKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpNumberKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpNumberKeys.Controls.Add(this.btnPound, 0, 3);
            this.tlpNumberKeys.Controls.Add(this.btnNumber0, 0, 3);
            this.tlpNumberKeys.Controls.Add(this.btnStar, 0, 3);
            this.tlpNumberKeys.Controls.Add(this.btnNumber9, 2, 2);
            this.tlpNumberKeys.Controls.Add(this.btnNumber8, 1, 2);
            this.tlpNumberKeys.Controls.Add(this.btnNumber7, 0, 2);
            this.tlpNumberKeys.Controls.Add(this.btnNumber6, 2, 1);
            this.tlpNumberKeys.Controls.Add(this.btnNumber5, 1, 1);
            this.tlpNumberKeys.Controls.Add(this.btnNumber4, 0, 1);
            this.tlpNumberKeys.Controls.Add(this.btnNumber3, 2, 0);
            this.tlpNumberKeys.Controls.Add(this.btnNumber2, 1, 0);
            this.tlpNumberKeys.Controls.Add(this.btnNumber1, 0, 0);
            this.tlpNumberKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNumberKeys.Location = new System.Drawing.Point(196, 0);
            this.tlpNumberKeys.Margin = new System.Windows.Forms.Padding(0);
            this.tlpNumberKeys.Name = "tlpNumberKeys";
            this.tlpNumberKeys.RowCount = 4;
            this.tlpNumberKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNumberKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNumberKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNumberKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNumberKeys.Size = new System.Drawing.Size(196, 274);
            this.tlpNumberKeys.TabIndex = 0;
            // 
            // btnPound
            // 
            this.btnPound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPound.Enabled = false;
            this.btnPound.Location = new System.Drawing.Point(3, 207);
            this.btnPound.Name = "btnPound";
            this.btnPound.Size = new System.Drawing.Size(59, 64);
            this.btnPound.TabIndex = 11;
            this.btnPound.Text = "#";
            this.btnPound.UseVisualStyleBackColor = true;
            this.btnPound.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnNumber0
            // 
            this.btnNumber0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber0.Location = new System.Drawing.Point(68, 207);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(59, 64);
            this.btnNumber0.TabIndex = 10;
            this.btnNumber0.Tag = "Number0";
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = true;
            this.btnNumber0.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnStar
            // 
            this.btnStar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStar.Enabled = false;
            this.btnStar.Location = new System.Drawing.Point(133, 207);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(60, 64);
            this.btnStar.TabIndex = 9;
            this.btnStar.Text = "*";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnNumber9
            // 
            this.btnNumber9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber9.Location = new System.Drawing.Point(133, 139);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(60, 62);
            this.btnNumber9.TabIndex = 8;
            this.btnNumber9.Tag = "Number9";
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = true;
            this.btnNumber9.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnNumber8
            // 
            this.btnNumber8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber8.Location = new System.Drawing.Point(68, 139);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(59, 62);
            this.btnNumber8.TabIndex = 7;
            this.btnNumber8.Tag = "Number8";
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = true;
            this.btnNumber8.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnNumber7
            // 
            this.btnNumber7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber7.Location = new System.Drawing.Point(3, 139);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(59, 62);
            this.btnNumber7.TabIndex = 6;
            this.btnNumber7.Tag = "Number7";
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = true;
            this.btnNumber7.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnNumber6
            // 
            this.btnNumber6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber6.Location = new System.Drawing.Point(133, 71);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(60, 62);
            this.btnNumber6.TabIndex = 5;
            this.btnNumber6.Tag = "Number6";
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = true;
            this.btnNumber6.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnNumber5
            // 
            this.btnNumber5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber5.Location = new System.Drawing.Point(68, 71);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(59, 62);
            this.btnNumber5.TabIndex = 4;
            this.btnNumber5.Tag = "Number5";
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = true;
            this.btnNumber5.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnNumber4
            // 
            this.btnNumber4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber4.Location = new System.Drawing.Point(3, 71);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(59, 62);
            this.btnNumber4.TabIndex = 3;
            this.btnNumber4.Tag = "Number4";
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            this.btnNumber4.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnNumber3
            // 
            this.btnNumber3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber3.Location = new System.Drawing.Point(133, 3);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(60, 62);
            this.btnNumber3.TabIndex = 2;
            this.btnNumber3.Tag = "Number3";
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            this.btnNumber3.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnNumber2
            // 
            this.btnNumber2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber2.Location = new System.Drawing.Point(68, 3);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(59, 62);
            this.btnNumber2.TabIndex = 1;
            this.btnNumber2.Tag = "Number2";
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            this.btnNumber2.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnNumber1
            // 
            this.btnNumber1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber1.Location = new System.Drawing.Point(3, 3);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(59, 62);
            this.btnNumber1.TabIndex = 0;
            this.btnNumber1.Tag = "Number1";
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            this.btnNumber1.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // tlpArrows
            // 
            this.tlpArrows.ColumnCount = 3;
            this.tlpArrows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpArrows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpArrows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpArrows.Controls.Add(this.btnCancel, 0, 4);
            this.tlpArrows.Controls.Add(this.btnSelect, 1, 2);
            this.tlpArrows.Controls.Add(this.btnVolumeUp, 2, 3);
            this.tlpArrows.Controls.Add(this.btnVolumeDown, 0, 3);
            this.tlpArrows.Controls.Add(this.btnChannelUp, 2, 1);
            this.tlpArrows.Controls.Add(this.btnChannelDown, 0, 1);
            this.tlpArrows.Controls.Add(this.btnArrowLeft, 0, 2);
            this.tlpArrows.Controls.Add(this.btnArrowUp, 1, 1);
            this.tlpArrows.Controls.Add(this.btnArrowRight, 2, 2);
            this.tlpArrows.Controls.Add(this.btnArrowDown, 1, 3);
            this.tlpArrows.Controls.Add(this.btnMenu, 0, 0);
            this.tlpArrows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArrows.Location = new System.Drawing.Point(0, 0);
            this.tlpArrows.Margin = new System.Windows.Forms.Padding(0);
            this.tlpArrows.Name = "tlpArrows";
            this.tlpArrows.RowCount = 5;
            this.tlpArrows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpArrows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpArrows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpArrows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpArrows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpArrows.Size = new System.Drawing.Size(196, 274);
            this.tlpArrows.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.tlpArrows.SetColumnSpan(this.btnCancel, 3);
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(3, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Tag = "Cancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.Location = new System.Drawing.Point(68, 105);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(59, 62);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Tag = "Select";
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVolumeUp.Location = new System.Drawing.Point(133, 173);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(60, 62);
            this.btnVolumeUp.TabIndex = 8;
            this.btnVolumeUp.Tag = "VolumeUp";
            this.btnVolumeUp.Text = "Volume   +";
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVolumeDown.Location = new System.Drawing.Point(3, 173);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(59, 62);
            this.btnVolumeDown.TabIndex = 7;
            this.btnVolumeDown.Tag = "VolumeDown";
            this.btnVolumeDown.Text = "Volume   -";
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            this.btnVolumeDown.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnChannelUp
            // 
            this.btnChannelUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChannelUp.Location = new System.Drawing.Point(133, 37);
            this.btnChannelUp.Name = "btnChannelUp";
            this.btnChannelUp.Size = new System.Drawing.Size(60, 62);
            this.btnChannelUp.TabIndex = 5;
            this.btnChannelUp.Tag = "ChannelUp";
            this.btnChannelUp.Text = "Channel +";
            this.btnChannelUp.UseVisualStyleBackColor = true;
            this.btnChannelUp.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnChannelDown
            // 
            this.btnChannelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChannelDown.Location = new System.Drawing.Point(3, 37);
            this.btnChannelDown.Name = "btnChannelDown";
            this.btnChannelDown.Size = new System.Drawing.Size(59, 62);
            this.btnChannelDown.TabIndex = 4;
            this.btnChannelDown.Tag = "ChannelDown";
            this.btnChannelDown.Text = "Channel  -";
            this.btnChannelDown.UseVisualStyleBackColor = true;
            this.btnChannelDown.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowLeft.Location = new System.Drawing.Point(3, 105);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Size = new System.Drawing.Size(59, 62);
            this.btnArrowLeft.TabIndex = 0;
            this.btnArrowLeft.Tag = "ArrowLeft";
            this.btnArrowLeft.Text = "Left";
            this.btnArrowLeft.UseVisualStyleBackColor = true;
            this.btnArrowLeft.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnArrowUp
            // 
            this.btnArrowUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowUp.Location = new System.Drawing.Point(68, 37);
            this.btnArrowUp.Name = "btnArrowUp";
            this.btnArrowUp.Size = new System.Drawing.Size(59, 62);
            this.btnArrowUp.TabIndex = 1;
            this.btnArrowUp.Tag = "ArrowUp";
            this.btnArrowUp.Text = "Up";
            this.btnArrowUp.UseVisualStyleBackColor = true;
            this.btnArrowUp.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnArrowRight
            // 
            this.btnArrowRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowRight.Location = new System.Drawing.Point(133, 105);
            this.btnArrowRight.Name = "btnArrowRight";
            this.btnArrowRight.Size = new System.Drawing.Size(60, 62);
            this.btnArrowRight.TabIndex = 2;
            this.btnArrowRight.Tag = "ArrowRight";
            this.btnArrowRight.Text = "Right";
            this.btnArrowRight.UseVisualStyleBackColor = true;
            this.btnArrowRight.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnArrowDown
            // 
            this.btnArrowDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowDown.Location = new System.Drawing.Point(68, 173);
            this.btnArrowDown.Name = "btnArrowDown";
            this.btnArrowDown.Size = new System.Drawing.Size(59, 62);
            this.btnArrowDown.TabIndex = 3;
            this.btnArrowDown.Tag = "ArrowDown";
            this.btnArrowDown.Text = "Down";
            this.btnArrowDown.UseVisualStyleBackColor = true;
            this.btnArrowDown.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnMenu
            // 
            this.tlpArrows.SetColumnSpan(this.btnMenu, 3);
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(190, 28);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Tag = "Menu";
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // tlpActions
            // 
            this.tlpActions.ColumnCount = 5;
            this.tlpMain.SetColumnSpan(this.tlpActions, 2);
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpActions.Controls.Add(this.btnMute, 4, 0);
            this.tlpActions.Controls.Add(this.btnRecord, 0, 0);
            this.tlpActions.Controls.Add(this.btnStop, 3, 0);
            this.tlpActions.Controls.Add(this.btnPlay, 1, 0);
            this.tlpActions.Controls.Add(this.btnPause, 2, 0);
            this.tlpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpActions.Location = new System.Drawing.Point(0, 274);
            this.tlpActions.Margin = new System.Windows.Forms.Padding(0);
            this.tlpActions.Name = "tlpActions";
            this.tlpActions.RowCount = 1;
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpActions.Size = new System.Drawing.Size(392, 49);
            this.tlpActions.TabIndex = 2;
            // 
            // btnMute
            // 
            this.btnMute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMute.Location = new System.Drawing.Point(315, 3);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(74, 43);
            this.btnMute.TabIndex = 4;
            this.btnMute.Tag = "Mute";
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnRecord
            // 
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecord.Location = new System.Drawing.Point(3, 3);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(72, 43);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Tag = "Record";
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Location = new System.Drawing.Point(237, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 43);
            this.btnStop.TabIndex = 3;
            this.btnStop.Tag = "Stop";
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.Location = new System.Drawing.Point(81, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(72, 43);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Tag = "Play";
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPause.Location = new System.Drawing.Point(159, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(72, 43);
            this.btnPause.TabIndex = 2;
            this.btnPause.Tag = "Pause";
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.OnRemoteKeyPress);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tlpActions, 0, 1);
            this.tlpMain.Controls.Add(this.tlpNumberKeys, 1, 0);
            this.tlpMain.Controls.Add(this.tlpArrows, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMain.Size = new System.Drawing.Size(392, 323);
            this.tlpMain.TabIndex = 3;
            // 
            // Transmitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 323);
            this.Controls.Add(this.tlpMain);
            this.Name = "Transmitter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinLIRC.NET Remote Control";
            this.tlpNumberKeys.ResumeLayout(false);
            this.tlpArrows.ResumeLayout(false);
            this.tlpActions.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNumberKeys;
        private System.Windows.Forms.Button btnPound;
        private System.Windows.Forms.Button btnNumber0;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.TableLayoutPanel tlpArrows;
        private System.Windows.Forms.Button btnChannelUp;
        private System.Windows.Forms.Button btnChannelDown;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.Button btnArrowUp;
        private System.Windows.Forms.Button btnArrowRight;
        private System.Windows.Forms.Button btnArrowDown;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.TableLayoutPanel tlpActions;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnMute;
    }
}