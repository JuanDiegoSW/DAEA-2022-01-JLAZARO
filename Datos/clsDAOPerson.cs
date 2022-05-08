using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class clsDAOPerson : clsDAO
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            con.Open();
            String sql = "select * from Person";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            con.Close();
            return dt;
        }
        public DataTable BuscarNombre(String nombre)
        {
            DataTable dt = new DataTable();
            con.Open();
            String sql = "select * from Person where FirstName like '%" + nombre + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            con.Close();
            return dt;
        }
    }
}
