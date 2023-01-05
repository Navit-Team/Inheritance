using System;

namespace PolyMorphysm
{
    public class Animal
    {
        public string Name { get; protected set; }
        public string Gender { get; protected set; }
        public double Energy { get; protected set; }
        public Animal(string name, string gender, double energy)
        {
            this.Name = name;
            this.Gender = gender;
            this.Energy = energy;
        }
        public override string ToString()
        {
            return $"Name: {this.Name}  Gender: {this.Gender}  Energy: {this.Energy}";
        }
    }
}
