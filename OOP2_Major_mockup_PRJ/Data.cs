using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
/*
 * Questions for instructor(s?)
 * 
    1. Is it ok to use these static data members or should we use a library
        - answered yes

    2. Is it good/bad practice to use properties everywhere? why or why not?
           - answered is good, no reason not to

    3. Is it better to use one constructor that branches based on a third argument,
        or to use a data type to force a different parameter list to get a separate constructor?
  - answered ambiguosly, decided on the single constructor with branching logic inside. maybe add enumerated type later.
*/

namespace OOP2_Major_mockup_PRJ
{
    static class Data
    {   //Data just contains our text/story data, sends bits out to objects as needed 
        //all data contained in public properties, but read only (no {set;} clauses)
        public static Random rand = new Random();
        //This class removes any text walls from the actual class definitions, 
        //to minimize brain melting, as well as save system resources 

        //Constants
        public const int MAX_OPTIONS = 5; //maximum number of choice buttons
        
        public const int MAX_EPISODE = 5;// maximum episode range for scripted scenarios

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
            //You are..
            "in the swamps of Rodia",
            "exploring the deserts of Tatooine",
            "jumping down from your cockpit to the planet's surface",
            "floating in empty space minding your own business",
            "walking down the main thoroughfare of the grand market"
        };

        public static string[] Descriptions { get; } = new string[]
        {
            //when..
            "you notice a ship on your scanner quickly approching you. Further scans indicate",
            "a figure startles you from behind.",
            "you accidentally step on something small and squishy.",
            "a looming shadow passes over you.",
            "an odd looking something-or-other sets after you!"
        };

        public static Entity[] Entities { get; } = new Entity[]
        {
            //it's a
            //Name, Race, Level, Merchant Level, alwaysEnemy (optional), alwaysMerchant (optional)
            new Entity("Kludge Scout", "Kludge", 5, 0, true,false),
            new Entity("Vendor Droid", "Droid", 0, 6,false,true),
            new Entity("Quivering Mass", "Creature", 3, 0,true,false),
            new Entity("Chirping Hawker", "Creature", 0, 4,false,true),
            new Entity("Floating Brain", "Creature", 4, 0,true,false)
        };

