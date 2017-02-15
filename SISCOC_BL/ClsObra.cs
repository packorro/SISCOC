using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISCOC_DAL;


namespace SISCOC_BL
{
    public class ClsObra
    {
      //IdObra                     INT NOT NULL PRIMARY KEY IDENTITY(1,1),
      //NombreObra                 VARCHAR(30) NOT NULL,
      //DescripcionObra            VARCHAR(70) NOT NULL,
      //FechaIni                   DATETIME NOT NULL DEFAULT '0000-00-00',
      //FechaFin                   DATETIME NOT NULL DEFAULT '0000-00-00',
      //MontoEstimado              FLOAT NOT NULL,
      //Zona                       INT NOT NULL,
      //Status                     INT NOT NULL


        #region Propiedades

            private int _IdObra;
            public int IdObra
            {
                get { return _IdObra; }
                set { _IdObra = value; }
            }

            private string _NombreObra;
            public string NombreObra
            {
                get { return _NombreObra; }
                set { _NombreObra = value; }
            }

            private string _DescripcionObra;
            public string DescripcionObra
            {
                get { return _DescripcionObra; }
                set { _DescripcionObra = value; }
            }

            private DateTime _FechaIni;
            public DateTime FechaIni
            {
                get { return _FechaIni; }
                set { _FechaIni = value; }
            }

            private DateTime _FechaFin;
            public DateTime FechaFin
            {
                get { return _FechaFin; }
                set { _FechaFin = value; }
            }


            private decimal _MontoEstimado;
            public decimal MontoEstimado
            {
                get { return _MontoEstimado; }
                set { _MontoEstimado = value; }
            }

            private int _Zona;
            public int Zona
            {
                get { return _Zona; }
                set { _Zona = value; }
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
            /// obtiene una Obra Activa
            /// </summary>
            /// <returns>regresa una Obra</returns>
            public static List<ClsObra> ListObra(int _IdObra)
            {
                List<ClsObra> ObraList = new List<ClsObra>();
                DataTable Table = new DataTable();

                try
                {
                    SqlParameter[] Parameters;
                    Parameters = new SqlParameter[1];

                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@IdObra";
                    Parameters[0].Value = _IdObra;
                    

                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    Table = DataAccess.ExecuteSPQuery(Parameters,"Sp_Select_Obra");
                    DataAccess.CloseConnection();

                    foreach (DataRow Row in Table.Rows)
                    { ObraList.Add(FillObra(Row)); }

                    return ObraList;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }


            //**
            /// <summary>
            /// obtiene una lista de ClsObras Activas
            /// </summary>
            /// <returns>regresa una lista de ClsObra</returns>
            public static List<ClsObra> ListObras()
            {
                List<ClsObra> ObrasList = new List<ClsObra>();
                DataTable Table = new DataTable();

                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    Table = DataAccess.ExecuteSPQuery("Sp_Select_Obras");
                    DataAccess.CloseConnection();

                    foreach (DataRow Row in Table.Rows)
                    { ObrasList.Add(FillObra(Row)); }

                    return ObrasList;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

        
            
            //**
            /// <summary>
            /// obtiene una lista de ClsObras Activas Nombre Like 
            /// </summary>
            /// <returns>regresa una lista de ClsObra</returns>
            public static List<ClsObra> ListObrasLike(string _NombreObra)
            {
                List<ClsObra> ObrasList = new List<ClsObra>();
                DataTable Table = new DataTable();

                try
                {
                    SqlParameter[] Parameters;
                    Parameters = new SqlParameter[1];

                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.VarChar;
                    Parameters[0].Size = 30;
                    Parameters[0].ParameterName = "@NombreObra";
                    Parameters[0].Value = _NombreObra;
                    
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    Table = DataAccess.ExecuteSPQuery(Parameters,"Sp_Select_ObraLike");
                    DataAccess.CloseConnection();

                    foreach (DataRow Row in Table.Rows)
                    { ObrasList.Add(FillObra(Row)); }

                    return ObrasList;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }




            //**
            /// <summary>
            /// Agrega un Obra
            /// </summary>             
            public static void AddObra(ClsObra Obra)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    
                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Obra, true), "Sp_Insert_Obra");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            /// <summary>
            /// Modifica los datos de un Obra
            /// </summary>
            /// <param name="IdObra">Recibe un Objeto de tipo IdObra</param>
            public static void UpdateObra(ClsObra Obra)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    
                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Obra, false), "Sp_Update_Obra");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }
         

