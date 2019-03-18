using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class OutputController:Controller
    {
        //now we have a reference to the player object, because it passes in the object reference to the form 
        //when the constructor of Outputcontroller is called. Again, I think this is bad practice.
        Game parent;
        
        public OutputController(Game parent)
        {
            this.parent = parent;
        }

        //This lets us assign the return value of the function to the text property of the form element. 
        //takes in a reference to the player object's health field, and updates it with the change.
        //negative change is damage, positive change is healing.
        public string updateHealth(int change)
        {
            //now we dont need to pass the health in at all, just access it directly
            int newHealth = parent.player.health + change;
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

        public void UpdateHUD()
        {
            //Gets player values and updates HUD
        }

    }
}
