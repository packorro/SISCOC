using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISCOC_DAL;       

namespace SISCOC_BL
{
    public class ClsKit
    {

        //[IdKit] [int] NOT NULL,
        //[IdArticulo] [int] NOT NULL,
        //[Cantidad] [decimal](9, 2) NOT NULL,
        //[PrecioU] [decimal](9, 2) NOT NULL )


        #region Propiedades

       
        private int _IdArticulo;
        public int IdArticulo
        {

            get { return _IdArticulo; }
            set { _IdArticulo = value; }
        }

        private string  _Articulo;
        public string Articulo
        {
            get { return _Articulo; }
            set { _Articulo = value; }
        }

        private string _Descripcion;
        public string  Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private double _Cantidad;
        public double Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }        
        }

        private double _PrecioU;
        public double PrecioU
        {
            get { return _PrecioU; }
            set { _PrecioU = value; }
        }


        private int _IdKit;
        public int IdKit
        {
            get { return _IdKit; }
            set { _IdKit = value; }
        }

        private string _NomKit;
        public string NomKit
        {
            get { return _NomKit;  }
            set { _NomKit = value; }
        }


        #endregion
        
        #region Metodos Publicos


        //Muestra los Articulos temporalmente guardados.
        public static List<ClsKit> ListArtKit()
        {
            List<ClsKit> ArtKit = new List<ClsKit>();
            DataTable Table = new DataTable();

            try
            {
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                Table = DataAccess.ExecuteSPQuery("Sp_Select_TempKitArticulo");
                DataAccess.CloseConnection();

                foreach (DataRow Rn in Table.Rows)
                {
                    ArtKit.Add(FillArtKit(Rn)); 
                }

                return ArtKit;  

            }

            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);   
            }
        
        }

        //Muestra los Articulos que pertenecen a un Kit
        public static List<ClsKit> BuscaArti_Kit(int Kit)
        {
            List<ClsKit> ArtKit = new List<ClsKit>();
            DataTable Table = new DataTable(); 

            try
            {

                SqlParameter[] Parameters;
                Parameters = new SqlParameter[2];

                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@Opcion";
                Parameters[0].Value = 2;

                Parameters[1] = new SqlParameter();
                Parameters[1].Direction = ParameterDirection.Input;
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].ParameterName = "@IdKit";
                Parameters[1].Value = Kit;

                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                Table = DataAccess.ExecuteSPQuery(Parameters,"Sp_Select_Kit");
                DataAccess.CloseConnection();

                foreach (DataRow Rn in Table.Rows)
                {
                    ArtKit.Add(FillArtKit(Rn));
                    
                }
                return ArtKit;

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);  
            }

        }

        //Busca los kits.
        public static List<ClsKit> BuscaKit(int Opcion, int Kit, string Dato)
        {
            List<ClsKit> BKit = new List<ClsKit>();
            DataTable Table = new DataTable();

            try
            { 
                    SqlParameter[] Parameters;
                    Parameters = new SqlParameter[3];


                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@Opcion";
                    Parameters[0].Value = Opcion;

                    if (Kit == 0)
                    {
                        Parameters[1] = new SqlParameter();
                        Parameters[1].Direction = ParameterDirection.Input;
                        Parameters[1].SqlDbType = SqlDbType.Int;
                        Parameters[1].ParameterName = "@IdKit";
                        Parameters[1].Value = null;
                    }
                    if (Kit > 0)
                    {
                        Parameters[1] = new SqlParameter();
                        Parameters[1].Direction = ParameterDirection.Input;
                        Parameters[1].SqlDbType = SqlDbType.Int;
                        Parameters[1].ParameterName = "@IdKit";
                        Parameters[1].Value = Kit;
                    }

                    //if (Dato == "")
                    //{
                    //    Parameters[2] = new SqlParameter();
                    //    Parameters[2].Direction = ParameterDirection.Input;
                    //    Parameters[2].SqlDbType = SqlDbType.VarChar;
                    //    Parameters[2].ParameterName = "@Dato";
                    //    Parameters[2].Value = null;
                    //}
                    //if (Dato != "")
                    //{
                        Parameters[2] = new SqlParameter();
                        Parameters[2].Direction = ParameterDirection.Input;
                        Parameters[2].SqlDbType = SqlDbType.VarChar;
                        Parameters[2].ParameterName = "@Dato";
                        Parameters[2].Value = Dato;
                    //}


                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                    Table = DataAccess.ExecuteSPQuery(Parameters, "Sp_Select_Kit");
                    DataAccess.CloseConnection();

                    foreach (DataRow Rn in Table.Rows)
                    {
                        BKit.Add(FillKit(Rn));
 
                    }
                return BKit;


            }
            catch(Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException); 
            }

        
        }


        //**
        /// <summary>
        /// Agrega un TmpKitArt
        /// </summary>
        /// <param name="Contacto">recibe un objeto del tipo ClsArtKit</param>
        /// 

        //Guarda los articulos en una tabla de paso.
        public static void AddArtKit(ClsKit ArtKit, int Opcion, int IdKit)
        {
            try 
            {
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPNonQuery(SplitItemToParameter(ArtKit,Opcion,IdKit), "Sp_Insert_TempKitArticulo");
                DataAccess.CloseConnection();  
            }
            catch (Exception EX)
            {  
                throw new Exception(EX.Message,EX.InnerException);      
            }
        
        }


        //Borra los registros de la tabla de paso.
        public static void DeleteartKit(ClsKit ArtKit)
        {

            try
            {

                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPNonQuery(SplitItemToParameter2(ArtKit), "Sp_Delete_TempKitArticulo");
                DataAccess.CloseConnection();  
            }

            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);   
            }

        }

        //Borro logicamente el kit
        public static void DeleteKit(int IdKit)
        {
            try
            {

                SqlParameter[] Parameters;
                Parameters = new SqlParameter[1];


                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@IdKit";
                Parameters[0].Value = IdKit;


                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPQuery(Parameters, "Sp_Delete_Kit");
                DataAccess.CloseConnection();  
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }
        }

        //Actualizo el Kit
        public static void UpdateKit(int IdKit, string NameKit)
        {
            try 
            {
                SqlParameter[] Parameters;
                Parameters = new SqlParameter[2];

                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@IdKit";
                Parameters[0].Value = IdKit;

                Parameters[1] = new SqlParameter();
                Parameters[1].Direction = ParameterDirection.Input;
                Parameters[1].SqlDbType = SqlDbType.VarChar;
                Parameters[1].ParameterName = "@Kit";
                Parameters[1].Value = NameKit;

                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPQuery(Parameters, "Sp_Update_Kit");
                DataAccess.CloseConnection();  

            }
            catch (Exception EX)
            { throw new Exception(EX.Message, EX.InnerException); }
        }

        public static void AddNewRowArtKitMan(int Opcion, int IdArticulo,  string Articulo, string Descripcion, long Cantidad, double PrecioU)
        {
            try
            {
                SqlParameter[] Parameters;
                Parameters = new SqlParameter[6];

                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@Opcion";
                Parameters[0].Value = Opcion;

                Parameters[1] = new SqlParameter();
                Parameters[1].Direction = ParameterDirection.Input;
                Parameters[1].SqlDbType = SqlDbType.VarChar;
                Parameters[1].ParameterName = "@Articulo";
                Parameters[1].Value = Articulo.ToUpper();

                Parameters[2] = new SqlParameter();
                Parameters[2].Direction = ParameterDirection.Input;
                Parameters[2].SqlDbType = SqlDbType.VarChar;
                Parameters[2].ParameterName = "@Descripcion";
                Parameters[2].Value = Descripcion.ToUpper();

                Parameters[3] = new SqlParameter();
                Parameters[3].Direction = ParameterDirection.Input;
                Parameters[3].SqlDbType = SqlDbType.Int;
                Parameters[3].ParameterName = "@Cantidad";
                Parameters[3].Value = Cantidad;

                Parameters[4] = new SqlParameter();
                Parameters[4].Direction = ParameterDirection.Input;
                Parameters[4].SqlDbType = SqlDbType.Decimal;
                Parameters[4].ParameterName = "@PrecioU";
                Parameters[4].Value = PrecioU;

                Parameters[5] = new SqlParameter();
                Parameters[5].Direction = ParameterDirection.Input;
                Parameters[5].SqlDbType = SqlDbType.Int;
                Parameters[5].ParameterName = "@IdArticulo";
                Parameters[5].Value = IdArticulo;        

                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPQuery(Parameters, "Sp_Insert_TempKitArticulo");
                DataAccess.CloseConnection();  

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);  
            }
        }

        //Inserto los datos del Kit.
        public static void AddKit(ClsKit Kit)
        {
            try 
            {
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());                
                DataAccess.ExecuteSPNonQuery(SplitItemToParamKit(Kit), "Sp_Insert_Kit");
                DataAccess.CloseConnection();  

            }

            catch (Exception EX) 
            { 
                throw new Exception(EX.Message, EX.InnerException); 
            }
        }
        //Inserto los Articulos del Kit
        public static void AddArti_Kit(ClsKit Kit, int Opcion, int IdKit)
        {


            try
            { 
            
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPNonQuery(SplitItemToParamArti_Kit(Kit,Opcion,IdKit), "Sp_Insert_Kit");
                DataAccess.CloseConnection();  
                
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);   
            }

        }


        public static void AddArti_Kit2(int Opcion, int IdKit)
        {

            SqlParameter[] Parameters;
            Parameters = new SqlParameter[2];

            Parameters[0] = new SqlParameter();
            Parameters[0].Direction = ParameterDirection.Input;
            Parameters[0].SqlDbType = SqlDbType.Int;
            Parameters[0].ParameterName = "@Opcion";
            Parameters[0].Value = Opcion;

            Parameters[1] = new SqlParameter();
            Parameters[1].Direction = ParameterDirection.Input;
            Parameters[1].SqlDbType = SqlDbType.Int;
            Parameters[1].ParameterName = "@IdKit";
            Parameters[1].Value = IdKit;


            try
            {
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPNonQuery(Parameters, "Sp_Insert_Kit");
                DataAccess.CloseConnection();

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }
        }

        #endregion

        #region Metodos Privados


        //Regresa el numero del Kit y el Nombre del Kit
        private static ClsKit FillKit(DataRow Row)
        {

            ClsKit Kit = new ClsKit();
            try
            {

                Kit.IdKit = Convert.ToInt32(Row["IdKit"]);
                Kit.NomKit = Convert.ToString(Row["Kit"]);
                Kit.PrecioU = Convert.ToDouble(Row["PrecioU"]);

                return Kit;
                
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }
        }

        //Regresa los Articulos.
        private static ClsKit FillArtKit(DataRow Row)
        {

            ClsKit ArtiKit = new ClsKit();


            try
            {

                ArtiKit.IdArticulo = Convert.ToInt32(Row["IdArticulo"]);
                ArtiKit.Articulo = Convert.ToString(Row["Articulo"]);
                ArtiKit.Descripcion = Convert.ToString(Row["Descripcion"]);
                ArtiKit.PrecioU = Convert.ToDouble(Row["PrecioU"]);
                ArtiKit.Cantidad = Convert.ToDouble(Row["Cantidad"]);

                return ArtiKit; 

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);   
            }

        }


        private static SqlParameter[] SplitItemToParameter(ClsKit ArtKit, int Opcion , int IdKit)
            {

                try
                {
                    SqlParameter[] Parameters;
                    Parameters = new SqlParameter[7];
                    
                                       
                   
                       Parameters[0] = new SqlParameter();
                       Parameters[0].Direction = ParameterDirection.Input;
                       Parameters[0].SqlDbType = SqlDbType.Int;
                       Parameters[0].ParameterName = "@IdArticulo";
                       Parameters[0].Value = ArtKit.IdArticulo;

                       Parameters[1] = new SqlParameter();
                       Parameters[1].Direction = ParameterDirection.Input;
                       Parameters[1].SqlDbType = SqlDbType.VarChar;
                       Parameters[1].ParameterName = "@Articulo";
                       Parameters[1].Value = ArtKit.Articulo;

                       Parameters[2] = new SqlParameter();
                       Parameters[2].Direction = ParameterDirection.Input;
                       Parameters[2].SqlDbType = SqlDbType.VarChar;
                       Parameters[2].ParameterName = "@Descripcion";
                       Parameters[2].Value = ArtKit.Descripcion;


                       Parameters[3] = new SqlParameter();
                       Parameters[3].Direction = ParameterDirection.Input;
                       Parameters[3].SqlDbType = SqlDbType.Decimal;
                       Parameters[3].ParameterName = "@Cantidad";
                       Parameters[3].Value = ArtKit.Cantidad;


                       Parameters[4] = new SqlParameter();
                       Parameters[4].Direction = ParameterDirection.Input;
                       Parameters[4].SqlDbType = SqlDbType.Decimal;
                       Parameters[4].ParameterName = "@PrecioU";
                       Parameters[4].Value = ArtKit.PrecioU;

                       Parameters[5] = new SqlParameter();
                       Parameters[5].Direction = ParameterDirection.Input;
                       Parameters[5].SqlDbType = SqlDbType.Int;
                       Parameters[5].ParameterName = "@Opcion";
                       Parameters[5].Value = Opcion;

                       if (Opcion > 1)
                       {
                           Parameters[6] = new SqlParameter();
                           Parameters[6].Direction = ParameterDirection.Input;
                           Parameters[6].SqlDbType = SqlDbType.Int;
                           Parameters[6].ParameterName = "@IdKit";
                           Parameters[6].Value = IdKit;
                       }
                       if (Opcion <= 1)
                       {
                           Parameters[6] = new SqlParameter();
                           Parameters[6].Direction = ParameterDirection.Input;
                           Parameters[6].SqlDbType = SqlDbType.Int;
                           Parameters[6].ParameterName = "@IdKit";
                           Parameters[6].Value = IdKit;
                       }



                   return Parameters;
                

                }
                catch (Exception EX)
                {
                    throw new Exception(EX.Message, EX.InnerException);   
                }
                
            }

        private static SqlParameter[] SplitItemToParameter2(ClsKit  ArtKit)
        {
            try
            {

                SqlParameter[] Parameters;
                Parameters = new SqlParameter[1];

                if (ArtKit.IdArticulo != 0)
                {

                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@IdArticulo";
                    Parameters[0].Value = ArtKit.IdArticulo;
                }

                if( ArtKit.IdArticulo == 0 )
                {

                    Parameters[0] = new SqlParameter();
                    Parameters[0].Direction = ParameterDirection.Input;
                    Parameters[0].SqlDbType = SqlDbType.Int;
                    Parameters[0].ParameterName = "@IdArticulo";
                    Parameters[0].Value = null;
                
                }


                return Parameters;

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);    
            
            }
        
        }

        //Agrego el nombre del KIT
        private static SqlParameter[] SplitItemToParamKit(ClsKit Kit)
        {

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
                Parameters[1].SqlDbType = SqlDbType.VarChar;
                Parameters[1].ParameterName = "@Kit";
                Parameters[1].Value = Kit.NomKit;

                return Parameters;

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);   
            }
        
        }

        //Agrega los articulos que pertenecen al KIT
        private static SqlParameter[] SplitItemToParamArti_Kit(ClsKit Kit, int Opcion, int IdKit)
        {

            try
            {
                SqlParameter[] Parameters;
                Parameters = new SqlParameter[2];



                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@Opcion";
                Parameters[0].Value = Opcion;

                Parameters[1] = new SqlParameter();
                Parameters[1].Direction = ParameterDirection.Input;
                Parameters[1].SqlDbType = SqlDbType.Int;
                Parameters[1].ParameterName = "@IdKit";
                Parameters[1].Value = IdKit;
                

                return Parameters; 

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException); 
            }
        
        }


        #endregion


    }
}
