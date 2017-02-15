using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SISCOC_DAL
{
    public class Data
    {
        #region Private Properties

        private ConnectionStrings _ConnectionString;
        private bool _UseTransaction = false;
        private SqlTransaction Transaction;
        private SqlConnection Connection;

        #endregion

        #region Public properties
        public string ConnectionString
        {
            get { return this._ConnectionString.ConnectionString; }
            set { this._ConnectionString.ConnectionString = value; }
        }
        public bool UseTransaction
        {
            get { return this._UseTransaction; }
            set
            {
                if (Connection.State == ConnectionState.Closed)
                    this._UseTransaction = value;
                else
                    throw new Exception("Can't change the UseTransaction value while a connection is open.");
            }
        }
        #endregion

        #region Public methods
       
        public Data()
        {
            this._ConnectionString = new ConnectionStrings();
            this.Connection = new SqlConnection();
        }

        public Data(string ConnectionString)
        {
            try
            {
                this._ConnectionString = new ConnectionStrings(ConnectionString);                
                Connection = new SqlConnection(this.ConnectionString);
                this.OpenConnection();
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public Data(string ConnectionString, bool WithTransaction)
        {
            try
            {
                this._ConnectionString = new ConnectionStrings(ConnectionString);
                this._UseTransaction = WithTransaction;
                Connection = new SqlConnection(this.ConnectionString);
                this.OpenConnection();
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }
        
        #region Coneccion

        public void OpenConnection()
        {
            try
            {
                if (this.ConnectionString.Length > 0)
                {
                    if (this.Connection.State == ConnectionState.Closed)
                        Connection.Open();
                    if (_UseTransaction)
                        Transaction = Connection.BeginTransaction();
                }
                else throw new Exception("No se ha establecido cadena de conexion");
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public void CloseConnection()
        {
            if (this.Connection.State != ConnectionState.Closed)
                Connection.Close();
                Connection.Dispose();
            //if (_UseTransaction)
                 //Transaction = Connection.
            //Connection.  
                //Connection.Open();   
        }

        public void CierraConexion()
        {
            if (this.Connection.State != ConnectionState.Closed)
            {
                Connection.ConnectionString = null;
                this.Connection = new SqlConnection();  
                Connection.Dispose();
                Connection.Close();               
            }
        }

        #endregion       

        /// <summary>
        /// Ejecuta un query recibido por un string
        /// </summary>
        /// <param name="Query"> Recibe un string donde se guarda el query</param>
        /// <returns>Regresa el resultado del query en un DataTable</returns>
        
        public DataTable ExecuteQuery(string Query)
        {
            DataTable Table = new DataTable();
            try
            {
                SqlCommand Command = new SqlCommand(Query, Connection);
                if (_UseTransaction) Command.Transaction = Transaction;
                SqlDataAdapter da = new SqlDataAdapter(Command);
                da.Fill(Table);
                return Table;
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public void ExecuteNonQuery(string NonQuery)
        {
            try
            {
                SqlCommand Command = new SqlCommand(NonQuery, Connection);
                if (_UseTransaction) Command.Transaction = Transaction;
                Command.ExecuteNonQuery();
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        #region ExecuteSPQuery

        public DataTable ExecuteSPQuery(SqlParameter[] Parameters, string SPName)
        {
            DataTable Table = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                Command.CommandType = CommandType.StoredProcedure;
                if (Parameters != null) Command.Parameters.AddRange(Parameters);
                if (_UseTransaction) Command.Transaction = Transaction;
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                return Table;
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public DataTable ExecuteSPQuery(SqlParameter Parameter, string SPName)
        {
            DataTable Table = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                Command.CommandType = CommandType.StoredProcedure;
                if (Parameter != null) Command.Parameters.Add(Parameter);
                if (_UseTransaction) Command.Transaction = Transaction;
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                return Table;
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public DataTable ExecuteSPQuery(string SPName)
        {
            DataTable Table = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                Command.CommandType = CommandType.StoredProcedure;
                if (_UseTransaction) Command.Transaction = Transaction;
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
                return Table;
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        #endregion

        #region ExecuteSPNonQuery

        public int ExecuteSPNonQuery(SqlParameter[] Parameters, string SPName)
        {
            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                if (Parameters != null) Command.Parameters.AddRange(Parameters);
                Command.CommandType = CommandType.StoredProcedure;
                if (_UseTransaction) Command.Transaction = Transaction;
                return Command.ExecuteNonQuery();
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public int ExecuteSPNonQuery(SqlParameter Parameter, string SPName)
        {
            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                if (Parameter != null) Command.Parameters.Add(Parameter);
                Command.CommandType = CommandType.StoredProcedure;
                if (_UseTransaction) Command.Transaction = Transaction;
                return Command.ExecuteNonQuery();
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        #endregion

        #region ExecuteSPQueryDataSet

        public DataSet ExecuteSPQueryDataSet(SqlParameter[] Parameters, string SPName)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                Command.CommandType = CommandType.StoredProcedure;
                if (Parameters != null) Command.Parameters.AddRange(Parameters);
                if (_UseTransaction) Command.Transaction = Transaction;
                Adapter.SelectCommand = Command;
                Adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public DataSet ExecuteSPQueryDataSet(SqlParameter Parameter, string SPName)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                Command.CommandType = CommandType.StoredProcedure;
                if (Parameter != null) Command.Parameters.Add(Parameter);
                if (_UseTransaction) Command.Transaction = Transaction;
                Adapter.SelectCommand = Command;
                Adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public DataSet ExecuteSPQueryDataSet(string SPName)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                Command.CommandType = CommandType.StoredProcedure;
                if (_UseTransaction) Command.Transaction = Transaction;
                Adapter.SelectCommand = Command;
                Adapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        #endregion

        #region ExecuteSPQueryScalar

        public object ExecuteSPQueryScalar(SqlParameter[] Parameters, string SPName)
        {
            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                Command.CommandType = CommandType.StoredProcedure;
                if (Parameters != null) Command.Parameters.AddRange(Parameters);
                if (_UseTransaction) Command.Transaction = Transaction;
                return Command.ExecuteScalar();
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public object ExecuteSPQueryScalar(SqlParameter Parameter, string SPName)
        {
            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                Command.CommandType = CommandType.StoredProcedure;
                if (Parameter != null) Command.Parameters.Add(Parameter);
                if (_UseTransaction) Command.Transaction = Transaction;
                return Command.ExecuteScalar();
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        public object ExecuteSPQueryScalar(string SPName)
        {
            try
            {
                SqlCommand Command = new SqlCommand(SPName, Connection);
                Command.CommandType = CommandType.StoredProcedure;
                if (_UseTransaction) Command.Transaction = Transaction;
                return Command.ExecuteScalar();
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        #endregion

        #region Transacciones

        public void CommitTransaction()
        {
            if (Transaction != null)
                if (Connection.State == ConnectionState.Open)
                {
                    Transaction.Commit();
                    CloseConnection();
                }
                else
                    throw new Exception("No se pudo realizar la transaccion por que no hay coneccion habierta.");
            else
                throw new Exception("no se pudo realizar la transaccion.");
        }

        public void RollBackTransaction()
        {
            if (Transaction != null)
                if (Connection.State == ConnectionState.Open)
                {
                    Transaction.Rollback();
                    CloseConnection();
                }
                else
                    throw new Exception("no se pudo desaser la transaccion por que no hay una coneccion habierta.");
            else
                throw new Exception("no se pudo desaser la transaccion.");
        }

        #endregion        

        #endregion

    }
}

