namespace WinLIRC.Configuration.Editor
{
    partial class ConfigurationBuilder
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gridConfig = new System.Windows.Forms.PropertyGrid();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openWinLIRCConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openXMLConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbIndex = new System.Windows.Forms.GroupBox();
            this.cboIndex = new System.Windows.Forms.ComboBox();
            this.tlpMain.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.gbIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gridConfig, 0, 1);
            this.tlpMain.Controls.Add(this.gbIndex, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(342, 573);
            this.tlpMain.TabIndex = 0;
            // 
            // gridConfig
            // 
            this.gridConfig.ContextMenuStrip = this.cmsMenu;
            this.gridConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConfig.HelpVisible = false;
            this.gridConfig.Location = new System.Drawing.Point(3, 53);
            this.gridConfig.Name = "gridConfig";
            this.gridConfig.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.gridConfig.Size = new System.Drawing.Size(336, 517);
            this.gridConfig.TabIndex = 0;
            this.gridConfig.ToolbarVisible = false;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWinLIRCConfigToolStripMenuItem,
            this.openXMLConfigToolStripMenuItem,
            this.saveAsXMLToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsMenu.ShowImageMargin = false;
            this.cmsMenu.ShowItemToolTips = false;
            this.cmsMenu.Size = new System.Drawing.Size(154, 70);
            // 
            // openWinLIRCConfigToolStripMenuItem
            // 
            this.openWinLIRCConfigToolStripMenuItem.Name = "openWinLIRCConfigToolStripMenuItem";
            this.openWinLIRCConfigToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openWinLIRCConfigToolStripMenuItem.Text = "Open WinLIRC Config";
            this.openWinLIRCConfigToolStripMenuItem.Click += new System.EventHandler(this.OnNativeConfigRead);
            // 
            // openXMLConfigToolStripMenuItem
            // 
            this.openXMLConfigToolStripMenuItem.Name = "openXMLConfigToolStripMenuItem";
            this.openXMLConfigToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openXMLConfigToolStripMenuItem.Text = "Open XML Config";
            this.openXMLConfigToolStripMenuItem.Click += new System.EventHandler(this.OnXmlConfigRead);
            // 
            // saveAsXMLToolStripMenuItem
            // 
            this.saveAsXMLToolStripMenuItem.Name = "saveAsXMLToolStripMenuItem";
            this.saveAsXMLToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveAsXMLToolStripMenuItem.Text = "Save As XML";
            this.saveAsXMLToolStripMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // gbIndex
            // 
            this.gbIndex.Controls.Add(this.cboIndex);
            this.gbIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIndex.Location = new System.Drawing.Point(3, 3);
            this.gbIndex.Name = "gbIndex";
            this.gbIndex.Size = new System.Drawing.Size(336, 44);
            this.gbIndex.TabIndex = 3;
            this.gbIndex.TabStop = false;
            // 
            // cboIndex
            // 
            this.cboIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIndex.FormattingEnabled = true;
            this.cboIndex.Location = new System.Drawing.Point(3, 16);
            this.cboIndex.Name = "cboIndex";
            this.cboIndex.Size = new System.Drawing.Size(330, 21);
            this.cboIndex.TabIndex = 0;
            this.cboIndex.SelectedIndexChanged += new System.EventHandler(this.OnIndexChanged);
            // 
            // ConfigurationBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 573);
            this.Controls.Add(this.tlpMain);
            this.Name = "ConfigurationBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinLIRC Configuration Builder";
            this.tlpMain.ResumeLayout(false);
            this.cmsMenu.ResumeLayout(false);
            this.gbIndex.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PropertyGrid gridConfig;
        private System.Windows.Forms.GroupBox gbIndex;
        private System.Windows.Forms.ComboBox cboIndex;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem openWinLIRCConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openXMLConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsXMLToolStripMenuItem;
    }
}