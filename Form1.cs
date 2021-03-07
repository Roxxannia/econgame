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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
            lblWelcome.Show();
            lblName.Text = "Enter your Country name";
            btnName.Text = "Continue";
            btnName.Text = "Continue";
            btnStartGame.Hide();
            btnInstruction.Hide();
            lblWarning.Visible = false;
            lblEntry.Hide();
            
        }

        
        private void btnName_Click(object sender, EventArgs e)
        {
            Global.CountryName = txtName.Text;
            UpdateScreen();
            
        }

        public void UpdateScreen()
        {
            do
            {
                lblWarning.Visible = true;
                lblWarning.Text = "Please enter your country name to continue";
                
                if (txtName.Text != "")
                {
                    Global.CountryName = txtName.Text;
                    btnStartGame.Show();
                    btnInstruction.Show();
                    txtName.Hide();
                    lblName.Hide();
                    btnName.Hide();
                    lblWarning.Hide();
                    lblEntry.Show();
                    lblEntry.Text = "Welcome to your country " + Global.CountryName + " !";
                    break;
                }
            }
            while (Global.CountryName == null && txtName.Text == "");
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            //when user presses the enter key
            if (e.KeyCode == Keys.Enter)
            {
                btnName.PerformClick();
                UpdateScreen();
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowGameForm();
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowRules();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void startForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(1138, 720);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }






}
