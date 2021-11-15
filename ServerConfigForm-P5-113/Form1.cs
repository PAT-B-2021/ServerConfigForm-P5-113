using Microsoft.Extensions.Hosting;
using ServiceMtk_P1_20190140113;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_113
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnorOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk mematikan Server";
            Host.Open();
            btn_ON.Enabled = false;
            btn_OFF.Enabled = true;
        }

        private void btn_OFF_Click(object sender, EventArgs e)
        {
            btn_ON.Enabled = true;
            btn_OFF.Enabled = false;
            Host.Close();
            labelKet.Text = "Klik ON untuk menjalankan Server";
            labelOnorOff.Text = "Server OFF";
            
        }
    }
}
