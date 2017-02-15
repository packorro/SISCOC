using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISCOC_DAL;

namespace SISCOC_BL
{
    public class ClsUsuario
    {
          //IdUsuario                 INT NOT NULL PRIMARY KEY IDENTITY(1,1),
          //Apell_Pat                 VARCHAR(70)  NULL DEFAULT '',
          //Apell_Mat                 VARCHAR(70)  NULL DEFAULT '',
          //Nombre                    VARCHAR(50) NOT NULL DEFAULT '',
          //Usuario                   VARCHAR(50) NOT NULL,
          //Contrasena                VARCHAR(20) NOT NULL,  
          //TipoUsuario               INT NOT NULL,  
          //Status                    INT NOT NULL 
        #region Propiedades

            private int _IdUsuario;
            public int IdUsuario
            {
                get { return _IdUsuario; }
                set { _IdUsuario = value; }
            }
            
            private string _Apell_Pat;
            public string Apell_Pat
            {
                get { return _Apell_Pat; }
                set { _Apell_Pat = value; }
            }

            private string _Apell_Mat;
            public string Apell_Mat
            {
                get { return _Apell_Mat; }
                set { _Apell_Mat = value; }
            }

            private string _Nombre;
            public string Nombre
            {
                get { return _Nombre; }
                set { _Nombre = value; }
            }

            private string _Usuario;
            public string Usuario
            {
                get { return _Usuario; }
                set { _Usuario = value; }
            }

            private string _Contrasena;
            public string Contrasena
            {
                get { return _Contrasena; }
                set { _Contrasena = value; }
            }

            private int _TipoUsuario;
            public int TipoUsuario
            {
                get { return _TipoUsuario; }
                set { _TipoUsuario = value; }
            }

            private int _Status;
            public int Status
            {
                get { return _Status; }
                set { _Status = value; }
            }

        #endregion

        #region Metodos Publicos

            //**
            /// <summary>
            /// obtiene una lista de Usuarios Activos
            /// </summary>
            /// <returns>regresa una lista de Usuarios</returns>        
            public static List<ClsUsuario> ListUsuarioTodos()
            {
                List<ClsUsuario> UsuarioList = new List<ClsUsuario>();
                DataTable Table = new DataTable();

                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    Table = DataAccess.ExecuteSPQuery("Sp_Select_UsuarioTodos");
                    DataAccess.CloseConnection();

                    foreach (DataRow Row in Table.Rows)
                    { UsuarioList.Add(FillUsuario(Row)); }

                    return UsuarioList;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }
        
