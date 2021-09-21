using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLections.Models
{
    class Palladin : Character
    {
        static int PowerPerLevel = 50;
        public int Power { get { return Level * PowerPerLevel; } }
        public Palladin(string name)
            : base(name, 50, Characters.Palladin)
        {

        }
        public Palladin(string name, int health) :
            base(name, health, Characters.Palladin)
        {

        }
        static Palladin()
        {
            MaxHealth = 10000;
            HealthForLevel = 100;
        }



    }
}
