using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISCOC_DAL;

namespace SISCOC_BL
{
    public class ClsContactoProveedor
    {
      //IdContactoProveedor       INT NOT NULL PRIMARY KEY IDENTITY(1,1),
      //IdProveedor               INT NOT NULL FOREIGN KEY REFERENCES Proveedor(IdProveedor),
      //Apell_Pat                 VARCHAR(70)  NULL DEFAULT '',
      //Apell_Mat                 VARCHAR(70)  NULL DEFAULT '',
      //Nombre                    VARCHAR(150) NOT NULL DEFAULT '',
      //Email                     VARCHAR(70)  NULL DEFAULT '',
      //TelCel                    VARCHAR(12)  NULL DEFAULT '',
      //TelCasa                   VARCHAR(12)  NULL DEFAULT '',  
      //TelEmpresa                VARCHAR(12)  NULL DEFAULT '',
      //Extension                 VARCHAR(10) NULL DEFAULT '',  
      //Status                    INT   NOT NULL

        #region Propiedades

            private int _IdContactoProveedor;
            public int IdContactoProveedor
            {
                get { return _IdContactoProveedor; }
                set { _IdContactoProveedor = value; }
            }

            private int _IdProveedor;
            public int IdProveedor
            {
                get { return _IdProveedor; }
                set { _IdProveedor = value; }
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

            private string _TelEmpresa;
            public string TelEmpresa
            {
                get { return _TelEmpresa; }
                set { _TelEmpresa = value; }
            }

            private string _Extension;
            public string Extension
            {
                get { return _Extension; }
                set { _Extension = value; }
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
            /// obtiene una lista de ContactoProveedores Activos
            /// </summary>
            /// <returns>regresa una lista de ContactoProveedores</returns>
            public static List<ClsContactoProveedor> ListContactoProveedor(int _IdProveedor)
            {
                List<ClsContactoProveedor> ContactoProveedorList = new List<ClsContactoProveedor>();
                DataTable Table = new DataTable();

                try
                {
                    SqlParameter[] Parameters;
                    Parameters = new SqlParameter[1];

                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@IdProveedor";
                    Parameters[0].Value = _IdProveedor;


                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                                       
                    Table = DataAccess.ExecuteSPQuery(Parameters,"Sp_Select_ContactoProveedor");
                    DataAccess.CloseConnection();

                    foreach (DataRow Row in Table.Rows)
                    { ContactoProveedorList.Add(FillContactoProveedor(Row)); }

                    return ContactoProveedorList;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            //**
            /// <summary>
            /// Agrega un ContactoProveedor
            /// </summary>             
            public static void AddContactoProveedor(ClsContactoProveedor ContactoProveedor)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());

                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(ContactoProveedor, true), "Sp_Insert_ContactoProveedor");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            /// <summary>
            /// Modifica los datos de un ContactoProveedor
            /// </summary>
            /// <param name="IdContactoProveedor">Recibe un Objeto de tipo IdContactoProveedor</param>
            public static void UpdateContactoProveedor(ClsContactoProveedor ContactoProveedor)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());

                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(ContactoProveedor, false), "Sp_Update_ContactoProveedor");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

        #endregion

        #region Metodos Privados

