using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinLIRC.Configuration.Editor
{
    /// <summary>
    /// WinLIRC.NET configuration editor user interface
    /// </summary>
    public partial class ConfigurationBuilder : Form
    {
        /// <summary>
        /// List of WinLIRC.NET configurations
        /// </summary>
        private List<irconfig> _config;

        /// <summary>
        /// Source of WinLIRC configuration
        /// </summary>
        private ConfigurationSource _file;

        /// <summary>
        /// Initializes WinLIRC.NET configuration editor user interface
        /// </summary>
        public ConfigurationBuilder()
        {
            try
            {
                InitializeComponent();

                _file = new ConfigurationSource();
            }
            catch (Exception e)
            {
                Program.HandleException(e);
            }
        }

        /// <summary>
        /// Handler to save WinLIRC.NET XML formatted configuration file
        /// </summary>
        /// <param name="sender">Object which raised the event</param>
        /// <param name="e">Event arguments</param>
        private void Save(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.AddExtension = true;
                d.CheckFileExists = false;
                d.CheckPathExists = true;
                d.RestoreDirectory = true;
                d.Title = "Select XML WinLIRC configuration file to save";
                d.ValidateNames = true;
                d.Filter = "XML Files|*.xml";
                d.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (d.ShowDialog() == DialogResult.OK)
                {
                    Invalidate();

                    if (_file != null && _config != null)
                    {
                        _file.Write(new FileInfo(d.FileName), _config);

                        MessageBox.Show("Operation successfully completed!");
                    }
                }
            }
            catch (Exception err)
            {
                Program.HandleException(err);
            }
        }

        /// <summary>
        /// Handler to handle when WinLIRC.NET configuration object is changed in the user interface
        /// </summary>
        /// <param name="sender">Object which raised the event</param>
        /// <param name="e">Event arguments</param>
        private void OnIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_config != null && _config[cboIndex.SelectedIndex] != null)
                    gridConfig.SelectedObject = _config[cboIndex.SelectedIndex];
            }
            catch (Exception err)
            {
                Program.HandleException(err);
            }
        }
        
        /// <summary>
        /// Handler to read WinLIRC native configuration
        /// </summary>
        /// <param name="sender">Object which raised the event</param>
        /// <param name="e">Event arguments</param>
        private void OnNativeConfigRead(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.AddExtension = true;
                d.CheckFileExists = true;
                d.CheckPathExists = true;
                d.Multiselect = false;
                d.RestoreDirectory = true;
                d.Title = "Select native WinLIRC configuration file to open";
                d.ValidateNames = true;
                d.Filter = "All Files|*.*";
                d.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (d.ShowDialog() == DialogResult.OK)
                {
                    Invalidate();

                    if (_file != null)
                    {
                        _config = _file.ReadConfig(new FileInfo(d.FileName));

                        if (_config != null && _config.Count > 0)
                        {
                            foreach (irconfig c in _config)
                                cboIndex.Items.Add(c.name);

                            cboIndex.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Program.HandleException(err);
            }
        }

        /// <summary>
        /// Handler to read WinLIRC.NET XML formatted configuration
        /// </summary>
        /// <param name="sender">Object which raised the event</param>
        /// <param name="e">Event arguments</param>
        private void OnXmlConfigRead(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.AddExtension = true;
                d.CheckFileExists = true;
                d.CheckPathExists = true;
                d.Multiselect = false;
                d.RestoreDirectory = true;
                d.Title = "Select XML WinLIRC configuration file to open";
                d.ValidateNames = true;
                d.Filter = "All Files|*.*";
                d.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (d.ShowDialog() == DialogResult.OK)
                {
                    Invalidate();

                    if (_file != null)
                    {
                        _config = _file.ReadXml(new FileInfo(d.FileName));

                        if (_config != null && _config.Count > 0)
                        {
                            foreach (irconfig c in _config)
                                cboIndex.Items.Add(c.name);

                            cboIndex.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Program.HandleException(err);
            }
        }
    }
}