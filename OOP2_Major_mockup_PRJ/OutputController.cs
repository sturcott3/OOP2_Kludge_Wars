using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class OutputController:Controller
    {
        //It might be better to just have Game.cs AS the output controller, this class isn't really necessary and it would reduce dependancies.
        //Or we could also have all the controller classes are some type of global static class/library that every class can access, 
        //that way we don't need to be hacky and make reference constructors and all that.

        //Player Reference
        private Player player;

        public OutputController (ref Player player)
        {
            //Getting reference to player
            this.player = player;
        }

        //negative change is damage, positive change is healing.
        public string updateHealth(int change)
        {
            //now we dont need to pass the health in at all, just access it directly
            int newHealth = player.Health + change;
            string output = string.Empty;
            for (int i = 0; i < newHealth; i++)
            {
                output += "+ ";
            }
            return output;
        }
        public string updateRepair(ref int playerRepair, int change)
        {
            int newHealth = playerRepair + change;
            string output = string.Empty;
            for (int i = 0; i < newHealth; i++)
            {
                output += "{} ";
            }
            return output;
        }

        public string updateFuel(ref int playerFuel, int change)
        {
            int newHealth = playerFuel + change;
            string output = string.Empty;
            for (int i = 0; i < newHealth; i++)
            {
                output += "[] ";
            }
            return output;
        }

    }
}
