using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    public class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int[] effects { get; private set; } = new int[4];
        public System.Drawing.Bitmap Icon { get; private set; }

        public Item (string name, string description, int healthEffect, int repairEffect, int fuelEffect, int moneyEffect, System.Drawing.Bitmap icon)
        {
            effects[0] = healthEffect;
            effects[1] = repairEffect;
            effects[2] = fuelEffect;
            effects[3] = moneyEffect;
            Name = name;
            Description = description;
            this.Icon = icon;
        }
    }
}
