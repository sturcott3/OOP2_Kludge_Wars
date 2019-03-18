using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class OutputController:Controller
    {
        //This lets us assign the return value of the function to the text property of the form element. 
        //takes in a reference to the player object's health field, and updates it with the change.
        //negative change is damage, positive change is healing.
        public string updateHealth(ref int playerHealth, int change)
        {
            int newHealth = playerHealth + change;
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
