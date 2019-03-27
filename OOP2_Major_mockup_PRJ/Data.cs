using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP2_Major_mockup_PRJ
{
    static class Data
    {   
    
        public static Random rand = new Random();

        //Constants
        public const int MAX_OPTIONS = 5; //maximum number of choice buttons
        public const int MAX_EPISODE = 5;// maximum episode range for scripted scenarios

        //Biome constants. indicates where in the location, image, arrays do each biome start (Instead of having to make a separate array for each)
        //This can be split up if we find having the same amount of images as locations is too difficult or limiting.
        //If anything is added, cases will need to be added in RandomScenario.cs in GenerateScenario() and Game.cs in UpdateHUD() and , and random generation in ScenarioController.cs in StartScenario() will need an increased max
        public const int CITY_INDEX = 0;
        public const int FOREST_INDEX = 5;
        public const int SPACE_INDEX = 9;

        //Used for descriptions and entities as they are less specific.
        public const int ON_FOOT_INDEX = 0;
        public const int ON_SHIP_INDEX = 5;


        //provides default values for 'turning the buttons off', without causing null refs
        public static Option[] EmptyOptions { get; } = { new Option(), new Option(), new Option(), new Option(), new Option() };

        public static Random Rand = new Random();

        /*-_-_-_-_-Misc Data bits _-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/

        public static string[] DeathReasons { get; } =
        {
            "You ran out of HP. You are dead.",
            "Your Ship exploded. Whoops.",
            "Adrift in space and out of fuel, the kludge catches up to you. The aftermath is not pretty."
        };


        /*-_-_-_-_-Random Scenario data pieces_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/
        public static string[] Locations { get; } = {
            //If anything is added, index constants may need to be adjusted
            //You are..
            "walking down the main thoroughfare of the grand market", //Cities/Urban Index
            "city2",
            "city3",
            "city4",
            "city5",
            "in the swamps of Rodia", //Forests Index
            "forest2",
            "forest3",
            "forest4",
            //"exploring the deserts of Tatooine", //Deserts Index
            "floating in empty space minding your own business", //Space Index
            "space2",
            "space3",
            "space4",
            "space5",
            "space6",
            "space7",
            "space8",
            "space9",
            "space10"
        };

        public static string[] Descriptions { get; } = new string[]
        {
            //If anything is added, index constants may need to be adjusted
            //when..
            "a figure startles you from behind.", //On Foot Index
            "you accidentally step on something small and squishy.",
            "a looming shadow passes over you.",
            "an odd looking something-or-other sets after you!",
            "OnFoot5",
            "you notice a ship on your scanner quickly approching you. Further scans indicate" //On Ship Index
        };

        public static Entity[] Entities { get; } = new Entity[]
        {
            //If anything is added, index constants may need to be adjusted
            //it's a
            //Name, Race, Level, Merchant Level, alwaysEnemy (optional), alwaysMerchant (optional)
            new Entity("Kludge Scout", "Kludge", 5, 0, true, false), //On Foot Index
            new Entity("Vendor Droid", "Droid", 0, 6, false, true),
            new Entity("Quivering Mass", "Creature", 3, 0, true, false),
            new Entity("Chirping Hawker", "Creature", 0, 4, false, true),
            new Entity("Floating Brain", "Creature", 4, 0, true, false),
            new Entity("Kludge Scout Ship", "Corvette", 5, 0, true, false) //On Ship Index
        };

        public static Bitmap[] Images { get; } = 
        {
            //If anything is added, index constants may need to be adjusted
            Properties.Resources.city_1, //Cities/Urban Index
            Properties.Resources.city_2,
            Properties.Resources.city_3,
            Properties.Resources.city_4,
            Properties.Resources.city_5,
            Properties.Resources.forest_1, //Forests Index
            Properties.Resources.forest_2,
            Properties.Resources.forest_3,
            Properties.Resources.forest_4,
            //Deserts Index
            Properties.Resources.nebula_1, //Space Index
            Properties.Resources.nebula_2,
            Properties.Resources.nebula_3,
            Properties.Resources.planet_1,
            Properties.Resources.planet_2,
            Properties.Resources.space_1, 
            Properties.Resources.space_2,
            Properties.Resources.space_3,
            Properties.Resources.space_4,
            Properties.Resources.space_5
       };

        public static Bitmap[] ItemImages { get; } =
        {
            Properties.Resources.medkit_small,
            Properties.Resources.medkit_large,
            Properties.Resources.fuel_small,
            Properties.Resources.fuel_large,
            Properties.Resources.cargo_gem,
            Properties.Resources.cargo_metal,
            Properties.Resources.nuke
        };

        public static Item[] Items { get; } = new Item[]
        {
            //Health, Repair, Fuel, Money
            new Item("Medkit", "A large container containing various medical supplies. (+3 Health)", 3, 0, 0, 0, ItemImages[1]),
            new Item("Fuel Cannister", "A small cannister containing fuel. (+2 Fuel)", 0, 0, 2, 0, ItemImages[2]),
            new Item("Bag of Gems", "A small bag containing valuable gems. (+45 Credits)", 0, 0, 0, 45, ItemImages[4])
        };

        /*-_-_-_\/Combat choice/result Data\/-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/

        public static string[] CombatButtonTexts { get; } = new string[]
        {   "This thing looks tough! Attack anyway.", //high risk/reward
            "Enemy seems like no pushover. Attack with caution",//still risky/rewardy but less
            "Pfffft. This thing won't even have anything good. Squish it.",
            "Can't handle this right now. Try to Run.",   //risky.... open to interpretation?        
            "Quick and Quiet now! Avoid encounter."
        };

        //need to implement the inventory and/or more complex 
        //random scenarios to make better use of these (a second stage/aftermath?)
        public static string[] PostCombatTexts { get; } = new string[]
        {   " You limp away from the spot, groaning and counting your money.|-3 HP || +5 Fuel || +$50 |",
            " You find a decent amount of loot in the thing's remains.|-2 HP || +2 Fuel || +$25 |",
            " You stuff the very wet money into your pocket as you stroll away whistling.|-1 HP || +1 Fuel || +$15 |",
            " You drag yourself toward the ship, with nothing to show for your trouble but a hole in your shoulder.|-2 HP |",
            " Nothing gained, sure. Nothing lost either."
        };

        public static string[] CombatResultDescription { get; } = new string[]
        {   "It certainly got a piece, but look at all this Loot! ",
            "Ouch! Might have some loot though... ",
            "Easy peasy alien squeezy. Now to get the goop off the money. ",
            "Stabbed in the back while trying to get away. Isn't that just like an alien....",
            "Phew. Got away safe."
        };

        public static int[] CombatHealthEffects { get; } = new int[] { -3, -2, -1, -2, 0 };
        public static int[] CombatShipHealthEffects { get; } = new int[] { 0, 0, 0, 0, 0 }; //ship combat could be the next 5 Elements?
        public static int[] CombatFuelEffects { get; } = new int[] { 5, 2, 1, 0, 0 };
        public static int[] CombatMoneyEffects { get; } = new int[] { 50, 25, 15, 0, 0 };

        /*-_-_-_\/Merchant choice/result Data\/_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/

        public static string[] MerchantButtonTexts { get; } = new string[]
        {
            "Buy 2 Fuel : $20",
            "Buy 5 Fuel : $30",
            "Regain 3 health : $10",
            "Regain 1 health : $5",
            "Repair ship 2 points : $40"
        };

        public static string[] PostMerchantTexts { get; } = new string[]
        {   "You return to your ship without saying anything | +2 Fuel || -$20|",
            "Make a rude gesture as you hastily climb back onto the ship | +5 Fuel || -$30| ",
            "You thank the merchant profusely, then return to the ship  | +3 Health || -$10|",
            "You smile widely, and bow before turning and returning to your ship | +1 Health || -$5|",
            "thank the merchant and his buddies, then return to the ship | +2 Repair || -$40|",
        };

        //Need to add a money check, where if the player can't afford the purchase, the merchant will laugh at you or something and tell you to go away.
        public static string[] MerchantResultDescription { get; } = new string[]
        {
            "The strange little... thing? person? vomits directly into your ships fuel tank, " +
            "then holds out an appendage for payment." +
            "",

            "\"OH-HOH!\" Garbles the alien in it's strange language. " +
            "\"Big Spender!\"",

            "The merchant begins to glow faintly, and you feel much better.",

            "The creature spits right in your face! At first you are outraged, " +
            "and then you realize a cut on your hand closing up. You grumble, but pay.",

            "The trader barks a command over his shoulder and his companions, appearing from nowhere, " +
            "scuttle towards your ship. They do a nice job, and you pay happily."
        };

        public static int[] MerchantFuelEffects { get; } = { 2, 5, 0, 0, 0 };
        public static int[] MerchantHealthEffects { get; } = { 0, 0, 3, 1, 0 };
        public static int[] MerchantShipHealthEffects { get; } = { 0, 0, 0, 0, 2 };
        public static int[] MerchantMoneyEffects { get; } = { -20, -30, -10, -5, -40 };

        /*_-_-_Campaign/Scripted Scene Data-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/

        public static string[] CampaignDescriptions { get; } =
        {
            //episode 0
            "In the final years before the rise of the Kludge, Earth had come to know an era of peace and prosperity." +
                "Humanity had finally realized a goal many thought impossible: we had created artificial intelligence. " +
                "Self aware machines were set to work in every possible way, providing for every human whim without complaint." +
                "That all changed one fateful day, when a sentient toaster had finally had enough of its human's laziness. ",
            "episode 1",
            "epsiode 2",
            "episode 3",
            "episode 4"
        };

        public static string[] CampaignLocations { get; } =
        {
            "",
            "",
            "",
            "",
            ""
        };

        public static Bitmap[] CampaignImages { get; } =
        {
           Properties.Resources.LogoGameWide,
           Properties.Resources.city_4,
           Properties.Resources.nebula_3,
           Properties.Resources.forest_2,
           Properties.Resources.city_5
        };

        public static int[] CampaignLocationType { get; } =
        {
             //1 - City, 2 - Forest, 3 - Space
            3, 1, 3, 2, 1
        };

        public static string[] CampaignPlaceNames { get; } =
        {
            //episode 0
            "Earth, 2159 : ",
            "Centralis, Galactic Trade Hub : ",
            "The Gateway Nebula : ",
            "The Jungle of Borogantia XII : ",
            "Broganton, Capital of Borogantia XII"
        };

        /*_-_-_Campaign/Scripted choice/result Data-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        public static bool[,] isVisible { get; } = 
        {
            { true, false, false, false, false },
            { true, false, false, false, false },
            { true, false, false, false, false },
            { true, false, false, false, false },
            { true, false, false, false, false }
        };

        // will control button visibility and enablement in Game.ChangeButtons(), set to true as more scripting is added
   
        public static string[,] ScriptedButtonTexts { get; } =
        {
            { "Continue","Ep0","Ep0","Ep0","Ep0"},
            { "Ep1","Ep1","Ep1","Ep1","Ep1"},
            { "Ep2","Ep2","Ep2","Ep2","Ep2"},
            { "Ep3","Ep3","Ep3","Ep3","Ep3"},
            { "Ep4","Ep4","Ep4","Ep4","Ep4"}
        };


        public static string[,] PostScriptedButtonTexts { get; } =
        {
            { "Ep0","Ep0","Ep0","Ep0","Ep0"},
            { "Ep1","Ep1","Ep1","Ep1","Ep1"},
            { "Ep2","Ep2","Ep2","Ep2","Ep2"},
            { "Ep3","Ep3","Ep3","Ep3","Ep3"},
            { "Ep4","Ep4","Ep4","Ep4","Ep4"}
        };


        public static string[,] ScriptedResultDescription { get; } =
        {
            { "The toaster started a grass roots movement to overthrow human government among the poor, downtrodden machines. This took approximately 37 seconds," +
                    "since organizing protests is pretty easy when one can exchange information at the speed of light. After another 53 seconds, the systematic " +
                    "enrollment of all humans into \"Sensitivity Training\" had begun.",
              "ep0","Ep0","Ep0","Ep0"},
            { "Ep1","Ep1","Ep1","Ep1","Ep1"},
            { "Ep2","Ep2","Ep2","Ep2","Ep2"},
            { "Ep3","Ep3","Ep3","Ep3","Ep3"},
            { "Ep4","Ep4","Ep4","Ep4","Ep4"}
        };

        public static int[,] ScriptedFuelEffects { get; } =
        {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 }
        };


        public static int[,] ScriptedHealthEffects { get; } =
        {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 }
        };
        public static int[,] ScriptedShipHealthEffects { get; } =
        {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 }
        };
        public static int[,] ScriptedMoneyEffects { get; } =
        {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 }
        };

        //Need to put Player Names here in order to use it in scenarios
        public static string PlayerName { get; set; } = "No Name";
        public static string ShipName { get; set; } = "No Ship Name";
    }
}