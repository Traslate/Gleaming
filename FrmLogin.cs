using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gleaming_Car
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Introduce tu usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Introduce tu usuario";
                txtusuario.ForeColor = Color.DarkGray;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "Introduce tu contraseña")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "Introduce tu contraseña";
                txtcontraseña.ForeColor = Color.DarkGray;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text =="Josue" && txtcontraseña.Text=="sisa2323")
            {
                MessageBox.Show("Datos correctos, puede continuar", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Progreso pro = new Progreso();
                pro.Show();
                this.Hide();                
            }
            else
            {
                MessageBox.Show("Datos incorrectos, vuelva a intentar","LOGIN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
               
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pcMostrar.BringToFront();
            txtcontraseña.UseSystemPasswordChar = false;
        }

        private void pcMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtcontraseña.UseSystemPasswordChar = true;
            
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
