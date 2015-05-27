using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalSystemSimple
{
    public abstract class Animal: IComparable
    {
        private string name;
        public Animal()
        {
            name = "noname";
        }
        public Animal(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
        public abstract string talk();

        public int CompareTo(object obj)
        {
            return ToString().CompareTo(obj.ToString());
        }
    }
}
