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
    public partial class gameForm : Form
    {
        public gameForm()
        {
            InitializeComponent();
            lblGreece.Text = "Country: Greece";
            lblRome.Text = "Country: Rome";
            lblYourCountry.Text = "";
            btnMarket.Text = "Market";
            btnWar.Text = "War";
            btnExit.Text = "Exit";
            btnInstruction.Text = "Instruction";
            pnlQuit.Hide();
            lblDay.Text = "Day " + Global.Day;
            
            Global.timer.Tick += new EventHandler(timer1_Tick);
            Global.timer.Start();

            //this.DoubleBuffered = true;
            Global.timer.Interval = 10;
            //Global.pickingCoutries();
            // Global.pickingEvents();
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Global.timer.Stop();
            pnlQuit.Show();
            lblQuit.Text = "Are you sure to quit to game?";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            pnlQuit.Hide();
            Global.timer.Start();
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowRules();
            Global.timer.Stop();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowPlayerCountry();
        }

        private void survive()
        {
            if (Global.PlayerWater >= 0 && Global.GreeceWater >= 0 && Global.RomeWater >= 0)
            {
                MessageBox.Show("All countries have survived");
            }
            else
            {
                Global.timer.Stop();
                if (Global.PlayerWater < 0)
                {
                    MessageBox.Show("Game Ends on Day " + Global.Day + "\r\n" + Global.playerCountry + " has run out of water.");
                    Global.ShowEcon();
                    this.Close();

                }
                else if (Global.GreeceWater <= 0)
                {
                    MessageBox.Show("Game Ends. " + "\r\n" + "Ancient Greece has run out of water.");
                    Global.ShowEcon();
                    this.Close();

                }
                else if (Global.RomeWater <= 0)
                {
                    MessageBox.Show("Game Ends. " + "\r\n" + "Ancient Rome has run out of water.");
                    Global.ShowEcon();
                    this.Close();

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        Random rand1 = new Random();
            
        Global.pickingCoutries();
        Global.pickingEvents();
        //Global.pickingWar();
        Global.minute++;
        lblTime.Text = Global.hour.ToString() + ":" + (Global.minute % 60).ToString();
        if (Global.minute % 60 == 0)
        {

            Global.hour = Global.hour + 1;
            lblTime.Text = Global.hour.ToString() + ":" + (Global.minute % 60).ToString();
            if (Global.hour == 24)
            {
                Global.Day = Global.Day + 1;
                if (Global.Day == 5 && Global.warnum ==1 )
                {
                    Global.warRomeGreece();
                }
                
                lblDay.Text = "Day " + Global.Day;
                Global.hour = 0;
                lblTime.Text = Global.hour.ToString() + ":" + (Global.minute % 60).ToString();
                Global.timer.Stop();
                string caption = "Day " + Global.Day + " Has Ended";
                string message = "Your current resources: " +
                    "\r\n" + "Clean Water: " + Global.PlayerWater +
                    "\r\n" + "Fruits & vegetables: " + Global.PlayerFV +
                    "\r\n" + "Meat: " + Global.PlayerMeat +
                    "\r\n" + "Oil: " + Global.PlayerOil +
                    "\r\n" + "Machinery: " + Global.PlayerMachinery +
                    "\r\n" + "Military: " + Global.PlayerMilitary +
                    "\r\n" + "RUP: " + Global.PlayerRUP +
                    "\r\n" + "Budget: " + Global.PlayerBudget;

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(this, message, caption, buttons,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);

                if (result == DialogResult.OK && Global.Day >= 2)
                {
                    Global.EventOccurence();
                    string caption1 = "Update";
                    string message1 = Global.EventOfDay + "\r\n" + Global.EventChange;
                    MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                    DialogResult result1;

                    // Displays the MessageBox.

                    result1 = MessageBox.Show(this, message1, caption1, buttons1,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign);
                    if (result1 == DialogResult.OK)
                    {
                        Global.timer.Start();
                            survive();
                    }

                }
                else if (result == DialogResult.OK)
                {
                    Global.timer.Start();
                    survive();
                }
            }
        }
    }
                
            
        

        private void btnWar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowWar();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowMarket();
        }
    }
}
