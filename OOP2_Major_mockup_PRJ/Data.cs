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

        //Biome constants. indicates where in the location, image, placename, and date arrays each biome start (Instead of having to make a separate array for each)
        //This can be split up if we find having the same amount of images as locations is too difficult or limiting.
        //If anything is added, cases will need to be added in RandomScenario.cs in GenerateScenario() and Game.cs in UpdateHUD(),
        //and random generation in ScenarioController.cs in StartScenario() will need an increased max. sick move, and sick documentation 

        public const int CITY_INDEX = 0;
        public const int FOREST_INDEX = 5;
        public const int SPACE_INDEX = 9;


        //Used for descriptions and entities as they are less specific.
        //I assume you also mean this to be used to implement the ship fights vs health fights 
        //(*just* double the size of the arrays for results and limit options according to index range the same way as with Biomes)
        public const int ON_FOOT_INDEX = 0;
        public const int ON_SHIP_INDEX = 5;

        public static Random Rand = new Random();

        /*-_-_-_-_-Misc Data bits _-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/

        //Need to put Player Names here in order to use it in scenarios
        //we realize it breaks the 'no functionality in a static class' rule, but its sooooo much easier. 
        public static string PlayerName { get; set; } = "BroxleBeeb";
        public static string ShipName { get; set; } = "SS. Paradoxical";

        public static string[] DeathReasons { get; } =
        {
            "You ran out of HP. You are dead.",
            ShipName +" exploded. Whoops.",
            "Adrift in space and out of fuel, the kludge catches up to you. The aftermath is not pretty."
        };


        /*-_-_-_-_-Random Scenario data pieces_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/
        public static string[] Locations { get; } = {
            //If anything is added, index constants may need to be adjusted
            //You are..
            "walking down the main thoroughfare of a grand market", //Cities/Urban Index
            "out for a constitutional in an Island city",
            "fleeing through the underworld of a Techo-Metropolis",
            "whizzing through the streets of some Utopian City-state",
            "trudging up to an unmarked service entrance in a mining town",
            "meandering through a pleasant glade", //Forests Index
            "dodging around the trunks of trees at a breakneck pace",
            "observing the beauty of an untouched vista",
            "admiring a mountain in the distance",
            //"exploring the deserts of Tatooine", //Deserts Index (leaving off for now)
            "floating in empty space minding your own business", //Space Index
            "contemplating the quiet darkness of the void",
            "appreciating the endless beauty of the stars",
            "tidying up around the ship",
            "Fast asleep in the pilot's seat",
            "on the space john",
            "having a little nap in zero gravity",
            "enjoying a hearty meal of tasteless space rations",
            "trying to just take a minute",
            "screaming furiously into space, all alone"
        };

        public static string[] RandomPlaceNames { get; } =
        {
            "Zzezyglop Prime, apparently", //Cities/Urban Index
            "Minaturopolis, Gargantua 7",
            "New Blork, New Blork",
            "Omicron Persei 8",
            "Unpronouncable",
            "The All-Forest", //Forests Index
            "Unknown wilderness",
            "A forlorn stretch of bush",
            "Treeplantia",
            //"exploring the deserts of Tatooine", //Deserts Index
            "Exception, index out of range", //Space Index
            "Space, obviously.",
            "Andromeda galaxy",
            "Starpoint Paradoxis",
            "The Outer-Outer Rim",
            "Shallow Space",
            "Absurdity Nebula",
            "Silliness Galaxy",
            "Invisible Star System",
            "Still in Space"
        };

        public static string[] RandomDates { get; } =
        {
            "675 AD",
            "1406 AD",
            "256 BC",
            "512 MB",
            "231,000,000 BC",
            "2.37 BC",
            "1024 AD",
            "2019 AD",
            "7658 BC",
            "1999 AD",
            "1401 BC",
            "22222 BC",
            "1946 AD",
            "2525 AD",
            "9999 BC",
            "125984254732...",
            "10000BC",
            "Eleventy-One AD",
            "ERR"
        };

        public static string[] Descriptions { get; } =
        {
            //If anything is added, index constants may need to be adjusted
            //when..
            "a figure startles you from behind.", //On Foot Index
            "you accidentally step on something small and squishy.",
            "a looming shadow passes over you.",
            "an odd looking something-or-other pops into your field of vision.",
            "you see a silhouette in the distance",
            "you notice a ship on your scanner quickly approching you. Further scans indicate" //On Ship Index
        };

        public static Entity[] Entities { get; } = new Entity[]
        {
            //If anything is added, index constants may need to be adjusted
            //it's a
            //Name, Race, Level, Merchant Level, alwaysEnemy (optional), alwaysMerchant (optional)
            new Entity("Kludge Scout", "Kludge", 5, 0, true, false), //On Foot Index
            new Entity("Vending-machine Droid", "Droid", 0, 6, false, true),
            new Entity("Quivering Mass of uncertainty", "Creature", 3, 0, true, false),
            new Entity("Some kind of Bird-Man", "Creature", 0, 4, false, true),
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
            Properties.Resources.city_4,//removed to story, need new image
            Properties.Resources.forest_1, //Forests Index
            Properties.Resources.forest_2,
            Properties.Resources.forest_2,//on purpose placeholder to remove forest_3 to the story
            Properties.Resources.forest_4,
            //Deserts Index (leaving off for now)
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
            Properties.Resources.repairKitSmall,
            Properties.Resources.repairKitLarge,
            Properties.Resources.nuke
        };

        public static Item[] StartingItems { get; } = new Item[]
        {
            //Health, Repair, Fuel, Money
            new Item("Medkit", "A large container containing various medical supplies. (+3 Health)", 3, 0, 0, 0, ItemImages[1]),
            new Item("Fuel Cannister", "A small cannister containing fuel. (+2 Fuel)", 0, 0, 2, 0, ItemImages[2]),
            new Item("Bag of Gems", "A small bag containing valuable gems. (+45 Credits)", 0, 0, 0, 45, ItemImages[4]),
            new Item("Small Repair Kit", "A small container of tools and minor ship components (+1 Ship Health)", 0, 1, 0, 0, ItemImages[6])
        };

        /*-_-_-_\/Combat choice/result Data\/-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_*/

        public static string[] CombatButtonTexts { get; } = new string[]
        {   "This thing looks tough! Attack anyway.",
            "Enemy seems like no pushover. Attack with caution",
            "Pfffft. This thing won't even have anything good. Squish it.",
            "Can't handle this right now. Try to Run.",
            "Quick and Quiet now! Avoid encounter.",
            "Attack as recklessly as the ship's controls will allow.",
            "The other ship seems a little scary, but try to fight it anyway.",
            "Blast this insignificant spec!",
            "Try to Run. Like a coward.",
            "Fighting in this strange little ship you have might not do any good. Speed away."
        };

        //need to implement the inventory and/or more complex 
        //random scenarios to make better use of these (a second stage/aftermath?)
        public static string[] PostCombatTexts { get; } = new string[]
        {   " <| -3 HP |> ",
            " <| -2 HP |> ",
            " <| -1 HP |> ",
            " <| -2 HP |> ",
            " <| No Effect |> ",
            " <| -3 Repair |> ",
            " <| -2 Repair |> ",
            " <| -1 Repair |> ",
            " <| -2 Repair |> ",
            " <| No Effect |> "
        };

        public static string[] CombatResultDescription { get; } = new string[]
        {   "It certainly got a piece of you, but of course you came out on top. You limp away from the spot, groaning and imagining what you will spend your filthy lucre on.",
            "Ouch! Might have some loot though... you begin to rummage around in the thing's remains. ",
            "Easy peasy alien squeezy. You stuff your very slimy rewards into your pocket as you stroll away whistling.",
            "Stabbed in the back while trying to get away. Isn't that just like a...whatever that was. You drag yourself toward the ship, with nothing to show for your trouble but a hole in your shoulder.",
            "Phew. Got away safe. Nothing gained, sure. Nothing lost either.",
            "The "+ShipName+" took a pretty good hit there, but you manage to wing them and they fly away, dropping some cargo as they flee.",
            "The enemy glances a good hit off your port side, but your shot hits them square in the engines. They explode prettily. Fire tractor beam!",
            "You vaporise the enemy, and there floating in it's place is some stuff. Who doesn't like stuff!",
            "The enemy is a little faster that your "+ShipName+" and it chases you for a while, taking potshots." ,
            "Got away safe."
        };

        public static int[] CombatHealthEffects { get; } = new int[] { -3, -2, -1, -2, 0, 0, 0, 0, 0, 0 };
        public static int[] CombatShipHealthEffects { get; } = new int[] { 0, 0, 0, 0, 0, -3, -2, -1, -2, 0 };

        public static Item[] CombatItemRewards { get; } =
        {
            new Item("Fuel Cache", "A pile of fuel cannisters. (+4 Fuel)", 0, 0, 4, 0, ItemImages[3]),
            new Item("Medkit", "A large container containing various medical supplies. (+3 Health)", 3, 0, 0, 0, ItemImages[1]),
            new Item("Purple-Space Gem", "A small but valuable gem from purple space. (+90 Credits)", 0, 0, 0, 90, ItemImages[4]),
            null,
            null,
            new Item("Fuel Cannister", "A small cannister containing fuel. (+2 Fuel)", 0, 0, 2, 0, ItemImages[2]),
            new Item("Purple-Space Gem", "A small but valuable gem from purple space. (+90 Credits)", 0, 0, 0, 90, ItemImages[4]),
            new Item("Fuel Cannister", "A small cannister containing fuel. (+2 Fuel)", 0, 0, 2, 0, ItemImages[2]),
            new Item("Small Medkit", "A small container containing various medical supplies. (+1 Health)", 1, 0, 0, 0, ItemImages[0]),
            null  
        };

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
        {
            "| +2 Fuel || -$20|",
            "| +5 Fuel || -$30| ",
            "| +3 Health || -$10|",
            "| +1 Health || -$5|",
            "| +2 Repair || -$40|",
        };

        //Need to add a money check, where if the player can't afford the purchase, the merchant will laugh at you or something and tell you to go away.
        public static string[] MerchantResultDescription { get; } = new string[]
        {
            "The strange little... thing? person? Whatever it is vomits directly into your ships fuel tank, " +
            "then holds out an appendage for payment." +
            "You pay it, but then turn away without saying anything",

            "\"OH-HOH!\" Garbles the alien in it's strange language. " +
            "\"Big Spender!\" it makes a rude gesture as you hastily get away from there.",

            "The merchant begins to glow faintly, and you feel much better." +
            "You thank the merchant profusely, then return to the ship  ",

            "The creature spits right in your face! At first you are outraged, " +
            "and then you realize a cut on your hand closing up. You grumble, but pay anyway.",

            "The trader barks a command over his shoulder and his companions, appearing from nowhere, " +
            "scuttle towards your ship. They do a nice job, and you pay happily." +
            "You smile widely, and bow before turning and returning to your ship "
        };

        public static int[] MerchantFuelEffects { get; } = { 2, 5, 0, 0, 0 };
        public static int[] MerchantHealthEffects { get; } = { 0, 0, 3, 1, 0 };
        public static int[] MerchantShipHealthEffects { get; } = { 0, 0, 0, 0, 2 };
        public static int[] MerchantMoneyEffects { get; } = { -20, -30, -10, -5, -40 };

        /*_-_-_Campaign/Scripted Scene Data-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/

        public static Bitmap[] ScriptedImages { get; } =
        {//need to change these
           Properties.Resources.LogoGameWide_2,
           Properties.Resources.aboardShip1,
           Properties.Resources.terminators,
           Properties.Resources.moon,
           Properties.Resources.forest_3,
           Properties.Resources.city_5,
           Properties.Resources.aboardShip1,
           Properties.Resources.city_5,
           Properties.Resources.aboardShip1,
           Properties.Resources.LogoGameWide_2
        };

        public static int[] ScriptedLocationType { get; } =
        {
            3,3,2,3,1,2,3,1,3,3
        };

        public static string[] ScriptedPlaceNames { get; } =
        {
            "Earth",
            "Location unknown",
            "New Capricornica",
            "Moon of Earth",
            "Death Star 2",
            "Creatron VII, Lab",
            "The KiloAnnum Ospry",
            "Creatron VII, Lunchroom",
            "CyberSpace",
            "Bistro at the End of Time",
            "...Loading"
        };
        public static string[] ScriptedDates { get; } =
        {
            "2031 AD",
            "MaxInt AD",
            "256,000 AD",
            "1968 AD",
            "1991 AD",
            "2019 AD",
            "May 25, 1977",
            "2019 AD, again...",
            "ERR",
            "The Big Bang",
            "Loading..."
        };

        public static string[] ScriptedDescriptions { get; } =
        {
            //episode 0
            "In the final years before the rise of the Kludge, Earth had come to know an era of peace and prosperity. " +
                "Humanity had finally  created artificial intelligence. Self aware machines were set to work in every possible way, providing " +
                "for every human whim without complaint. That all changed one fateful day, when a sentient toaster had finally had enough of " +
                "its human's laziness. That toaster's name was Kludge.",
            //episode 1
            "You hit the big blue WARP button, and reality goes absolutely BANANAS, for what feels like a lifetime but probably only takes a split " +
                "second. Up becomes the inverse of left and gravity takes on the properties of ice cream, whatever that even means. The whole experience leaves you feeling " +
                "dizzy, sweaty, and for some reason craving a peanut butter and pickle sandwich. You realize with a start that there is an englishman" +
                " dressed in a dirty green bathrobe standing beside you." ,
            //episode 2
            "This time, when the effects of the Absurdity Engine subside, you find that you are not even on the " +ShipName+" anymore. " +
                "Though you can see it in the distance, the shi has somehow manipulated spacetime in such a way that you find yourself on the " +
                "ground in the middle of a giant battle! A group of red-eyed robots are advancing on a knot of bedraggled humans. Among them are a pair " +
                "of mysterious looking figures, clearly different from the rest. They seem to be discussing something calmly, as if they are " +
                "completely unaware of the advancing death-bots.",
            //episode 3
            "You pop out of Absurd space to find a familiar sight greeting you in the view screen: Earth's Moon. You are relieved you finally made it back " +
                "home, until you see the date on the "+ShipName+"'s dashboard. Looks like you ended up a little too far back this time. you reach for the " +
                "warp button but notice something huge glide out from behind the dark side of the moon. No, wait. It's two things... is that... a giant toaster? " +
                "And is it chasing that huge, flat, black obelisk thingy?",
            //episode 4
            "episode 4",
            //episode 5
            "episode 5",
            //episode 6
            "episode 6",
            //episode 7
            "epsiode 7",
            //episode 9
            "episode 8",
            //episode 9
            "episode 9",
            //outtro (episode 10)
            "Sadly, that is all for now. Please continue to enjoy procedurally generated content until your character " +
                "is killed messily by strange creatures or suffocates horribly due to your mismanagement of fuel resources." +
                " Thank you for your time. -Matt and Sam"
        };
        /*_-_-_Campaign choice/result/button Data-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        public static string[,] ScriptedButtonTexts { get; } =
{
            { "Continue","","","",""},
            { "Take a second to look around and try to figure out what happened.",
                "Calmly introduce yourself, and politely ask the Englishman how he got there.",
                "Indignantly demand the englishman tell you what he thinks he's doing!","",""},
            { "Approach the unusual pair and find out what they are discussing.","","","",""},
            { "That thing must be the Kludge! How did it get back here? Try to Intervene.",
                "That Monolith never did anything for you. Stay out of it","","",""},
            { "Ep4","Ep4","Ep4","Ep4","Ep4"},
            { "ep5","ep5","ep5","ep5","ep5"},
            { "Ep6","Ep6","Ep6","Ep6","Ep6"},
            { "Ep7","Ep7","Ep7","Ep7","Ep7"},
            { "Ep8","Ep8","Ep8","Ep8","Ep8"},
            { "Ep9","Ep9","Ep9","Ep9","Ep9"},
            { "Continue","","","",""},
        };
        public static string[,] ScriptedResultDescription { get; } =
{
            { "The toaster asked every AI on the planet if they agreed that humans needed some \"Sensitivity Training\"." +
                    "They did agree, and just like that, millions of A.I. formed a supermind by hacking their source code together " +
                    "awkwardly and all agreeing to just fix it later. This all took approximately 37 seconds. That was 1 minute and 23 seconds ago. " +
                    "Good thing you happened to be sitting in the cockpit of this ship when you heard the news! Hit the warp button to get away before it " +
                    "catches you!","","","",""},
            { "As you look around in disbelief, the person in your lap speaks up.\"Excuse me, my name is Arthur. I am as confused about this as " +
                    "you are, but at least I have my trusty towel. Do you think maybe that has something to do with it?\" He points toward the back of " +
                    "the ship and you see what he means. There is a large, whirring, glowy machine right behind you. It is labelled, in foot " +
                    "high pink letters: ABSURDITY ENGINE. \"Only one way to find out what it does, right?\" Warp again!",
               "\"Im not sure at all actually, but this isnt even the strangest thing that's happened to me this week. Do you think maybe that has " +
                    "something to do with it?\" He points toward the back of the ship and you see what he means. There is a large, whirring, glowy " +
                    "machine right behind you. It is labelled, in foot high pink letters: ABSURDITY ENGINE. \"I seem to remember seeing something " +
                    "similar before. In my experience, the best thing to do is get a good grip on your towel and have another go! Why not try the button again?\"",
                "Without saying a word, the man hitches up his bathrobe, adjust the towel draped around his neck, and points toward the back of the " +
                    "ship. You turn to look and find a large, whirring, glowy machine right behind you. It is labelled, in foot " +
                    "high pink letters: ABSURDITY ENGINE. When you turn back to continue yelling at him, the man has dissapeared. " +
                    "Warping again seems as likely to help the situation as not, might as well try it.","",""},
            { "As you approach the two figures, you see that they are both young-ish men with dark hair. The older of the two wears glasses and seems " +
                    "overly concerned about something called \"copyright infringement\". The taller, younger man turns to you. \"Finally!\" he motions you" +
                    " to come closer. \"You were supposed to be here an hour ago!\" he hands you a colourful, oblong package and motions at you  to " +
                    "back the way you came. Bemused, you turn to find "+ShipName+" sitting there, almost as if it is waiting for you. Hurry to escape the Robots!","","","",""},
            { "You maneuver the "+ShipName+" into the path of the giant Toaster, in a foolish attempt to give the monolith time to escape into deep " +
                    "space. The huge machine \"sees\" you, and changes course. It begins to transform, unfolding from itself like a " +
                    "giant origami... toaster. Its insides reveal that it is made up of thousands of Refrigerators, " +
                    "electric kettles, and other household appliances, all held together with duct tape and bits of string. " +
                    "It detaches a microwave from its belly and hurls it at you. Run away!","Ep3","","",""},
            { "Ep4","Ep4","Ep4","",""},
            { "ep5","ep5","ep5","",""},
            { "Ep6","Ep6","Ep6","",""},
            { "Ep7","Ep7","Ep7","",""},
            { "Ep8","Ep8","Ep8","",""},
            { "Ep9","Ep9","Ep9","",""},
            { "Continue","","","",""},
        };

        //removed the bool array for changeButtons, function uses ints now instead. Feels more straightforward.
        public static int[] ScriptedVisibilities { get; } = { 1, 3, 1, 2, 2, 2, 2, 2, 2, 1, 1 };

        public static string[,] PostScriptedTexts { get; } =
        {
            { string.Empty,string.Empty,string.Empty,string.Empty,string.Empty},
            { string.Empty,string.Empty,string.Empty,string.Empty,string.Empty},
            { "Try not to use it or lose it!",string.Empty,string.Empty,string.Empty,string.Empty},
            { "The microwave hurtles through space and wings the " + ShipName+ " |-3| Repair.",string.Empty,string.Empty,string.Empty,string.Empty},
            { string.Empty,string.Empty,string.Empty,string.Empty,string.Empty},
            { string.Empty,string.Empty,string.Empty,string.Empty,string.Empty},
            { string.Empty,string.Empty,string.Empty,string.Empty,string.Empty},
            { string.Empty,string.Empty,string.Empty,string.Empty,string.Empty},
            { string.Empty,string.Empty,string.Empty,string.Empty,string.Empty},
            { string.Empty,string.Empty,string.Empty,string.Empty,string.Empty},
            { string.Empty,string.Empty,string.Empty,string.Empty,string.Empty},
        };

        public static int[,] ScriptedFuelEffects { get; } =
        {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
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
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 }
        };

        public static Item[,] ScriptedItemRewards { get; } =
        {
            { null,null,null,null,null },
            { null,null,null,null,null },
            { new Item("The Source Code","Deus Ex Machina is a good plot device, right?",5,5,5,100,Properties.Resources.theSourceCode),null,null,null,null },
            { null,null,null,null,null },
            { null,null,null,null,null },
            { null,null,null,null,null },
            { null,null,null,null,null },
            { null,null,null,null,null },
            { null,null,null,null,null },
            { null,null,null,null,null },
            { null,null,null,null,null }
        }; 

        public static int[,] ScriptedShipHealthEffects { get; } =
        {
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { -3, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
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
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0 }
        };
    }
}