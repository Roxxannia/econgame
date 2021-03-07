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
    public partial class PlayerCountry : Form
    {
        public PlayerCountry()
        {
            InitializeComponent();
            lblDay.Text = "Day " + Global.Day;
            lblWater.Text = "Water: "+ Global.PlayerWater.ToString();
            lblMeat.Text = "Meat: " + Global.PlayerMeat.ToString();
            lblOil.Text = "Oil: " + Global.PlayerOil.ToString();
            lblMilitary.Text = "Military: " + Global.PlayerMilitary.ToString();
            lblVeg.Text = "Fruits & Vegetables: " + Global.PlayerFV.ToString();
            lblRUP.Text = "RUP: " + Global.PlayerRUP.ToString();
            lblMachinery.Text = "Machinery: " + Global.PlayerMachinery.ToString();
            pnlInfo.Visible = true;
            lblInfo.Text = "Total Bugget: " + Global.PlayerBudget.ToString() +
                "\r\n" + "Labour Fees: " + Global.PlayerReqFees.ToString()+
                "\r\n" + "Water PPC: " + Global.PlayerPPCWater.ToString() +
                "\r\n" + "Meat PPC: " + Global.PlayerPPCMeat.ToString() +
                "\r\n" + "Fruit & Veggies PPC: " + Global.PlayerPPCFV.ToString() +
                "\r\n" + "Oil PPC: " + Global.PlayerPPCOil.ToString()+
                "\r\n" + "Machine PPC: " +Global.PlayerPPCMachine.ToString();
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowRules();
            Global.timer.Stop();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Global.ShowGameForm();
            this.Hide();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Global.PlayerBudget = Global.PlayerBudget - Global.PlayerReqFees;
            btnPay.Enabled = false;
        }
    }
}
