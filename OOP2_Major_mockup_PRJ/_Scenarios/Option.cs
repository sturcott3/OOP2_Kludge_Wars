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
            switch (next)
            {
                case 'a'://a corresponds to the first column of the buttonOne row
                    ButtonText = Data.ScriptedButtonTexts[seed,0];
                    PostClickText = Data.PostScriptedButtonTexts[seed,0];
                    ResultDescription = Data.ScriptedResultDescription[seed,0];
                    PlayerHealthEffect = Data.ScriptedHealthEffects[seed,0];
                    ShipHealthEffect = Data.ScriptedShipHealthEffects[seed,0];
                    FuelEffect = Data.ScriptedFuelEffects[seed,0];
                    MoneyEffect = Data.ScriptedMoneyEffects[seed,0];
                    break;
                case 'b':
                    ButtonText = Data.ScriptedButtonTexts[seed, 1];
                    PostClickText = Data.PostScriptedButtonTexts[seed, 1];
                    ResultDescription = Data.ScriptedResultDescription[seed, 1];
                    PlayerHealthEffect = Data.ScriptedHealthEffects[seed, 1];
                    ShipHealthEffect = Data.ScriptedShipHealthEffects[seed, 1];
                    FuelEffect = Data.ScriptedFuelEffects[seed, 1];
                    MoneyEffect = Data.ScriptedMoneyEffects[seed, 1];
                    break;
                case 'c':
                    ButtonText = Data.ScriptedButtonTexts[seed, 2];
                    PostClickText = Data.PostScriptedButtonTexts[seed, 2];
                    ResultDescription = Data.ScriptedResultDescription[seed, 2];
                    PlayerHealthEffect = Data.ScriptedHealthEffects[seed, 2];
                    ShipHealthEffect = Data.ScriptedShipHealthEffects[seed, 2];
                    FuelEffect = Data.ScriptedFuelEffects[seed, 2];
                    MoneyEffect = Data.ScriptedMoneyEffects[seed, 2];
                    break;
                case 'd':
                    ButtonText = Data.ScriptedButtonTexts[seed, 3];
                    PostClickText = Data.PostScriptedButtonTexts[seed, 3];
                    ResultDescription = Data.ScriptedResultDescription[seed, 3];
                    PlayerHealthEffect = Data.ScriptedHealthEffects[seed, 3];
                    ShipHealthEffect = Data.ScriptedShipHealthEffects[seed, 3];
                    FuelEffect = Data.ScriptedFuelEffects[seed, 3];
                    MoneyEffect = Data.ScriptedMoneyEffects[seed, 3];
                    break;
                case 'e':
                    ButtonText = Data.ScriptedButtonTexts[seed, 4];
                    PostClickText = Data.PostScriptedButtonTexts[seed, 4];
                    ResultDescription = Data.ScriptedResultDescription[seed, 4];
                    PlayerHealthEffect = Data.ScriptedHealthEffects[seed, 4];
                    ShipHealthEffect = Data.ScriptedShipHealthEffects[seed, 4];
                    FuelEffect = Data.ScriptedFuelEffects[seed, 4];
                    MoneyEffect = Data.ScriptedMoneyEffects[seed, 4];
                    break;
            }

        }

        
        //2 integer arg version of constructor is for random gen
        //can add a new encounter type pretty easily by adding the relevant data to Data, and making a 'type' 3
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
