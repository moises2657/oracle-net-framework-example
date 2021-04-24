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
    public partial class entrada_primitiva : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CONEXION"].ConnectionString;
            string queryString = "APPS.PRUEBA_NET.entrada_primitivos";
            OracleDataAdapter sqladapter = new OracleDataAdapter(queryString, connectionString);
            OracleParameter p1 = new OracleParameter("p_ejemplo1", OracleDbType.Int32, direction: ParameterDirection.Input);
            p1.Value = 20;
            p1.Direction = ParameterDirection.Input;
            OracleParameter p2 = new OracleParameter("p_ejemplo2", OracleDbType.Varchar2, direction: ParameterDirection.Input);
            p2.Value = "ejemplo";
            sqladapter.SelectCommand.Parameters.Add(p1);
            sqladapter.SelectCommand.Parameters.Add(p2);
            sqladapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqladapter.Fill(new DataSet());
        }
    }
}