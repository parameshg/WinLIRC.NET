using System;
using System.Configuration;
using System.Net;

namespace WinLIRC.Receiver.Daemon.Settings
{
    /// <summary>
    /// WinLIRC.NET receiver settings
    /// </summary>
    public class ReceiverSettings : ConfigurationSection
    {
        /// <summary>
        /// WinLIRC.NET receiver daemon's settings configuration section
        /// </summary>
        private static string ConfigSection
        {
            get { return "Settings"; }
        }

        /// <summary>
        /// WinLIRC.NET receiver daemon's default instance of settings
        /// </summary>
        public static ReceiverSettings Default
        {
            get { return (ReceiverSettings)ConfigurationManager.GetSection(ConfigSection) ?? 
                new ReceiverSettings(); }
        }

        /// <summary>
        /// IP address of the machine running WinLIRC server
        /// </summary>
        [ConfigurationProperty("Server", IsRequired = false)]
        public IPAddress Server
        {
            get
            {
                IPAddress result = IPAddress.Loopback;

                if (this["Server"] != null)
                    IPAddress.Parse((string)this["Server"]);

                return result;
            }
        }

        /// <summary>
        /// TCP port to which WinLIRC server emits decoded signals
        /// </summary>
        [ConfigurationProperty("Port", IsRequired = true)]
        public int Port
        {
            get { return (int)this["Port"]; }
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