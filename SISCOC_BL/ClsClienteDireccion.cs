using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISCOC_DAL;

namespace SISCOC_BL
{
    public class ClsClienteDireccion
    {
      //IdClienteDireccion        INT NOT NULL PRIMARY KEY PRIMARY KEY IDENTITY(1,1),
      //IdCliente                 INT NOT NULL FOREIGN KEY REFERENCES Cliente(IdCliente),
      //Domicilio                 VARCHAR(50)  NULL DEFAULT '',
      //Colonia                   VARCHAR(30)  NULL DEFAULT '',
      //Ciudad                    VARCHAR(20)  NULL DEFAULT '',
      //Email                     VARCHAR(70)  NULL DEFAULT '',
      //TelCel                    VARCHAR(12)  NULL DEFAULT '',
      //TelCasa                   VARCHAR(12)  NULL DEFAULT '',
      //Empresa                   VARCHAR(50)  NULL DEFAULT '',
      //TelEmpresa                VARCHAR(12)  NULL DEFAULT '',

        #region Propiedades

            private int _IdClienteDireccion;
            public int IdClienteDireccion
            {
                get { return _IdClienteDireccion; }
                set { _IdClienteDireccion = value; }
            }


            private int _IdCliente;
            public int IdCliente
            {
                get { return _IdCliente; }
                set { _IdCliente = value; }
            }

            private string _Domicilio;
            public string Domicilio
            {
                get { return _Domicilio; }
                set { _Domicilio = value; }
            }

            private string _Colonia;
            public string Colonia
                {
                    get { return _Colonia; }
                    set { _Colonia = value; }
                }

            private string _Ciudad;
            public string Ciudad
            {
                get { return _Ciudad; }
                set { _Ciudad = value; }
            }

            private string _Email;
            public string Email
            {
                get { return _Email; }
                set { _Email = value; }
            }

            private string _TelCel;
            public string TelCel
            {
                get { return _TelCel; }
                set { _TelCel = value; }
            }

            private string _TelCasa;
            public string TelCasa
            {
                get { return _TelCasa; }
                set { _TelCasa = value; }
            }

            private string _Empresa;
            public string Empresa
            {
                get { return _Empresa; }
                set { _Empresa = value; }
            }

            private string _TelEmpresa;
            public string TelEmpresa
            {
                get { return _TelEmpresa; }
                set { _TelEmpresa = value; }
            }

        #endregion

        #region Metodos Publicos

            /// <summary>
            /// obtiene una lista de ClienteDireccion
            /// </summary>
            /// <returns>regresa una lista de ClienteDireccion</returns>
        public static List<ClsClienteDireccion> ListClienteDireccion(int _IdCliente)
            {
                List<ClsClienteDireccion> ClienteDireccionList = new List<ClsClienteDireccion>();
                DataTable Table = new DataTable();

                try
                {
                    SqlParameter[] Parameters;
                    Parameters = new SqlParameter[1];

                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@IdCliente";
                    Parameters[0].Value = _IdCliente;                  

                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    
                    Table = DataAccess.ExecuteSPQuery(Parameters, "Sp_Select_ClienteDireccion");
                    DataAccess.CloseConnection();

                    foreach (DataRow Row in Table.Rows)
                    { ClienteDireccionList.Add(FillClienteDireccion(Row)); }                    

                    return ClienteDireccionList;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            ////**
            ///// <summary>
            ///// obtiene una lista de ClienteDireccions Activos
            ///// </summary>
            ///// <returns>regresa una lista de ClienteDireccions</returns>
            //public static List<ClsClienteDireccion> ListClienteDireccion(int _IdCliente)
            //{
            //    List<ClsClienteDireccion> ClienteDireccionList = new List<ClsClienteDireccion>();
            //    DataTable Table = new DataTable();

            //    try
            //    {
            //        Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
            //        DataAccess.ExecuteSPQuery(SplitItemToParameter(_IdCliente, true), "Sp_Insert_ClienteDireccion");
            //        //Table = DataAccess.ExecuteSPQuery("Sp_Select_ClienteDireccion");
            //        DataAccess.CloseConnection();

            //        foreach (DataRow Row in Table.Rows)
            //        { ClienteDireccionList.Add(FillClienteDireccion(Row)); }

            //        return ClienteDireccionList;
            //    }
            //    catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            //}

            //**
            /// <summary>
            /// Agrega un ClienteDireccion
            /// </summary>             
            public static void AddClienteDireccion(ClsClienteDireccion ClienteDireccion)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    //Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["MSConta.Properties.Settings." + Cheque.Empresa.ToString() + ""].ToString());
                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(ClienteDireccion, true), "Sp_Insert_ClienteDireccion");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            /// <summary>
            /// Modifica los datos de un ClienteDireccion
            /// </summary>
            /// <param name="IdClienteDireccion">Recibe un Objeto de tipo IdCliente</param>
            public static void UpdateClienteDireccion(ClsClienteDireccion ClienteDireccion)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    //Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["MSConta.Properties.Settings." + Cheque.Empresa.ToString() + ""].ToString());
                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(ClienteDireccion, false), "Sp_Update_ClienteDireccion");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            ///// <summary>
            ///// Modifica los datos de una cheque
            ///// </summary>
            ///// <param name="Contacto">Recibe parametros</param>
            //public static void UpdateCheque(int IDPoliza, Int16 status, int UsuarioModifica, string Empresa)
            //{
            //    try
            //    {
            //        SqlParameter[] Parameters;
            //        Parameters = new SqlParameter[3];

            //        Parameters[0] = new SqlParameter();
            //        Parameters[0].Direction = ParameterDirection.Input;
            //        Parameters[0].SqlDbType = SqlDbType.Int;
            //        Parameters[0].ParameterName = "@IdPoliza";
            //        Parameters[0].Value = IDPoliza;

