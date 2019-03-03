using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Major_mockup_PRJ
{
    public partial class Game : Form
    {
         /*_-_-_-_SYSTEM CODE NO TOUCHIE_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        public Game()
        {
            InitializeComponent();
        }
        /*_-_-_-_-_-_-_-END NO TOUCHIE_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/



        /*_-_-_-_-_-_-_TEST BLOCK_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/
        private void btnDebug_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IT WORKS", "Success");
        }
        /*_-_-_-_-_-_-_-END TESTER_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-*/


        //Might be better instead of having ABC buttons, just make each option a button. No label, just change button text.
        //It will also have to be some sort of list box so we can dynamically fill it with buttons, rather than it being limited to 3.
        //Also I'm sure you have ideas already, but we need to fill the bottom left some more.
        private void btnOption1_Click(object sender, EventArgs e)
        {

        }

        private void btnOption2_Click(object sender, EventArgs e)
        {

        }

        private void btnOption3_Click(object sender, EventArgs e)
        {

        }
    }
}
