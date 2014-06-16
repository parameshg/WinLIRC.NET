using System;
using System.Configuration;

namespace WinLIRC.Transmitter.Daemon.Settings
{
    /// <summary>
    /// List of WinLIRC.NET application settings
    /// </summary>
    public class ApplicationList : ConfigurationElementCollection
    {
        /// <summary>
        /// WinLIRC.NET application iterator via index
        /// </summary>
        /// <param name="index">Index of the configured WinLIRC.NET application</param>
        /// <returns>WinLIRC application settings</returns>
        public ApplicationSetting this[int index]
        {
            get { return base.BaseGet(index) as ApplicationSetting; }
        }

        /// <summary>
        /// WinLIRC.NET application iterator via its identifier
        /// </summary>
        /// <param name="id">Identifier of the configured WinLIRC.NET application</param>
        /// <returns>WinLIRC application settings</returns>
        public ApplicationSetting this[Guid id]
        {
            get
            {
                ApplicationSetting result = null;

                foreach (ApplicationSetting config in this)
                {
                    if (config.ID.Equals(id))
                    {
                        result = config;
                        break;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// WinLIRC.NET application iterator via its name
        /// </summary>
        /// <param name="name">Name of the configured WinLIRC.NET application</param>
        /// <returns>WinLIRC application settings</returns>
        public new ApplicationSetting this[string name]
        {
            get
            {
                ApplicationSetting result = null;

                foreach (ApplicationSetting config in this)
                {
                    if (config.Name.ToLower().Trim() == name.ToLower().Trim())
                    {
                        result = config;
                        break;
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Creates new WinLIRC.NET application settings
        /// </summary>
        /// <returns>WinLIRC application settings</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new ApplicationSetting();
        }

        /// <summary>
        /// Gets WinLIRC.NET application key
        /// </summary>
        /// <param name="element">WinLIRC.NET application</param>
        /// <returns>Identifier of WinLIRC.NET application</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ApplicationSetting)element).Name;
        }
    }
}