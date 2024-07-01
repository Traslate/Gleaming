using Diseño1;
using PROSYS;
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
    public partial class FrmMenuInicio : Form
    {
        bool sidebarExpand;
        public FrmMenuInicio()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelBaseSubMenu.Visible = false;

        }
        private void hidesubmenu()
        {
            if (panelBaseSubMenu.Visible == true)
                panelBaseSubMenu.Visible = true;


        }
        private void showsubmenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hidesubmenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Menu___Inicio_Load(object sender, EventArgs e)
        {

        }

        private void sidebartimertick(object sender, EventArgs e)
        {

        }

        private void sidebarcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else 
            {

                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showsubmenu(panelBaseSubMenu);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new bdCliente());

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            bdEmpleado pro = new bdEmpleado();
            pro.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            bdInventario pro = new bdInventario();
            pro.Show();
        }

        private void btnNavegador_Click(object sender, EventArgs e)
        {
            FrmNavegador pro = new FrmNavegador();
            pro.Show();
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            FrmGaleria pro = new FrmGaleria();
            pro.Show();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            FrmCalculaduraC pro = new FrmCalculaduraC();
            pro.Show();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            FrmNotas pro = new FrmNotas();
            pro.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            
        }

        private void panelBaseSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmEdad pro = new FrmEdad();
            pro.Show();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuInicio_Click(object sender, EventArgs e)
        {

        }
        private void panelChildForm_Click(object sender, EventArgs e)
        {
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {


        }

        
    }
}
