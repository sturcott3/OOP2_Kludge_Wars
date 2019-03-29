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
        public Item CombatReward { get; set; }

        //constructor allows type of encounter to get relevant data from Data class


        //seed tracks which episode we are on when Scripted is true. When Scripted is false, sceneTracker tracks 
        public Option(int sceneTracker, int button, bool Scripted)
        {
            if (Scripted)
            { 
                PopulateScriptedFields(sceneTracker, button);
            }

            else
            {
                if (sceneTracker == 1)
                {
                    PopulateCombatFields(button);
                }
                else if (sceneTracker == 2)
                {
                    PopulateMerchantFields(button);
                }
            }
        }
        private void PopulateScriptedFields(int sceneTracker, int button)
        {
            ButtonText = Data.ScriptedButtonTexts[sceneTracker, button];
            PostClickText = Data.PostScriptedButtonTexts[sceneTracker, button];
            ResultDescription = Data.ScriptedResultDescription[sceneTracker, button];
            PlayerHealthEffect = Data.ScriptedHealthEffects[sceneTracker, button];
            ShipHealthEffect = Data.ScriptedShipHealthEffects[sceneTracker, button];
            FuelEffect = Data.ScriptedFuelEffects[sceneTracker, button];
            MoneyEffect = Data.ScriptedMoneyEffects[sceneTracker, button];
            CombatReward = Data.ScriptedItemRewards[sceneTracker, button];
        }

        private void PopulateCombatFields(int button)
        {
            ButtonText = Data.CombatButtonTexts[button];
            PostClickText = Data.PostCombatTexts[button];
            ResultDescription = Data.CombatResultDescription[button];
            PlayerHealthEffect = Data.CombatHealthEffects[button];
            ShipHealthEffect = Data.CombatShipHealthEffects[button];
            CombatReward = Data.CombatItemRewards[button];
        }

        private void PopulateMerchantFields(int button)
        {
            ButtonText = Data.MerchantButtonTexts[button];
            PostClickText = Data.PostMerchantTexts[button];
            ResultDescription = Data.MerchantResultDescription[button];
            PlayerHealthEffect = Data.MerchantHealthEffects[button];
            ShipHealthEffect = Data.MerchantShipHealthEffects[button];
            FuelEffect = Data.MerchantFuelEffects[button];
            MoneyEffect = Data.MerchantMoneyEffects[button];
        }
    }
}
