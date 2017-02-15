using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SISCOC_DAL;

namespace SISCOC_BL
{
    public class ClsListas
    {
        #region Properties
            private int _value;
            public int value
            {
                get { return _value; }
                set { _value = value; }
            }         

            private string _text;
            public string text
            {
                get { return _text; }
                set { _text = value; }
            }
        #endregion

        #region Public methods

            /*
             Fisica - 1
             Moral  - 2            
            */
            public static List<ClsListas> ListTipoPersona()
                {
                    try
                    {
                        List<ClsListas> TipoPersonaList = new List<ClsListas>();

                        ClsListas Fisica = new ClsListas();
                        ClsListas Moral = new ClsListas();

                        Fisica._value = 1;
                        Fisica._text = "FISICA";

                        Moral._value= 2;
                        Moral._text = "MORAL";

                        TipoPersonaList.Add(Fisica);
                        TipoPersonaList.Add(Moral);

                        return TipoPersonaList;
                    }
                    catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
                }

            /*
             "SUSPENDIDO" - 0
             "NORMAL"     - 1                        
           */
            public static List<ClsListas> ListCmbStatus()
            {
                try
                {
                    List<ClsListas> CmbStatusList = new List<ClsListas>();

                    ClsListas Normal = new ClsListas();
                    ClsListas Suspendido = new ClsListas();                    

                    Suspendido._value = 0;
                    Suspendido._text = "SUSPENDIDO";

                    Normal._value = 1;
                    Normal._text = "NORMAL";                                      

                    CmbStatusList.Add(Normal);
                    CmbStatusList.Add(Suspendido);
                    

                    return CmbStatusList;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }                 
            
             /*
               "NORTE"  -1
               "SUR"    -2
               "ESTE"   -3
               "OESTE"  -4
               "CENTRO" -5
             */
            public static List<ClsListas> ListZona()
            {
                try
                {
                    List<ClsListas> Zona = new List<ClsListas>();

                    ClsListas Norte = new ClsListas();
                    ClsListas Sur = new ClsListas();
                    ClsListas Este = new ClsListas();
                    ClsListas Oeste = new ClsListas();
                    ClsListas Centro = new ClsListas();

                    Norte._value = 1;
                    Norte._text = "NORTE";

                    Sur._value = 2;
                    Sur._text = "SUR";

                    Este._value = 3;
                    Este._text = "ESTE";

                    Oeste._value = 4;
                    Oeste._text = "OESTE";

                    Centro._value = 5;
                    Centro._text = "CENTRO";

                    Zona.Add(Norte);
                    Zona.Add(Sur);
                    Zona.Add(Este);
                    Zona.Add(Oeste);
                    Zona.Add(Centro);
                    
                    return Zona;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

              /*
                "ADMINISTRADOR"  - 1
                "NORMAL"         - 2
                "LIMITADO"       - 3                
              */
            public static List<ClsListas> ListTipoUsuario()
            {
                try
                {
                    List<ClsListas> TipoUsuario = new List<ClsListas>();

                    ClsListas Administrador = new ClsListas();
                    ClsListas Normal = new ClsListas();
                    ClsListas Limitado = new ClsListas();

                    Administrador._value = 1;
                    Administrador._text = "ADMINISTRADOR";

                    Normal._value = 2;
                    Normal._text = "NORMAL";

                    Limitado._value = 3;
                    Limitado._text = "LIMITADO";

                    TipoUsuario.Add(Administrador);
                    TipoUsuario.Add(Normal);
                    TipoUsuario.Add(Limitado);

                    return TipoUsuario;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }
        
            /*
            "APELL PATERNO"   -  1
            "APELL MATERNO"   -  2
            "NOMBRE"       -  3       
             */
            public static List<ClsListas> ListBusqueda()
            {
                try
                {
                    List<ClsListas> Busqueda = new List<ClsListas>();

                    ClsListas ApellPat = new ClsListas();
                    ClsListas ApellMat = new ClsListas();
                    ClsListas Nombre = new ClsListas();

                    ApellPat._value = 1;
                    ApellPat._text = "APELL PATERNO";

                    ApellMat._value = 2;
                    ApellMat._text = "APELL MATERNO";

                    Nombre._value = 3;
                    Nombre._text = "NOMBRE";

                    Busqueda.Add(ApellPat);
                    Busqueda.Add(ApellMat);
                    Busqueda.Add(Nombre);

                    return Busqueda;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }



            /*
              "<"  -1
              ">"  -2
              "="  -3
              "<=" -4
              ">=" -5
              "<>" -6             
            */
            public static List<ClsListas> ListOperadores()
            {
                try
                {
                    List<ClsListas> Operador = new List<ClsListas>();

                    ClsListas Menor = new ClsListas();
                    ClsListas Mayor = new ClsListas();
                    ClsListas Igual = new ClsListas();
                    ClsListas MenorIgual = new ClsListas();
                    ClsListas MayorIgual = new ClsListas();
                    ClsListas Diferente = new ClsListas();

                    Menor._value = 1;
                    Menor._text = "<";

                    Mayor._value = 2;
                    Mayor._text = ">";

                    Igual._value = 3;
                    Igual._text = "=";

                    MenorIgual._value = 4;
                    MenorIgual._text = "<=";

                    MayorIgual._value = 5;
                    MayorIgual._text = ">=";

                    Diferente._value = 6;
                    Diferente._text = "<>";
                    
                    Operador.Add(Menor);
                    Operador.Add(Mayor);
                    Operador.Add(Igual);
                    Operador.Add(MenorIgual);
                    Operador.Add(MayorIgual);
                    Operador.Add(Diferente);

                    return Operador;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }


            /*
              "ReporteCliente"    - 1
              "rep y"  - 2
              "Rep z" - 3                
            */
            public static List<ClsListas> ListReporte()
            {
                try
                {
                    List<ClsListas> Reporte = new List<ClsListas>();

                    ClsListas ReporteCliente = new ClsListas();


                    ReporteCliente._value = 1;
                    ReporteCliente._text = "REPORTE OBRA_CLIENTE";

                    //FormaISAA._value = 2;
                    //FormaISAA._text = "FORMA IS-AA";

                    //FormaISREX._value = 3;
                    //FormaISREX._text = "FORMA IS-REX";

                    Reporte.Add(ReporteCliente);
                    //Reporte.Add(FormaISAA);
                    //Reporte.Add(FormaISREX);

                    return Reporte;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

        #endregion      

    }
}
