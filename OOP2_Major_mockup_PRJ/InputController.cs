using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class InputController:Controller
    {
        //It seems C# doesn't include support for InputBox like VB does so we need to make our own dialog
        private InputDialog frmInputDialog = new InputDialog();

        //Input getting and validation
        public string GetInput(string title, string directions, int type)
        {
            //Need to implement types still
            //Type 1 = Letters only, Type 2 = Numbers only, Type 3, Letters and Numbers only, Type 4, All Characters Allowed
            string input = "";

            frmInputDialog.SetTitle(title);
            frmInputDialog.SetDirections(directions);

            //Input validation
            StatusOk = false;
            while (!StatusOk)
            {
                frmInputDialog.ShowDialog();
                input = frmInputDialog.GetResult();
                
                if(input.Length > 0 && IsAllLetters(input))
                {
                    StatusOk = true;
                }
                else
                {
                    frmInputDialog.ShowWarning("Invalid Input, must contain letters only");
                    //Loop
                }
            }
            
            return input;
        }

        public bool IsAllLetters(string input)
        {
            foreach (char c in input)
            {
                //If character is not a letter
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        public void MakeChoice(int option)
        {

        }
    }
}
