using System;

namespace PolyMorphysm
{
    public class Teacher : Worker
    {
        private string subject;

        public Teacher(string subject, string start_working, string academic_degree, string status, string belonging, string first_name, string last_name, int age, int id) : base(start_working, academic_degree, status, belonging, first_name, last_name, age, id)
        {
            this.subject = subject;
            this.start_working = start_working;
            this.academic_degree = academic_degree;
            this.status = status;
            this.belonging = belonging;
            this.first_name = first_name;
            this.last_name = last_name;
        }
        public new string ToString()
        {
            return $"name {this.first_name}, last {this.last_name}, age {this.age}, id {this.id}";
        }
    }
}