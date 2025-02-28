using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectroTech.conexion
{
	public class DatabaseConnection
	{
        private static string ruta = "Server=localhost\\SQLEXPRESS02;Database=ElectroTech;Trusted_Connection=True;";
        private SqlConnection conexion;

        public SqlConnection GetConnection()
        {

            conexion = new SqlConnection(ruta);
            if (conexion == null)
            {
                conexion = new SqlConnection(ruta);
            }
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }

            return conexion;
        }
        public void CloseConnection()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
