using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISCOC_DAL;

namespace SISCOC_BL
{
    public class ClsCliente
    {
      //IdCliente                 INT NOT NULL PRIMARY KEY IDENTITY(1,1),
      //TipoPersona               INT NOT  NULL DEFAULT 1,
      //Apell_Pat                 VARCHAR(70)  NULL DEFAULT '',
      //Apell_Mat                 VARCHAR(70)  NULL DEFAULT '',
      //Nombre                    VARCHAR(150) NOT NULL DEFAULT '',
      //RFC                       VARCHAR(13)  NULL DEFAULT '',
      //CURP                      VARCHAR(18)  NULL DEFAULT '',
      //NSS                       VARCHAR(11)  NULL DEFAULT '',
      //FechaNac                  DATETIME  NULL DEFAULT '', 
      //Monto                     FLOAT NOT NULL,
      //Subsidio                  FLOAT NOT NULL,
      //MontoBruto                FLOAT NOT NULL,
      //Zona                      INT   NOT NULL,
      //Status                    INT   NOT NULL

        #region Propiedades

            private int _IdCliente;
            public int IdCliente
            {
                get { return _IdCliente; }
                set { _IdCliente = value; }
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

            private string _CURP;
            public string CURP
            {
                get { return _CURP; }
                set { _CURP = value; }
            }

            private string _NSS;
            public string NSS
            {
                get { return _NSS; }
                set { _NSS = value; }
            }

            private DateTime _FechaNac;
            public DateTime FechaNac
            {
                get { return _FechaNac; }
                set { _FechaNac = value; }
            }
          
            private decimal _Monto;
            public decimal Monto
            {
                get { return _Monto; }
                set { _Monto = value; }
            }

            private decimal _Subsidio;
            public decimal Subsidio
            {
                get { return _Subsidio; }
                set { _Subsidio = value; }
            }

            private decimal _MontoBruto;
            public decimal MontoBruto
            {
                get { return _MontoBruto; }
                set { _MontoBruto = value; }
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
            /// obtiene una lista de Clientes Activos
            /// </summary>
            /// <returns>regresa una lista de Clientes</returns>
            public static List<ClsCliente> ListCliente()
            {
                List<ClsCliente> ClienteList = new List<ClsCliente>();
                DataTable Table = new DataTable();

                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    Table = DataAccess.ExecuteSPQuery("Sp_Select_Cliente");
                    DataAccess.CloseConnection();

                    foreach (DataRow Row in Table.Rows)
                    { ClienteList.Add(FillCliente(Row)); }

                    return ClienteList;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            //**
            /// <summary>
            /// Agrega un Cliente
            /// </summary>             
            public static void AddCliente(ClsCliente Cliente)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    //Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["MSConta.Properties.Settings." + Cheque.Empresa.ToString() + ""].ToString());
                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Cliente, true), "Sp_Insert_Cliente");
                    DataAccess.CloseConnection();
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            /// <summary>
            /// Modifica los datos de un Cliente
            /// </summary>
            /// <param name="IdCliente">Recibe un Objeto de tipo IdCliente</param>
            public static void UpdateCliente(ClsCliente Cliente)
            {
                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                    //Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["MSConta.Properties.Settings." + Cheque.Empresa.ToString() + ""].ToString());
                    DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Cliente, false), "Sp_Update_Cliente");
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