            private static ClsContactoProveedor FillContactoProveedor(DataRow Row)
            {
                ClsContactoProveedor ContactoProveedor = new ClsContactoProveedor();
                try
                {


                    ContactoProveedor.IdContactoProveedor = Convert.ToInt32(Row["IdContactoProveedor"]);
                    ContactoProveedor.IdProveedor = Convert.ToInt32(Row["IdProveedor"]);
                    ContactoProveedor.Apell_Pat = Convert.ToString(Row["Apell_Pat"]).Trim();
                    ContactoProveedor.Apell_Mat = Convert.ToString(Row["Apell_Mat"]);
                    ContactoProveedor.Nombre = Convert.ToString(Row["Nombre"]);                    
                    ContactoProveedor.Email = Convert.ToString(Row["Email"]);
                    ContactoProveedor.TelCel = Convert.ToString(Row["TelCel"]);
                    ContactoProveedor.TelCasa = Convert.ToString(Row["TelCasa"]);
                    ContactoProveedor.TelEmpresa = Convert.ToString(Row["TelEmpresa"]);
                    ContactoProveedor.Extension = Convert.ToString(Row["Extension"]);
                    ContactoProveedor.Status = Convert.ToInt32(Row["Status"]);

                    return ContactoProveedor;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            private static SqlParameter[] SplitItemToParameter(ClsContactoProveedor ContactoProveedor, bool isNew)
            {
                SqlParameter[] Parameters;
                if (isNew) //para guardar 
                    Parameters = new SqlParameter[10];
                else //para modificar 
                    Parameters = new SqlParameter[11];

                try
                {
                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@IdProveedor";
                    Parameters[0].Value = ContactoProveedor.IdProveedor;

                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.VarChar;
                    Parameters[1].Size = 70;
                    Parameters[1].ParameterName = "@Apell_Pat";
                    Parameters[1].Value =ContactoProveedor.Apell_Pat;

                    Parameters[2] = new SqlParameter();
                    Parameters[2].Direction = ParameterDirection.Input;
                    Parameters[2].SqlDbType = SqlDbType.VarChar;
                    Parameters[2].Size = 70;
                    Parameters[2].ParameterName = "@Apell_Mat";
                    Parameters[2].Value =ContactoProveedor.Apell_Mat;

                    Parameters[3] = new SqlParameter();
                    Parameters[3].Direction = ParameterDirection.Input;
                    Parameters[3].SqlDbType = SqlDbType.VarChar;
                    Parameters[3].Size = 150;
                    Parameters[3].ParameterName = "@Nombre";
                    Parameters[3].Value =ContactoProveedor.Nombre;

                    Parameters[4] = new SqlParameter();
                    Parameters[4].Direction = ParameterDirection.Input;
                    Parameters[4].SqlDbType = SqlDbType.VarChar;
                    Parameters[4].Size = 70;
                    Parameters[4].ParameterName = "@Email";
                    Parameters[4].Value = ContactoProveedor.Email;

                    Parameters[5] = new SqlParameter();
                    Parameters[5].Direction = ParameterDirection.Input;
                    Parameters[5].SqlDbType = SqlDbType.VarChar;
                    Parameters[5].Size = 12;
                    Parameters[5].ParameterName = "@TelCel";
                    Parameters[5].Value = ContactoProveedor.TelCel;

                    Parameters[6] = new SqlParameter();
                    Parameters[6].Direction = ParameterDirection.Input;
                    Parameters[6].SqlDbType = SqlDbType.VarChar;
                    Parameters[6].Size = 12;
                    Parameters[6].ParameterName = "@TelCasa";
                    Parameters[6].Value = ContactoProveedor.TelCasa;

                    Parameters[7] = new SqlParameter();
                    Parameters[7].Direction = ParameterDirection.Input;
                    Parameters[7].SqlDbType = SqlDbType.VarChar;
                    Parameters[7].Size = 12;
                    Parameters[7].ParameterName = "@TelEmpresa";
                    Parameters[7].Value = ContactoProveedor.TelEmpresa;
                    
                    Parameters[8] = new SqlParameter();
                    Parameters[8].Direction = ParameterDirection.Input;
                    Parameters[8].SqlDbType = SqlDbType.VarChar;
                    Parameters[8].Size = 10;
                    Parameters[8].ParameterName = "@Extension";
                    Parameters[8].Value = ContactoProveedor.Extension;

                    Parameters[9] = new SqlParameter();
                    Parameters[9].Direction = ParameterDirection.Input;
                    Parameters[9].SqlDbType = SqlDbType.Int;
                    Parameters[9].ParameterName = "@Status";
                    Parameters[9].Value = ContactoProveedor.Status;

                    if (!isNew)
                    {
                        Parameters[10] = new SqlParameter();
                        Parameters[10].Direction = ParameterDirection.Input;
                        Parameters[10].SqlDbType = SqlDbType.Int;
                        Parameters[10].ParameterName = "@IdContactoProveedor";
                        Parameters[10].Value = ContactoProveedor.IdContactoProveedor;
                    }

                    return Parameters;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

        #endregion       
    }
        #region Filtro
            public class ContactoProveedorFilter
            {
                private string ContactoProveedorData;
                private int TipoBusqueda;

                public ContactoProveedorFilter(string ContactoProveedorData, int TipoBusqueda)
                {
                    this.ContactoProveedorData = ContactoProveedorData;
                    this.TipoBusqueda = TipoBusqueda;
                }

                public bool BuscaAll(ClsContactoProveedor ContactoProveedor)
                {
                    switch (TipoBusqueda)
                    {   //Busca Like 
                        case 1: { return ContactoProveedor.Apell_Pat.ToLower().Contains(ContactoProveedorData.ToLower()); }
                        case 2: { return ContactoProveedor.Apell_Mat.ToLower().Contains(ContactoProveedorData.ToLower()); }
                        case 3: { return ContactoProveedor.Nombre.ToLower().Contains(ContactoProveedorData.ToLower()); }
                        //Pa Guardar
                        case 4: { return ContactoProveedor.Apell_Pat.ToLower().Equals(ContactoProveedorData.ToLower()); }
                        case 5: { return ContactoProveedor.Apell_Mat.ToLower().Equals(ContactoProveedorData.ToLower()); }
                        case 6: { return ContactoProveedor.Nombre.ToLower().Equals(ContactoProveedorData.ToLower()); }                        
                    }
                    return false;
                }
            }
        #endregion
}
