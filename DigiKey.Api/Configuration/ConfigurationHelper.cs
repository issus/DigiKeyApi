using System;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace DigiKey.Api.Configuration
{

    /// <summary>
    /// Helper class that wraps up working with System.Configuration.Configuration
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class ConfigurationHelper : IConfigurationHelper
    {
        /// <summary>
        /// This object represents the config file
        /// </summary>
        protected System.Configuration.Configuration config;

        /// <summary>
        /// Updates the value for the specified key in the AppSettings of the Config file.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Update(string key, string value)
        {
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }
        }

        /// <summary>
        /// Gets the attribute or value of the key.
        /// </summary>
        /// <param name="attrName">Name of the attribute.</param>
        /// <returns>string value of attribute</returns>
        public string GetAttribute(string attrName)
        {
            try
            {
                return config.AppSettings.Settings[attrName] == null
                    ? null
                    : config.AppSettings.Settings[attrName].Value;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the boolean attribute or value.
        /// </summary>
        /// <param name="attrName">Name of the attribute.</param>
        /// <returns>true of false</returns>
        public bool GetBooleanAttribute(string attrName)
        {
            try
            {
                var value = GetAttribute(attrName);
                return value != null && Convert.ToBoolean(value);
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            try
            {
                config.Save(ConfigurationSaveMode.Full);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException cee)
            {
                //_log.DebugFormat($"Exception Message {cee.Message}");
                throw;
            }
            catch (System.Exception ex)
            {
                //_log.DebugFormat($"Exception Message {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Refreshes the application settings.
        /// </summary>
        public void RefreshAppSettings()
        {
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
