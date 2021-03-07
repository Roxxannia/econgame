using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconGame
{
    class Global
    {
        public static String CountryName;
        public static int Day = 0;
        
        public static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        //public static int startTime = 0;
        public static int hour = 0;
        public static int minute = 0;
        public static int resultFlag;
        public static Random rand = new Random();

        //Country Rome variables
        public static int RomeBudget = rand.Next(1, 20) * 1000;
        public static int RomeRUP = rand.Next(50, 200) * 1000;
        public static int RomeWater = rand.Next(1, 30) * 100;
        public static int RomeFV = rand.Next(1, 30) * 100;
        public static int RomeMeat = rand.Next(1, 30) * 10;
        public static int RomeOil = rand.Next(1, 30) * 10;
        public static int RomeMachinery = rand.Next(1, 10) * 100;
        public static int RomeMilitary = rand.Next(1, 20) * 100;
        //Requirements 
        public static int RomeReqWater = rand.Next(1, 15) * 100;
        public static int RomeReqFV = rand.Next(1, 15) * 100;
        public static int RomeReqMeat = rand.Next(1, 20) * 10;
        public static int RomeReqOil = rand.Next(1, 15) * 10;
        public static int RomeReqFees = rand.Next(1, 10) * 100;
        //PPC
        public static int RomePPCWater = rand.Next(1, 90) * 100;
        public static int RomePPCFV = rand.Next(1, 90) * 100;
        public static int RomePPCMeat = rand.Next(1, 90) * 100;
        public static int RomePPCMachine = rand.Next(1, 90) * 100;
        public static int RomePPCOil = rand.Next(1, 90) * 100;


        // Coountry Greece variables
        public static int GreeceBudget = rand.Next(1, 20) * 1000;
        public static int GreeceRUP = rand.Next(1, 9) * 1000;
        public static int GreeceWater = rand.Next(1, 30) * 100;
        public static int GreeceFV = rand.Next(1, 30) * 100;
        public static int GreeceMeat = rand.Next(1, 30) * 10;
        public static int GreeceOil = rand.Next(1, 30) * 10;
        public static int GreeceMachinery = rand.Next(1, 10) * 100;
        public static int GreeceMilitary = rand.Next(1, 20) * 100;
        //Requirements 
        public static int GreeceReqWater = rand.Next(1, 15) * 100;
        public static int GreeceReqFV = rand.Next(1, 15) * 100;
        public static int GreeceReqMeat = rand.Next(1, 20) * 10;
        public static int GreeceReqOil = rand.Next(1, 15) * 10;
        public static int GreeceReqFees = rand.Next(1, 10) * 100;
        //PPC
        public static int GreecePPCWater = rand.Next(1, 90) * 100;
        public static int GreecePPCFV = rand.Next(1, 90) * 100;
        public static int GreecePPCMeat = rand.Next(1, 90) * 100;
        public static int GreecePPCMachine = rand.Next(1, 90) * 100;
        public static int GreecePPCOil = rand.Next(1, 90) * 100;

        // Coountry Player variables
        //Initial resources
        public static int PlayerBudget = rand.Next(1, 20) * 1000;
        public static int PlayerRUP = rand.Next(1, 9) * 1000;
        //public static int PlayerWater = rand.Next(1, 30) * 100;
        public static int PlayerWater = -2;
        public static int PlayerFV = rand.Next(1, 30) * 100;
        public static int PlayerMeat = rand.Next(1, 30) * 10;
        public static int PlayerOil = rand.Next(1, 30) * 10;
        public static int PlayerMachinery = rand.Next(1, 10) * 100;
        public static int PlayerMilitary = rand.Next(1, 20) * 100;
        //Requirements 
        public static int PlayerReqWater = rand.Next(1, 15) * 100;
        public static int PlayerReqFV = rand.Next(1, 15) * 100;
        public static int PlayerReqMeat = rand.Next(1, 20) * 10;
        public static int PlayerReqOil = rand.Next(1, 15) * 10;
        public static int PlayerReqFees = rand.Next(1, 10) * 100;
        //PPC
        public static int PlayerPPCWater = rand.Next(1, 90) * 100;
        public static int PlayerPPCFV = rand.Next(1, 90) * 100;
        public static int PlayerPPCMeat = rand.Next(1, 90) * 100;
        public static int PlayerPPCMachine = rand.Next(1, 90) * 100;
        public static int PlayerPPCOil = rand.Next(1, 90) * 100;


        //Market price random number generation 
        //Rome Market
        public static int GreeceFVPrice = rand.Next(1, 10);
        public static int GreeceMeatPrice = rand.Next(1, 15);
        public static int GreeceMachinePrice = rand.Next(1, 100);
        public static int GreeceOilPrice = rand.Next(20, 50);
        public static int GreeceWaterPrice = rand.Next(1, 100);

        public static int GreeceFVQuantity = rand.Next(1, Global.GreeceReqFV/2);
        public static int GreeceMeatQuantity = rand.Next(1, Global.GreeceReqMeat/2);
        public static int GreeceMachineQuantity = rand.Next(1, Global.GreeceMachinery/2);
        public static int GreeceOilQuantity = rand.Next(1, Global.GreeceReqOil/2);
        public static int GreeceWaterQuantity= rand.Next(1, Global.GreeceReqWater/2);



        //Greece Market
        public static int RomeFVPrice = rand.Next(1,10);
        public static int RomeMeatPrice = rand.Next(1,15);
        public static int RomeMachinePrice = rand.Next(1, 100);
        public static int RomeOilPrice = rand.Next(20,50);
        public static int RomeWaterPrice = rand.Next(1,100);

        public static int RomeFVQuantity = rand.Next(1, Global.RomeReqFV / 2);
        public static int RomeMeatQuantity = rand.Next(1, Global.RomeReqMeat / 2);
        public static int RomeMachineQuantity = rand.Next(1, Global.RomeMachinery / 2);
        public static int RomeOilQuantity = rand.Next(1, Global.RomeReqOil / 2);
        public static int RomeWaterQuantity = rand.Next(1, Global.RomeReqWater / 2);

        //Player Market
        public static int PlayerFVPrice = rand.Next(1, 10);
        public static int PlayerMeatPrice = rand.Next(1, 15);
        public static int PlayerMachinePrice = rand.Next(1, 100);
        public static int PlayerOilPrice = rand.Next(20, 50);
        public static int PlayerWaterPrice = rand.Next(1, 100);

        public static int PlayerFVQuantity;
        public static int PlayerMeatQuantity;
        public static int PlayerMachineQuantity;
        public static int PlayerOilQuantity;
        public static int PlayerWaterQuantity;

        public static void PurchaseWater(int quantity, int price, int buyerQ, int sellerQ, int buyerBudget, int sellerBudget)
        {
            buyerQ = buyerQ + quantity;
            sellerQ = sellerQ - quantity;
            buyerBudget = buyerBudget - quantity * price;
            sellerBudget = sellerBudget + quantity * price;

        }
        public static void PurchaseMachine(int quantity, int price, int buyerQ, int sellerQ, int buyerBudget, int sellerBudget)
        {
            buyerQ = buyerQ + quantity;
            sellerQ = sellerQ - quantity;
            buyerBudget = buyerBudget - quantity * price;
            sellerBudget = sellerBudget + quantity * price;
        }
        public static void PurchaseMeat(int quantity, int price, int buyerQ, int sellerQ, int buyerBudget, int sellerBudget)
        {
            buyerQ = buyerQ + quantity;
            sellerQ = sellerQ - quantity;
            buyerBudget = buyerBudget - quantity * price;
            sellerBudget = sellerBudget + quantity * price;
        }

        public static void PurchaseOil(int quantity, int price, int buyerQ, int sellerQ, int buyerBudget, int sellerBudget)
        {
            buyerQ = buyerQ + quantity;
            sellerQ = sellerQ - quantity;
            buyerBudget = buyerBudget - quantity * price;
            sellerBudget = sellerBudget + quantity * price;
        }

        public static void PurchaseFV(int quantity, int price, int buyerQ, int sellerQ, int buyerBudget, int sellerBudget)
        {
            buyerQ = buyerQ + quantity;
            sellerQ = sellerQ - quantity;
            buyerBudget = buyerBudget - quantity * price;
            sellerBudget = sellerBudget + quantity * price;
        }

        public static void survive()
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
                    MessageBox.Show("Game Ends on Day " + Global.Day+ "\r\n" + Global.playerCountry + " has run out of water.");
                    Global.ShowEcon();
                    
                    
                }
                else if (Global.GreeceWater <= 0)
                {
                    MessageBox.Show("Game Ends. " + "\r\n" + "Ancient Greece has run out of water.");
                    Global.ShowEcon();

                }
                else if (Global.RomeWater <= 0)
                {
                    MessageBox.Show("Game Ends. " + "\r\n" + "Ancient Rome has run out of water.");
                    Global.ShowEcon();

                }
            }
        }


        public static string[] naturalEvents = {"Water Pollution", //0
            "Crop Famine",  //1
            "Mad Cow Disease",  //2
            "Plague", //3 
            "Discovery of Oil Field", //4 
            "Discovery of Gound Water", //5
            "Earthquake", //6
            "Tsunami"}; //7


        public static string[] countries = { "Acient Rome", "Ancient Greece", Global.CountryName }; //0,1,2

        public static String Events;
        public static int EventNum;
        public static String Country;
        public static int CountryNum;
        public static int EventDay1 = rand.Next(2, 4);
        public static int EventDay2 = rand.Next(5, 7);
        public static String EventOfDay;

        public static int length = rand.Next(7, 10);
        public static void pickingCoutries()
        {
            Global.CountryNum = Global.rand.Next(0, 2);
            Global.Country = Global.countries[Global.CountryNum];
        }
        public static void pickingEvents()
        {
            Global.EventNum = Global.rand.Next(0, 7);
            Global.Events = Global.naturalEvents[Global.EventNum];

        }

        public static int warnum = rand.Next(1, 2);
        public static void pickingWar()
        {
            if (Global.warnum == 1)
            {
                Global.warRomeGreece();
                Global.WarChange = "Rome and Greece started a war";
            }
            else 
            {
                Global.WarChange = "Rome and Greece signed Peace Agreements";
            }

        }
        public static String EventChange;
        public static void EventOccurence()
        {
            if (Global.Day == Global.EventDay1 || Global.Day == Global.EventDay2)
            {
                Global.EventOfDay = Global.Events + " hits " + Global.Country;
                if (Global.Country == "Ancient Rome")
                {

                    if (Global.Events == "Water Pollution")
                    {
                        Global.WaterPollution(Global.RomeWater);

                    }
                    else if (Global.Events == "Crop Famine")
                    {
                        Global.CropFamine(Global.RomeFV);

                    }
                    else if (Global.Events == "Mad Cow Disease")
                    {
                        Global.MadCow(Global.RomeMeat);

                    }
                    else if (Global.Events == "Plague")
                    {
                        Global.Plague(Global.RomeFV, Global.RomeMeat, Global.RomeMilitary, Global.RomeRUP);

                    }
                    else if (Global.Events == "Discovery of Oil Field")
                    {
                        Global.DisocverOil(Global.RomeOil);

                    }
                    else if (Global.Events == "Discovery of Ground Water")
                    {
                        Global.DisocverWater(Global.RomeWater, Global.RomePPCWater);

                    }
                    else if (Global.Events == "Earthquake")
                    {
                        Global.Earthquake(Global.RomeWater, Global.RomeFV, Global.RomeMeat, Global.RomeMilitary, Global.RomeRUP, Global.RomeMachinery);

                    }
                    else if (Global.Events == "Tsunami")
                    {
                        Global.Tsunami(Global.RomeWater, Global.RomeFV, Global.RomeMeat, Global.RomeMilitary, Global.RomeRUP, Global.RomeMachinery);
                    }    
                }
                else if (Global.Country == "Ancient Greece")
                {
                    if (Global.Events == "Water Pollution")
                    {
                        Global.WaterPollution(Global.GreeceWater);
                    }
                    else if (Global.Events == "Crop Famine")
                    {
                        Global.CropFamine(Global.GreeceFV);
                    }
                    else if (Global.Events == "Mad Cow Disease")
                    {
                        Global.MadCow(Global.GreeceMeat);
                    }
                    else if (Global.Events == "Plague")
                    {
                        Global.Plague(Global.GreeceFV, Global.GreeceMeat, Global.GreeceMilitary, Global.GreeceRUP);
                    }
                    else if (Global.Events == "Discovery of Oil Field")
                    {
                        Global.DisocverOil(Global.GreeceOil);
                    }
                    else if (Global.Events == "Discovery of Ground Water")
                    {
                        Global.DisocverWater(Global.GreeceWater, Global.GreecePPCWater);
                    }
                    else if (Global.Events == "Earthquake")
                    {
                        Global.Earthquake(Global.GreeceWater, Global.GreeceFV, Global.GreeceMeat, Global.GreeceMilitary, Global.GreeceRUP, Global.GreeceMachinery);
                    }
                    else if (Global.Events == "Tsunami")
                    {
                        Global.Tsunami(Global.GreeceWater, Global.GreeceFV, Global.GreeceMeat, Global.GreeceMilitary, Global.GreeceRUP, Global.GreeceMachinery);
                    }
                }
                else if (Global.Country == Global.CountryName)
                {
                    if (Global.Events == "Water Pollution")
                    {
                        Global.WaterPollution(Global.PlayerWater);
                    }
                    else if (Global.Events == "Crop Famine")
                    {
                        Global.CropFamine(Global.PlayerFV);
                    }
                    else if (Global.Events == "Mad Cow Disease")
                    {
                        Global.MadCow(Global.PlayerMeat);
                    }
                    else if (Global.Events == "Plague")
                    {
                        Global.Plague(Global.PlayerFV, Global.PlayerMeat, Global.PlayerMilitary, Global.PlayerRUP);
                    }
                    else if (Global.Events == "Discovery of Oil Field")
                    {
                        Global.DisocverOil(Global.PlayerOil);
                    }
                    else if (Global.Events == "Discovery of Ground Water")
                    {
                        Global.DisocverWater(Global.PlayerWater, Global.PlayerPPCWater);
                    }
                    else if (Global.Events == "Earthquake")
                    {
                        Global.Earthquake(Global.PlayerWater, Global.PlayerFV, Global.PlayerMeat, Global.PlayerMilitary, Global.PlayerRUP, Global.PlayerMachinery);
                    }
                    else if (Global.Events == "Tsunami")
                    {
                        Global.Tsunami(Global.PlayerWater, Global.PlayerFV, Global.PlayerMeat, Global.PlayerMilitary, Global.PlayerRUP, Global.PlayerMachinery);
                    }
                }           
            }
            else
            {
                Global.EventOfDay = "No special events will take place today";
            }
        }

        //war calculation
        public static void WarResultRome()
        {
            if (Global.RomeMilitary >= 1.3 * Global.PlayerMilitary)
            {
                Global.WarCalculation(Global.RomeWater, Global.RomeFV, Global.RomeMeat, Global.RomeOil, Global.RomeMilitary, Global.RomeRUP, Global.RomeMachinery,
                    Global.PlayerWater, Global.PlayerFV, Global.PlayerMeat, Global.PlayerOil, Global.PlayerMilitary, Global.PlayerRUP, Global.PlayerMachinery, "Aciennt Rome", Global.CountryName);
                Global.resultFlag = -1;
            }
            else if (Global.PlayerMilitary >= 1.3 * Global.RomeMilitary)
            {
                Global.WarCalculation(Global.PlayerWater, Global.PlayerFV, Global.PlayerMeat, Global.PlayerOil, Global.PlayerMilitary, Global.PlayerRUP, Global.PlayerMachinery,
                    Global.RomeWater, Global.RomeFV, Global.RomeMeat, Global.RomeOil, Global.RomeMilitary, Global.RomeRUP, Global.RomeMachinery,
                     Global.CountryName,"Aciennt Rome");
                Global.resultFlag = 1;
            }
            else
            {
                MessageBox.Show(Global.EventChange = "No country won the war.");
                Global.resultFlag = 0;
            }
        }

        public static void WarResultGreece()
        {
            if (Global.GreeceMilitary >= 1.3 * Global.PlayerMilitary)
            {
                Global.WarCalculation(Global.GreeceWater, Global.GreeceFV, Global.GreeceMeat, Global.GreeceOil, Global.GreeceMilitary, Global.GreeceRUP, Global.GreeceMachinery,
                    Global.PlayerWater, Global.PlayerFV, Global.PlayerMeat, Global.PlayerOil, Global.PlayerMilitary, Global.PlayerRUP, Global.PlayerMachinery, "Aciennt Greece", Global.CountryName);
                Global.resultFlag = -1;
            }
            else if (Global.PlayerMilitary >= 1.3 * Global.GreeceMilitary)
            {
                Global.WarCalculation(Global.PlayerWater, Global.PlayerFV, Global.PlayerMeat, Global.PlayerOil, Global.PlayerMilitary, Global.PlayerRUP, Global.PlayerMachinery,
                    Global.GreeceWater, Global.GreeceFV, Global.GreeceMeat, Global.GreeceOil, Global.GreeceMilitary, Global.GreeceRUP, Global.GreeceMachinery,
                     Global.CountryName, "Aciennt Greece");
                Global.resultFlag = 1;
            }
            else
            {
                MessageBox.Show(Global.EventChange = "No country won the war.");
                Global.resultFlag = 0;
            }
        }
        
        public static void warRomeGreece()
        {
            if (Global.GreeceMilitary >= 1.3 * Global.RomeMilitary)
            {
                Global.WarCalculation(Global.GreeceWater, Global.GreeceFV, Global.GreeceMeat, Global.GreeceOil, Global.GreeceMilitary, Global.GreeceRUP, Global.GreeceMachinery,
                   Global.RomeWater, Global.RomeFV, Global.RomeMeat, Global.RomeOil, Global.RomeMilitary, Global.RomeRUP, Global.RomeMachinery, "Aciennt Greece", Global.CountryName);
                Global.resultFlag = -1;
            }
            else if (Global.RomeMilitary >= 1.3 * Global.GreeceMilitary)
            {
                Global.WarCalculation(Global.RomeWater, Global.RomeFV, Global.RomeMeat, Global.RomeOil, Global.RomeMilitary, Global.RomeRUP, Global.RomeMachinery,
                    Global.GreeceWater, Global.GreeceFV, Global.GreeceMeat, Global.GreeceOil, Global.GreeceMilitary, Global.GreeceRUP, Global.GreeceMachinery,
                     Global.CountryName, "Aciennt Greece");
                Global.resultFlag = 1;
            }
            else
            {
                MessageBox.Show(Global.EventChange = "No country won the war.");
                Global.resultFlag = 0;
            }

        }

        public static String WarChange;
        public static void WarCalculation(int winwater, int winFV, int winmeat, int winoil, int winmilitary, int winRUP, int winmachines,
            int lostwater, int lostFV, int lostmeat, int lostoil, int lostmilitary, int lostRUP, int lostmachines, string wincountry, string lostcountry)
        {
            winwater = winwater +lostwater / 2;
            winFV = winFV +lostFV / 2;
            winmeat = winmeat +lostmeat / 2;
            winoil = winoil + lostoil / 2;
            winmilitary = winmilitary +lostmilitary/ 2;
            winRUP = winRUP + lostRUP/ 2;
            winmachines = winmachines + lostmachines / 2;
            MessageBox.Show(Global.WarChange = wincountry + " won the war against " + lostcountry);

        }


        //market




        //Displaying Forms
        public static void ShowStart()
        {
            if (form1 == null)
            {
                form1 = new startForm();
            }
            form1.Show();

        }

        public static startForm form1 = null;

        public static void ShowRules()
        {
            if (rules == null)
            {
                rules = new Rules();
            }
            rules.Show();

        }
        public static Rules rules = null;

        public static void ShowGameForm()
        {
            if (gameform == null)
            {
                gameform = new gameForm();
            }
            gameform.Show();

        }
        public static gameForm gameform = null;

        public static void ShowPlayerCountry()
        {
            if (playerCountry == null)
            {
                playerCountry = new PlayerCountry();
            }
            playerCountry.Show();

        }
        public static PlayerCountry playerCountry = null;

        public static void ShowWar()
        {
            if (war == null)
            {
                war = new War();
            }
            war.Show();

        }
        public static War war = null;

        public static void ShowMarket()
        {
            if (market == null)
            {
                market = new Market();
            }
            market.Show();

        }
        public static Market market = null;

        public static void ShowEcon()
        {
            if (econ == null)
            {
               econ = new Econ();
            }
            econ.Show();

        }
        public static Econ econ= null;

        public static void WaterPollution(int water)
        {
            water = 0;
            Global.EventChange = "All clean water are gone";
        }

        public static void CropFamine(int FV)
        {
            FV = FV * (1 - rand.Next(5, 10) / 10);
            Global.EventChange = "50% to 100% current fruits and vegetables are gone";
        }
        public static void MadCow(int meat)
        {
            meat = meat * (1 - rand.Next(5, 10) / 10);
            Global.EventChange = "50% to 100% current meat are gone";
        }
        public static void Plague(int FV, int meat, int military, int RUP)
        {
            FV = FV * (1 - rand.Next(5, 10) / 10);
            meat = meat * (1 - rand.Next(5, 10) / 10);
            military = military * 8 / 10;
            RUP = RUP * 8 / 10;
            Global.EventChange = "50% to 100% current meat, fruits and vegetables are gone" + "\r\n" + "20% military units and RUPs are gone";
        }

        public static void DisocverOil(int oil)
        {
            oil = oil + 5000;
            Global.EventChange = "Increase oil by 5000 units";
        }

        public static void DisocverWater(int water, int PPC)
        {
            water = water + 9000;
            PPC = PPC / 10;
            Global.EventChange = "Decrease RUP by a factor of 10" + "\r\n" + "Increase clean water by 9000 units";
        }

        public static void Earthquake(int water, int FV, int meat, int military, int RUP, int machines)
        {
            water = water / 2;
            FV = FV / 2;
            meat = meat / 2;
            military = military / 2;
            RUP = RUP / 2;
            machines = machines / 2;
            Global.EventChange = "Half of current resources are gone";
        }

        public static void Tsunami(int water, int FV, int meat, int military, int RUP, int machines)
        {
            water = water / 2;
            FV = FV / 2;
            meat = meat / 2;
            military = military / 2;
            RUP = RUP / 2;
            machines = machines / 2;
            Global.EventChange = "Half of current resources are gone";
        }
    }



}
