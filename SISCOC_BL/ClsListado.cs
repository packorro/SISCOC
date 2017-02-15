using System;
using System.Collections.Generic;
using System.Text;

namespace SISCOC_BL
{
   public  class ClsListado
    {

        #region Propiedades

        private int _Valor;
        public int Valor
        {
            get { return  _Valor;   }
            set { _Valor = value; }
        }

        private string _ValorStr;
        public string ValorStr
        {
            get { return _ValorStr; }
            set { _ValorStr = value; }
        }

        private string _Texto;
        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }

        #endregion

        #region Public Methods

        //Tipo Persona
        //Fisica - F
        //Moral  -  M

        public static List<ClsListado> TipoPersona ()
        {

            try
            {
                List<ClsListado> CmbTipoPersona = new List<ClsListado>();

                ClsListado Fisica = new ClsListado();
                ClsListado Moral = new ClsListado();

                Fisica._ValorStr = "F";
                Fisica._Texto = "FISICA";

                Moral._ValorStr = "M";
                Moral._Texto = "MORAL";

                CmbTipoPersona.Add(Fisica);
                CmbTipoPersona.Add(Moral);

                return CmbTipoPersona; 


            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message.ToString(), EX.InnerException);
            }

        }

        //Zonas
        //- Norte
        //- Sur
        //- Este
        //- Oeste

        public static List<ClsListado> CmbZonas()
         {
             try
             {

                 List<ClsListado> CmdZonas = new List<ClsListado>();

                 ClsListado Norte = new ClsListado();
                 ClsListado Sur = new ClsListado();
                 ClsListado Este = new ClsListado();
                 ClsListado Oeste = new ClsListado();

                 Norte._ValorStr = "N";
                 Norte._Texto = "NORTE";

                 Sur._ValorStr = "S";
                 Sur._Texto = "SUR";

                 Este._ValorStr = "E";
                 Este._Texto = "ESTE";

                 Oeste._ValorStr = "O";
                 Oeste._Texto = "OESTE";

                 CmdZonas.Add(Norte);
                 CmdZonas.Add(Sur);
                 CmdZonas.Add(Este);
                 CmdZonas.Add(Oeste);

                 return CmdZonas;

             }
             catch(Exception EX)
             {
                 throw new Exception(EX.Message.ToString(), EX.InnerException);
             }

         }

        //Bodega
        //1
        //2

        public static List<ClsListado> CmdBodega()
        {
            try
            {

                List<ClsListado> CmbBodega = new List<ClsListado>();

                ClsListado Bodega1 = new ClsListado();
                ClsListado Bodega2 = new ClsListado();

                Bodega1._Valor = 1;
                Bodega2._Valor = 2;

                CmbBodega.Add(Bodega1);
                CmbBodega.Add(Bodega2);

                return CmbBodega; 

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message.ToString(), EX.InnerException);      
            }
        
        }

        //KIT

        //PLOMERIA PLUS
        //PLOMERIA PVC
        //PLOMERIA COBRE Y GALVANIZADA
        //INSTALACION DE BAÑO
        //VITROPISO Y AZULEJO
        //ELECTRICIDAD
        //PINTURA E IMPERMEABILIZANTE
        //GESTORIA 

        public static List<ClsListado> CmdKit()
        {
            try
            {
                List<ClsListado> CmbKit = new List<ClsListado>();

                ClsListado PlomeriaPls = new ClsListado();
                ClsListado PlomeriaPvc = new ClsListado();
                ClsListado PlomeriaCG = new ClsListado();
                ClsListado InstalacionBaño = new ClsListado();
                ClsListado VitroAzulejo = new ClsListado();
                ClsListado Electric = new ClsListado();
                ClsListado PintImperm = new ClsListado();
                ClsListado Gestoria = new ClsListado();


                PlomeriaPls._Valor = 1;
                PlomeriaPls._Texto = "PLOMERIA PLUS";

                PlomeriaPvc._Valor = 2;
                PlomeriaPvc._Texto = "PLOMERIA PVC";

                PlomeriaCG._Valor = 3;
                PlomeriaCG._Texto = "PLOMERIA COBRE Y GALVANIZADA";

                InstalacionBaño._Valor = 4;
                InstalacionBaño._Texto = "INSTALACION DE BAÑO";

                VitroAzulejo._Valor = 5;
                VitroAzulejo._Texto = "VITROPISO Y AZULEJO";

                Electric._Valor = 6;
                Electric._Texto = "ELECTRICIDAD";

                PintImperm._Valor = 7;
                PintImperm._Texto = "PINTURA E IMPERMEABILIZANTE";

                Gestoria._Valor = 8;
                Gestoria._Texto = "GESTORIA";

                CmbKit.Add(PlomeriaPls);
                CmbKit.Add(PlomeriaPvc);
                CmbKit.Add(PlomeriaCG);
                CmbKit.Add(InstalacionBaño);
                CmbKit.Add(VitroAzulejo);
                CmbKit.Add(Electric);
                CmbKit.Add(PintImperm);
                CmbKit.Add(Gestoria);  


                return CmbKit; 

            }

            catch( Exception EX )
            {
                throw new Exception(EX.Message.ToString(), EX.InnerException);     
            }
        
        }


        //STATUS

        //ACTIVO = 1 
        //INACTIVO = 0 

        public static List<ClsListado> Status()
        {

            try
            {

                List<ClsListado> CmbStatus = new List<ClsListado>();

                ClsListado Activo = new ClsListado();
                ClsListado Inactivo = new ClsListado();

                Activo._Valor = 1;
                Activo._Texto = "ACTIVO";

                Inactivo._Valor = 0;
                Inactivo._Texto  = "INACTIVO";

                CmbStatus.Add(Activo);
                CmbStatus.Add(Inactivo);
                

                return CmbStatus; 

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message.ToString(), EX.InnerException);    
            }

        
        
        }

        //PROVEEDORES

        //MAPCO

        public static List<ClsListado> Proveedor()

        {

            try
            {
                List<ClsListado> CmbProveedor = new List<ClsListado>();

                ClsListado MAPCO = new ClsListado();

                MAPCO._Valor = 1;
                MAPCO._Texto = "MAPCO" ;

                CmbProveedor.Add(MAPCO); 

                return CmbProveedor; 

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message.ToString(), EX.InnerException);    
            }

        
        }



        #endregion

    }
}
