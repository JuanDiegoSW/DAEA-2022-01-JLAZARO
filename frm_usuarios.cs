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
    public partial class frm_usuarios : Form
    {
        SqlConnection conn;
        public frm_usuarios(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if( conn.State == ConnectionState.Open)
            {
                String sql = "select *  from tbl_Usuario";
                SqlCommand cmd = new SqlCommand(sql, conn);
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
            String aux = txtNombre.Text;
            if (conn.State == ConnectionState.Open)
            {
                SqlDataAdapter datos = new SqlDataAdapter("select * from tbl_Usuario where usuario_nombre like '%" + this.txtNombre.Text + "%'",conn);
                DataSet dt = new DataSet();
                datos.Fill(dt, "Usuario");
                this.dgvListado.DataSource = dt.Tables[0];
            }
            else
            {
                MessageBox.Show("Conexion Cerrada");
            }
        }
    }
}
