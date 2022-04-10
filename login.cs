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
    public partial class login : Form
    {
        SqlConnection con;
        public login(SqlConnection conn)
        {
            this.con = conn;
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "p_Login";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlParameter param = new SqlParameter();
            //param.ParameterName = "@usu_nombre";
            //param.SqlDbType = SqlDbType.NVarChar;
            //param.Value = usuario;
            /*param.ParameterName = "@usu_password";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = password;*/

            cmd.Parameters.Add("@usu_nombre", SqlDbType.VarChar).Value = usuario;
            cmd.Parameters.Add("@usu_pass", SqlDbType.VarChar).Value = password;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                frm_persona persona = new frm_persona(con);
                reader.Close();
                persona.Show();
            }
            else
            {
                txtPassword.Text = "";
                txtUsuario.Text = "";

                MessageBox.Show("Datos Erroneos");
            }
        }
    }
}
