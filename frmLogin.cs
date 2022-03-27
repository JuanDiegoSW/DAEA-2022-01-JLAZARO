using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if( txtUsuario.Text == "admin" && txtPassword.Text =="admin")
            {
                Console.WriteLine("Credenciales Correctas");
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else
            {
                Console.WriteLine("Credenciales Incorrectas");
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
