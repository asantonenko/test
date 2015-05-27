using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalSystemSimple
{
    public class Dog: Animal
    {
        private string message = "Arf! Arf!";
        public Dog (): base () {}
        public Dog (string name) : base(name) { }
        public override string talk()
        {
            string toSay = message;
            message = message + " Rrrr!";
            if (message.Length > 30)
                throw new Exception("\""+message + "\" too long!");
            return message;
        }
        public override string ToString()
        {
            return "Dog " + Name;
        }
    }
}
