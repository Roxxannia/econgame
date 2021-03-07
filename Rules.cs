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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
            lblIntro.Text = "Imagine that you are running a country," + 
                "\r\n " + "how do you manage to make your country survive through the challanges";
            lblReady.Text = "Are you ready for the country game?";
            pnlRules.Show();
            scenarios();
            btnNext.Hide();
        }

        public void scenarios()
        {
            btnNext.Hide();
            lblTitle.Text = "Game Scenario";
            lblGameRule.Text = "1250 BC, there existed three countries: Ancient Rome, Ancient Greece and " + Global.CountryName + " ." +
                "\r\n " + "You are the leader of your country " + Global.CountryName + " ." +
                "\r\n" + "\r\n" +
                "In the year of 1250 BC, a natural disaster hit all three countries. Each country is left with a" +
                "\r\n" + "certain amount of resources. However, these resources are not enough for your country to" +
                "\r\n" + "survive through the next couple years. What can you do to help your country to get through" +
                "\r\n" + "the following unknown years?";
        }

        public void vocabularies()
        {
            btnNext.Hide();
            lblTitle.Text = "Game vocabularies";
            lblGameRule.Text = "Total budget:" +
                "\r\n " + "The amount of money your country owns, it is a form of currency shared " +
                "\r\n" + "\r\n" +
                "RUPs:" +
                "\r\n" + "The number of people in your workforce. RUPs can be distributed to produce clean" +
                "\r\n" + "water, meat, fruits & vegetables, machines and oil in order to meet the requirement of your" +
                "\r\n" + "country’s yearly requirement, with regards to the PPC chart." +
                "\r\n" + "\r\n" +
                "Military:" +
                "\r\n" + "Soldiers will enter the battle if a country decides to start a war" +
                "\r\n" + "\r\n" +
                "PPC:" +
                "\r\n" + "PPC describes how many RUPs are required to produce 1 unit of clean water, meat," +
                "\r\n" + "fruits and vegetables, machines and oil.";
        }

        public void resources()
        {
            btnNext.Hide();
            lblTitle.Text = "Game Resources";
            lblGameRule.Text = "Yearly Minimum Requirements include:" +
                "\r\n " + "    -> Clearn water" +
                "\r\n" + "    -> Fruits & Vegetables" +
                "\r\n" + "     -> Meat" +
                "\r\n" + "    -> Oil" +
                "\r\n" + "\r\n" +
                "Captical Resources include:" +
                "\r\n" + "    -> Machine" +
                "\r\n" + "    -> Military" +
                "\r\n" + "\r\n" +
                "Production Possibility (PPC)" +
                "\r\n" + "    -> # RUPS per ton of clean water" +
                "\r\n" + "    -> # RUPS per ton of fruits and vegetables" +
                "\r\n" + "    -> # RUPS per ton of meat" +
                "\r\n" + "    -> # RUPS per unit of machinery" +
                "\r\n" + "    -> # RUPS per unit of oil ";  
        }

        public void rules()
        {
            btnNext.Show();
            lblTitle.Text = "Game rules";
            lblGameRule.Text = "  1. Your country must have the required amount of water to survive" +
                "\r\n " +
                "\r\n " + " 2. You need to supply required amount of meat, fruits &vegetables to military and RUPs" +
                "\r\n " + "    -> If you do not have enough meat, fruits and veggies, " +
                "\r\n" + "         military decreases by 10% and RUPs decrease by 5% by the end of that year." +
                "\r\n " +
                "\r\n " + " 3. You have to pay labour fees for all your RUPs to continue working for the country" +
                "\r\n " + "    -> If you do not pay the labour fees, RUPs decrease by 5-10%." +
                "\r\n " +
                "\r\n " + " 4. You need to have the required amount of oil for all the machines to work" +
                "\r\n " + "    -> If you do not meet the oil requirements, machinery units decrease by %;" +
                "\r\n " + "    -> The % is calculated as the unit of oil possessed/required amount of oil;" +
                "\r\n " + "    -> If there is no oil, machinery units decrease by 25%.";
                
        }


        public void goal()
        {
            btnNext.Hide();
            lblTitle.Text = "Game goals";
            lblGameRule.Text = "Survive through all the years (each day counts as 1 year)" +
                "\r\n" + "Tips: water and Survive :D" +
                 "\r\n" + "We will explore the economic theories behind the game when you finish";
        }

        private void btnScenario_Click(object sender, EventArgs e)
        {
            scenarios();
        }

        private void btnVocab_Click(object sender, EventArgs e)
        {
            vocabularies();
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            resources();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            rules();
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            goal();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.ShowGameForm();
            Global.timer.Start();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblGameRule.Text = "5. You can start a war (more military units wins)" +
                "\r\n " + "    -> one country wins by 30% of military units;" +
                "\r\n " + "    -> the country that wins can take away 50% of the lost country’s resources;" +
                "\r\n " + "    -> you can only start 1 war per day" +
                "\r\n " +
                "\r\n " + "6. You can form a partnership with other countries" +
                "\r\n " + "    -> This partnership must share troops;" +
                "\r\n " + "    -> if one country enters war, the other country automatically enters the war as well." +
                "\r\n " +
                "\r\n " + "7. You are allowed to trade resources with other countries" +
                "\r\n " + "    -> You can choose to accept or reject any trade offers;" +
                "\r\n " + "    -> Other countries can also choose to accept or reject;" +
                "\r\n " + "    -> You can bargain the trade with other countries.";
        }
    }
}
