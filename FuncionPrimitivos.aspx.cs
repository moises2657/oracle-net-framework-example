using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemplosOracle
{
    public partial class FuncionPrimitivos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString;
            string queryString = "select APPS.PRUEBA_NET.salida_funcion_primitivos from dual";
            OracleDataAdapter sqladapter = new OracleDataAdapter(queryString, connectionString);
            DataSet res = new DataSet();
            sqladapter.Fill(res);
            Response.Write(JsonConvert.SerializeObject(res, Formatting.Indented));
        }
    }
}