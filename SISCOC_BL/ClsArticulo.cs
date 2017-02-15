using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SISCOC_DAL; 
using System.Data.SqlClient;   

namespace SISCOC_BL
{
   public class ClsArticulo
    {      

        #region Propiedades
        private int _IdArticulo;
        public int IdArticulo
        {
            get { return _IdArticulo; }
            set { _IdArticulo = value; }
        }

        private string _NombreArti;
        public string NombreArti
        {
            get { return _NombreArti; }
            set { _NombreArti = value; }
        }

        private string _DescripcionArti;
        public string DescripcionArti
        {
            get { return _DescripcionArti; }
            set { _DescripcionArti = value; }
        }

        private double _PrecioUnit;
        public double PrecioUnit
        {
            get { return _PrecioUnit; }
            set { _PrecioUnit = value; }
        }

        private int _Grupo;
        public int Grupo
        {
            get { return _Grupo; }
            set { _Grupo = value; }
        }

        private int _KitArti;
        public int KitArti
        {
            get { return _KitArti; }
            set { _KitArti = value; }
        }

        private int _Bodega;
        public int Bodega
        {
            get { return _Bodega; }
            set { _Bodega = value; }
        }

        private int _Status;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

       private string _DescKit;
       public string DescKit
       {
           get { return _DescKit; }
           set { _DescKit = value; }
       }

       private int _Kit;
       public int Kit
       {
           get { return _Kit; }
           set { _Kit = value; }
       }

       private int _ClaveKit;
       public int ClaveKit
       {
           get { return _ClaveKit; }
           set { _ClaveKit = value; }
       }


        #endregion

        #region Metodos Publicos

        //**
        /// <summary>
        /// Obtiene una lista de Articulo (contenga filtros)  
        /// </summary>
        /// <returns>Regresa una lista de Articulo</returns>
        /// 

        public static List<ClsArticulo> ListaArticulo(int Status, string Filtro, int Opcion)
        {
            List<ClsArticulo> ArticuloList = new List<ClsArticulo>();
            DataTable Table = new DataTable();

            try
            {

                SqlParameter[] Parameters;
                Parameters = new SqlParameter[3];

                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.Int;
                Parameters[0].ParameterName = "@Status";
                Parameters[0].Value = Status;

                Parameters[1] = new SqlParameter();
                Parameters[1].Direction = ParameterDirection.Input;
                Parameters[1].SqlDbType = SqlDbType.VarChar;
                Parameters[1].ParameterName = "@Filtro";
                Parameters[1].Value = Filtro;

                Parameters[2] = new SqlParameter();
                Parameters[2].Direction = ParameterDirection.Input;
                Parameters[2].SqlDbType = SqlDbType.Int;
                Parameters[2].ParameterName = "@Opcion";
                Parameters[2].Value = Opcion;


                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                Table = DataAccess.ExecuteSPQuery(Parameters, "Sp_Select_Articulo");
                DataAccess.CloseConnection();

                foreach (DataRow Row in Table.Rows)
                {
                    ArticuloList.Add(FillArticulo(Row));
                }

                return ArticuloList; 

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);  
            }
        
        }

