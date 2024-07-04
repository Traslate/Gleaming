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
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, num4, suma, promedio;
            num1 = int.Parse(txtnota1.Text);
            num2 = int.Parse(txtnota2.Text);
            num3 = int.Parse(txtnota3.Text);
            num4 = int.Parse(txtnota4.Text);
            suma = num1 + num2 + num3 + num4;
            lblresultado.Text = (suma / 4).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {

        }
    }
}
