using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class InputController
    {
        private InputDialog frmInputDialog = new InputDialog();
        private bool StatusOk { get; set; } = true;

        public string GetInput(string title, string directions, string buttonText, int type)
        {
            //Single String Input
            frmInputDialog.SetStyle(1);
            string input = string.Empty;

            frmInputDialog.SetTitle(title);
            frmInputDialog.SetDirections(directions);
            frmInputDialog.SetButton(buttonText);

            do {
                frmInputDialog.ShowDialog();
                input = frmInputDialog.GetResult();
            } while (!ValidateInput(input, type));

            return input;
        }

        public string[] GetInput(string title, string direction1, string direction2, string buttonText, int type, int style = 2)
        {
            //Two String Input
            
            //If style is set to an invalid style
            if(style == 1 || style > 3)
            {
                style = 2;
            }

            frmInputDialog.SetStyle(style);
            string[] input = null;

            frmInputDialog.SetTitle(title);
            frmInputDialog.SetDirections(direction1, direction2);
            frmInputDialog.SetButton(buttonText);

            do
            {
                frmInputDialog.ShowDialog();
                input = frmInputDialog.GetResults();
                
            } while (!input.All(value => ValidateInput(value, type)));

            return input;
        }

        private bool ValidateInput(string input, int type)
        {
            //Type 1 = Letters only, Type 2 = Numbers only, Type 3 = Letters and Numbers only, Type 4 = All Characters Allowed, Type 5 = No validation preformed (Used for debug purposes).

            //Input validation
            if ((input.Length > 0 && ((type == 1 && IsAllLetters(input)) || (type == 2 && IsAllNumbers(input)) || (type == 3 && IsAllLettersNumbers(input)) || (type == 4))) || type == 5)
            {
                return true;
            }
            else
            {
                switch (type)
                {
                    
                    case 1:
                        frmInputDialog.ShowWarning("Invalid Input, must contain letters only.", 2.5);
                        break;
                    case 2:
                        frmInputDialog.ShowWarning("Invalid Input, must contain numbers only.", 2.5);
                        break;
                    case 3:
                        frmInputDialog.ShowWarning("Invalid Input, must contain letters and numbers only.", 2.5);
                        break;
                    case 4:
                        frmInputDialog.ShowWarning("Invalid Input, must not be empty.", 2.5);
                        break;
                    default:
                        throw new Exception("Invalid input type " + type);
                }
            }
            return false;
        }
        //return


        private bool IsAllLetters(string input)
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
        private bool IsAllNumbers(string input)
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
        private bool IsAllLettersNumbers(string input)
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
    }
}
