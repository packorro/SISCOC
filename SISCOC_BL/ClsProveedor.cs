using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISCOC_DAL;

namespace SISCOC_BL
{
    public class ClsProveedor
    {
      //IdProveedor               INT NOT NULL PRIMARY KEY IDENTITY(1,1),
      //TipoPersona               INT NOT NULL DEFAULT '',
      //Apell_Pat                 VARCHAR(70)  NULL DEFAULT '',
      //Apell_Mat                 VARCHAR(70)  NULL DEFAULT '',
      //Nombre                    VARCHAR(150) NOT NULL DEFAULT '',
      //RFC                       VARCHAR(13)  NULL DEFAULT '',        
      //Email                     VARCHAR(70)  NULL DEFAULT '',
      //Telefono                  VARCHAR(12)  NULL DEFAULT '',  
      //Domicilio                 VARCHAR(150) NULL DEFAULT '',
      //Colonia                   VARCHAR(30)  NULL DEFAULT '',
      //Ciudad                    VARCHAR(20)  NULL DEFAULT '',  
      //Status                    INT   NOT NULL


        #region Propiedades
            private int _IdProveedor;
            public int IdProveedor
            {
                get { return _IdProveedor; }
                set { _IdProveedor = value; }
            }

            private int _TipoPersona;
            public int TipoPersona
            {
                get { return _TipoPersona; }
                set { _TipoPersona = value; }
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

            private string _RFC;
            public string RFC
            {
                get { return _RFC; }
                set { _RFC = value; }
            }

            private string _Email;
            public string Email
            {
                get { return _Email; }
                set { _Email = value; }
            }

            private string _Telefono;
            public string Telefono
            {
                get { return _Telefono; }
                set { _Telefono = value; }
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
            /// obtiene una lista de Proveedores Activos
            /// </summary>
            /// <returns>regresa una lista de Proveedores</returns>
            public static List<ClsProveedor> ListProveedor()
            {
                List<ClsProveedor> ProveedorList = new List<ClsProveedor>();
                DataTable Table = new DataTable();

                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    Table = DataAccess.ExecuteSPQuery("Sp_Select_Proveedor");
                    DataAccess.CloseConnection();

                    foreach (DataRow Row in Table.Rows)
                    { ProveedorList.Add(FillProveedor(Row)); }

                    return ProveedorList;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            //**
            /// <summary>
            /// Agrega un Proveedor
            /// </summary>             
            public static void AddProveedor(ClsProveedor Proveedor)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());

                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Proveedor, true), "Sp_Insert_Proveedor");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            /// <summary>
            /// Modifica los datos de un Proveedor
            /// </summary>
            /// <param name="IdProveedor">Recibe un Objeto de tipo IdProveedor</param>
            public static void UpdateProveedor(ClsProveedor Proveedor)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());

                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Proveedor, false), "Sp_Update_Proveedor");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }       

         #endregion

        #region Metodos Privados

            private static ClsProveedor FillProveedor(DataRow Row)
            {
                ClsProveedor Proveedor = new ClsProveedor();
                try
                {
                    Proveedor.IdProveedor = Convert.ToInt32(Row["IdProveedor"]);
                    Proveedor.TipoPersona = Convert.ToInt32(Row["TipoPersona"]);
                    Proveedor.Apell_Pat = Convert.ToString(Row["Apell_Pat"]).Trim();
                    Proveedor.Apell_Mat = Convert.ToString(Row["Apell_Mat"]);
                    Proveedor.Nombre = Convert.ToString(Row["Nombre"]);
                    Proveedor.RFC = Convert.ToString(Row["RFC"]);
                    Proveedor.Email = Convert.ToString(Row["Email"]);
                    Proveedor.Telefono = Convert.ToString(Row["Telefono"]);
                    Proveedor.Domicilio = Convert.ToString(Row["Domicilio"]);
                    Proveedor.Colonia = Convert.ToString(Row["Colonia"]);
                    Proveedor.Ciudad = Convert.ToString(Row["Ciudad"]);
                    Proveedor.Status = Convert.ToInt32(Row["Status"]);

                    return Proveedor;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            private static SqlParameter[] SplitItemToParameter(ClsProveedor Proveedor, bool isNew)
            {
                SqlParameter[] Parameters;
                if (isNew) //para guardar 
                    Parameters = new SqlParameter[11];
                else //para modificar 
                    Parameters = new SqlParameter[12];


                try
                {
                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    //Parameters[0].Size = 2;
                    Parameters[0].ParameterName = "@TipoPersona";
                    Parameters[0].Value = Proveedor.TipoPersona;

                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.VarChar;
                    Parameters[1].Size = 70;
                    Parameters[1].ParameterName = "@Apell_Pat";
                    Parameters[1].Value = Proveedor.Apell_Pat;

                    Parameters[2] = new SqlParameter();
                    Parameters[2].Direction = ParameterDirection.Input;
                    Parameters[2].SqlDbType = SqlDbType.VarChar;
                    Parameters[2].Size = 70;
                    Parameters[2].ParameterName = "@Apell_Mat";
                    Parameters[2].Value = Proveedor.Apell_Mat;

                    Parameters[3] = new SqlParameter();
                    Parameters[3].Direction = ParameterDirection.Input;
                    Parameters[3].SqlDbType = SqlDbType.VarChar;
                    Parameters[3].Size = 150;
                    Parameters[3].ParameterName = "@Nombre";
                    Parameters[3].Value =Proveedor.Nombre;

                    Parameters[4] = new SqlParameter();
                    Parameters[4].Direction = ParameterDirection.Input;
                    Parameters[4].SqlDbType = SqlDbType.VarChar;
                    Parameters[4].Size = 13;
                    Parameters[4].ParameterName = "@RFC";
                    Parameters[4].Value =Proveedor.RFC;

                    Parameters[5] = new SqlParameter();
                    Parameters[5].Direction = ParameterDirection.Input;
                    Parameters[5].SqlDbType = SqlDbType.VarChar;
                    Parameters[5].Size = 70;
                    Parameters[5].ParameterName = "@Email";
                    Parameters[5].Value = Proveedor.Email;

                    Parameters[6] = new SqlParameter();
                    Parameters[6].Direction = ParameterDirection.Input;
                    Parameters[6].SqlDbType = SqlDbType.VarChar;
                    Parameters[6].Size = 12;
                    Parameters[6].ParameterName = "@Telefono";
                    Parameters[6].Value = Proveedor.Telefono;

                    Parameters[7] = new SqlParameter();
                    Parameters[7].Direction = ParameterDirection.Input;
                    Parameters[7].SqlDbType = SqlDbType.VarChar;
                    Parameters[7].Size=150;
                    Parameters[7].ParameterName = "@Domicilio";
                    Parameters[7].Value = Proveedor.Domicilio;


                    Parameters[8] = new SqlParameter();
                    Parameters[8].Direction = ParameterDirection.Input;
                    Parameters[8].SqlDbType = SqlDbType.VarChar;
                    Parameters[8].Size = 30;
                    Parameters[8].ParameterName = "@Colonia";
                    Parameters[8].Value = Proveedor.Colonia;

                    Parameters[9] = new SqlParameter();
                    Parameters[9].Direction = ParameterDirection.Input;
                    Parameters[9].SqlDbType = SqlDbType.VarChar;
                    Parameters[9].Size=20;
                    Parameters[9].ParameterName = "@Ciudad";
                    Parameters[9].Value = Proveedor.Ciudad;
                    
                    Parameters[10] = new SqlParameter();
                    Parameters[10].Direction = ParameterDirection.Input;
                    Parameters[10].SqlDbType = SqlDbType.Int;
                    Parameters[10].ParameterName = "@Status";
                    Parameters[10].Value =Proveedor.Status;

                    if (!isNew)
                    {
                        Parameters[11] = new SqlParameter();
                        Parameters[11].Direction = ParameterDirection.Input;
                        Parameters[11].SqlDbType = SqlDbType.Int;
                        Parameters[11].ParameterName = "@IdProveedor";
                        Parameters[11].Value = Proveedor.IdProveedor;
                    }

                    return Parameters;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

       #endregion       
    }

        #region Filtro
            public class ProveedorFilter
            {
                private string ProveedorData;
                private int TipoBusqueda;

                public ProveedorFilter(string ProveedorData, int TipoBusqueda)
                {
                    this.ProveedorData = ProveedorData;
                    this.TipoBusqueda = TipoBusqueda;
                }

                public bool BuscaAll(ClsProveedor Proveedor)
                {
                    switch (TipoBusqueda)
                    {   //Busca Like 
                        case 1: { return Proveedor.Apell_Pat.ToLower().Contains(ProveedorData.ToLower()); }
                        case 2: { return Proveedor.Apell_Mat.ToLower().Contains(ProveedorData.ToLower()); }
                        case 3: { return Proveedor.Nombre.ToLower().Contains(ProveedorData.ToLower()); }
                        //Pa Guardar
                        case 4: { return Proveedor.Apell_Pat.ToLower().Equals(ProveedorData.ToLower()); }
                        case 5: { return Proveedor.Apell_Mat.ToLower().Equals(ProveedorData.ToLower()); }
                        case 6: { return Proveedor.Nombre.ToLower().Equals(ProveedorData.ToLower()); }
                        case 7: { return Proveedor.RFC.ToLower().Equals(ProveedorData.ToLower()); }
                    }
                    return false;
                }
            }
        #endregion
}
