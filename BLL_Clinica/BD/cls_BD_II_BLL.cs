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
    public class cls_BD_II_BLL
    {

        public void CrearDTParametros(ref cls_BD_II_DAL Obj_BD_DAL)
        {
            Obj_BD_DAL.dtParametros = new DataTable("PARAMETROS_SP");
            Obj_BD_DAL.dtParametros.Columns.Add("NOMB_PARAM");
            Obj_BD_DAL.dtParametros.Columns.Add("TIP_DAT_PARAM");
            Obj_BD_DAL.dtParametros.Columns.Add("VALOR_PARAM");
        }

        public void ExecDataAdapter(ref cls_BD_II_DAL Obj_BD_DAL)
        {
            try
            {
                // INSTANCIA EL OBJETO DE TIPO SQLCONNECTION
                Obj_BD_DAL.obj_SqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["win_auth"].ToString().Trim());

                if (Obj_BD_DAL.obj_SqlCnx.State == ConnectionState.Closed)
                {
                    //EN ESTE MOMENTO CON LAS CREDENCIALES DEL CONECTIONSTRING CREADO SE AUTENTICA O LOGUEA CON LA BD
                    Obj_BD_DAL.obj_SqlCnx.Open();
                }

                Obj_BD_DAL.Obj_SqlDap = new SqlDataAdapter(Obj_BD_DAL.sNobreSP,   //nombre del store procedure que debe ejecutar en la BD
                                                        Obj_BD_DAL.obj_SqlCnx   //conexion a la bd previamente contruida y abierta
                                                        );

                Obj_BD_DAL.Obj_SqlDap.SelectCommand.CommandType = CommandType.StoredProcedure; //SEGURIDAD, EJECUTA SOLO LO QUE ESTA PREVIAMENTE PROGRAMADO, BUSCA EN PROGRAMABILITY QUE LA SENTENCIA ESTE PROGRAMADA


                //////////////////////////////////////////////////
                #region AGREGAR PARÁMETROS



                if (Obj_BD_DAL.dtParametros != null)//PASA PARAMTROS AL STORE PROCEDURE
                {
                    SqlDbType TipoDatoSQL = SqlDbType.VarChar;

                    foreach (DataRow dr in Obj_BD_DAL.dtParametros.Rows)
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



                        Obj_BD_DAL.Obj_SqlDap.SelectCommand.Parameters.Add(
                                                                            dr[0].ToString(),            //nombre del parametro
                                                                            TipoDatoSQL                  //el tipo de datos que entiende
                                                                            ).Value = dr[2].ToString(); //el valor del parametro
                    }
                }
                #endregion

                ////////////////////////////////////////

                Obj_BD_DAL.dsDatos = new DataSet();

                Obj_BD_DAL.Obj_SqlDap.Fill(Obj_BD_DAL.dsDatos,  //fill objeto donde el sql va a devolver los datos resultando de la ejecucion del SP
                                            Obj_BD_DAL.sNombreDataTable  //nombre tecnico del data tables en programacion o codigo
                                            );



                //SE HACE EL DERROCHE DE TALENTO DE PROGRAMACIÓN PARA IR A EJECUTAR DENTRO DE LA BD
                Obj_BD_DAL.sMsjError = string.Empty;

            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString().Trim();

            }
            finally
            {
                if (Obj_BD_DAL.obj_SqlCnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.obj_SqlCnx.Close();
                }

                Obj_BD_DAL.obj_SqlCnx.Dispose();

            }
        }

        public void ExecCommand(ref cls_BD_II_DAL Obj_BD_DAL)
        {
            try
            {
                // INSTANCIA EL OBJETO DE TIPO SQLCONNECTION
                Obj_BD_DAL.obj_SqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["win_auth"].ToString().Trim());

                if (Obj_BD_DAL.obj_SqlCnx.State == ConnectionState.Closed)
                {
                    //EN ESTE MOMENTO CON LAS CREDENCIALES DEL CONECTIONSTRING CREADO SE AUTENTICA O LOGUEA CON LA BD
                    Obj_BD_DAL.obj_SqlCnx.Open();
                }

                Obj_BD_DAL.Obj_SqlCmd = new SqlCommand(Obj_BD_DAL.sNobreSP,   //************ cambiarle SQLDAP//nombre del store procedure que debe ejecutar en la BD
                                                        Obj_BD_DAL.obj_SqlCnx   //conexion a la bd previamente contruida y abierta
                                                        );

                Obj_BD_DAL.Obj_SqlCmd.CommandType = CommandType.StoredProcedure; //************ cambiarle SQLDAP//SEGURIDAD, EJECUTA SOLO LO QUE ESTA PREVIAMENTE PROGRAMADO, BUSCA EN PROGRAMABILITY QUE LA SENTENCIA ESTE PROGRAMADA


                //////////////////////////////////////////////////
                #region AGREGAR PARÁMETROS


                if (Obj_BD_DAL.dtParametros != null)//PASA PARAMTROS AL STORE PROCEDURE
                {
                    SqlDbType TipoDatoSQL = SqlDbType.VarChar;

                    foreach (DataRow dr in Obj_BD_DAL.dtParametros.Rows)
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



                        Obj_BD_DAL.Obj_SqlCmd.Parameters.Add(//************ cambiarle SQLDAP
                                                             dr[0].ToString(),            //nombre del parametro
                                                             TipoDatoSQL                  //el tipo de datos que entiende
                                                             ).Value = dr[2].ToString(); //el valor del parametro
                    }
                }
                #endregion

                ////////////////////////////////////////
                ///
                if (Obj_BD_DAL.sIndAxn == "NORMAL")
                {
                    Obj_BD_DAL.Obj_SqlCmd.ExecuteNonQuery();//************ cambiarle SQLDAP
                }
                else
                {
                    Obj_BD_DAL.sValorScalar = Obj_BD_DAL.Obj_SqlCmd.ExecuteScalar().ToString().Trim();
                }




                Obj_BD_DAL.sMsjError = string.Empty;

            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString().Trim();

            }
            finally
            {
                if (Obj_BD_DAL.obj_SqlCnx.State == ConnectionState.Open)
                {
                    Obj_BD_DAL.obj_SqlCnx.Close();
                }

                Obj_BD_DAL.obj_SqlCnx.Dispose();

            }
        }

    }
}
