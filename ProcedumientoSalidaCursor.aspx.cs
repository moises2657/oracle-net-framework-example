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
    public partial class salida_cursor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString;
            string queryString = "APPS.PRUEBA_NET.salida_cursor";
            OracleDataAdapter sqladapter = new OracleDataAdapter(queryString, connectionString);
            OracleParameter p1 = new OracleParameter("p_cursor", OracleDbType.RefCursor, direction: ParameterDirection.Output);
            sqladapter.SelectCommand.Parameters.Add(p1);
            sqladapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet x = new DataSet();
            sqladapter.Fill(x);
            Response.Write(JsonConvert.SerializeObject(x, Formatting.Indented));
        }
    }
}