            //**
            /// <summary>
            /// obtiene una lista de Usuarios Activos
            /// </summary>
            /// <returns>regresa una lista de Usuarios</returns>   
            public static List<ClsUsuario> ListUsuario()
            {
                List<ClsUsuario> UsuarioList = new List<ClsUsuario>();
                DataTable Table = new DataTable();

                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    Table = DataAccess.ExecuteSPQuery("Sp_Select_Usuario");
                    DataAccess.CloseConnection();

                    foreach (DataRow Row in Table.Rows)
                    { UsuarioList.Add(FillUsuario(Row)); }

                    return UsuarioList;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            //**
            /// <summary>
            /// Agrega un Usuario
            /// </summary>             
            public static void AddUsuario(ClsUsuario Usuario)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    //Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["MSConta.Properties.Settings." + Cheque.Empresa.ToString() + ""].ToString());
                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Usuario, true), "Sp_Insert_Usuario");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            /// <summary>
            /// Modifica los datos de un Usuario
            /// </summary>
            /// <param name="IdUsuario">Recibe un Objeto de tipo IdUsuario</param>
            public static void UpdateUsuario(ClsUsuario Usuario)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    //Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["MSConta.Properties.Settings." + Cheque.Empresa.ToString() + ""].ToString());
                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Usuario, false), "Sp_Update_Usuario");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

         

        #endregion

        #region Metodos Privados

            private static ClsUsuario FillUsuario(DataRow Row)
            {
                ClsUsuario Usuario = new ClsUsuario();
                try
                {
                    Usuario.IdUsuario = Convert.ToInt32(Row["IdUsuario"]);                    
                    Usuario.Apell_Pat = Convert.ToString(Row["Apell_Pat"]).Trim();
                    Usuario.Apell_Mat = Convert.ToString(Row["Apell_Mat"]);
                    Usuario.Nombre = Convert.ToString(Row["Nombre"]);
                    Usuario.Usuario = Convert.ToString(Row["Usuario"]);
                    Usuario.Contrasena = Convert.ToString(Row["Contrasena"]);
                    Usuario.TipoUsuario = Convert.ToInt16(Row["TipoUsuario"]);
                    Usuario.Status = Convert.ToInt32(Row["Status"]);

                    return Usuario;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            private static SqlParameter[] SplitItemToParameter(ClsUsuario Usuario, bool isNew)
            {
                SqlParameter[] Parameters;
                if (isNew) //para guardar 
                    Parameters = new SqlParameter[7];
                else //para modificar 
                    Parameters = new SqlParameter[8];
                try
                {           
                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.VarChar;
                    Parameters[0].Size = 70;
                    Parameters[0].ParameterName = "@Apell_Pat";
                    Parameters[0].Value = Usuario.Apell_Pat;

                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.VarChar;
                    Parameters[1].Size = 70;
                    Parameters[1].ParameterName = "@Apell_Mat";
                    Parameters[1].Value = Usuario.Apell_Mat;

                    Parameters[2] = new SqlParameter();
                    Parameters[2].Direction = ParameterDirection.Input;
                    Parameters[2].SqlDbType = SqlDbType.VarChar;
                    Parameters[2].Size = 50;
                    Parameters[2].ParameterName = "@Nombre";
                    Parameters[2].Value = Usuario.Nombre;

                    Parameters[3] = new SqlParameter();
                    Parameters[3].Direction = ParameterDirection.Input;
                    Parameters[3].SqlDbType = SqlDbType.VarChar;
                    Parameters[3].Size = 50;
                    Parameters[3].ParameterName = "@Usuario";
                    Parameters[3].Value = Usuario.Usuario;

                    Parameters[4] = new SqlParameter();
                    Parameters[4].Direction = ParameterDirection.Input;
                    Parameters[4].SqlDbType = SqlDbType.VarChar;
                    Parameters[4].Size = 20;
                    Parameters[4].ParameterName = "@Contrasena";
                    Parameters[4].Value = Usuario.Contrasena;

                    
                    Parameters[5] = new SqlParameter();
                    Parameters[5].Direction = ParameterDirection.Input;
                    Parameters[5].SqlDbType = SqlDbType.Int;
                    Parameters[5].ParameterName = "@TipoUsuario";
                    Parameters[5].Value = Usuario.TipoUsuario;


                    Parameters[6] = new SqlParameter();
                    Parameters[6].Direction = ParameterDirection.Input;
                    Parameters[6].SqlDbType = SqlDbType.Int;
                    Parameters[6].ParameterName = "@Status";
                    Parameters[6].Value = Usuario.Status;

                    if (!isNew)
                    {
                        Parameters[7] = new SqlParameter();
                        Parameters[7].Direction = ParameterDirection.Input;
                        Parameters[7].SqlDbType = SqlDbType.Int;
                        Parameters[7].ParameterName = "@IdUsuario";
                        Parameters[7].Value = Usuario.IdUsuario;
                    }
                    
                    return Parameters;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

       #endregion
    }

    #region Filtro
    public class UsuarioFilter
    {
        private string UsuarioData;
        private int TipoBusqueda;

        public UsuarioFilter(string UsuarioData, int TipoBusqueda)
        {
            this.UsuarioData = UsuarioData;
            this.TipoBusqueda = TipoBusqueda;
        }

        public bool BuscaAll(ClsUsuario Usuario)
        {
            switch (TipoBusqueda)
            {   //Busca en la Lista
                case 1: { return Usuario.Apell_Pat.ToLower().Contains(UsuarioData.ToLower()); }
                case 2: { return Usuario.Apell_Mat.ToLower().Contains(UsuarioData.ToLower()); }
                case 3: { return Usuario.Nombre.ToLower().Contains(UsuarioData.ToLower()); }
                //Pa Guardar Modificar
                case 4: { return Usuario.Usuario.ToLower().Equals(UsuarioData.ToLower()); }              
            }
            return false;
        }
    }
    #endregion

   
}
