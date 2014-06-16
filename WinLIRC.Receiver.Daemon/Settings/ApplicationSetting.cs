using System;
using System.Configuration;

namespace WinLIRC.Receiver.Daemon.Settings
{
    /// <summary>
    /// WinLIRC.NET application settings
    /// </summary>
    public class ApplicationSetting : ConfigurationElement
    {
        /// <summary>
        /// Idenfier of WinLIRC.NET application
        /// </summary>
        [ConfigurationProperty("ID", IsRequired = true)]
        public Guid ID
        {
            get { return (Guid)this["ID"]; }
        }

        /// <summary>
        /// Name of WinLIRC.NET application
        /// </summary>
        [ConfigurationProperty("Name", IsRequired = true)]
        public string Name
        {
            get { return (string)this["Name"]; }
        }

        /// <summary>
        /// Communication channel used by WinLIRC.NET application
        /// </summary>
        [ConfigurationProperty("Queue", IsRequired = true)]
        public string Queue
        {
            get { return (string)this["Queue"]; }
        }
    }
}