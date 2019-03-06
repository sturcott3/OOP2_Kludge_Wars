using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Major_mockup_PRJ
{
    class Entity
    {
        private string name, race;
        private int level, merchantLevel;
        private bool alwaysEnemy, alwaysMerchant;

        public Entity(string name, string race, int level, int merchantLevel, bool alwaysEnemy = false, bool alwaysMerchant = false)
        {
            this.name = name;
            this.race = race;
            this.level = level;
            this.merchantLevel = merchantLevel;
            this.alwaysEnemy = alwaysEnemy;
            this.alwaysMerchant = alwaysMerchant;
        }

        //Getters
        public string GetName()
        {
            return name;
        }
        public string GetRace()
        {
            return race;
        }
        public int GetLevel()
        {
            return level;
        }
        public int GetMerchantLevel()
        {
            return merchantLevel;
        }
        public bool GetEnemy()
        {
            return alwaysEnemy;
        }
        public bool GetMerchant()
        {
            return alwaysMerchant;
        }
    }
}
