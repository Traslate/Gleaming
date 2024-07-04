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
    public partial class FrmEdad : Form
    {
        int FN, FA, R1, R2, R3;

        private void alphaBlendTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public FrmEdad()
        {
            InitializeComponent();
        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnacimiento_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            FN = Convert.ToInt32(txtnacimiento.Text);
            FA = Convert.ToInt32(txtactual.Text);
            R1 = FA - FN;
            txtedad.Text = R1.ToString();
        }
    }
}
