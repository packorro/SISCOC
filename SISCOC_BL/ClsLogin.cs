using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SISCOC_DAL;


namespace SISCOC_BL
{
    public class ClsLogin
    {
        #region Metodos Publicos
            /// <summary>
            /// Verifica Usuario y password del Usuario            
            /// </summary>
            /// <returns>regresa una lista de Usuario, Contraseña </returns>
            public static DataSet LoguinUsuario(string _Usuario, string _Contrasena)
            {
                DataSet dsLoguin = new DataSet();
                try
                {
                    SqlParameter[] Parameters;
                    Parameters = new SqlParameter[2];

                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.VarChar;
                    Parameters[0].Size = 50;
                    Parameters[0].ParameterName = "@Usuario";
                    Parameters[0].Value = _Usuario;

                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.VarChar;
                    Parameters[1].Size = 20;
                    Parameters[1].ParameterName = "@Contrasena";
                    Parameters[1].Value = _Contrasena;

                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    dsLoguin = DataAccess.ExecuteSPQueryDataSet(Parameters, "Sp_Select_UsuarioLogin");
                    DataAccess.CloseConnection();
                    return dsLoguin;
                }
                catch (Exception Ex)
                { throw new Exception(Ex.Message, Ex.InnerException); }
            }



            /// <summary>
            /// Usa la Master            
            /// </summary>
            /// <returns>BD Master Para Cerrar Conexiones </returns>
            public static void CloseLoguinUsuario()
            {                
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    DataAccess.ExecuteNonQuery("  USE MASTER " +                                                                  
                                                                  "  ALTER DATABASE [ANJU] SET SINGLE_USER WITH ROLLBACK IMMEDIATE  " +
                                                                  "  ALTER DATABASE [ANJU] SET SINGLE_USER WITH NO_WAIT  " +
                                                                  "  ALTER DATABASE [ANJU] SET MULTI_USER");
                    DataAccess.CloseConnection();                    
                }
                catch (Exception Ex)
                { throw new Exception(Ex.Message, Ex.InnerException); }
            }    

        #endregion


    }
}
