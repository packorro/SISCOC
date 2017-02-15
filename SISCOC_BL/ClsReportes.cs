using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SISCOC_DAL;

namespace SISCOC_BL
{
    public class ClsReportes
    {

        #region FORMA_IS-AA

            //ENTRADAS DE MATERIAL FORMA IS-AA RECIBE 4 PARAMETROS
            public static DataTable ListObraCliente(string _Operador, decimal _Monto, int _Zona)
            {
                DataTable Table = new DataTable("ObraCliente");

                try
                {
                    Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());

                    Table = DataAccess.ExecuteQuery(" SELECT (RTRIM(Apell_Pat) +' '+ RTRIM(Apell_Mat) +' '+ RTRIM(Nombre)) AS Cliente, " +
                                                               " Monto, SubSidio, MontoBruto, " +
                                                               " CASE Zona  " +
                                                                    " WHEN 1 THEN 'NORTE' " +
                                                                    " WHEN 2 THEN 'SUR' " +
                                                                    " WHEN 3 THEN 'ESTE' " +
                                                                    " WHEN 4 THEN 'OESTE' " +
                                                                    " WHEN 5 THEN 'CENTRO' " +
                                                               " END  AS Zona " +
                                                    " FROM Cliente " +
                                                    " WHERE MontoBruto " + _Operador + "  " + _Monto + " AND Zona=" + _Zona + " AND Status=1 " +
                                                    " ORDER BY Zona, Cliente");

                    DataAccess.CloseConnection();

                    return Table;
                }
                catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
            }

        #endregion


        #region Obra-Articulos

        public static DataTable ListObraArti(DateTime FI, DateTime FF, int Obra)
        {
            DataTable Table = new DataTable("ObraArticulo");
            try
            {

                SqlParameter[] Parameters;
                Parameters = new SqlParameter[3];

                Parameters[0] = new SqlParameter();
                Parameters[0].Direction = ParameterDirection.Input;
                Parameters[0].SqlDbType = SqlDbType.DateTime;
                Parameters[0].ParameterName = "@FechaIni";
                Parameters[0].Value = FI;


                Parameters[1] = new SqlParameter();
                Parameters[1].Direction = ParameterDirection.Input;
                Parameters[1].SqlDbType = SqlDbType.DateTime;
                Parameters[1].ParameterName = "@FechaFin";
                Parameters[1].Value = FF;

                if (Obra == 0)
                {
                    Parameters[2] = new SqlParameter();
                    Parameters[2].Direction = ParameterDirection.Input;
                    Parameters[2].SqlDbType = SqlDbType.Int;
                    Parameters[2].ParameterName = "@Obra";
                    Parameters[2].Value = null;
                }
                else
                {
                    Parameters[2] = new SqlParameter();
                    Parameters[2].Direction = ParameterDirection.Input;
                    Parameters[2].SqlDbType = SqlDbType.Int;
                    Parameters[2].ParameterName = "@Obra";
                    Parameters[2].Value = Obra;
                }
                Data DataAccess = new Data(System.Configuration.ConfigurationManager.ConnectionStrings["SISCOC_FEL.Properties.Settings.SISCOC_Con"].ToString());
                Table = DataAccess.ExecuteSPQuery(Parameters, "Sp_Report_Obra");
                DataAccess.CloseConnection();

                return Table;

            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message, EX.InnerException);
            }

        }

        #endregion
        

    }
}
