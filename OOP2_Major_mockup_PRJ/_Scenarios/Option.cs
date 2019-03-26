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


        //constructor allows type of encounter to get relevant data from Data class


        public Option() { }//no arg constructor allows piece by piece construction of these later, 
                           //in the scripted scenarios(from player input at runtime or other possible functionality)

        
        //seed tracks which episode we are on when Scripted is true. When Scripted is false, sceneTracker tracks 
        public Option(int sceneTracker, int button , bool Scripted)
        {
            if (Scripted) {

                sceneTracker -= 1;

                switch (button)
                {
                    case 0:
                        ButtonText = Data.ScriptedButtonTexts[sceneTracker,button];
                        PostClickText = Data.PostScriptedButtonTexts[sceneTracker, button];
                        ResultDescription = Data.ScriptedResultDescription[sceneTracker, button];
                        PlayerHealthEffect = Data.ScriptedHealthEffects[sceneTracker, button];
                        ShipHealthEffect = Data.ScriptedShipHealthEffects[sceneTracker, button];
                        FuelEffect = Data.ScriptedFuelEffects[sceneTracker, button];
                        MoneyEffect = Data.ScriptedMoneyEffects[sceneTracker, button];
                        break;
                    case 1:
                        ButtonText = Data.ScriptedButtonTexts[sceneTracker, button];
                        PostClickText = Data.PostScriptedButtonTexts[sceneTracker, button];
                        ResultDescription = Data.ScriptedResultDescription[sceneTracker, button];
                        PlayerHealthEffect = Data.ScriptedHealthEffects[sceneTracker, button];
                        ShipHealthEffect = Data.ScriptedShipHealthEffects[sceneTracker, button];
                        FuelEffect = Data.ScriptedFuelEffects[sceneTracker, button];
                        MoneyEffect = Data.ScriptedMoneyEffects[sceneTracker, button];
                        break;
                    case 2:
                        ButtonText = Data.ScriptedButtonTexts[sceneTracker, button];
                        PostClickText = Data.PostScriptedButtonTexts[sceneTracker, button];
                        ResultDescription = Data.ScriptedResultDescription[sceneTracker, button];
                        PlayerHealthEffect = Data.ScriptedHealthEffects[sceneTracker, button];
                        ShipHealthEffect = Data.ScriptedShipHealthEffects[sceneTracker, button];
                        FuelEffect = Data.ScriptedFuelEffects[sceneTracker, button];
                        MoneyEffect = Data.ScriptedMoneyEffects[sceneTracker, button];
                        break;
                    case 3:
                        ButtonText = Data.ScriptedButtonTexts[sceneTracker, button];
                        PostClickText = Data.PostScriptedButtonTexts[sceneTracker, button];
                        ResultDescription = Data.ScriptedResultDescription[sceneTracker, button];
                        PlayerHealthEffect = Data.ScriptedHealthEffects[sceneTracker, button];
                        ShipHealthEffect = Data.ScriptedShipHealthEffects[sceneTracker, button];
                        FuelEffect = Data.ScriptedFuelEffects[sceneTracker, button];
                        MoneyEffect = Data.ScriptedMoneyEffects[sceneTracker, button];
                        break;
                    case 4:
                        ButtonText = Data.ScriptedButtonTexts[sceneTracker, button];
                        PostClickText = Data.PostScriptedButtonTexts[sceneTracker, button];
                        ResultDescription = Data.ScriptedResultDescription[sceneTracker, button];
                        PlayerHealthEffect = Data.ScriptedHealthEffects[sceneTracker, button];
                        ShipHealthEffect = Data.ScriptedShipHealthEffects[sceneTracker, button];
                        FuelEffect = Data.ScriptedFuelEffects[sceneTracker, button];
                        MoneyEffect = Data.ScriptedMoneyEffects[sceneTracker, button];
                        break;
                }
            }
            else
            {
                if (sceneTracker == 1)
                {
                    ButtonText = Data.CombatButtonTexts[button];
                    PostClickText = Data.PostCombatButtonTexts[button];
                    ResultDescription = Data.CombatResultDescription[button];
                    PlayerHealthEffect = Data.CombatHealthEffects[button];
                    ShipHealthEffect = Data.CombatShipHealthEffects[button];
                    FuelEffect = Data.CombatFuelEffects[button];
                    MoneyEffect = Data.CombatMoneyEffects[button];

                }
                else if (sceneTracker == 2)
                {
                    ButtonText = Data.MerchantButtonTexts[sceneTracker];
                    PostClickText = Data.PostMerchantButtonTexts[sceneTracker];
                    ResultDescription = Data.MerchantResultDescription[sceneTracker];
                    PlayerHealthEffect = Data.MerchantHealthEffects[sceneTracker];
                    ShipHealthEffect = Data.MerchantShipHealthEffects[sceneTracker];
                    FuelEffect = Data.MerchantFuelEffects[sceneTracker];
                    MoneyEffect = Data.MerchantMoneyEffects[sceneTracker];
                }
            }
        }
    }
}
