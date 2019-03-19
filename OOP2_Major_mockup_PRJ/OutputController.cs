using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class OutputController:Controller
    {

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
