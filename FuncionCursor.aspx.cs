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
    public partial class FuncionCursor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString;
            string queryString = "BEGIN :refcursor1 := APPS.PRUEBA_NET.salida_funcion_cursor; END;";
            OracleDataAdapter sqladapter = new OracleDataAdapter(queryString, connectionString);
            sqladapter.SelectCommand.Parameters.Add(new OracleParameter("refcursor1", OracleDbType.RefCursor, ParameterDirection.Output));
            DataSet res = new DataSet();
            sqladapter.Fill(res);
            Response.Write(JsonConvert.SerializeObject(res, Formatting.Indented));
        }
    }
}