            private static ClsCliente FillCliente(DataRow Row)
            {
                ClsCliente Cliente = new ClsCliente();
                try
                {
                    Cliente.IdCliente = Convert.ToInt32(Row["IdCliente"]);
                    Cliente.TipoPersona = Convert.ToInt32(Row["TipoPersona"]);
                    Cliente.Apell_Pat = Convert.ToString(Row["Apell_Pat"]).Trim();
                    Cliente.Apell_Mat = Convert.ToString(Row["Apell_Mat"]);
                    Cliente.Nombre = Convert.ToString(Row["Nombre"]);
                    Cliente.RFC = Convert.ToString(Row["RFC"]);
                    Cliente.CURP = Convert.ToString(Row["CURP"]);
                    Cliente.NSS = Convert.ToString(Row["NSS"]);
                    Cliente.FechaNac = Convert.ToDateTime(Row["FechaNac"]);                    
                    Cliente.Monto = Convert.ToDecimal(Row["Monto"]);
                    Cliente.Subsidio = Convert.ToDecimal(Row["Subsidio"]);
                    Cliente.MontoBruto = Convert.ToDecimal(Row["MontoBruto"]);
                    Cliente.Zona = Convert.ToInt32(Row["Zona"]);
                    Cliente.Status = Convert.ToInt32(Row["Status"]);

                    return Cliente;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

            private static SqlParameter[] SplitItemToParameter(ClsCliente Cliente, bool isNew)
            {
                SqlParameter[] Parameters;
                if (isNew) //para guardar 
                    Parameters = new SqlParameter[13];
                else //para modificar 
                    Parameters = new SqlParameter[14];


                try
                {                
                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    //Parameters[0].Size = 2;
                    Parameters[0].ParameterName = "@TipoPersona";
                    Parameters[0].Value = Cliente.TipoPersona;

                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.VarChar;
                    Parameters[1].Size = 70;
                    Parameters[1].ParameterName = "@Apell_Pat";
                    Parameters[1].Value = Cliente.Apell_Pat;

                    Parameters[2] = new SqlParameter();
                    Parameters[2].Direction = ParameterDirection.Input;
                    Parameters[2].SqlDbType = SqlDbType.VarChar;
                    Parameters[2].Size = 70;
                    Parameters[2].ParameterName = "@Apell_Mat";
                    Parameters[2].Value = Cliente.Apell_Mat;

                    Parameters[3] = new SqlParameter();
                    Parameters[3].Direction = ParameterDirection.Input;
                    Parameters[3].SqlDbType = SqlDbType.VarChar;
                    Parameters[3].Size = 150;
                    Parameters[3].ParameterName = "@Nombre";
                    Parameters[3].Value = Cliente.Nombre;

                    Parameters[4] = new SqlParameter();
                    Parameters[4].Direction = ParameterDirection.Input;
                    Parameters[4].SqlDbType = SqlDbType.VarChar;
                    Parameters[4].Size = 13;
                    Parameters[4].ParameterName = "@RFC";
                    Parameters[4].Value = Cliente.RFC;

                    Parameters[5] = new SqlParameter();
                    Parameters[5].Direction = ParameterDirection.Input;
                    Parameters[5].SqlDbType = SqlDbType.VarChar;
                    Parameters[5].Size = 13;
                    Parameters[5].ParameterName = "@CURP";
                    Parameters[5].Value = Cliente.CURP;

                    Parameters[6] = new SqlParameter();
                    Parameters[6].Direction = ParameterDirection.Input;
                    Parameters[6].SqlDbType = SqlDbType.VarChar;
                    Parameters[6].Size = 13;
                    Parameters[6].ParameterName = "@NSS";
                    Parameters[6].Value = Cliente.NSS;

                    Parameters[7] = new SqlParameter();
                    Parameters[7].Direction = ParameterDirection.Input;
                    Parameters[7].SqlDbType = SqlDbType.DateTime;
                    Parameters[7].ParameterName = "@FechaNac";
                    Parameters[7].Value = Cliente.FechaNac;

      
                    Parameters[8] = new SqlParameter();
                    Parameters[8].Direction = ParameterDirection.Input;
                    Parameters[8].SqlDbType = SqlDbType.Decimal;
                    Parameters[8].ParameterName = "@Monto";
                    Parameters[8].Value = Cliente.Monto;

                    Parameters[9] = new SqlParameter();
                    Parameters[9].Direction = ParameterDirection.Input;
                    Parameters[9].SqlDbType = SqlDbType.Decimal;
                    Parameters[9].ParameterName = "@Subsidio";
                    Parameters[9].Value = Cliente.Subsidio;

                    Parameters[10] = new SqlParameter();
                    Parameters[10].Direction = ParameterDirection.Input;
                    Parameters[10].SqlDbType = SqlDbType.Decimal;
                    Parameters[10].ParameterName = "@MontoBruto";
                    Parameters[10].Value = Cliente.MontoBruto;

                    Parameters[11] = new SqlParameter();
                    Parameters[11].Direction = ParameterDirection.Input;
                    Parameters[11].SqlDbType = SqlDbType.Int;
                    Parameters[11].ParameterName = "@Zona";
                    Parameters[11].Value = Cliente.Zona;

                    Parameters[12] = new SqlParameter();
                    Parameters[12].Direction = ParameterDirection.Input;
                    Parameters[12].SqlDbType = SqlDbType.Int;
                    Parameters[12].ParameterName = "@Status";
                    Parameters[12].Value = Cliente.Status;

                    if (!isNew)
                    {
                        Parameters[13] = new SqlParameter();
                        Parameters[13].Direction = ParameterDirection.Input;
                        Parameters[13].SqlDbType = SqlDbType.Int;
                        Parameters[13].ParameterName = "@IdCliente";
                        Parameters[13].Value = Cliente.IdCliente;
                    }


                    return Parameters;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

        #endregion

    }
    #region Filtro
    public class ClienteFilter
    {
        private string ClienteData;
        private int TipoBusqueda;

        public ClienteFilter(string ClienteData, int TipoBusqueda)
        {
            this.ClienteData = ClienteData;
            this.TipoBusqueda = TipoBusqueda;
        }

        public bool BuscaAll(ClsCliente Cliente)
        {
            switch (TipoBusqueda)
            {   //Busca Like 
                case 1: { return Cliente.Apell_Pat.ToLower().Contains(ClienteData.ToLower()); }
                case 2: { return Cliente.Apell_Mat.ToLower().Contains(ClienteData.ToLower()); }
                case 3: { return Cliente.Nombre.ToLower().Contains(ClienteData.ToLower()); }
                //Pa Guardar
                case 4: { return Cliente.Apell_Pat.ToLower().Equals(ClienteData.ToLower()); }
                case 5: { return Cliente.Apell_Mat.ToLower().Equals(ClienteData.ToLower()); }
                case 6: { return Cliente.Nombre.ToLower().Equals(ClienteData.ToLower()); }
                case 7: { return Cliente.RFC.ToLower().Equals(ClienteData.ToLower()); }

            }
            return false;
        }
    }
    #endregion
}
