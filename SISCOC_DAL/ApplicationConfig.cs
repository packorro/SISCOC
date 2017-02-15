using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace SISCOC_DAL
{
    public class ApplicationConfig
    {
        #region Public static Methods

        public static List<ConnectionStrings> GetConnectionStrings()
        {
            List<ConnectionStrings> connectionStrings = new List<ConnectionStrings>();
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            try
            {
                for (int x = 0; x < configuration.ConnectionStrings.ConnectionStrings.Count; x++)
                {
                    connectionStrings.Add(new ConnectionStrings(configuration.ConnectionStrings.
                        ConnectionStrings[x].ConnectionString, configuration.ConnectionStrings.ConnectionStrings[x].
                        Name));
                }
                return connectionStrings;
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message, Ex.InnerException);
            }
        }

        public static void SaveConnectionString(ConnectionStrings ConnectionString)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            try
            {
                configuration.ConnectionStrings.ConnectionStrings[ConnectionString.ConnectionID].ConnectionString =
                    ConnectionString.ConnectionString;
                configuration.Save(ConfigurationSaveMode.Full);
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message, Ex.InnerException);
            }
        }

        public static void EncryptConnectionStrings()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSection ConnectionStringSection = configuration.ConnectionStrings;
            string ProtectionProvider = "DataProtectionConfigurationProvider";

            try
            {
                if (ConnectionStringSection.SectionInformation.ProtectionProvider == null)
                {
                    ConnectionStringSection.SectionInformation.ProtectSection(ProtectionProvider);
                    ConnectionStringSection.SectionInformation.ForceSave = true;
                    configuration.Save(ConfigurationSaveMode.Full);
                }
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public static void DecryptConnectionStrings()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSection ConnectionStringSection = configuration.ConnectionStrings;

            try
            {
                ConnectionStringSection.SectionInformation.UnprotectSection();
                ConnectionStringSection.SectionInformation.ForceSave = true;
                configuration.Save(ConfigurationSaveMode.Full);
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }
        #endregion
    }
}
