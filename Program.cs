using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritancePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Alam", "23", new AddressFormat("Gulshan", "Dhaka"), 3.34);
            student1.ShowInfo();

        }
    }
}
