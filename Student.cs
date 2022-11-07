using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritancePractice
{
    internal class Student : Person
    {
        double cgpa;

        internal double Cgpa
        {
            get { return this.cgpa; }
            set { this.cgpa = value; }
        }

        internal Student(string name, string age, AddressFormat address, double cgpa) : base(name, age, address)
        {
            this.Cgpa = cgpa;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Cgpa: {0}", this.Cgpa);

        }
    }
}
