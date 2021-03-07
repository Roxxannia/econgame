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
    public partial class Market : Form
    {
        public Market()
        {
            InitializeComponent();
            lblRUP.Text = "RUP: " + Global.PlayerRUP.ToString();
            lblGVeg.Text = "Greeece: " + Global.GreeceFVPrice.ToString();
            lblGMach.Text = "Greeece: " + Global.GreeceMachinePrice.ToString();
            lblGMeat.Text = "Greeece: " + Global.GreeceMeatPrice.ToString();
            lblGOil.Text = "Greeece: " + Global.GreeceOilPrice.ToString();
            lblGWater.Text = "Greeece: " + Global.GreeceWaterPrice.ToString();

            lblRVeg.Text = "Rome: " + Global.RomeFVPrice.ToString();
            lblRMach.Text = "Rome: " + Global.RomeMachinePrice.ToString();
            lblRMeat.Text = "Rome: " + Global.RomeMeatPrice.ToString();
            lblROil.Text = "Rome: " + Global.RomeOilPrice.ToString();
            lblRWater.Text = "Rome: " + Global.RomeWaterPrice.ToString();

            displayinfo();
        }

        private void displayinfo()
        {
            lblYours.Text = "Water: " + Global.PlayerWater.ToString() +
            "\r\n" + "Meat: " + Global.PlayerMeat.ToString() +
            "\r\n" + "Oil: " + Global.PlayerOil.ToString() +
            "\r\n" + "Military: " + Global.PlayerMilitary.ToString() +
            "\r\n" + "Fruits & Vegetables: " + Global.PlayerFV.ToString() +
           "\r\n" + "RUP: " + Global.PlayerRUP.ToString() +
            "\r\n" + "Machinery: " + Global.PlayerMachinery.ToString();
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
        }

       

        private void btnOne_Click(object sender, EventArgs e)
        {
            //ok so
            //again using ran gen stuff, there will be 3 resources requested by other countries to be sold to 
            //within the lbl is which resource, and then the price and quantity wanted 
            //if player wants to sell, they will click the Sell! button otherwise, ignore 
            //these 3 offers are there until the day is over and a new set of random offers are inputted 

            //by clicking sell! button, math will be done to the player's RUP and sold resource quantity
            //add and subtract accordingly 

            //make sure to disable the sell! button after they sell it once lol and use the flag var again here to reenable after a new day

        }

        private void lblGVeg_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGVeg_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(txtGVeg.Text);
            if (quantity <= Global.GreeceFVQuantity && quantity >= 1)
            {
                Global.PurchaseFV(quantity, Global.GreeceFVPrice, Global.PlayerFV, Global.GreeceFV, Global.PlayerBudget, Global.GreeceBudget);
                displayinfo();
            }
            else if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid number");
                Global.timer.Stop();
            }
            else
            {
                MessageBox.Show("You didn't purchase anything");
                Global.timer.Stop();
            }
            
        }

        private void btnRVeg_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(txtRVeg.Text);
            if (quantity <= Global.GreeceFVQuantity && quantity >= 1)
            {
                Global.PurchaseFV(quantity, Global.RomeFVPrice, Global.PlayerFV, Global.RomeFV, Global.PlayerBudget, Global.RomeBudget);
                displayinfo();
            }
            else if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid number");
            }
            else
            {
                MessageBox.Show("You didn't purchase anything");
                Global.timer.Stop();
            }

        }

        private void btnGMach_Click(object sender, EventArgs e)
        {
            Global.PurchaseMachine(Global.GreeceMachineQuantity, Global.GreeceMachinePrice, Global.PlayerMachinery, Global.GreeceMachinery, Global.PlayerBudget, Global.GreeceBudget);
        }

        private void btnRMach_Click(object sender, EventArgs e)
        {
            Global.PurchaseMachine(Global.RomeMachineQuantity, Global.RomeMachinePrice, Global.PlayerMachinery, Global.RomeMachinery, Global.PlayerBudget, Global.RomeBudget);
        }

        private void btnGOil_Click(object sender, EventArgs e)
        {
            Global.PurchaseOil(Global.GreeceOilQuantity, Global.GreeceOilPrice, Global.PlayerOil, Global.GreeceOil, Global.PlayerBudget, Global.GreeceBudget);
        }

        private void btnROil_Click(object sender, EventArgs e)
        {
            Global.PurchaseOil(Global.RomeOilQuantity, Global.RomeOilPrice, Global.PlayerOil, Global.RomeOil, Global.PlayerBudget, Global.RomeBudget);
        }

        private void btnGMeat_Click(object sender, EventArgs e)
        {
            Global.PurchaseMeat(Global.GreeceMeatQuantity, Global.GreeceMeatPrice, Global.PlayerOil, Global.GreeceMeat, Global.PlayerBudget, Global.GreeceBudget);

        }

        private void btnRMeat_Click(object sender, EventArgs e)
        {
            Global.PurchaseMeat(Global.RomeMeatQuantity, Global.RomeMeatPrice, Global.PlayerOil, Global.RomeMeat, Global.PlayerBudget, Global.GreeceBudget);
        }

        private void btnGWater_Click(object sender, EventArgs e)
        {
            Global.PurchaseWater(Global.GreeceWaterQuantity, Global.GreeceWaterPrice, Global.PlayerOil, Global.GreeceWater, Global.PlayerBudget, Global.GreeceBudget);

        }

        private void btnRWater_Click(object sender, EventArgs e)
        {
            Global.PurchaseWater(Global.RomeWaterQuantity, Global.RomeWaterPrice, Global.PlayerOil, Global.RomeWater, Global.PlayerBudget, Global.RomeBudget);
        }
    }
}
