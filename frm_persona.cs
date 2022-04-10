using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class frm_persona : Form
    {
        SqlConnection con;
        public frm_persona(SqlConnection conn)
        {
            this.con = conn;
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if( con.State == ConnectionState.Open)
            {
                String sql = "select *  from Person";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();
            }
            else
            {
                MessageBox.Show("Conexion Cerrada");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           if (con.State == ConnectionState.Open)
            {
                String FirstName = txtNombre.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BuscarPersonaNombre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@FirstName";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = FirstName;

                cmd.Parameters.Add(param);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();

            }
            else
            {
                MessageBox.Show("Conexion Cerrada");
            }
        }
    }
}