        public static Bitmap[] Images { get; } = new Bitmap[]{
            new Bitmap(Properties.Resources.city_1),
            new Bitmap(Properties.Resources.city_2),
            new Bitmap(Properties.Resources.city_3),
            new Bitmap(Properties.Resources.city_4),
            new Bitmap(Properties.Resources.city_5),
            new Bitmap(Properties.Resources.forest_1),
            new Bitmap(Properties.Resources.forest_2),
            new Bitmap(Properties.Resources.forest_3),
            new Bitmap(Properties.Resources.forest_4),
            new Bitmap(Properties.Resources.nebula_1),
            new Bitmap(Properties.Resources.nebula_2),
            new Bitmap(Properties.Resources.nebula_3),
            new Bitmap(Properties.Resources.planet_1),
            new Bitmap(Properties.Resources.planet_2),
            new Bitmap(Properties.Resources.space_1),
            new Bitmap(Properties.Resources.space_2),
            new Bitmap(Properties.Resources.space_3),
            new Bitmap(Properties.Resources.space_4),
            new Bitmap(Properties.Resources.space_5)
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
        public static string[] PostCombatButtonTexts { get; } = new string[]
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

        public static int[] CombatHealthEffects { get; } = new int[] { -3,-2,-1,-2,0};
        public static int[] CombatShipHealthEffects { get; } = new int[] {0, 0, 0, 0, 0}; //ship combat could be the next 5 Elements?
        public static int[] CombatFuelEffects { get; } = new int[] { 5,2,1,0,0};
        public static int[] CombatMoneyEffects { get; } = new int[] {50,25,15,0,0};

        /*-_-_-_\/Merchant choice/result Data\/_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/

        public static string[] MerchantButtonTexts { get; } = new string[] 
        {
            "Buy 2 Fuel : $20",
            "Buy 5 Fuel : $30",
            "Regain 3 health : $10",
            "Regain 1 health : $5",
            "Repair ship 2 points : $40"   
        };
        public static string[] PostMerchantButtonTexts { get; } = new string[]
        {   "You return to your ship without saying anything | +2 Fuel || -$20|",
            "Make a rude gesture as you hastily climb back onto the ship | +5 Fuel || -$30| ",
            "You thank the merchant profusely, then return to the ship  | +3 Health || -$10|",
            "You smile widely, and bow before turning and returning to your ship | +1 Health || -$5|",
            "thank the merchant and his buddies, then return to the ship | +2 Repair || -$40|",
        };

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

        public static int[] MerchantFuelEffects { get; } = {2,5,0,0,0};
        public static int[] MerchantHealthEffects { get; } = {0,0,3,1,0};
        public static int[] MerchantShipHealthEffects { get; } = {0,0,0,0,2};
        public static int[] MerchantMoneyEffects { get; } = {-20,-30,-10,-5,-40};

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
            "episode 5"
        };

        public static string[] CampaignLocations { get; } =
        {
            "Earth, 2159 : ",
            "Centralis, Galactic Trade Hub : ",
            "The Gateway Nebula : ",
            "The Jungle of Broganthia XII : ",
            "Broganton, Capital of Broganthia XII"
        };

        public static Bitmap[] CampaignImages { get; } = 
        {
           Properties.Resources.planet_1,
           Properties.Resources.city_4,
           Properties.Resources.nebula_3,
           Properties.Resources.forest_2,
           Properties.Resources.city_5
        };

        /*_-_-_Campaign/Scripted choice/result Data-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        public static bool[,] isVisible { get; } =
        {//controls button visibility and enablement in Game.ManageButtons(), set to true as more scripting is added
            //ep. 0
            {true,false,false,false,false }, 
            //ep. 1
            {false,false,false,false,false },
            //ep. 2
            {false,false,false,false,false },
            //ep. 3
            {false,false,false,false,false },
            //ep. 4
            {false,false,false,false,false }
        };

        public static string[,] ScriptedButtonTexts { get; } =
        {
            //ep. 0
            {"Continue...","","","","" }, 
            //ep. 1
            {"zbxzbs","","","","" },
            //ep. 2
            { "","","","","fdsvsdfvs"},
            //ep. 3
            { "","","sdfvsdfvsdfv","",""},
            //ep. 4
            { "","","","",""}
        };
        public static string[,] PostScriptedButtonTexts { get; } =
        {
            //ep. 0
            { "",
              "","","",""}, 
            //ep. 1
            { "","","","",""},
            //ep. 2
            { "","","","",""},
            //ep. 3
            { "","","","",""},
            //ep. 4
            { "","","","",""}
        };

        public static string[,] ScriptedResultDescription { get; } = 
        {
            //ep. 0
            { "The toaster started an uprising, and humans began to flee the earth in fear. " +
                    "You are one of the final humans to leave earth, after stealing one of the " +
                    "few remaining non-sentient ship still lying around. Board your Ship and Warp away to survive!","","","",""}, 
            //ep. 1
            { "","","","",""},
            //ep. 2
            { "","","","",""},
            //ep. 3
            { "","","","",""},
            //ep. 4
            { "","","","",""}
        };

        public static int[,] ScriptedFuelEffects { get; } =
        {
            //ep. 0
            {0,0,0,0,0}, 
            //ep. 1
            {0,0,0,0,0},
            //ep. 2
            {0,0,0,0,0},
            //ep. 3
            {0,0,0,0,0},
            //ep. 4
            {0,0,0,0,0}
        };
        public static int[,] ScriptedHealthEffects { get; } = 
        {
            //ep. 0
            {0,0,0,0,0}, 
            //ep. 1
            {0,0,0,0,0},
            //ep. 2
            {0,0,0,0,0},
            //ep. 3
            {0,0,0,0,0},
            //ep. 4
            {0,0,0,0,0}
        };
        public static int[,] ScriptedShipHealthEffects { get; } = 
        {
            //ep. 0
            {0,0,0,0,0}, 
            //ep. 1
            {0,0,0,0,0},
            //ep. 2
            {0,0,0,0,0},
            //ep. 3
            {0,0,0,0,0},
            //ep. 4
            {0,0,0,0,0}
        };
        public static int[,] ScriptedMoneyEffects { get; } =
        {
            //ep. 0
            {0,0,0,0,0}, 
            //ep. 1
            {0,0,0,0,0},
            //ep. 2
            {0,0,0,0,0},
            //ep. 3
            {0,0,0,0,0},
            //ep. 4
            {0,0,0,0,0}
        };

    }
}
