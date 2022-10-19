using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string contraseña = txtPassword.Text;

            if (nombre.ToUpper() == "MARCOS" && contraseña == "123456") 
            {
                MessageBox.Show("Bienvenido!");
            }
            else
            {
                MessageBox.Show("No esta registrado");
            }
        }
    }
}
