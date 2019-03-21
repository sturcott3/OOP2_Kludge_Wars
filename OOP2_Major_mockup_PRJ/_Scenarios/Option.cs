using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class Option
    {
        //Auto-implemented properties to allow them 
        //to be built piecemeal in the scripted scenes, at least for now
        public string ButtonText { get; set; }
        public string PostClickText { get; set; }
        public string ResultDescription { get; set; }
        public int PlayerHealthEffect { get; set; }
        public int ShipHealthEffect { get; set; }
        public int FuelEffect { get; set; }
        public int MoneyEffect { get; set; }


        //Overloaded constructors allows type of encounter to get relevant data from Data class


        public Option() { }//no arg constructor allows piece by piece construction of these later, 
                           //in the scripted scenarios(from player input at runtime or other possible functionality)



        //1 arg constructor for scripted, predetermined
        //seed tracks which episode we are on, next enforces overloading/differentiation
        public Option(int seed, char next)
        {

        }

        
        //2 arg constructor is for random gen
        public Option(int type, int index)
        {
            if (type == 1)
            {
                ButtonText = Data.CombatButtonTexts[index];
                PostClickText = Data.PostCombatButtonTexts[index];
                ResultDescription = Data.CombatResultDescription[index];
                PlayerHealthEffect = Data.CombatHealthEffects[index];
                ShipHealthEffect = Data.CombatShipHealthEffects[index];
                FuelEffect = Data.CombatFuelEffects[index];
                MoneyEffect = Data.CombatMoneyEffects[index];

            }
            else if (type == 2)
            {
                ButtonText = Data.MerchantButtonTexts[index];
                PostClickText = Data.PostMerchantButtonTexts[index];
                ResultDescription = Data.MerchantResultDescription[index];
                PlayerHealthEffect = Data.MerchantHealthEffects[index];
                ShipHealthEffect = Data.MerchantShipHealthEffects[index];
                FuelEffect = Data.MerchantFuelEffects[index];
                MoneyEffect = Data.MerchantMoneyEffects[index];
            }
        } 
    }
}
