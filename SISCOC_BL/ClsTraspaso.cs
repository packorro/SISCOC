using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SISCOC_DAL;  
using System.Data.SqlClient;   

namespace SISCOC_BL
{
   public  class ClsTraspaso
    {
        //[IdTraspasos] [int] IDENTITY(1,1) NOT NULL,
        //[IdObraOrigen] [int] NOT NULL,
        //[IdObraDestino] [int] NOT NULL,
        //[IdArticulo] [int] NOT NULL,
        //[CantidadArtTrasp] [float] NOT NULL,
        //[Fecha] [datetime] NOT NULL DEFAULT ('0000-00-00'),
        //[Status] [int] NOT NULL DEFAULT ((1)),

        #region Propiedades

       private int _IdTraspasos;
       public int IdTraspasos
       {
           get { return _IdTraspasos; }
           set { _IdTraspasos = value; }
       }

       private int _IdObraOrigen;
       public int IdObraOrigen
       {
           get { return _IdObraOrigen; }
           set { _IdObraOrigen = value; }
       }

       private int _IdObraDestino;
       public int IdObraDestino
       {
           get{return _IdObraDestino; }
           set{ _IdObraDestino = value;  }
       }

       private int _IdArticulo;
       public int IdArticulo
       {
           get { return _IdArticulo; }
           set { _IdArticulo = value; }
       }

       private double _CantidadArtTrasp;
       public double CantidadArtTrasp
       {
           get { return _CantidadArtTrasp; }
           set { _CantidadArtTrasp = value; }
       }

       private DateTime _Fecha;
       public DateTime Fecha
       {
           get { return _Fecha; }
           set { _Fecha = value; }
       }

       private int _Status;
       public int Status
       {
           get { return _Status; }
           set { _Status = value; }
       }


       private int _IdObra;
       public int IdObra
       {
           get{return _IdObra; }
           set { _IdObra = value; }
       }

       private string _NomObra;
       public string NomObra
       {
           get { return _NomObra; }
           set { _NomObra = value; }
       }

       private string _Check;
       public string Check
       {
           get { return _Check; }
           set { _Check = value; }
       }


       private int _IdArtObra;
       public int IdArtObra
       {
           get { return _IdArtObra; }
           set { _IdArtObra = value; }
       }

       private string _NombreArt;
       public string NombreArt
       {
           get { return _NombreArt; }
           set { _NombreArt = value; }

       }

       private double _Cantidad;
       public double Cantidad
       {
           get { return _Cantidad; }
           set { _Cantidad = value; }
       }

       private string _IdObr;
       public string IdObr
       {
           get { return _IdObr; }
           set { _IdObr = value; }
       }

       private string _Obr;
       public string Obr
       {
           get { return _Obr; }
           set { _Obr = value; }
       }

       private int _IdProv;
       public int IdProv
       {
           get { return _IdProv; }
           set { _IdProv = value; }
       }
       private string _Prov;
       public string Prov
       {
           get { return _Prov; }
           set { _Prov = value; }
       }

       private int _IdKit;
       public int IdKit
       {
            get {return _IdKit;  }
            set { _IdKit  = value ; }
       }

       private string _NomKit;
       public string NomKit
       {
           get { return _NomKit;  }
           set { _NomKit = value; }
       }
      

#endregion

        #region  Metodos Publicos

           //**
           /// <summary>
           /// Obtiene una lista de Traspasos (contenga filtros)  
           /// </summary>
           /// <returns>Regresa una lista de Traspaso</returns>
           /// 
           public static List<ClsTraspaso> ListaTraspaso(int Status)
           {
               List<ClsTraspaso> TraspasoList = new List<ClsTraspaso>();
               DataTable Table = new DataTable();

               try
               {
                   SqlParameter[] Parameters;
                   Parameters = new SqlParameter[1];

                   Parameters[0] = new SqlParameter();
                   Parameters[0].Direction = ParameterDirection.Input;
                   Parameters[0].SqlDbType = SqlDbType.Int;
                   Parameters[0].ParameterName = "@Status";
                   Parameters[0].Value = Status;

                   Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                   Table = DataAccess.ExecuteSPQuery(Parameters, "Sp_Select_Traspaso");
                   DataAccess.CloseConnection();

                   foreach (DataRow Row in Table.Rows)
                   {
                       TraspasoList.Add(FillTraspaso(Row));  
                   }

                   return TraspasoList; 
               }
               catch (Exception EX)
               {
                   throw new Exception(EX.Message, EX.InnerException);   
               }
           }


