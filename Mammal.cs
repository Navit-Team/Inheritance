using System;

namespace PolyMorphysm
{
    public class Mammal : Animal
    {
        public double Milk { get; protected set; }
        public const int CALL_IN_MILK = 500;
        public Mammal(string name, string gender, double energy, double milk) : base(name, gender, energy)
        {
            this.Milk = milk;
        }
        public void AddMilk() { this.Milk++; }
        public new string ToString()
        {
            return base.ToString() + $"  milk: {this.Milk}";
        }
    }
}
