using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphysm
{
    public class Person
    {
        protected string first_name;
        protected string last_name;
        protected int age;
        protected int id;

        // בנאי
        public Person(string first_name, string last_name, int age, int id)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.id = id;
        }
        public override string ToString()
        {
            return $"name {this.first_name}, last {this.last_name}, age {this.age}, id {this.id}";
        }
    }
}