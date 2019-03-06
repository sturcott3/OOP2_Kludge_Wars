using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class Option
    {
        //Button Text, Post-Click text, health effect, shipHealth effect, fuel effect, money effect.
        private string name;
        private string buttonText;
        private string postClckText;
        private int healthEffect;
        private int repairEffect;
        private int fuelEffect;
        private int creditEffect;

        //This is completely independant of Scenario, with my line of thinking being that it would be used to create a
        //pool that we could pull from and assign to the buttons as needed, as many times as needed. 
        public Option(string name, string buttonText, string postClckText, int healthEffect, int repairEffect, int fuelEffect, int creditEffect)
        {//constructor initializes all fields
            this.name = name;
            this.buttonText = buttonText;
            this.postClckText = postClckText;
            
            
            //positive numbers means fuel/money gained or healing/repair
            //negative means damage, expenditure, loss
            //this way we can always just say += in our updateHUD() and when updating properties of Player
            this.healthEffect = healthEffect;
            this.repairEffect = repairEffect;
            this.fuelEffect = fuelEffect;
            this.creditEffect = creditEffect;
        }

        //setters just in case, but probably wont need to use
        public void setName(string name) { this.name = name; }
        public void setButtonText(string text) { buttonText = text; }
        public void setPostClickText(string text) { postClckText = text; }
        public void setHealthEffect(int change) { healthEffect = change; }
        public void setRepairEffect(int change) { repairEffect = change; }
        public void setFuelEffect(int change) { fuelEffect = change; }
        public void setCreditEffect(int change) { creditEffect = change; }



        //getters
        public string ToString() { return this.name + ": " + this.buttonText; } //or some such...
        public string getButtonText(){ return buttonText; }
        public string getPostClickText() { return postClckText ; }
        public int getHealthEffect() { return healthEffect; }
        public int getRepairEffect() { return repairEffect; }
        public int getFuelEffect() { return fuelEffect; }
        public int getCreditEffect() { return creditEffect; }


        public Option[] SetOptions()
       // this can exist either in Scenario, ScenarioController, or here. 
       //Could also be re-written to use a List<Option>
       //and be determined on the fly, for more randomization
        {
            Option[] options = new Option[3];

            //some simple hardcoded examples
            options[0] = new Option("Combat","Fight","Ouch!, you took 3 damage",-3,0,0,0);
            options[1] = new Option("fuel_purchase_v1", "Buy 5 units of fuel for 50 credits.", "Transaction complete.", 0, 0, 5,-50);

            //most important thing about this idea is as we define more complex scenarios, 
            //especially if we begin implementing a more robust randomized combat/encounter system, we 
            //can write functions to randomize the results. I hope the example below is indicative of what I mean.
            options[2] = new Option("random_combat", "Fight", "Ouch!, you took" /*+ getDamage()*/ + "damage.",
                0/* + getPlayerDamage()*/,
                0 /*+ getShipDamage*/, 
                0/*+getFuelReward()*/, 
                0/* + getCreditReward()*/);

            return options;
        }

    }
}
