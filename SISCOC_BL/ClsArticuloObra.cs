using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SISCOC_DAL;      

namespace SISCOC_BL
{
    public class ClsArticuloObra
    {

        //IdArticuloObra	    int
        //IdObra	            int
        //Proveedor	            int
        //Factura	            char
        //IdArticulo	        int
        //CantidadArt	        float
        //NombreObra            char
       

        #region Properties

        private int _IdArticuloObra;
        public int IdArticuloObra
        {
            get { return _IdArticuloObra; }
            set { _IdArticuloObra = value; }
        }

        private int _IdObra;
        public int IdObra
        {
            get { return _IdObra; }
            set { _IdObra = value; }
        }
        
        private string _Factura;
        public string Factura
        {
            get { return _Factura; }
            set { _Factura = value; }
        }

        private int _IdArticulo;
        public int IdArticulo
        {
            get { return _IdArticulo; }
            set { _IdArticulo = value; }
        }

        private decimal   _CantidadArt;
        public decimal CantidadArt
        {
            get { return _CantidadArt; }
            set { _CantidadArt = value; }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private int _IdArticuloTmp;
        public int IdArticuloTmp
        {
            get { return _IdArticuloTmp; }
            set { _IdArticuloTmp = value; }
        }

        private string _ArticuloTmp;
        public string ArticuloTmp
        {
            get { return _ArticuloTmp; }
            set { _ArticuloTmp = value; }
        }
        private string _NomObra;
        public string NomObra
        {
            get { return _NomObra; }
            set { _NomObra = value; }
        }

        private int _IdProveedor;
        public int IdProveedor
        {
            get { return _IdProveedor; }
            set { _IdProveedor = value; }
        }

        private string _Proveedor;
        public string Proveedor
        {
            get { return _Proveedor; }
            set { _Proveedor = value; }
        }


        #endregion

        #region Metodos Publicos

        //Listado de Articulos Obra
        public static List<ClsArticuloObra> ListaArticuloObra(int Opcion, int IdArtiObra)
        {

            List<ClsArticuloObra> ArtiObra = new List<ClsArticuloObra>();
            DataTable Tabla = new DataTable();
            try
            {
                SqlParameter[] Parameters;
                Parameters = new SqlParameter[2];

                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@Opcion";
                Parameters[0].Value = Opcion;

                if (IdArtiObra == 0)
                {
                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.Int;
                    Parameters[1].ParameterName = "@IdObra";
                    Parameters[1].Value = null;
                }
                else
                {
                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.Int;
                    Parameters[1].ParameterName = "@IdObra";
                    Parameters[1].Value = IdArtiObra;
                }

                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                Tabla = DataAccess.ExecuteSPQuery(Parameters, "Sp_Select_ArticuloObra");                                
                DataAccess.CloseConnection();

                foreach (DataRow Rn in Tabla.Rows)
                {
                    ArtiObra.Add(FillArtObra(Rn));
                }
                return ArtiObra; 


            }
            catch (Exception EX)
            { throw new Exception(EX.Message, EX.InnerException); }
            
        }

        public static List<ClsArticuloObra> BuscaArti_Obra(int Opcion, int IdArtiObra)
        {

            List<ClsArticuloObra> ArtiObra = new List<ClsArticuloObra>();
            DataTable Tabla = new DataTable();
            try
            {
                SqlParameter[] Parameters;
                Parameters = new SqlParameter[2];

                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@Opcion";
                Parameters[0].Value = Opcion;

                if (IdArtiObra == 0)
                {
                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.Int;
                    Parameters[1].ParameterName = "@IdObra";
                    Parameters[1].Value = null;
                }
                else
                {
                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.Int;
                    Parameters[1].ParameterName = "@IdObra";
                    Parameters[1].Value = IdArtiObra;
                }

                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                Tabla = DataAccess.ExecuteSPQuery(Parameters, "Sp_Select_ArticuloObra");
                DataAccess.CloseConnection();

                foreach (DataRow Rn in Tabla.Rows)
                {
                    ArtiObra.Add(FillArtObraDetalle(Rn));
                }
                return ArtiObra;
            }

            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }

        
        }

