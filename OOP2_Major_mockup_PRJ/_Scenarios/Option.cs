using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class Option
    {
        public string ButtonText { get; set; }
        public string PostClickText { get; set; }
        public string ResultDescription { get; set; }
        public int PlayerHealthEffect { get; set; }
        public int ShipHealthEffect { get; set; }
        public int MoneyEffect { get; set; }
        public Item Reward { get; set; }
        

        //constructor allows type of encounter to get relevant data from Data class


        //seed tracks which episode we are on when Scripted is true.
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
            PostClickText = Data.PostScriptedTexts[sceneTracker, button];
            ResultDescription = Data.ScriptedResultDescription[sceneTracker, button];
            PlayerHealthEffect = Data.ScriptedHealthEffects[sceneTracker, button];
            ShipHealthEffect = Data.ScriptedShipHealthEffects[sceneTracker, button];
            MoneyEffect = Data.ScriptedMoneyEffects[sceneTracker, button];
            Reward = Data.ScriptedItemRewards[sceneTracker, button];
        }

        private void PopulateCombatFields(int button)
        {
            ButtonText = Data.CombatButtonTexts[button];
            PostClickText = Data.PostCombatTexts[button];
            ResultDescription = Data.CombatResultDescription[button];
            PlayerHealthEffect = Data.CombatHealthEffects[button];
            ShipHealthEffect = Data.CombatShipHealthEffects[button];
            Reward = Data.CombatItemRewards[button];
        }

        private void PopulateMerchantFields(int button)
        {
            ButtonText = Data.MerchantButtonTexts[button];
            PostClickText = Data.PostMerchantTexts[button];
            ResultDescription = Data.MerchantResultDescription[button];
            Reward = Data.MerchantItemRewards[button];
            MoneyEffect = Data.MerchantMoneyEffects[button];
        }
    }
}
