using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class Entity
    {
        //Define properties
        public string Name { get; set; }
        public string Race { get; set; }
        public int Level { get; set; }
        public int MerchantLevel { get; set; }     
        public bool IsEnemy { get; set; }
        public bool IsMerchant { get; set; }

        //Entity creation constructor
        public Entity(string name, string race, int level, int merchantLevel, bool isEnemy = false, bool isMerchant = false)
        {
            Name = name;
            Race = race;
            Level = level;
            MerchantLevel = merchantLevel;
            IsEnemy = isEnemy;
            IsMerchant = isMerchant;
        }


    }
}