       #endregion

        #region Metodos Privados

            private static ClsObra FillObra(DataRow Row)
            {
                ClsObra Obra = new ClsObra();
                try
                {
                    Obra.IdObra = Convert.ToInt32(Row["IdObra"]);
                    Obra.NombreObra = Convert.ToString(Row["NombreObra"]);
                    Obra.DescripcionObra = Convert.ToString(Row["DescripcionObra"]);
                    Obra.FechaIni = Convert.ToDateTime(Row["FechaIni"]);
                    Obra.FechaFin = Convert.ToDateTime(Row["FechaFin"]);
                    Obra.MontoEstimado = Convert.ToDecimal(Row["MontoEstimado"]);                    
                    Obra.Zona = Convert.ToInt32(Row["Zona"]);
                    Obra.Status = Convert.ToInt32(Row["Status"]);

                    return Obra;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            private static SqlParameter[] SplitItemToParameter(ClsObra Obra, bool isNew)
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
                    Parameters[0].Size = 30;
                    Parameters[0].ParameterName = "@NombreObra";
                    Parameters[0].Value = Obra.NombreObra;

                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.VarChar;
                    Parameters[1].Size = 70;
                    Parameters[1].ParameterName = "@DescripcionObra";
                    Parameters[1].Value = Obra.DescripcionObra;

                    Parameters[2] = new SqlParameter();
                    Parameters[2].Direction = ParameterDirection.Input;
                    Parameters[2].SqlDbType = SqlDbType.DateTime;
                    Parameters[2].ParameterName = "@FechaIni";
                    Parameters[2].Value = Obra.FechaIni;

                    Parameters[3] = new SqlParameter();
                    Parameters[3].Direction = ParameterDirection.Input;
                    Parameters[3].SqlDbType = SqlDbType.DateTime;
                    Parameters[3].ParameterName = "@FechaFin";
                    Parameters[3].Value = Obra.FechaFin;
                    
                    Parameters[4] = new SqlParameter();
                    Parameters[4].Direction = ParameterDirection.Input;
                    Parameters[4].SqlDbType = SqlDbType.Decimal;
                    Parameters[4].ParameterName = "@MontoEstimado";
                    Parameters[4].Value = Obra.MontoEstimado;
                    
                    Parameters[5] = new SqlParameter();
                    Parameters[5].Direction = ParameterDirection.Input;
                    Parameters[5].SqlDbType = SqlDbType.Int;
                    Parameters[5].ParameterName = "@Zona";
                    Parameters[5].Value = Obra.Zona;

                    Parameters[6] = new SqlParameter();
                    Parameters[6].Direction = ParameterDirection.Input;
                    Parameters[6].SqlDbType = SqlDbType.Int;
                    Parameters[6].ParameterName = "@Status";
                    Parameters[6].Value = Obra.Status;

                    if (!isNew)
                    {
                        Parameters[7] = new SqlParameter();
                        Parameters[7].Direction = ParameterDirection.Input;
                        Parameters[7].SqlDbType = SqlDbType.Int;
                        Parameters[7].ParameterName = "@IdObra";
                        Parameters[7].Value = Obra.IdObra;
                    }
                    
                    return Parameters;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

       #endregion
    }

        #region Filtro
            public class CatalogoObraFilter
            {
                private string CatalogoObraData;

                public CatalogoObraFilter(string CatalogoObraData)
                {
                    this.CatalogoObraData = CatalogoObraData;
                }

                //busca por Nombre de la Obra :te devuelve un entero
                public bool BuscaCatalogoObraNombreLike(ClsObra CatalogoObra)
                {
                    return CatalogoObra.NombreObra.ToLower().Contains(CatalogoObraData.ToLower());
                }

                //busca por nombre de Obra: Valida si es =
                public bool BuscaCatalogoObraNombre(ClsObra CatalogoObra)
                {
                    return CatalogoObra.NombreObra.ToLower().Equals(CatalogoObraData.ToLower());
                }

            }
        #endregion
}
