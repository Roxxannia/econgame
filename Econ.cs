using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconGame
{
    public partial class Econ : Form
    {
        public Econ()
        {
            InitializeComponent();


            lblPpf.Text = "A production possibility frontier (PPF) shows the maximum possible output combinations of two goods" + "\r\n" + 
                "or services an economy can achieve when all resources are fully and efficiently employed." + "\r\n" +
                "A PPF is used to show an economy's growth through their resource allocation, production quantities," + "\r\n" +
                "and how efficiently they invest resources.";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "Increase in machinery and new technology improvements";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = "Increase in meat and fruits and vegetables quantities";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = "Increase in military";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = "Improved healthcare, education, and training";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.Text = "Decrease in machinery and lower technology efficiency";
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label13.Text = "Natural disasters such as famine, flood, earthquake";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label14.Text = "Losses due to war";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Text = "Worsened healthcare, education, and training";
        }

        private void label19_Click(object sender, EventArgs e)
        {
            label17.Text = "Producing more meat over fruits";
            label18.Text = "Producing more fruits over meat";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
