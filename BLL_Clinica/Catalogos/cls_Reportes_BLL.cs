using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL_Clinica;
using System.Data.SqlClient;
using BLL_Clinica.BD;
using DAL_Clinica.BD;
using System.Configuration;

namespace BLL_Clinica.Catalogos
{
    public class cls_Reportes_BLL
    {
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();

        public void CitasTotales(ref cls_Reportes_DAL Obj_Reportes_DAL)
        {
            Obj_BD_DAL.sNomSp = ConfigurationManager.AppSettings["reporte_citas_totales"].ToString();
            Obj_BD_BLL.crearDTparametros(ref Obj_BD_DAL);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@fecha_inicial", "8", Obj_Reportes_DAL.FechaInicial);
            Obj_BD_DAL.obj_dtParametros.Rows.Add("@fecha_final", "8", Obj_Reportes_DAL.FechaFinal);

            Obj_BD_DAL.sNomTabla = "T_CITAS";

            Obj_BD_BLL.ExecDataAdapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Reportes_DAL.sMsjError = string.Empty;
                Obj_Reportes_DAL.DtDatos = Obj_BD_DAL.obj_ds.Tables[0];
            }
            else
            {
                Obj_BD_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Reportes_DAL.DtDatos = null;
            }

        }

    }
}
