using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class OutputController:Controller
    {
        //This has to reference the player object in the game class, not create a new player object
        //UNSURE HOW TO DO
        Player player;

        //This lets us assign the return value of the function to the text property of the form element. 
        //takes in a reference to the player object's health field, and updates it with the change.
        //negative change is damage, positive change is healing.
        public static string updateHealth(ref int playerHealth, int change)
        {
            int newHealth = playerHealth + change;
            string output = string.Empty;
            for (int i = 0; i < newHealth; i++)
            {
                output += "+ ";
            }
            return output;
        }

        public void UpdateHUD()
        {
            //Gets player values and updates HUD
        }

    }
}
