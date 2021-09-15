using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLections
{
    class Palladin
    {
        private static int currentID = 0;
        public int id { get; }
        public static int MaxHealth { get; set; }
        public static int HealthForLevel { get; set; }
        private string _name;
        public string Name
        {
            get
            {
                while ((char.IsNumber(_name[0]) || char.IsSymbol(_name[0])) && _name.Length > 0)
                {
                    _name = _name[1..];
                }
                return _name + " ↑";
            }
            set
            {
                _name = "~" + value ;
            }
        }
        public int Health { get; set; }
        private int Level { get; set; } = 1;
        public Weapon Weapon { get; set; }
        public Palladin(string name, int health)
        {
            id = currentID++;
            Name = name;
            Health = checkMaxHeath(health);
            Weapon = Weapon.sword;

        }
        public Palladin(string name)
        {
            id = currentID++;
            Name = name;
            Health = 50;
            Weapon = Weapon.dagger;
        }
        static Palladin()
        {
            MaxHealth = 10000;
            HealthForLevel = 100;
        }
        private int checkMaxHeath(int health)
        {
            int _return = health;
            if (health > MaxHealth)
            {
                _return = MaxHealth;
            }
            return _return;
        }
        public void LevelUP()
        {
            Level++;
            Health += HealthForLevel;
            Health = checkMaxHeath(Health);
        }
        public void Show()
        {
            Console.WriteLine($"{id} Palladin {Name} with health {Health} level {Level} with {Weapon}");
        }
    }
}
