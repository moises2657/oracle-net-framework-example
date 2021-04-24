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
    public partial class salida_primitivos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString;
            string queryString = "APPS.PRUEBA_NET.salida_primitivos";
            OracleDataAdapter sqladapter = new OracleDataAdapter(queryString, connectionString);
            OracleParameter p1 = new OracleParameter("total_rows", OracleDbType.Int32, direction: ParameterDirection.Output);
            sqladapter.SelectCommand.Parameters.Add(p1);
            sqladapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqladapter.Fill(new DataSet());
            Response.Write(p1.Value);
        }
    }
}