using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class InputController:Controller
    {
        private InputDialog frmInputDialog = new InputDialog();

        //Input getting and validation
        public string GetInput(string title, string directions, int type)
        {
            //Type 1 = Letters only, Type 2 = Numbers only, Type 3, Letters and Numbers only, Type 4, All Characters Allowed
            string input = string.Empty;

            frmInputDialog.SetTitle(title);
            frmInputDialog.SetDirections(directions);

            //Input validation
            StatusOk = false;
            while (!StatusOk)
            {
                frmInputDialog.ShowDialog();
                input = frmInputDialog.GetResult();
                
                if(input.Length > 0 && ((type == 1 && IsAllLetters(input)) || (type == 2 && IsAllNumbers(input)) || (type == 3 && IsAllLettersNumbers(input)) || (type == 4)))
                {
                    StatusOk = true;
                }
                else
                {
                    switch (type)
                    {
                        case 1:
                            frmInputDialog.ShowWarning("Invalid Input, must contain letters only.");
                            break;
                        case 2:
                            frmInputDialog.ShowWarning("Invalid Input, must contain numbers only.");
                            break;
                        case 3:
                            frmInputDialog.ShowWarning("Invalid Input, must contain letters and numbers only.");
                            break;
                        case 4:
                            frmInputDialog.ShowWarning("Invalid Input, must not be empty.");
                            break;
                        default:
                            throw new Exception("Invalid input type " + type);
                    }
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
        public bool IsAllNumbers(string input)
        {
            foreach (char c in input)
            {
                //If character is not a number
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }

            return true;
        }
        public bool IsAllLettersNumbers(string input)
        {
            foreach (char c in input)
            {
                //If character is not a letter or number
                if (!char.IsLetter(c) && !char.IsNumber(c))
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
