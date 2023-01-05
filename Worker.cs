using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphysm
{
    public class Worker : Person
    {
        protected string start_working;
        protected string academic_degree;// תואר
        protected string status;//קביעות
        protected string belonging;//קבוצת שייכות

        public Worker(string start_working, string academic_degree, string status, string belonging, string first_name, string last_name, int age, int id) : base(first_name, last_name, age, id)
        {
            this.start_working = start_working;
            this.academic_degree = academic_degree;
            this.status = status;
            this.belonging = belonging;
            base.first_name = first_name;
        }

        public string WorkerToString()
        {
            return $"start working: {this.start_working}\nacademic degree: {this.academic_degree}" +
                $"\nstatus: {this.status}\nbelonging: {this.belonging}";
        }

        public new string ToString()
        {
            return $"name {this.first_name}, last {this.last_name}, age {this.age}, id {this.id}, start working {this.start_working}";
        }
    }
}