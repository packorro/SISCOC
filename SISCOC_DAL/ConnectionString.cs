using System;
using System.Collections.Generic;
using System.Text;

namespace SISCOC_DAL
{
    public class ConnectionStrings:Object
    {
        #region Properties
        private string _Server;
        public string Server
        {
            get { return _Server; }
            set { _Server = value; }
        }

        private string _User;
        public string User
        {
            get { return _User; }
            set
            {
                if (_User != null)
                    _ConnectionString.Replace(_User, value);
                _User = value;
            }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private string _DataBase;
        public string DataBase
        {
            get { return _DataBase; }
            set { _DataBase = value; }
        }

        private bool _IntegratedSecurity = false;
        public bool IntegratedSecurity
        {
            get { return _IntegratedSecurity; }
            set { _IntegratedSecurity = value; }
        }

        private string _ConnectionString;
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set
            {
                _ConnectionString = value;
                this.SplitConnectionString();
            }
        }

        private string _ConnectionID;
        public string ConnectionID
        {
            get { return _ConnectionID; }
            set { _ConnectionID = value; }
        }
        #endregion

        #region Public methods
        public ConnectionStrings() { }

        public ConnectionStrings(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public ConnectionStrings(string ConnectionString, string ConnectionID)
        {
            this.ConnectionString = ConnectionString;
            this.ConnectionID = ConnectionID;
        }

        public ConnectionStrings(string Server, string DataBase, string UserId, string Password, bool IntegratedSecurity)
        {
            this.ConnectionString = CreateMsSqlConnectionString(Server, DataBase, UserId, Password, IntegratedSecurity);
        }

        public void ReMakeMsSqlConnectionString()
        {
            if (!this.IntegratedSecurity)
                this._ConnectionString = "Data Source=" + _Server + ";Initial Catalog=" + _DataBase + ";User ID=" +
                    _User + ";Password=" + _Password + ";";
            else
                this._ConnectionString = "Data Source=" + _Server + ";Initial Catalog=" + _DataBase +
                    ";Integrated Security=True;";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            ConnectionStrings ConnectionString = (ConnectionStrings)obj;
            return this.ConnectionID == ConnectionString.ConnectionID && this.DataBase == ConnectionString.DataBase
                && this.IntegratedSecurity == ConnectionString.IntegratedSecurity && this.Password ==
                ConnectionString.Password && this.Server == ConnectionString.Server && this.User ==
                ConnectionString.User && this.ConnectionString == ConnectionString.ConnectionString;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Private methods
        private void SplitConnectionString()
        {
            String[] ConnectionStringSplitted;
            try
            {
                ConnectionStringSplitted = this._ConnectionString.Split(new char[] { ';' },
                    StringSplitOptions.RemoveEmptyEntries);

                for (int x = 0; x < ConnectionStringSplitted.Length; x++)
                {
                    switch (ConnectionStringSplitted[x].Substring(0, ConnectionStringSplitted[x].IndexOf("=")).ToLower())
                    {
                        case "data source":
                            this.Server = ConnectionStringSplitted[x].Substring(
                                ConnectionStringSplitted[x].IndexOf('=') + 1);
                            break;
                        case "initial catalog":
                            this.DataBase = ConnectionStringSplitted[x].Substring(
                                ConnectionStringSplitted[x].IndexOf('=') + 1);
                            break;
                        case "user id":
                            this.User = ConnectionStringSplitted[x].Substring(
                                ConnectionStringSplitted[x].IndexOf('=') + 1);
                            break;
                        case "password":
                            this.Password = ConnectionStringSplitted[x].Substring(
                                ConnectionStringSplitted[x].IndexOf('=') + 1);
                            break;
                        case "integrated security":
                            try
                            {
                                this.IntegratedSecurity = Convert.ToBoolean(ConnectionStringSplitted[x].Substring(
                                    ConnectionStringSplitted[x].IndexOf('=') + 1));
                            }
                            catch (Exception) { IntegratedSecurity = false; }
                            break;
                    }
                }
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }

        }
        #endregion

        #region Public Static Methods
        public static string CreateMsSqlConnectionString(string Server, string DataBase, string User, string Password,
            bool IntegratedSecurity)
        {
            string ConnectionString = "";
            if (!IntegratedSecurity)
                ConnectionString = "Data Source=" + Server + ";Initial Catalog=" + DataBase + ";User ID=" +
                    User + ";Password=" + Password + ";";
            else
                ConnectionString = "Data Source=" + Server + ";Initial Catalog=" + DataBase + 
                    ";Integrated Security=True;";
            return ConnectionString;
        }
        #endregion
    }
}
