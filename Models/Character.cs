using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLections.Models
{
    class Character
    {
        public static int MaxHealth { get; set; }
        public static int HealthForLevel { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        protected int Level { get; set; } = 1;
        private Characters Characters;
        public Character(string name, int health, Characters Characters)
        {
            Name = name;
            Health = CheckMaxHeath(health);
            this.Characters = Characters;
        }
        private int CheckMaxHeath(int health)
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
            Health = CheckMaxHeath(Health);
        }
        public void Show(bool withEnd = true)
        {
            string endLine = "";
            if (withEnd)
            {
                endLine = "\n";
            }
            Console.Write($"{Characters} {Name} with health {Health} level {Level} {endLine}");
        }
    }
}
