﻿using System;
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
        public string GetInput(string title, string directions)
        {
            StatusOk = false;
            string input;
            //while (!StatusOk)
            //{
                frmInputDialog.SetTitle(title);
                frmInputDialog.SetDirections(directions);


                frmInputDialog.ShowDialog();
                input = frmInputDialog.GetResult();
                
                //char.islet
                //Input validation
                //if(input.Length > 0 && (input.)
            //}
            
            return input;
        }

        public void MakeChoice(int option)
        {

        }
    }
}
