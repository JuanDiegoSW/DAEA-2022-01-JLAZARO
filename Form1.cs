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
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;

            String str = "Server=" + servidor + ";DataBase=" + bd + ";";

            if (chkAutenticacion.Checked)
                str += "Integrated Security=true";
            else
                str += "User Id=" + user + ";Password=" + pwd + ";";
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conexion Exitosa");
                btnDesconectar.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al conectarse el servidor: " + ex.ToString());
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frm_usuarios usuario = new frm_usuarios(conn);
            usuario.Show();

        }
    }
}
