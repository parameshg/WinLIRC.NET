using System;
using System.Configuration;

namespace WinLIRC.Transmitter.Daemon.Settings
{
    /// <summary>
    /// WinLIRC.NET transmitter settings
    /// </summary>
    public class TransmitterSettings : ConfigurationSection
    {
        /// <summary>
        /// WinLIRC.NET transmitter daemon's settings configuration section
        /// </summary>
        private static string ConfigSection
        {
            get { return "Settings"; }
        }

        /// <summary>
        /// WinLIRC.NET transmitter daemon's default instance of settings
        /// </summary>
        public static TransmitterSettings Default
        {
            get
            {
                return (TransmitterSettings)ConfigurationManager.GetSection(ConfigSection) ??
                new TransmitterSettings();
            }
        }

        /// <summary>
        /// Path to WinLIRC transmitter executable
        /// </summary>
        [ConfigurationProperty("Client", IsRequired = true)]
        public string Client
        {
            get { return (string)this["Client"]; }
        }

        /// <summary>
        /// Path to WinLIRC.NET Remote configuration file
        /// </summary>
        [ConfigurationProperty("RemoteKeys", IsRequired = true)]
        public string RemoteKeys
        {
            get { return (string)this["RemoteKeys"]; }
        }

        /// <summary>
        /// List of applications configured with WinLIRC.NET
        /// </summary>
        [ConfigurationProperty("Applications")]
        [ConfigurationCollection(typeof(ApplicationList), AddItemName = "Add")]
        public ApplicationList Applications
        {
            get { return (ApplicationList)this["Applications"]; }
        }
    }
}