using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalSystemSimple
{
    public class Cat: Animal
    {
        public Cat (): base () {}
        public Cat (string name): base (name) {}
        public override string talk()
        {
            return "Meow!";
        }
        public override string ToString()
        {
            return "Cat "+Name;
        }
    }
}
