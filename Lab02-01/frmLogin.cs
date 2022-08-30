using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario { usuario = "melady" , contraseña="123"});


            foreach(Usuario i in usuarios)
            {
                if (txtUsuario.Equals(i.usuario)){
                    if (txtPassword.Equals(i.contraseña)){
                        PrincipalMDI principal = new PrincipalMDI();
                        principal.Show();
                        this.Hide();
                    } else {
                        frmLogin login = new frmLogin();
                        login.Show();
                        this.Hide();
                    }
                }else
                {
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Hide();
                }
           
            }

          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