            //        Parameters[1] = new SqlParameter();
            //        Parameters[1].Direction = ParameterDirection.Input;
            //        Parameters[1].SqlDbType = SqlDbType.Bit;
            //        Parameters[1].ParameterName = "@Status";
            //        Parameters[1].Value = status;

            //        Parameters[2] = new SqlParameter();
            //        Parameters[2].Direction = ParameterDirection.Input;
            //        Parameters[2].SqlDbType = SqlDbType.Int;
            //        Parameters[2].ParameterName = "@UsuarioModifica";
            //        Parameters[2].Value = UsuarioModifica;


            //        Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["MSConta.Properties.Settings." + Empresa + ""].ToString());
            //        DataAccess.ExecuteSPNonQuery(Parameters, "Sp_UpDate_Cheque");
            //        DataAccess.CloseConnection();
            //    }
            //    catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            //}

       #endregion

        #region Metodos Privados

        private static ClsClienteDireccion FillClienteDireccion(DataRow Row)
            {
                ClsClienteDireccion ClienteDireccion = new ClsClienteDireccion();
                try
                {
                    ClienteDireccion.IdClienteDireccion = Convert.ToInt32(Row["IdClienteDireccion"]);
                    ClienteDireccion.IdCliente = Convert.ToInt32(Row["IdCliente"]);
                    ClienteDireccion.Domicilio = Convert.ToString(Row["Domicilio"]);
                    ClienteDireccion.Colonia = Convert.ToString(Row["Colonia"]);
                    ClienteDireccion.Ciudad = Convert.ToString(Row["Ciudad"]);
                    ClienteDireccion.Email = Convert.ToString(Row["Email"]);
                    ClienteDireccion.TelCel = Convert.ToString(Row["TelCel"]);
                    ClienteDireccion.TelCasa = Convert.ToString(Row["TelCasa"]);
                    ClienteDireccion.Empresa = Convert.ToString(Row["Empresa"]);
                    ClienteDireccion.TelEmpresa = Convert.ToString(Row["TelEmpresa"]);           

                    return ClienteDireccion;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            private static SqlParameter[] SplitItemToParameter(ClsClienteDireccion ClienteDireccion, bool isNew)
            {
                SqlParameter[] Parameters;
                if (isNew) //para guardar 
                    Parameters = new SqlParameter[9];
                else //para modificar 
                    Parameters = new SqlParameter[10];
                
                try
                {
                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@IdCliente";
                    Parameters[0].Value = ClienteDireccion.IdCliente;

                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.VarChar;
                    Parameters[1].Size = 50;
                    Parameters[1].ParameterName = "@Domicilio";
                    Parameters[1].Value = ClienteDireccion.Domicilio;

                    Parameters[2] = new SqlParameter();
                    Parameters[2].Direction = ParameterDirection.Input;
                    Parameters[2].SqlDbType = SqlDbType.VarChar;
                    Parameters[2].Size = 30;
                    Parameters[2].ParameterName = "@Colonia";
                    Parameters[2].Value = ClienteDireccion.Colonia;

                    Parameters[3] = new SqlParameter();
                    Parameters[3].Direction = ParameterDirection.Input;
                    Parameters[3].SqlDbType = SqlDbType.VarChar;
                    Parameters[3].Size = 20;
                    Parameters[3].ParameterName = "@Ciudad";
                    Parameters[3].Value = ClienteDireccion.Ciudad;

                    Parameters[4] = new SqlParameter();
                    Parameters[4].Direction = ParameterDirection.Input;
                    Parameters[4].SqlDbType = SqlDbType.VarChar;
                    Parameters[4].Size = 70;
                    Parameters[4].ParameterName = "@Email";
                    Parameters[4].Value = ClienteDireccion.Email;

                    Parameters[5] = new SqlParameter();
                    Parameters[5].Direction = ParameterDirection.Input;
                    Parameters[5].SqlDbType = SqlDbType.VarChar;
                    Parameters[5].Size = 12;
                    Parameters[5].ParameterName = "@TelCel";
                    Parameters[5].Value = ClienteDireccion.TelCel;

                    Parameters[6] = new SqlParameter();
                    Parameters[6].Direction = ParameterDirection.Input;
                    Parameters[6].SqlDbType = SqlDbType.VarChar;
                    Parameters[6].Size = 12;
                    Parameters[6].ParameterName = "@TelCasa";
                    Parameters[6].Value = ClienteDireccion.TelCasa;

                    Parameters[7] = new SqlParameter();
                    Parameters[7].Direction = ParameterDirection.Input;
                    Parameters[7].SqlDbType = SqlDbType.VarChar;
                    Parameters[7].Size = 50;
                    Parameters[7].ParameterName = "@Empresa";
                    Parameters[7].Value = ClienteDireccion.Empresa;

                    Parameters[8] = new SqlParameter();
                    Parameters[8].Direction = ParameterDirection.Input;
                    Parameters[8].SqlDbType = SqlDbType.VarChar;
                    Parameters[8].Size = 12;
                    Parameters[8].ParameterName = "@TelEmpresa";
                    Parameters[8].Value = ClienteDireccion.TelEmpresa;      

                    if (!isNew)
                    {
                        Parameters[9] = new SqlParameter();
                        Parameters[9].Direction = ParameterDirection.Input;
                        Parameters[9].SqlDbType = SqlDbType.Int;
                        Parameters[9].ParameterName = "@IdClienteDireccion";
                        Parameters[9].Value = ClienteDireccion.IdClienteDireccion;
                    }
                    
                    return Parameters;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

        #endregion
    }


}
