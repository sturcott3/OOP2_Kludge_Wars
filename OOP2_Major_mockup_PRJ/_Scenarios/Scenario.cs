using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP2_Major_mockup_PRJ
{
    class Scenario
    {
        //properties
        public string Description { get; set; }
        public string Location { get; set; } 
        public Bitmap Image { get; set; }

        //5 buttons, 5 Options + 1 container to pass them all at once
        public Option Button1 { get; set; }
        public Option Button2 { get; set; }
        public Option Button3 { get; set; }
        public Option Button4 { get; set; }
        public Option Button5 { get; set; }
        public Option[] CurrentOptions { get; set; } = new Option[Data.MAX_OPTIONS];

        //virtual methods for now only here to allow both scenario types to inherit the method, 
        //could later have code that is mutual brought back in. 
        public virtual void GenerateScenario(int seed) {  }
        public virtual Option[] GetOptions(int[] index) { return null; }
    }
}
