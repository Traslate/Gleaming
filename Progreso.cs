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
    public partial class Progreso : Form
    {
        public Progreso()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(ProgressBar1.Value< 100)
            {
                ProgressBar1.Value += 5;  
            }
            else
            {
                FrmMenuInicio dle = new FrmMenuInicio();
                dle.Show();
                this.Hide();
                timer1.Stop();
            }
        }
        
        

        private void Progreso_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }
    }
}