           //**
           /// <summary>
           /// Agrega un Traspaso
           /// </summary>
           /// <param name="Contacto">recibe un objeto del tipo ClsTraspaso</param>
           /// 
           public static void AddTraspaso(ClsTraspaso Traspaso , int Opcion)
           {
               try
               {
                   Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                   DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Traspaso, true, Opcion), "Sp_Insert_Traspaso");
                   DataAccess.CloseConnection(); 
               }
               catch (Exception EX)
               {
                   throw new Exception(EX.Message, EX.InnerException);   
               }

          }

       public static DataSet BuscaObra(int ObraOrigen, int Opcion)
       {

           DataSet dsDatos = new DataSet();

           try
           {

               SqlParameter[] Parameters;
               Parameters = new SqlParameter[5];

               Parameters[0] = new SqlParameter();
               Parameters[0].Direction = ParameterDirection.Input;
               Parameters[0].SqlDbType = SqlDbType.Int;               
               Parameters[0].ParameterName = "@Opcion";
               Parameters[0].Value = Opcion;

               Parameters[1] = new SqlParameter();
               Parameters[1].Direction = ParameterDirection.Input;
               Parameters[1].SqlDbType = SqlDbType.Int;               
               Parameters[1].ParameterName = "@IdObraOrigen";
               Parameters[1].Value = ObraOrigen;


               Parameters[2] = new SqlParameter();
               Parameters[2].Direction = ParameterDirection.Input;
               Parameters[2].SqlDbType = SqlDbType.Int;               
               Parameters[2].ParameterName = "@IdObraDestino";
               Parameters[2].Value = 0;


               Parameters[3] = new SqlParameter();
               Parameters[3].Direction = ParameterDirection.Input;
               Parameters[3].SqlDbType = SqlDbType.Int;               
               Parameters[3].ParameterName = "@IdArticulo";
               Parameters[3].Value = 0;


               Parameters[4] = new SqlParameter();
               Parameters[4].Direction = ParameterDirection.Input;
               Parameters[4].SqlDbType = SqlDbType.Float;               
               Parameters[4].ParameterName = "@CantidadArtTrasp";
               Parameters[4].Value = 0;

               Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
               dsDatos = DataAccess.ExecuteSPQueryDataSet(Parameters, "Sp_Insert_Traspaso");
               DataAccess.CloseConnection();
               return dsDatos;
           }
           catch (Exception EX)
           {
               throw new Exception(EX.Message, EX.InnerException);
           }
       }


       public static DataSet BuscaCantidad(int ObraOrigen, int IdArticulo, int Opcion)
       {

           DataSet dsDatos = new DataSet();

           try
           {

               SqlParameter[] Parameters;
               Parameters = new SqlParameter[5];

               Parameters[0] = new SqlParameter();
               Parameters[0].Direction = ParameterDirection.Input;
               Parameters[0].SqlDbType = SqlDbType.Int;
               Parameters[0].ParameterName = "@Opcion";
               Parameters[0].Value = Opcion;

               Parameters[1] = new SqlParameter();
               Parameters[1].Direction = ParameterDirection.Input;
               Parameters[1].SqlDbType = SqlDbType.Int;
               Parameters[1].ParameterName = "@IdObraOrigen";
               Parameters[1].Value = ObraOrigen;


               Parameters[2] = new SqlParameter();
               Parameters[2].Direction = ParameterDirection.Input;
               Parameters[2].SqlDbType = SqlDbType.Int;
               Parameters[2].ParameterName = "@IdObraDestino";
               Parameters[2].Value = 0;


               Parameters[3] = new SqlParameter();
               Parameters[3].Direction = ParameterDirection.Input;
               Parameters[3].SqlDbType = SqlDbType.Int;
               Parameters[3].ParameterName = "@IdArticulo";
               Parameters[3].Value = IdArticulo;


               Parameters[4] = new SqlParameter();
               Parameters[4].Direction = ParameterDirection.Input;
               Parameters[4].SqlDbType = SqlDbType.Float;
               Parameters[4].ParameterName = "@CantidadArtTrasp";
               Parameters[4].Value = 0;

               Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
               dsDatos = DataAccess.ExecuteSPQueryDataSet(Parameters, "Sp_Insert_Traspaso");
               DataAccess.CloseConnection();
               return dsDatos;
           }
           catch (Exception EX)
           {
               throw new Exception(EX.Message, EX.InnerException);
           }
       }


       public static DataSet ActualizoCantidad(int ObraOrigen, int IdArticulo, int Registro, double Cantidad, int Opcion)
       {

           DataSet dsDatos = new DataSet();

           try
           {

               SqlParameter[] Parameters;
               Parameters = new SqlParameter[8];

               Parameters[0] = new SqlParameter();
               Parameters[0].Direction = ParameterDirection.Input;
               Parameters[0].SqlDbType = SqlDbType.Int;
               Parameters[0].ParameterName = "@Opcion";
               Parameters[0].Value = Opcion;

               Parameters[1] = new SqlParameter();
               Parameters[1].Direction = ParameterDirection.Input;
               Parameters[1].SqlDbType = SqlDbType.Int;
               Parameters[1].ParameterName = "@IdObraOrigen";
               Parameters[1].Value = ObraOrigen;


               Parameters[2] = new SqlParameter();
               Parameters[2].Direction = ParameterDirection.Input;
               Parameters[2].SqlDbType = SqlDbType.Int;
               Parameters[2].ParameterName = "@IdObraDestino";
               Parameters[2].Value = 0;


               Parameters[3] = new SqlParameter();
               Parameters[3].Direction = ParameterDirection.Input;
               Parameters[3].SqlDbType = SqlDbType.Int;
               Parameters[3].ParameterName = "@IdArticulo";
               Parameters[3].Value = IdArticulo;


               Parameters[4] = new SqlParameter();
               Parameters[4].Direction = ParameterDirection.Input;
               Parameters[4].SqlDbType = SqlDbType.Float;
               Parameters[4].ParameterName = "@CantidadArtTrasp";
               Parameters[4].Value = 0;

               Parameters[5] = new SqlParameter();
               Parameters[5].Direction = ParameterDirection.Input;
               Parameters[5].SqlDbType = SqlDbType.Int;
               Parameters[5].ParameterName = "@IdArticuloObra";
               Parameters[5].Value = 0;

               Parameters[6] = new SqlParameter();
               Parameters[6].Direction = ParameterDirection.Input;
               Parameters[6].SqlDbType = SqlDbType.Int;
               Parameters[6].ParameterName = "@Cantidad";
               Parameters[6].Value = Cantidad;

               Parameters[7] = new SqlParameter();
               Parameters[7].Direction = ParameterDirection.Input;
               Parameters[7].SqlDbType = SqlDbType.Int;
               Parameters[7].ParameterName = "@Registro";
               Parameters[7].Value = Registro;

              

               Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
               DataAccess.ExecuteSPNonQuery(Parameters, "Sp_Insert_Traspaso");
               DataAccess.CloseConnection();
               return dsDatos;
           }
           catch (Exception EX)
           {
               throw new Exception(EX.Message, EX.InnerException);
           }
       }


           //**
           /// <summary>
           /// Actualiza un Traspaso
           /// </summary>
           /// <param name="Contacto">recibe un objeto del tipo ClsTraspaso</param>
           /// 
           public static void UpDateTraspaso(ClsTraspaso Traspaso)
           {
               try 
               {
                   Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                   DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Traspaso, false, 0), "Sp_Update_Traspaso");
                   DataAccess.CloseConnection();  
               }
               catch (Exception EX)
               {
                   throw new Exception(EX.Message, EX.InnerException); 
               } 
           }

           //**
           /// <summary>
           /// Borra Logicamente un Traspaso
           /// </summary>
           /// <param name="Contacto">recibe un objeto del tipo ClsTraspaso</param>
           public static void DeleteArticulo(ClsTraspaso Traspaso)
           {
               try
               {
                   Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                   DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Traspaso, false, 1), "Sp_Update_Traspaso");
                   DataAccess.CloseConnection();

               }
               catch (Exception EX)
               { throw new Exception(EX.Message, EX.InnerException); }
           }



           //BuscaObra
           public static List<ClsTraspaso>  BuscaObra (int Opcion,int Status,string Filtro)
           {
               List<ClsTraspaso> Obra = new List<ClsTraspaso>();
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

                   Parameters[1] = new SqlParameter();
                   Parameters[1].Direction = ParameterDirection.Input;
                   Parameters[1].SqlDbType = SqlDbType.Int;
                   Parameters[1].ParameterName = "@Status";
                   Parameters[1].Value = Status;


                   Parameters[2] = new SqlParameter();
                   Parameters[2].Direction = ParameterDirection.Input;
                   Parameters[2].SqlDbType = SqlDbType.VarChar;
                   Parameters[2].ParameterName = "@Filtro";
                   Parameters[2].Value = Filtro;


                   Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                   Table = DataAccess.ExecuteSPQuery(Parameters, "Sp_Select_ObraTras");
                   DataAccess.CloseConnection();

                   foreach (DataRow Row in Table.Rows)
                   {
                       Obra.Add(FillObra(Row));
                   }

                   return Obra; 
               }
               catch (Exception EX)
               {
                   throw new Exception(EX.Message, EX.InnerException);   
               }

           }

           //Busca-Proveedor

           public static List<ClsTraspaso> BuscaProveedor(string Filtro)
           {
               List<ClsTraspaso> Prov = new List<ClsTraspaso>();
               DataTable Table = new DataTable();

               try
               {
                   SqlParameter[] Parameters ;
                   Parameters = new SqlParameter[1];

                   Parameters[0] = new SqlParameter();
                   Parameters[0].Direction = ParameterDirection.Input;
                   Parameters[0].SqlDbType = SqlDbType.VarChar;
                   Parameters[0].ParameterName = "@Filtro";
                   Parameters[0].Value = Filtro;

                   Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                   Table = DataAccess.ExecuteSPQuery(Parameters, "Sp_Select_ProveedorTras");
                   DataAccess.CloseConnection();

                   foreach (DataRow Row in Table.Rows)
                   {
                       Prov.Add(FillProv(Row));  
                   }

                   return Prov;
      
               }
               catch (Exception EX)
               {
                   throw new Exception(EX.Message, EX.InnerException);   
               }
     
           }

           //Busca Articulo - Obra

           public static List<ClsTraspaso> BuscaArticulo_Obra(int Opcion, int Status, int IdObra, string Filtro)
           {

               List<ClsTraspaso> Articulo_Obra = new List<ClsTraspaso>();
               DataTable Table = new DataTable();

               try
               {
                   SqlParameter[] Parameters;
                   Parameters = new SqlParameter[4];


                   Parameters[0] = new SqlParameter();
                   Parameters[0].Direction = ParameterDirection.Input;
                   Parameters[0].SqlDbType = SqlDbType.Int;
                   Parameters[0].ParameterName = "@Opcion";
                   Parameters[0].Value = Opcion;

                   Parameters[1] = new SqlParameter();
                   Parameters[1].Direction = ParameterDirection.Input;
                   Parameters[1].SqlDbType = SqlDbType.Int;
                   Parameters[1].ParameterName = "@Status";
                   Parameters[1].Value = Status;

                   Parameters[2] = new SqlParameter();
                   Parameters[2].Direction = ParameterDirection.Input;
                   Parameters[2].SqlDbType = SqlDbType.Int;
                   Parameters[2].ParameterName = "@IdObra";
                   Parameters[2].Value = IdObra;

                   Parameters[3] = new SqlParameter();
                   Parameters[3].Direction = ParameterDirection.Input;
                   Parameters[3].SqlDbType = SqlDbType.VarChar;
                   Parameters[3].ParameterName = "@Filtro";
                   Parameters[3].Value = Filtro;


                   Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                   Table = DataAccess.ExecuteSPQuery(Parameters, "Sp_Select_ArticuloObra");
                   DataAccess.CloseConnection();

                   foreach (DataRow Row in Table.Rows)
                   {
                       Articulo_Obra.Add(FillArt_Obra(Row));                   
                   }

                   return Articulo_Obra; 

               }
               catch(Exception EX )
               {
                   throw new Exception(EX.Message, EX.InnerException); 
               }

           }

           public static List<ClsTraspaso> DatosObra( string IdObra, string Obra)
           {

               try
               {
                   List<ClsTraspaso> LDatosObra = new List<ClsTraspaso>();

                   ClsTraspaso Idobr = new ClsTraspaso();
                   ClsTraspaso Obr = new ClsTraspaso();

                   Idobr._IdObr = IdObra;
                   Obr._Obr = Obra;

                   LDatosObra.Add(Idobr);
                   LDatosObra.Add(Obr);

                   return LDatosObra; 


               }
               catch (Exception EX)
               {
                   throw new Exception(EX.Message.ToString(), EX.InnerException);
               }

           }


       #endregion

        #region Metodos Privados

           private static ClsTraspaso FillTraspaso(DataRow Row)
           {
               ClsTraspaso Traspaso = new ClsTraspaso();
               try 
               {
                   Traspaso.IdTraspasos = Convert.ToInt32(Row["IdTraspasos"]);
                   Traspaso.IdObraOrigen = Convert.ToInt32(Row["IdObraOrigen"]);
                   Traspaso.IdObraDestino = Convert.ToInt32(Row["IdObraDestino"]);
                   Traspaso.IdArticulo = Convert.ToInt32(Row["IdArticulo"]);
                   Traspaso.CantidadArtTrasp = Convert.ToDouble(Row["CantidadArtTrasp"]);
                   Traspaso.Fecha = Convert.ToDateTime(Row["Fecha"]);
                   Traspaso.Status = Convert.ToInt16(Row["Status"]);

                   return Traspaso; 

               }
               catch (Exception EX)
               {
                   throw new Exception(EX.Message, EX.InnerException);   
               }
           }

           private static ClsTraspaso FillObra(DataRow Row)
           {

               ClsTraspaso Obra = new ClsTraspaso();
               try
               {
                   Obra.IdObra = Convert.ToInt32(Row["IdObra"]);
                   Obra.NomObra = Convert.ToString(Row["NombreObra"]);

                   return Obra;
               }
               catch (Exception EX)
               {
                   throw new Exception(EX.Message, EX.InnerException);   
               }
           }

           private static ClsTraspaso FillProv(DataRow Row)
           {

               ClsTraspaso Prov = new ClsTraspaso();
               try
               {
                   Prov.IdProv = Convert.ToInt32(Row["IdProveedor"]);
                   Prov.Prov = Convert.ToString(Row["Nombre"]);

                   return Prov; 
               }
               catch (Exception EX)
               {
                   throw new Exception(EX.Message, EX.InnerException);
               }
           }

           private static ClsTraspaso FillArt_Obra(DataRow Row)
           {
               
               ClsTraspaso Art_Obra = new ClsTraspaso();
               try
               {
                   //Art_Obra.Check = Convert.ToString(Row["Check"]);
                   Art_Obra.NombreArt = Convert.ToString(Row["Articulo"]);
                   Art_Obra.IdArtObra = Convert.ToInt32(Row["IdArticulo"]);
                   Art_Obra.Cantidad = Convert.ToInt32(Row["Cantidad"]);

                   return Art_Obra; 
               }
               catch (Exception EX)
               {
                   throw new Exception(EX.Message, EX.InnerException);  
               }       
           }
       
           private static SqlParameter[] SplitItemToParameter(ClsTraspaso Traspaso, bool isNew, int Opcion)
           {

               try
               {                    
                   SqlParameter[] Parameters;

                   //if (isNew)
                       Parameters = new SqlParameter[6];
                   //else
                     //  Parameters = new SqlParameter[7];

                   
                   Parameters[0] = new SqlParameter();
                   Parameters[0].Direction = ParameterDirection.Input;
                   Parameters[0].SqlDbType = SqlDbType.Int;
                   Parameters[0].ParameterName = "@IdObraOrigen";
                   Parameters[0].Value = Traspaso.IdObraOrigen;

                   Parameters[1] = new SqlParameter();
                   Parameters[1].Direction = ParameterDirection.Input;
                   Parameters[1].SqlDbType = SqlDbType.Int;
                   Parameters[1].ParameterName = "@IdObraDestino";
                   Parameters[1].Value = Traspaso.IdObraDestino;

                   Parameters[2] = new SqlParameter();
                   Parameters[2].Direction = ParameterDirection.Input;
                   Parameters[2].SqlDbType = SqlDbType.Int;
                   Parameters[2].ParameterName = "@IdArticulo";
                   Parameters[2].Value = Traspaso.IdArticulo;

                   Parameters[3] = new SqlParameter();
                   Parameters[3].Direction = ParameterDirection.Input;
                   Parameters[3].SqlDbType = SqlDbType.Decimal;
                   Parameters[3].ParameterName = "@CantidadArtTrasp";
                   Parameters[3].Value = Traspaso.CantidadArtTrasp;
                                 
                   Parameters[4] = new SqlParameter();
                   Parameters[4].Direction = ParameterDirection.Input;
                   Parameters[4].SqlDbType = SqlDbType.Int;
                   Parameters[4].ParameterName = "@Opcion";
                   Parameters[4].Value = Opcion;

                   Parameters[5] = new SqlParameter();
                   Parameters[5].Direction = ParameterDirection.Input;
                   Parameters[5].SqlDbType = SqlDbType.Int;
                   Parameters[5].ParameterName = "@IdArticuloObra";
                   Parameters[5].Value = Traspaso.IdArtObra;  

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
