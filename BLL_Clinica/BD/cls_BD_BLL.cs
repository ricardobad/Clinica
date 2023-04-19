using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Clinica.BD;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BLL_Clinica.BD
{
    public class cls_BD_BLL
    {
        public void crearDTparametros(ref cls_BD_DAL Obj_DAL)
        {
            Obj_DAL.obj_dtParametros = new DataTable("parametros");
            Obj_DAL.obj_dtParametros.Columns.Add("Nom_Param");
            Obj_DAL.obj_dtParametros.Columns.Add("Tipo_Dato");
            Obj_DAL.obj_dtParametros.Columns.Add("Valor");
        }


        public void ExecDataAdapter(ref cls_BD_DAL Obj_BD_DAL)
        {//para ejecutar la extraccion de la BD
            try
            {
                Obj_BD_DAL.obj_Sqlcnx = new SqlConnection(ConfigurationManager.ConnectionStrings["sql_auth"].ToString());

                if (Obj_BD_DAL.obj_Sqlcnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.obj_Sqlcnx.Open();
                }



                Obj_BD_DAL.obj_Sqldap = new SqlDataAdapter(Obj_BD_DAL.sNomSp,
                                                        Obj_BD_DAL.obj_Sqlcnx);

                Obj_BD_DAL.obj_Sqldap.SelectCommand.CommandType = CommandType.StoredProcedure;

                #region AGREGAR PARÁMETROS

                if (Obj_BD_DAL.obj_dtParametros != null)
                {
                    SqlDbType TipoDatoSQL = SqlDbType.VarChar;

                    foreach (DataRow dr in Obj_BD_DAL.obj_dtParametros.Rows)
                    {
                        #region Definición de tipos de Datos del SQL

                        switch (dr[1])
                        {
                            case "1":
                                {
                                    TipoDatoSQL = SqlDbType.Int;
                                    break;
                                }
                            case "2":
                                {
                                    TipoDatoSQL = SqlDbType.Decimal;
                                    break;
                                }
                            case "3":
                                {
                                    TipoDatoSQL = SqlDbType.Float;
                                    break;
                                }
                            case "4":
                                {
                                    TipoDatoSQL = SqlDbType.Char;
                                    break;
                                }
                            case "5":
                                {
                                    TipoDatoSQL = SqlDbType.NChar;
                                    break;
                                }
                            case "6":
                                {
                                    TipoDatoSQL = SqlDbType.VarChar;
                                    break;
                                }
                            case "7":
                                {
                                    TipoDatoSQL = SqlDbType.NVarChar;
                                    break;
                                }
                            case "8":
                                {
                                    TipoDatoSQL = SqlDbType.DateTime;
                                    break;
                                }
                            case "9":
                                {
                                    TipoDatoSQL = SqlDbType.Bit;
                                    break;
                                }
                            case "10":
                                {
                                    TipoDatoSQL = SqlDbType.Money;
                                    break;
                                }
                            case "11":
                                {
                                    TipoDatoSQL = SqlDbType.TinyInt;
                                    break;
                                }

                            default:
                                break;
                        }

                        #endregion

                        Obj_BD_DAL.obj_Sqldap.SelectCommand.Parameters.Add(dr[0].ToString(),
                                                                        TipoDatoSQL
                                                                        ).Value = dr[2].ToString();

                    }
                }

                #endregion

                Obj_BD_DAL.obj_ds = new DataSet();
                Obj_BD_DAL.obj_Sqldap.Fill(Obj_BD_DAL.obj_ds,
                                        Obj_BD_DAL.sNomTabla);

                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_BD_DAL.obj_Sqlcnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.obj_Sqlcnx.Close();
                }

                Obj_BD_DAL.obj_Sqlcnx.Dispose();
            }
        }


        public void ExecCommand(ref cls_BD_DAL Obj_BD_DAL)
        {//para realizar las instrucciones
            try
            {
                Obj_BD_DAL.obj_Sqlcnx = new SqlConnection(ConfigurationManager.ConnectionStrings["sql_auth"].ToString());

                if (Obj_BD_DAL.obj_Sqlcnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.obj_Sqlcnx.Open();
                }



                Obj_BD_DAL.obj_Sqlcmd = new SqlCommand(Obj_BD_DAL.sNomSp,
                                                        Obj_BD_DAL.obj_Sqlcnx);

                Obj_BD_DAL.obj_Sqlcmd.CommandType = CommandType.StoredProcedure;

                #region AGREGAR PARÁMETROS

                if (Obj_BD_DAL.obj_dtParametros != null)
                {
                    SqlDbType TipoDatoSQL = SqlDbType.VarChar;

                    foreach (DataRow dr in Obj_BD_DAL.obj_dtParametros.Rows)
                    {
                        #region Definición de tipos de Datos del SQL

                        switch (dr[1])
                        {
                            case "1":
                                {
                                    TipoDatoSQL = SqlDbType.Int;
                                    break;
                                }
                            case "2":
                                {
                                    TipoDatoSQL = SqlDbType.Decimal;
                                    break;
                                }
                            case "3":
                                {
                                    TipoDatoSQL = SqlDbType.Float;
                                    break;
                                }
                            case "4":
                                {
                                    TipoDatoSQL = SqlDbType.Char;
                                    break;
                                }
                            case "5":
                                {
                                    TipoDatoSQL = SqlDbType.NChar;
                                    break;
                                }
                            case "6":
                                {
                                    TipoDatoSQL = SqlDbType.VarChar;
                                    break;
                                }
                            case "7":
                                {
                                    TipoDatoSQL = SqlDbType.NVarChar;
                                    break;
                                }
                            case "8":
                                {
                                    TipoDatoSQL = SqlDbType.DateTime;
                                    break;
                                }
                            case "9":
                                {
                                    TipoDatoSQL = SqlDbType.Bit;
                                    break;
                                }
                            case "10":
                                {
                                    TipoDatoSQL = SqlDbType.Money;
                                    break;
                                }
                            case "11":
                                {
                                    TipoDatoSQL = SqlDbType.TinyInt;
                                    break;
                                }

                            default:
                                break;
                        }

                        #endregion

                        Obj_BD_DAL.obj_Sqlcmd.Parameters.Add(dr[0].ToString(),
                                                                        TipoDatoSQL
                                                                        ).Value = dr[2].ToString();

                    }
                }

                #endregion

                Obj_BD_DAL.obj_Sqlcmd.ExecuteNonQuery();

                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_BD_DAL.obj_Sqlcnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.obj_Sqlcnx.Close();
                }

                Obj_BD_DAL.obj_Sqlcnx.Dispose();
            }
        }
    }
}
