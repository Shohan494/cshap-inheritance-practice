using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritancePractice
{
    struct AddressFormat
    {
        string area;
        string district;

        public AddressFormat(string area, string district)
        {
            this.area = area;
            this.district = district;
        }

        public void ShowAddress()
        {
            Console.WriteLine("Area: {0} - District: {1}", this.area, this.district);
        }
    }
    internal class Person
    {
        string name;
        string age;
        AddressFormat address;

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal string Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        internal AddressFormat Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        internal Person()
        {

        }

        internal Person(string name, string age, AddressFormat address)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Age: {0}", this.Age);
            this.Address.ShowAddress();
        }
    }
}
