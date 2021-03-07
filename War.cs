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
    public partial class War : Form
    {
        public War()
        {
            InitializeComponent();
            pnlWin.Visible = true;
            pnlLose.Visible = true;

            //Global.resultFlag = 0;
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowRules();
            Global.timer.Stop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowGameForm();
            //this part helps with enabling the buttons again when the player comes back
            //but need code to check if it's the next day or not
            //disable war button in the GameMainform.cs until it is the next day?
            if (Global.resultFlag == 1)
            {
                btnRome.Enabled = true;
                btnGreece.Enabled = true;
            }
        }

        private void btnRome_Click(object sender, EventArgs e)
        {
            //user decides to fight rome 
            //get rome's military stats and compare with playercountry's military 
            // can have a global function that does the comparison if you want 
            // or just get the values and compare here 

            //according to the rules, do the math and show stats on the resources you've won or lost and their quantities
            //display all win/lose resources stats in the lblWin or lblLose 
            Global.WarResultRome();
            //if win
            if (Global.resultFlag == 1)
            { pnlWin.Visible = true; }
            else if (Global.resultFlag == -1)
            { pnlLose.Visible = true; }
           
            //lblWin.Text = "You won the war!"; //and blah
            //if lose
            
            //lblLose.Text = "You lost the war!"; // and blah
            //player can only go to war once per day 
            btnGreece.Enabled = false;
            btnRome.Enabled = false;

        }

        private void btnGreece_Click(object sender, EventArgs e)
        {
            Global.WarResultGreece();
            //if win
            if (Global.resultFlag == 1)
            { pnlWin.Visible = true; }
            else if (Global.resultFlag == -1)
            { pnlLose.Visible = true; }

            btnGreece.Enabled = false;
            btnRome.Enabled = false;
        }
    }
}
