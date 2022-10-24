using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kursova2
{
    public class Hero
    {
        private double attackCoef = 15;

        private double defenceCoef = 20;

        public Fraction fraction { get; set; }

        public Hero(string name, Fraction fraction)
        {
            this.Name = name;
            this.fraction = fraction;
            this.Level = 0;
            this.Health = 100;
            this.Stamina = 100;
            this.Mana = 100;
            this.ItemSet = new List<Items>();
        }

        public string Name { get; private set; }


        public int Level { get; private set; }

        public double Health { get; private set; }

        public double Stamina { get; private set; }

        public double Mana { get; private set; }

        public List<Items> ItemSet { get; }

        public int LevelUp()
        {
            this.Level++;
            this.Health = 100;
            this.Stamina = 100;
            this.Mana = 100;
            return this.Level;
        }
        public double GetAttack()
        {
            double getAttack = ItemSet.Sum(i => i.Attack);
            getAttack += this.Level * this.attackCoef;
            return getAttack;
        }
        public double GetDefence()
        {
            double getDefence = ItemSet.Sum(i => i.Deffence);
            getDefence += this.Level * this.defenceCoef;
            return getDefence;
        }

        
    }
}

