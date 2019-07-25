using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse02
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Button_Click(object sender, EventArgs e)
        {
            
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Data_Click(object sender, EventArgs e)
        {
            SerialMonitor x = new SerialMonitor();
            x.Show();
        }
    }
}