        //**
        /// <summary>
        /// Agrega un Articulo
        /// </summary>
        /// <param name="Contacto">recibe un objeto del tipo ClsArticulo</param>
        public static void AddArticulo(ClsArticulo  Articulo)
        {
            try
            {
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Articulo ,true, 3 ) , "Sp_Insert_Articulo");
                DataAccess.CloseConnection(); 
            }
            catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
        }

        //**
        /// <summary>
        /// Actualiza un Articulo
        /// </summary>
        /// <param name="Contacto">recibe un objeto del tipo ClsArticulo</param>
        public static void UpdateArticulo(ClsArticulo Articulo)
        {
            try
            {
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                 DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Articulo, false , 0 ), "Sp_Update_Articulo");
                 DataAccess.CloseConnection();   

            }
            catch (Exception EX)
            { throw new Exception(EX.Message, EX.InnerException); }
        }

        //**
        /// <summary>
        /// Borra Logicamente un Articulo
        /// </summary>
        /// <param name="Contacto">recibe un objeto del tipo ClsArticulo</param>
        public static void DeleteArticulo(ClsArticulo Articulo)
        {
            try
            {
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_CON"].ToString());
                DataAccess.ExecuteSPNonQuery(SplitItemToParameter(Articulo, false, 1), "Sp_Update_Articulo");
                DataAccess.CloseConnection();

            }
            catch (Exception EX)
            { throw new Exception(EX.Message, EX.InnerException); }
        }


        #endregion
       
        #region Metodos Privados


        private static ClsArticulo  FillArticulo(DataRow Row)
        {
            ClsArticulo Articulo = new ClsArticulo();

            try
            {

                Articulo.IdArticulo = Convert.ToInt32(Row["IdArticulo"]);
                Articulo.NombreArti = Convert.ToString(Row["NombreArti"]);
                Articulo.DescripcionArti = Convert.ToString(Row["DescripcionArti"]);
                Articulo.PrecioUnit = Convert.ToDouble(Row["PrecioUnit"]);
                Articulo.Grupo = Convert.ToInt32(Row["Grupo"]);
                Articulo.KitArti = Convert.ToInt32(Row["KitArti"]);
                Articulo.Bodega = Convert.ToInt32(Row["Bodega"]);
                Articulo.Status = Convert.ToInt32(Row["Status"]);
                Articulo.DescKit = Convert.ToString(Row["DescKit"]);
                Articulo.Kit = Convert.ToInt16(Row["Kit"]);
                Articulo.ClaveKit = Convert.ToInt32(Row["ClaveKit"]);

                return Articulo;
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);     
            }

        }

        private static SqlParameter[] SplitItemToParameter(ClsArticulo Articulo, bool isNew, int Opcion)
        {
            
            try
            {

               
                SqlParameter[] Parameters;
                if(isNew)
                  Parameters = new SqlParameter[8];
                else
                  Parameters = new SqlParameter[10];
                                
               

                // Nombre Articulo
                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.VarChar; 
                Parameters[0].ParameterName = "@NombreArti";
                Parameters[0].Value = Articulo.NombreArti;

                //Descripcion Articulo
                Parameters[1] = new SqlParameter();
                Parameters[1].Direction = ParameterDirection.Input;
                Parameters[1].SqlDbType = SqlDbType.VarChar;
                Parameters[1].ParameterName = "@DescripcionArti";
                Parameters[1].Value = Articulo.DescripcionArti;

                //Precio Unitario
                Parameters[2] = new SqlParameter();
                Parameters[2].Direction = ParameterDirection.Input;
                Parameters[2].SqlDbType = SqlDbType.Decimal;
                Parameters[2].ParameterName = "@PrecioUnit";
                Parameters[2].Value = Articulo.PrecioUnit;

                //Grupo
                Parameters[3] = new SqlParameter();
                Parameters[3].Direction = ParameterDirection.Input;
                Parameters[3].SqlDbType = SqlDbType.Int;
                Parameters[3].ParameterName = "@Grupo";
                Parameters[3].Value = Articulo.Grupo;

                //Kit Articulo
                Parameters[4] = new SqlParameter();
                Parameters[4].Direction = ParameterDirection.Input;
                Parameters[4].SqlDbType = SqlDbType.Int;
                Parameters[4].ParameterName = "@KitArti";
                Parameters[4].Value = Articulo.KitArti;

                //Bodega
                Parameters[5] = new SqlParameter();
                Parameters[5].Direction = ParameterDirection.Input;
                Parameters[5].SqlDbType = SqlDbType.Int;
                Parameters[5].ParameterName = "@Bodega";
                Parameters[5].Value = Articulo.Bodega;

                //Bodega
                Parameters[6] = new SqlParameter();
                Parameters[6].Direction = ParameterDirection.Input;
                Parameters[6].SqlDbType = SqlDbType.Int;
                Parameters[6].ParameterName = "@Kit";
                Parameters[6].Value = Articulo.Kit; 


                //Bodega
                Parameters[7] = new SqlParameter();
                Parameters[7].Direction = ParameterDirection.Input;
                Parameters[7].SqlDbType = SqlDbType.Int;
                Parameters[7].ParameterName = "@ClaveKit";
                Parameters[7].Value = Articulo.ClaveKit; 



                //Opción
                if (!isNew)
                {
                 
                        //IdArticulo
                        Parameters[8] = new SqlParameter();
                        Parameters[8].Direction = ParameterDirection.Input;
                        Parameters[8].SqlDbType = SqlDbType.Int;
                        Parameters[8].ParameterName = "@IdArticulo";
                        Parameters[8].Value = Articulo.IdArticulo;

                    if (Opcion == 0)
                    {
                        Parameters[9] = new SqlParameter();
                        Parameters[9].Direction = ParameterDirection.Input;
                        Parameters[9].SqlDbType = SqlDbType.Int;
                        Parameters[9].ParameterName = "@Opcion";
                        Parameters[9].Value = 0;

                    }

                    if (Opcion == 1)
                    {
                        Parameters[9] = new SqlParameter();
                        Parameters[9].Direction = ParameterDirection.Input;
                        Parameters[9].SqlDbType = SqlDbType.Int;
                        Parameters[9].ParameterName = "@Opcion";
                        Parameters[9].Value = 1;
                    }
                    

                }
                return Parameters; 

            }
            catch (Exception EX )
            {
                throw new Exception(EX.Message, EX.InnerException);
            }
        
        }


        #endregion

        #region Metodos Privados
       private static ClsArticulo FillCatalogoArticulo(DataRow Row)
       {
           ClsArticulo CatalogoArticulo = new ClsArticulo();
           try
           {
               CatalogoArticulo.IdArticulo = Convert.ToInt32(Row["IdArticulo"]);
               CatalogoArticulo.NombreArti = Convert.ToString(Row["NombreArti"]);
               CatalogoArticulo.DescripcionArti = (Convert.ToString(Row["DescripcionArti"]) == null ? "" : Convert.ToString(Row["DescripcionArti"]));
               CatalogoArticulo.PrecioUnit = Convert.ToDouble(Row["PrecioUnit"]);
               CatalogoArticulo.Grupo = Convert.ToInt32(Row["Grupo"]);
               CatalogoArticulo.KitArti = Convert.ToInt32(Row["KitArti"]);
               CatalogoArticulo.Bodega = Convert.ToInt32(Row["Bodega"]);
               CatalogoArticulo.Status = Convert.ToInt32(Row["Status"]);
               CatalogoArticulo.DescKit = Convert.ToString(Row["Desckit"]);
               //string s = (p == true ? "Cierto" : "Falso");

               return CatalogoArticulo;
           }
           catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
       }
       #endregion


    }

    #region Filtro
    public class CatalogoArticuloFilter
    {
        private string CatalogoArticuloLists;

        public CatalogoArticuloFilter(string CatalogoArticuloList)
        {
            this.CatalogoArticuloLists = CatalogoArticuloList;
        }

        //busca por Id de Aplicacion
        public bool BuscaCatalogoArticuloLike(ClsArticulo CatalogoArticuloList)
        {
            return CatalogoArticuloList.NombreArti.ToUpper().Contains(CatalogoArticuloLists.ToUpper());
        }
    }
    #endregion

}