        //Listado Aticulos - Obra
        public static List<ClsArticuloObra> LArtiObra(int IdArticuloObra)
        {
            List<ClsArticuloObra> ArtiObr = new List<ClsArticuloObra>();
            DataTable Tabla = new DataTable();


            try 
            {
                SqlParameter[] Parameters;
                Parameters = new SqlParameter[2];

                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@Opcion";
                Parameters[0].Value = 1;

                Parameters[1] = new SqlParameter();
                Parameters[1].Direction = ParameterDirection.Input;
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].ParameterName = "@IdObra";
                Parameters[1].Value = IdArticuloObra;

                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                Tabla = DataAccess.ExecuteSPQuery(Parameters, "Sp_Select_ArticuloObra");
                DataAccess.CloseConnection();

                foreach (DataRow Rn in Tabla.Rows)
                {
                    ArtiObr.Add(FillArtis(Rn));
                }
                return ArtiObr; 


            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);  
            }

        }


        //Agrego los Datos a la tabla de Articulos Obra
        public static void AddArtiObra(ClsArticuloObra ArtiObra, int Opcion )
        {
            try
            {
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPNonQuery(SplitItemToParamArtiObra(ArtiObra, Opcion), "Sp_Insert_ArticuloObra");
                DataAccess.CloseConnection();
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }

        }

        //Guarda los articulos en una tabla de paso.
        public static void AddArtObraTmp(ClsArticuloObra ArtObraTmp, int Opcion, int Id)
        {
            try
            {
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPNonQuery(SplitItemToParameterTmp(ArtObraTmp, Opcion, Id), "Sp_Insert_TempArtiObra");
                DataAccess.CloseConnection();
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }

        }

        //Muestro los datos de la tabla de paso.
        public static List<ClsArticuloObra>  ListadoTmp()
        {
            List<ClsArticuloObra> ListaTmp = new List<ClsArticuloObra>();
            DataTable Tabla = new DataTable(); 

            try
            {

                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                Tabla = DataAccess.ExecuteSPQuery("Sp_Select_TempArtiObra");
                DataAccess.CloseConnection();

                foreach (DataRow Rn in Tabla.Rows)
                {
                    ListaTmp.Add(FillTmp(Rn));
                }

                return ListaTmp; 

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }
        }


        //Borro la tabla temporal
        public static void DeleteTmpArtiObra(ClsArticuloObra ArtiO)
        {
            try
            {
                SqlParameter[] Parameters;
                Parameters = new SqlParameter[1];

                if (ArtiO.IdArticuloTmp != 0)
                {
                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@IdArti";
                    Parameters[0].Value = ArtiO.IdArticuloTmp;
                }

                if (ArtiO.IdArticuloTmp  == 0)
                {
                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@IdArti";
                    Parameters[0].Value = null;
                }


                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPQuery(Parameters,"Sp_Delete_TempArtiObra");
                DataAccess.CloseConnection();
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }
            
        }

        //Actualizo la información.
        public static void UpdateArticuloObra(ClsArticuloObra ArtiObr, int Opcion)
        {
            try
            {
                SqlParameter[] Parameters;
                Parameters  = new SqlParameter[4];

                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@Opcion";
                Parameters[0].Value = Opcion;

                Parameters[1] = new SqlParameter();
                Parameters[1].Direction = ParameterDirection.Input;
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].ParameterName = "@IdArticuloObra";
                Parameters[1].Value = ArtiObr.IdArticuloObra;

                Parameters[2] = new SqlParameter();
                Parameters[2].Direction = ParameterDirection.Input;
                Parameters[2].SqlDbType = SqlDbType.Int;
                Parameters[2].ParameterName = "@IdObra";
                Parameters[2].Value = ArtiObr.IdObra;

                Parameters[3] = new SqlParameter();
                Parameters[3].Direction = ParameterDirection.Input;
                Parameters[3].SqlDbType = SqlDbType.Int;
                Parameters[3].ParameterName = "@Proveedor";
                Parameters[3].Value = ArtiObr.IdProveedor;

                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPQuery(Parameters, "Sp_Update_ArticuloObra");
                DataAccess.CloseConnection();

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }
        }

        #endregion


        #region Metodos Privados

        private static ClsArticuloObra FillArtObra(DataRow Row)
        {
            ClsArticuloObra  ArtiObra = new ClsArticuloObra();
            try
            {
                ArtiObra.IdArticuloObra = Convert.ToInt32(Row["IdArticuloObra"]);
                ArtiObra.IdObra = Convert.ToInt32(Row["IdObra"]);
                ArtiObra.IdProveedor = Convert.ToInt32(Row["IdProveedor"]);
                ArtiObra.Proveedor = Convert.ToString(Row["Proveedor"]);                
                ArtiObra.Factura = Convert.ToString(Row["Factura"]);
                ArtiObra.NomObra = Convert.ToString(Row["Obra"]);
                //ArtiObra.IdArticulo = Convert.ToInt32(Row["IdArticulo"]);
                ////ArtiObra.CantidadArt = Convert.ToDecimal(Row["CantidadArt"]);
                ////ArtiObra.Descripcion = Convert.ToString(Row["NombreArti"]);

                return ArtiObra;

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }

        }

        //Articulos...
        private static ClsArticuloObra FillArtObraDetalle(DataRow Row)
        {

            ClsArticuloObra ArtiObra = new ClsArticuloObra();


            try
            {
                //ArtiObra.IdArticuloObra = Convert.ToInt32(Row["IdArticuloObra"]);
                //ArtiObra.IdObra = Convert.ToInt32(Row["IdObra"]);
                ArtiObra.IdProveedor  = Convert.ToInt32(Row["IdProveedor"]);
                ArtiObra.Proveedor = Convert.ToString(Row["Proveedor"]);
                ArtiObra.Factura = Convert.ToString(Row["Factura"]);
                ArtiObra.IdArticulo = Convert.ToInt32(Row["IdArticulo"]);
                ArtiObra.CantidadArt = Convert.ToDecimal(Row["Cantidad"]);
                ArtiObra.Descripcion = Convert.ToString(Row["Articulo"]);

                return ArtiObra;

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }

        }



        private static ClsArticuloObra FillArtis(DataRow Row)
        {

            ClsArticuloObra ArtiObra = new ClsArticuloObra();


            try
            {
                ArtiObra.IdArticuloObra = Convert.ToInt32(Row["IdArticuloObra"]);
                //ArtiObra.IdObra = Convert.ToInt32(Row["IdObra"]);
                //ArtiObra.Proveedor = Convert.ToString(Row["Proveedor"]);
                //ArtiObra.Factura = Convert.ToString(Row["Factura"]);
                ArtiObra.IdArticulo = Convert.ToInt32(Row["IdArticulo"]);
                ArtiObra.CantidadArt = Convert.ToDecimal(Row["Cantidad"]);
                ArtiObra.Descripcion = Convert.ToString(Row["Articulo"]);

                return ArtiObra;

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }

        }


        private static ClsArticuloObra FillTmp(DataRow Row)
        {
            ClsArticuloObra ArtiObraTmp = new ClsArticuloObra();
            try
            {
                ArtiObraTmp.ArticuloTmp = Convert.ToString(Row["Descripcion"]);
                ArtiObraTmp.IdArticuloTmp = Convert.ToInt32(Row["IdArticulo"]);
                ArtiObraTmp.CantidadArt = Convert.ToDecimal(Row["Cantidad"]); 

                return ArtiObraTmp;       


            }
                

            catch(Exception EX )
            {
                throw new Exception(EX.Message, EX.InnerException);
            }

        }

        //Agrego el Articulo-Obra
        private static SqlParameter[] SplitItemToParamArtiObra(ClsArticuloObra ArtiObra, int Opcion)
        {

            try
            {
                SqlParameter[] Parameters;
                                
                if (Opcion == 1)  Parameters = new SqlParameter[2];
                else  Parameters = new SqlParameter[7];               

                
                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@Opcion";
                    Parameters[0].Value = Opcion;

                    Parameters[1] = new SqlParameter();
                    Parameters[1].Direction = ParameterDirection.Input;
                    Parameters[1].SqlDbType = SqlDbType.Int;
                    Parameters[1].ParameterName = "@IdObra";
                    Parameters[1].Value = ArtiObra.IdObra ;
                

                if (Opcion != 1)
                {
                    
                                    
                    Parameters[2] = new SqlParameter();
                    Parameters[2].Direction = ParameterDirection.Input;
                    Parameters[2].SqlDbType = SqlDbType.Int;
                    Parameters[2].ParameterName = "@Proveedor";
                    Parameters[2].Value = ArtiObra.IdProveedor;

                    Parameters[3] = new SqlParameter();
                    Parameters[3].Direction = ParameterDirection.Input;
                    Parameters[3].SqlDbType = SqlDbType.VarChar;
                    Parameters[3].ParameterName = "@Factura";
                    Parameters[3].Value = ArtiObra.Factura;

                    Parameters[4] = new SqlParameter();
                    Parameters[4].Direction = ParameterDirection.Input;
                    Parameters[4].SqlDbType = SqlDbType.Int;
                    Parameters[4].ParameterName = "@IdArticulo";
                    Parameters[4].Value = ArtiObra.IdArticulo;

                    Parameters[5] = new SqlParameter();
                    Parameters[5].Direction = ParameterDirection.Input;
                    Parameters[5].SqlDbType = SqlDbType.Decimal;
                    Parameters[5].ParameterName = "@CantidadArt";
                    Parameters[5].Value = ArtiObra.CantidadArt;

                    Parameters[6] = new SqlParameter();
                    Parameters[6].Direction = ParameterDirection.Input;
                    Parameters[6].SqlDbType = SqlDbType.Decimal;
                    Parameters[6].ParameterName = "@IdArticuloObra";
                    Parameters[6].Value = ArtiObra.IdArticuloObra;

                }
                return Parameters;

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }

        }


        private static SqlParameter[] SplitItemToParameterTmp(ClsArticuloObra ArtiObra, int Opcion, int Id)
        {

            try
            {

                SqlParameter[] Parameters;
                //if (Id == 0)
                //Parameters = new SqlParameter[3];
                //else
                Parameters = new SqlParameter[5];

                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@Opcion";
                Parameters[0].Value = Opcion;

                Parameters[1] = new SqlParameter();
                Parameters[1].Direction = ParameterDirection.Input;
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].ParameterName = "@IdArticulo";
                Parameters[1].Value = ArtiObra.IdArticulo;           


                Parameters[2] = new SqlParameter();
                Parameters[2].Direction = ParameterDirection.Input;
                Parameters[2].SqlDbType = SqlDbType.VarChar;
                Parameters[2].ParameterName = "@Descripcion";
                Parameters[2].Value = ArtiObra.Descripcion;


                Parameters[3] = new SqlParameter();
                Parameters[3].Direction = ParameterDirection.Input;
                Parameters[3].SqlDbType = SqlDbType.VarChar;
                Parameters[3].ParameterName = "@Cantidad";
                Parameters[3].Value = ArtiObra.CantidadArt;

                if (Id != 0)
                {
                    Parameters[4] = new SqlParameter();
                    Parameters[4].Direction = ParameterDirection.Input;
                    Parameters[4].SqlDbType = SqlDbType.VarChar;
                    Parameters[4].ParameterName = "@Id";
                    Parameters[4].Value = Id;
                }
                else
                {
                    Parameters[4] = new SqlParameter();
                    Parameters[4].Direction = ParameterDirection.Input;
                    Parameters[4].SqlDbType = SqlDbType.VarChar;
                    Parameters[4].ParameterName = "@Id";
                    Parameters[4].Value = 0;   
                }

                return Parameters;

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }


        }

        #endregion      


    }

          #region FiltroFactura
    public class FilterFactura
    {
        private string FilterFacturaLists;

        public FilterFactura(string FilterFacturaList)
        {
            this.FilterFacturaLists = FilterFacturaList;
        }

        //busca por Id de Aplicacion
        public bool BuscaFacturaLike(ClsArticuloObra FilterFacturaList)
        {
            return FilterFacturaList.Factura.ToUpper().Contains(FilterFacturaLists.ToUpper());
        }
    }

    #endregion
}
