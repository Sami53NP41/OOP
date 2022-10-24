using System;
using System.Collections.Generic;
using System.Text;

namespace Kursova2
{
    public class Items
    {
        public string Name { get; private set; }
        public double Attack { get; private set; }
        public double Deffence { get; private set; }
        public Items(string name, double ATK, double DEF)
        {
            if (ATK > 10 || ATK < 0)
                throw new Exception("Ïnvalid Attack, please enter number between 10 and 0");
            else if (DEF > 10 || DEF < 0)
                throw new Exception("Invalid Deffence, please enter number between 10 and 0");
            else
            {
                Name = name;
                Attack = ATK;
                Deffence = DEF;
            }
        }

        private void UpgradeAttack(double atk)
        {
            if (atk < 0 || atk > 50)
                throw new Exception("Invalid Attack improvement value");
            else
            {
                this.Attack += atk;
            }
        }

        private void UpgradeDefence(double def)
        {
            if (def < 0 || def > 50)
                throw new Exception("Invalid Defence improvement value");
            else
            {
                this.Deffence += def;
            }
        }
    }
}
